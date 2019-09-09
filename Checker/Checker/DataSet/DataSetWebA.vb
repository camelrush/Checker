Public Class DataSetWebA
    Inherits DataSetWebBase

    Private Const Url = "https://camelrushsampleweb.s3-ap-northeast-1.amazonaws.com/public/index.html"

    Protected Overrides Function GetDataMethod(p_Key As String) As String
    End Function

    Protected Overrides Function Scraping() As Boolean

    End Function

End Class
