Public Class StrategyAbstract
    Private m_A, m_B As Double
    Public Property A() As Double
        Get
            Return m_A
        End Get
        Set(ByVal value As Double)
            m_A = value
        End Set
    End Property
    Public Property B() As Double
        Get
            Return m_B
        End Get
        Set(ByVal value As Double)
            m_B = value
        End Set
    End Property
    Public Sub New(ByVal a As Double, ByVal b As Double)
        m_A = a
        m_B = b
    End Sub
    Overridable Function Operation() As Double
        Return 0
    End Function
End Class
