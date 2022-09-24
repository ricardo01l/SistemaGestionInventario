Public Class EinventarioGeneral

    Private idInv, balance As String
    Private codProd As String

    Public Property _idInv As String
        Get
            Return idInv
        End Get
        Set(ByVal value As String)
            idInv = value
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
    Public Property _balance As String
        Get
            Return balance
        End Get
        Set(ByVal value As String)
            balance = value
        End Set
    End Property


    Public Sub New()

    End Sub


End Class
