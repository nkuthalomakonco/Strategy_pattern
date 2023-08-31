Public Class OperationDivision
    Inherits StrategyAbstract

    Public Sub New(a As Double, b As Double)
        MyBase.New(a, b)
    End Sub

    Public Overrides Function Operation() As Double
        Try
            Return MyBase.A() / MyBase.B()
        Catch ex As Exception
            Return 0 'div by 0
        End Try
    End Function
End Class
