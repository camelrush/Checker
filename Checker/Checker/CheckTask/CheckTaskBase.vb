Imports Checker
Imports System.Threading

Public MustInherit Class CheckTaskBase
    Implements ICheckRoutine

    Public Event Finish()

    Protected Shared m_DataSetWebA As DataSetWebA
    Protected Shared m_DataSetWebB As New Dictionary(Of String, DataSetWebB)
    Protected Shared m_DataSetExcelA As DataSetExcelA
    Protected Shared m_DataSetExcelB As DataSetExcelB

    Public Enum ctStatus
        Ready
        Progress
        Finish
    End Enum

    Private m_Status As ctStatus
    Private m_CheckParam As String

    Protected MustOverride Sub CheckMethod(ByVal p_CheckParam As String) Implements ICheckRoutine.CheckMethod

    Public Sub Check()

        Dim checkThread As New Thread(New ThreadStart(AddressOf CheckStart))

        m_Status = ctStatus.Ready

        Call checkThread.Start()

    End Sub

    Private Sub CheckStart()

        m_Status = ctStatus.progress

        Call CheckMethod(m_CheckParam)

        m_Status = ctStatus.finish

        RaiseEvent Finish()

        Debug.Print("Task Finished. checkParam=" & m_CheckParam)

    End Sub

    Public Shared Sub SetPrimaryKey(ByVal p_DataSetType As DataSetBase.dsType, ByVal p_Key As String)
        Select Case p_DataSetType
            Case DataSetBase.dsType.ExcelA
            Case DataSetBase.dsType.ExcelB
            Case DataSetBase.dsType.WebA
                m_DataSetWebA = New DataSetWebA(p_Key)
            Case DataSetBase.dsType.WebB
                m_DataSetWebB.Add(p_Key, New DataSetWebB(p_Key))
        End Select

    End Sub

    Public ReadOnly Property CheckStatus() As ctStatus
        Get
            Return m_Status
        End Get
    End Property

    Public Property CheckParameter As String
        Get
            Return Me.m_CheckParam
        End Get
        Set(param As String)
            Me.m_CheckParam = param
        End Set
    End Property

End Class
