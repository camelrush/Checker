Imports System.Threading

Public Class CheckRunner

    Private Const DEFAULT_MAX_RUN_COUNT = 5
    Private Const DEFAULT_RUNNER_INTERVAL = 100
    Private Const DEFAULT_TICK_INTERVAL = 500
    Public Event Finish()

    Private m_MaxRunCount As Long
    Private m_RunnerInterval As Long
    Private m_CheckTasks As List(Of CheckTaskBase)

    Public Sub New()
        m_MaxRunCount = DEFAULT_MAX_RUN_COUNT
        m_RunnerInterval = DEFAULT_RUNNER_INTERVAL
        m_CheckTasks = New List(Of CheckTaskBase)
    End Sub

    Public Sub Add(ByVal p_CheckName As String)

        If InStr(p_CheckName, "X") > 0 Then
            m_CheckTasks.Add(CheckTaskFactory.Create(CheckTaskFactory.crPattern.patternX, p_CheckName))
        ElseIf InStr(p_CheckName, "Y") > 0 Then
            m_CheckTasks.Add(CheckTaskFactory.Create(CheckTaskFactory.crPattern.patternY, p_CheckName))
        ElseIf InStr(p_CheckName, "Z") > 0 Then
            m_CheckTasks.Add(CheckTaskFactory.Create(CheckTaskFactory.crPattern.patternZ, p_CheckName))
        End If

    End Sub

    Public Sub Start()

        Dim runnerThread As New Thread(New ThreadStart(AddressOf RunnerStart))

        runnerThread.Start()

    End Sub

    Public Sub RunnerStart()

        Do
            '次の状態確認まで停止
            System.Threading.Thread.Sleep(m_RunnerInterval)

            '全タスク終了まで繰り返す
            If GetTaskCount(CheckTaskBase.ctStatus.finish) = m_CheckTasks.Count Then
                '終了イベント通知
                RaiseEvent Finish()
                Exit Sub
            End If

            'タスク開始(最大同時実行数まで)
            Dim w_CntReady As Long = GetTaskCount(CheckTaskBase.ctStatus.ready)
            Dim w_CntProgress As Long = GetTaskCount(CheckTaskBase.ctStatus.progress)

            If w_CntReady > 0 And w_CntProgress < m_MaxRunCount Then
                Dim w_RunCount As Long = m_MaxRunCount - w_CntProgress
                For Each w_CheckTask In m_CheckTasks
                    If (w_CheckTask.CheckStatus = CheckTaskBase.ctStatus.ready) And
                       (w_RunCount > 0) Then
                        w_CheckTask.Check()
                        w_RunCount -= 1
                    End If
                Next
            End If

            Debug.Print("All:" & m_CheckTasks.Count & " Ready:" & GetTaskCount(CheckTaskBase.ctStatus.ready) & " " &
                        "Progress:" & GetTaskCount(CheckTaskBase.ctStatus.progress) & " " &
                        "Finish:" & GetTaskCount(CheckTaskBase.ctStatus.finish))
        Loop

    End Sub

    Private Function GetTaskCount(ByVal p_Status As CheckTaskBase.ctStatus)
        Dim w_Count As Long
        For Each checkTask In m_CheckTasks
            If checkTask.CheckStatus = p_Status Then
                w_Count += 1
            End If
        Next
        Return w_Count
    End Function

    Public Function GetFinishTaskCount(Optional ByVal p_CheckName As String = "")
        Dim w_Count As Long
        For Each checkTask In m_CheckTasks
            If checkTask.CheckStatus = CheckTaskBase.ctStatus.finish Then
                If p_CheckName <> "" AndAlso InStr(checkTask.CheckParameter, p_CheckName) > 0 Then
                    w_Count += 1
                End If
                If p_CheckName = "" Then
                    w_Count += 1
                End If
            End If
        Next
        Return w_Count
    End Function

    Public WriteOnly Property MaxRunCount
        Set(value)
            m_MaxRunCount = value
        End Set
    End Property

    Public WriteOnly Property RunnerInterval
        Set(value)
            m_RunnerInterval = value
        End Set
    End Property

End Class
