Public Class CheckTaskX
    Inherits CheckTaskBase

    Protected Overrides Sub CheckMethod(ByVal p_CheckParam As String)

        Dim w_ColNameA As String = p_CheckParam.Split("!")(0)
        Dim w_ColNameB As String = p_CheckParam.Split("!")(1)

        'Aから値を取得
        Dim w_ValueA As String = m_DataSetWebA.Value(w_ColNameA)

        'Bから値を取得
        For w_i = 0 To m_DataSetWebB.Count - 1
            Dim w_WebB As DataSetWebB = m_DataSetWebB.ElementAt(w_i).Value
            Dim w_ValueB As String
            w_ValueB = w_WebB.Value(w_ColNameB)

            'A:Bで結果を判定
            If (w_ValueA = "●") And (w_ValueB = "●") Then
                'CheckOk
            End If
        Next

        System.Threading.Thread.Sleep(700)

    End Sub

End Class
