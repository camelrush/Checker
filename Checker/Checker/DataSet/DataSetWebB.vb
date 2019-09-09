Public Class DataSetWebB
    Inherits DataSetWebBase

    Private Const M_URL = "https://camelrushsampleweb.s3-ap-northeast-1.amazonaws.com/public/index.html"

    Public Sub New(ByVal p_PrimaryKey As String)
        MyBase.New(p_PrimaryKey)
    End Sub

    Protected Overrides Function ReadDataSet(ByVal p_PrimaryKey As String) As Dictionary(Of String, String)

        'Scraping 手続き1

        'Scraping 手続き2

        'Scraping 手続き3

        'データを読み込んで返却
        Return ReadHtmlData()

    End Function

End Class
