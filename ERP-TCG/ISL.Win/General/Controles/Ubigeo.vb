''' <summary>
''' Control creado para automatizar la carga de datos desde la tabla STD.UBIGEO
''' </summary>
''' <remarks></remarks>
Public Class Ubigeo

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal Id As String)

    ''' <summary>
    ''' Evento que permite establecer si ha cambiado el Id del Ubigeo
    ''' </summary>
    ''' <remarks></remarks>
    Public Event DatoCambiado As DatosCambiadosEventHandler

    Const idPorDefecto As String = "140101"

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del lugar geográfico
    ''' </summary>
    ''' <remarks></remarks>
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
            RaiseEvent DatoCambiado(value)
        End Set
    End Property

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Método para seleccionar los combos del departamento, provincia y distrito a partir de un Id
    ''' </summary>
    ''' <param name="id"></param>
    ''' <remarks></remarks>
    Public Sub Seleccionar(ByVal id As String)
        Try
            If String.IsNullOrEmpty(id) Then id = idPorDefecto
            Departamento1.Seleccionar(id)
            Provincia1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
            Provincia1.Seleccionar(id)
            Distrito1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
            Distrito1.CodigoProvincia = Provincia1.Id.Substring(2, 4)
            Distrito1.Seleccionar(id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Inicializa el control con valores por defecto (CHICLAYO)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Inicializar()
        Seleccionar(idPorDefecto)
    End Sub

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica el departamento
    ''' </summary>
    ''' <param name="idDepartamento"></param>
    ''' <param name="NombreDepartamento"></param>
    ''' <remarks></remarks>
    Private Sub Departamento1_DatosCambiados(ByVal idDepartamento As String, ByVal NombreDepartamento As String) Handles Departamento1.DatosCambiados
        Try

            If Departamento1.cboDepartamento.ReadOnly = False Then

                Id = idDepartamento.Substring(0, 2) + "0000"
                Provincia1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                Provincia1.Listar()

                Distrito1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                Distrito1.CodigoProvincia = "01"
                Distrito1.Listar()

                If Not String.IsNullOrEmpty(Id) Then Seleccionar(Id)
                Distrito1.Refresh()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica una provincia
    ''' </summary>
    ''' <param name="idProvincia"></param>
    ''' <param name="NombreProvincia"></param>
    ''' <remarks></remarks>
    Private Sub Provincia1_DatosCambiados(ByVal idProvincia As String, ByVal NombreProvincia As String) Handles Provincia1.DatosCambiados
        Try
            If Provincia1.cboProvincia.ReadOnly = False Then
                Id = idProvincia.Substring(0, 4) + "00"
                Distrito1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                Distrito1.CodigoProvincia = Provincia1.Id.Substring(2, 2)
                Distrito1.Listar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica un distrito
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="NombreDistrito"></param>
    ''' <remarks></remarks>
    Private Sub Distrito1_DatosCambiados(ByVal id As String, ByVal NombreDistrito As String) Handles Distrito1.DatosCambiados
        If Distrito1.cboDistrito.ReadOnly = False Then Me.Id = id
    End Sub

    Private Sub Ubigeo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Try
            Seleccionar(Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
