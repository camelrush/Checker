Imports Checker

Public MustInherit Class DataSetBase
    Implements IDataSet


    Protected MustOverride Function GetDataMethod(ByVal p_Key As String) As String Implements IDataSet.GetDataMethod

    Public Function GetData(ByVal p_Key As String) As String



    End Function

End Class
