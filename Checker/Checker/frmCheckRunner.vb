

Public Class frmCheckRunner

    Private WithEvents Runner As CheckRunner
    Private Const M_RUNNING_TASK As Integer = 100
    Private m_CheckCount(3) As Long     '1:X、2:Y、3:Z

    Private Sub frmCheckRunner_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call InitRunner()
        Call InitScreen()

    End Sub

    Private Sub CmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        Call InitScreen()
        cmdStart.Enabled = False
        cmdInit.Enabled = False
        Call Runner.Start()
        timProgress.Enabled = True
        Call timProgress.Start()

    End Sub

    Private Sub CmdInit_Click(sender As Object, e As EventArgs) Handles cmdInit.Click
        Call InitRunner()
        Call InitScreen()
    End Sub

    Private Sub InitRunner()

        '要素数初期化
        m_CheckCount(1) = 0
        m_CheckCount(2) = 0
        m_CheckCount(3) = 0
        Runner = New CheckRunner

        For w_i = 0 To M_RUNNING_TASK - 1
            Dim w_Random As Integer = Fix((Rnd() * 100) Mod 3) + 1
            Select Case w_Random
                Case 1
                    Runner.Add("X_" & m_CheckCount(1) + 1)
                Case 2
                    Runner.Add("Y_" & m_CheckCount(2) + 1)
                Case 3
                    Runner.Add("Z_" & m_CheckCount(3) + 1)
            End Select
            m_CheckCount(w_Random) += 1
        Next

    End Sub

    Private Sub InitScreen()

        lblPrgAll.Text = "CheckAll(0/" & m_CheckCount(1) + m_CheckCount(2) + m_CheckCount(3) & ")"
        lblPrgX.Text = "CheckX(0/" & m_CheckCount(1) & ")"
        lblPrgY.Text = "CheckY(0/" & m_CheckCount(2) & ")"
        lblPrgZ.Text = "CheckZ(0/" & m_CheckCount(3) & ")"

        prgAll.Maximum = m_CheckCount(1) + m_CheckCount(2) + m_CheckCount(3)
        prgAll.Minimum = 0
        prgAll.Value = 0

        prgX.Maximum = m_CheckCount(1)
        prgX.Minimum = 0
        prgX.Value = 0

        prgY.Maximum = m_CheckCount(2)
        prgY.Minimum = 0
        prgY.Value = 0

        prgZ.Maximum = m_CheckCount(3)
        prgZ.Minimum = 0
        prgZ.Value = 0

        lblStatus.Text = ""

        Call timProgress.Stop()
        timProgress.Enabled = False

    End Sub

    Private Sub TimProgress_Tick(sender As Object, e As EventArgs) Handles timProgress.Tick

        Call m_RefreshScreen()

        If Runner.GetFinishTaskCount() = M_RUNNING_TASK Then
            Call timProgress.Stop()
            timProgress.Enabled = False
            Call MsgBox("Check Finished.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Checker")
            cmdStart.Enabled = True
            cmdInit.Enabled = True
        End If

    End Sub

    Private Sub m_RefreshScreen()

        Dim w_XFinish = Runner.GetFinishTaskCount("X")
        Dim w_YFinish = Runner.GetFinishTaskCount("Y")
        Dim w_ZFinish = Runner.GetFinishTaskCount("Z")

        lblPrgAll.Text = "CheckAll(" & w_XFinish + w_YFinish + w_ZFinish & "/" & m_CheckCount(1) + m_CheckCount(2) + m_CheckCount(3) & ")"
        lblPrgX.Text = "CheckX(" & w_XFinish & "/" & m_CheckCount(1) & ")"
        lblPrgY.Text = "CheckY(" & w_YFinish & "/" & m_CheckCount(2) & ")"
        lblPrgZ.Text = "CheckZ(" & w_ZFinish & "/" & m_CheckCount(3) & ")"

        prgAll.Value = w_XFinish + w_YFinish + w_ZFinish
        prgX.Value = w_XFinish
        prgY.Value = w_YFinish
        prgZ.Value = w_ZFinish

        lblStatus.Text = ""

    End Sub

    Private Sub CmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        End
    End Sub

End Class
