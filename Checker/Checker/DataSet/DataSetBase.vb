Imports Checker

Public MustInherit Class DataSetBase
    Implements IDataSet

    Private m_PrimaryKey As String
    Private m_DataSet As Dictionary(Of String, String)
    Private m_IsEmpty As Boolean

    Public Enum dsType
        WebA
        WebB
        ExcelA
        ExcelB
        ExcelC
    End Enum

    Public Sub New()

    End Sub

    Public Sub New(ByVal p_PrimaryKey As String)
        Me.New()
        m_PrimaryKey = p_PrimaryKey
        m_IsEmpty = True
    End Sub

    Public ReadOnly Property Value(ByVal p_Key As String) As String
        Get
            If m_IsEmpty Then
                m_DataSet = ReadDataSet(m_PrimaryKey)
                m_IsEmpty = False
            End If
            Return m_DataSet(p_Key)
        End Get
    End Property

    Protected MustOverride Function ReadDataSet(ByVal p_PrimaryKey As String) As Dictionary(Of String, String) Implements IDataSet.ReadDataSet

End Class
