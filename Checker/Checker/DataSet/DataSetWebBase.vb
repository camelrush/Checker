Imports Checker

Public MustInherit Class DataSetWebBase
    Inherits DataSetBase
    Implements IScraping

    Protected m_IeApp As SHDocVw.InternetExplorer
    Protected m_DataSet As Dictionary(Of String, String)

    Protected MustOverride Function Scraping() As Boolean Implements IScraping.Scraping
    'm_IeApp = CreateObject("InternetExplorer.application")

End Class
