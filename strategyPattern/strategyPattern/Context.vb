Public Class Context
    Private m_Strategy As New StrategyAbstract(0, 0)
    Public Sub New(ByVal st As StrategyAbstract)
        m_Strategy = st
    End Sub
    Public Function Operation() As Double
        Return m_Strategy.Operation()
    End Function

End Class
