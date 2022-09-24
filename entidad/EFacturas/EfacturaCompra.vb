Public Class EfacturaCompra
    Private codFactCompr, codProd As String
    Private fechaFact As Date
    Private estatus As Boolean

    Public Property _codFactCompr As String
        Get
            Return codFactCompr
        End Get
        Set(ByVal value As String)
            codFactCompr = value
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
