Public Class EinventarioCompra
    Private idInvCompr, cantidad As String
    Private codProd, codFactCompr, precio As String

    Public Property _idInvCompr As String
        Get
            Return idInvCompr
        End Get
        Set(ByVal value As String)
            idInvCompr = value
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
    Public Property _codFactCompr As String
        Get
            Return codFactCompr
        End Get
        Set(ByVal value As String)
            codFactCompr = value
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
