Public Class CheckTaskX
    Inherits CheckTaskBase

    Protected Overrides Sub CheckMethod(ByVal p_CheckParam As String)

        m_DataSetWebA.GetData(p_CheckParam)

        System.Threading.Thread.Sleep(700)

    End Sub

End Class
