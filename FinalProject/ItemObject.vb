Public Class ItemObject

    Private ObjectAdapter As New ProjectDatabaseDataSetTableAdapters.SaleObjectTableAdapter
    Private CatagoryAdapter As New ProjectDatabaseDataSetTableAdapters.CatagoryTableAdapter
    Private DepartmentAdapter As New ProjectDatabaseDataSetTableAdapters.DepartmentsTableAdapter
    Private mLastStatus As String

    Public ReadOnly Property LastStatus As String
        Get
            Return mLastStatus
        End Get
    End Property

    Public Function ObjectInsert(ByVal pUPC As Integer,
                           ByVal pInvCount As Integer,
                           ByVal pPurchasePrice As Decimal,
                           ByVal pMarkUp As Decimal) As Boolean
        Dim WorksFlag As Boolean
        If ObjectAdapter.Insert(pUPC, pInvCount, pPurchasePrice, pMarkUp, 0, 0, 0, 0) > 0 Then
            WorksFlag = True
            mLastStatus = String.Format("{0} Item Added To Database.", pUPC)
        Else
            WorksFlag = False
            mLastStatus = String.Format("Error Adding {0} Item To Database.", pUPC)
        End If
        Return WorksFlag
    End Function
    Public Function DepartmentInsert(ByVal pID As Integer,
                                     ByVal pName As String) As Boolean
        Dim WorksFlag As Boolean
        If DepartmentAdapter.Insert(pID, pName) > 0 Then
            WorksFlag = True
            mLastStatus = String.Format("Department {0} Added", pName)
        Else
            WorksFlag = False
            mLastStatus = String.Format("Department {0} Not Added", pName)
        End If
        Return WorksFlag
    End Function

End Class
