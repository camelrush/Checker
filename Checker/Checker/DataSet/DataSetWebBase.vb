Imports Checker

Public MustInherit Class DataSetWebBase
    Inherits DataSetBase

    Protected m_IeApp As SHDocVw.InternetExplorer
    Protected m_DataSet As Dictionary(Of String, String)

    Private Structure udtHtmlDefine
        Dim Name As String
        Dim Tag As String
        Dim Attr As String
        Dim Value As String
    End Structure

    Private m_HtmlDefs As Collection

    Public Sub New()
        MyBase.New
        m_HtmlDefs = New Collection()
    End Sub
    Public Sub New(ByVal p_PrimaryKey As String)
        MyBase.New(p_PrimaryKey)
    End Sub

    Public Sub AddHtmlDef(ByVal p_Name As String, ByVal p_Tag As String, ByVal p_Attribute As String, ByVal p_Value As String)
        Dim w_TmpDef As udtHtmlDefine
        w_TmpDef.Name = p_Name
        w_TmpDef.Tag = p_Tag
        w_TmpDef.Attr = p_Attribute
        w_TmpDef.Value = p_Value
        m_HtmlDefs.Add(w_TmpDef)
    End Sub

    Protected Function ReadHtmlData() As Dictionary(Of String, String)

        Dim w_Dic As New Dictionary(Of String, String)

        For Each w_HtmlDef As udtHtmlDefine In m_HtmlDefs

            Dim w_Doc As Object
            Dim w_Value As String = ""
            w_Doc = m_IeApp.Documents

            Select Case w_HtmlDef.Attr.ToUpper()
                Case "NAME"
                    w_Value = w_Doc.getElementsByName(w_HtmlDef.Value)(0)
                Case "ID"
                    w_Value = w_Doc.getElementById(w_HtmlDef.Value)
                Case "TAGNAME"
                    w_Value = w_Doc.getElementsByTagName(w_HtmlDef.Value)(0)
                Case "CLASS"
                    w_Value = w_Doc.getElementsByClassName(w_HtmlDef.Value)(0)
            End Select

            w_Dic.Add(w_HtmlDef.Name, w_Value)

        Next

        Return w_Dic

    End Function

End Class
