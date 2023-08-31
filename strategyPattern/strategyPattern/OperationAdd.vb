Public Class OperationAdd
    Inherits StrategyAbstract
    Public Sub New(a As Double, b As Double)
        MyBase.New(a, b)
    End Sub
    Public Overrides Function Operation() As Double
        Return MyBase.A() + MyBase.B()
    End Function
End Class
