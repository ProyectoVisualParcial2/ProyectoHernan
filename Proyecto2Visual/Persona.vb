Public Class Persona

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property
    Private _edad As Integer
    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

    Sub New(id As Integer, nombre As String, apellido As String, edad As Integer)
        _id = id
        _nombre = nombre
        _apellido = apellido
        _edad = edad
    End Sub

    Sub New(nombre As String, apellido As String, edad As String)
        _nombre = nombre
        _apellido = apellido
        _edad = edad
    End Sub
End Class
