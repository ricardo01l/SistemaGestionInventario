Public Class EinventarioVenta
    Private idInvVent, cantidad As String
    Private codProd, codFactVent, precio As String

    Public Property _idInvVent As String
        Get
            Return idInvVent
        End Get
        Set(ByVal value As String)
            idInvVent = value
        End Set
    End Property
    Public Property _cantidad As String
        Get
            Return cantidad
        End Get
        Set(ByVal value As String)
            cantidad = value
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
    Public Property _codFactVent As String
        Get
            Return codFactVent
        End Get
        Set(ByVal value As String)
            codFactVent = value
        End Set
    End Property
    Public Property _precio As String
        Get
            Return precio
        End Get
        Set(ByVal value As String)
            precio = value
        End Set
    End Property

    Public Sub New()

    End Sub
End Class
