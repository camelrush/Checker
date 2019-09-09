Imports Checker
Imports System.Threading

Public MustInherit Class CheckTaskBase
    Implements ICheckRoutine

    Public Event Finish()

    Protected Shared m_DataSetWebA As DataSetWebA
    Protected Shared m_DataSetExcelA As DataSetExcelA

    Public Enum ctStatus
        ready
        progress
        finish
    End Enum

    Private m_Status As ctStatus
    Private m_CheckParam As String

    Protected MustOverride Sub CheckMethod(ByVal p_CheckParam As String) Implements ICheckRoutine.CheckMethod

    Public Sub Check()

        Dim checkThread As New Thread(New ThreadStart(AddressOf CheckStart))

        m_Status = ctStatus.ready

        Call checkThread.Start()

    End Sub

    Private Sub CheckStart()

        m_Status = ctStatus.progress

        Call CheckMethod(m_CheckParam)

        m_Status = ctStatus.finish

        RaiseEvent Finish()

        Debug.Print("Task Finished. checkParam=" & m_CheckParam)

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
