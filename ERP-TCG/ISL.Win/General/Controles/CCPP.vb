''' Control creado para automatizar la carga de datos desde la tabla std.CCPP
''' con información de Centros poblados según su ubicación de departamento, provincia y distrito
Public Class CCPP

#Region "Declaración de variables"

    Public Delegate Sub DatosCambiadosEventHandler(ByVal Id As String)

    ''' <summary>
    ''' Evento que permite establecer si ha cambiado el Id del CCPP
    ''' </summary>
    ''' <remarks></remarks>
    Public Event DatoCambiado As DatosCambiadosEventHandler
    Const idPorDefecto As String = "1401010001"

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Id del centro poblado (10 caracteres)
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
    ''' Inicializar control con valores por defecto (CHICLAYO)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Inicializar()
        Seleccionar(idPorDefecto)
    End Sub

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
            Distrito1.CodigoProvincia = Provincia1.Id.Substring(2, 2)
            Distrito1.Seleccionar(id)
            CentroPoblado1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
            CentroPoblado1.CodigoProvincia = Provincia1.Id.Substring(2, 2)
            CentroPoblado1.CodigoDistrito = Distrito1.Id.Substring(4, 2)
            CentroPoblado1.Seleccionar(id)
        Catch ex As Exception
            Throw ex
        End Try
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

                Id = idDepartamento.Substring(0, 2) + "01010001"
                Provincia1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                Provincia1.Listar()

                Distrito1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                Distrito1.CodigoProvincia = "01"
                Distrito1.Listar()

                CentroPoblado1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                CentroPoblado1.CodigoProvincia = "01"
                CentroPoblado1.CodigoDistrito = "01"
                CentroPoblado1.Listar()

                If Not String.IsNullOrEmpty(Me.Id) Then Seleccionar(Me.Id.Substring(0, 2) + "01010001")

                CentroPoblado1.Refresh()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Control que se ejecuta cada vez que se modifica la provincia
    ''' </summary>
    ''' <param name="idProvincia"></param>
    ''' <param name="NombreProvincia"></param>
    ''' <remarks></remarks>
    Private Sub Provincia1_DatosCambiados(ByVal idProvincia As String, ByVal NombreProvincia As String) Handles Provincia1.DatosCambiados
        Try
            If Provincia1.cboProvincia.ReadOnly = False Then
                Id = idProvincia.Substring(0, 4) + "010001"
                Distrito1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                Distrito1.CodigoProvincia = Provincia1.Id.Substring(2, 2)
                Distrito1.Listar()

                CentroPoblado1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                CentroPoblado1.CodigoProvincia = "01"
                CentroPoblado1.CodigoDistrito = "01"
                CentroPoblado1.Listar()

                CentroPoblado1.Refresh()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cada vez que se modifica el distrito
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="NombreDistrito"></param>
    ''' <remarks></remarks>
    Private Sub Distrito1_DatosCambiados(ByVal id As String, ByVal NombreDistrito As String) Handles Distrito1.DatosCambiados
        If Distrito1.cboDistrito.ReadOnly = False Then

            CentroPoblado1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
            CentroPoblado1.CodigoProvincia = "01"
            CentroPoblado1.CodigoDistrito = "01"
            CentroPoblado1.Listar()

            Me.Id = id.Substring(0, 6) + "0001"

            If Not String.IsNullOrEmpty(Me.Id) Then
                Seleccionar(Me.Id)
            End If
            CentroPoblado1.Refresh()

        End If

    End Sub

    ''' <summary>
    ''' Evento que se ejecuta cuando se modifica el centro poblado
    ''' </summary>
    ''' <param name="idCentroPoblado"></param>
    ''' <param name="NombreCentroPoblado"></param>
    ''' <remarks></remarks>
    Private Sub CentroPoblado1_DatosCambiados(ByVal idCentroPoblado As String, ByVal NombreCentroPoblado As String) Handles CentroPoblado1.DatosCambiados
        If CentroPoblado1.cboCentroPoblado.ReadOnly = False Then Me.Id = idCentroPoblado
    End Sub

    Private Sub CCPP_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
        Try
            Seleccionar(Me.Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub CCPP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
