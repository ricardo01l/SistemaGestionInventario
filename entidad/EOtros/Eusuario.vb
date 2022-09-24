Public Class Eusuario


    Private users, cedula, passwords, nombre, apellido, telefono, estatus, nivel As String

    Public Property _users As String
        Get
            Return users
        End Get
        Set(ByVal value As String)
            users = value
        End Set
    End Property
    Public Property _cedula As String
        Get
            Return cedula
        End Get
        Set(ByVal value As String)
            cedula = value
        End Set
    End Property
    Public Property _passwords As String
        Get
            Return passwords
        End Get
        Set(ByVal value As String)
            passwords = value
        End Set
    End Property
    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(ByVal value As String)
            apellido = value
        End Set
    End Property
    Public Property _telefono As String
        Get
            Return telefono
        End Get
        Set(ByVal value As String)
            telefono = value
        End Set
    End Property
    Public Property _estatus As String
        Get
            Return estatus
        End Get
        Set(ByVal value As String)
            estatus = value
        End Set
    End Property
    Public Property _nivel As String
        Get
            Return nivel
        End Get
        Set(ByVal value As String)
            nivel = value
        End Set
    End Property


    Public Sub New()

    End Sub
End Class
