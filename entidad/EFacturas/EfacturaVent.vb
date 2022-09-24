Public Class EfacturaVent
    Private codFactVent, codProd As String
    Private fechaFact As Date
    Private estatus As Boolean

    Public Property _codFactVent As String
        Get
            Return codFactVent
        End Get
        Set(ByVal value As String)
            codFactVent = value
        End Set
    End Property
    Public Property _codProd As String
        Get
            Return codProd
        End Get
        Set(ByVal value As String)
            codProd = value
        End Set
    End Property
    Public Property _fechaFact As Date
        Get
            Return fechaFact
        End Get
        Set(ByVal value As Date)
            fechaFact = value
        End Set
    End Property
    Public Property _estatus As Boolean
        Get
            Return estatus
        End Get
        Set(ByVal value As Boolean)
            estatus = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
