Public Class Eproducto

    Private codProd, nombreProd, descProd As String

    Public Property _codProd As String
        Get
            Return codProd
        End Get
        Set(ByVal value As String)
            codProd = value
        End Set
    End Property
    Public Property _nombreProd As String
        Get
            Return nombreProd
        End Get
        Set(ByVal value As String)
            nombreProd = value
        End Set
    End Property
    Public Property _descProd As String
        Get
            Return descProd
        End Get
        Set(ByVal value As String)
            descProd = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal codProd As String, ByVal nombreProd As String, ByVal descProd As String)
        Me.codProd = codProd
        Me._nombreProd = nombreProd
        Me._descProd = descProd
    End Sub

End Class
