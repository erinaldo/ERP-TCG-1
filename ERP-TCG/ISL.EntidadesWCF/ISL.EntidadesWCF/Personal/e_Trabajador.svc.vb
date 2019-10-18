''' <summary>
''' Clase para definir la entidad: Trabajador
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_Trabajador
    Implements Ie_Trabajador
    Implements ICloneable
    Implements IEquatable(Of e_Trabajador)

#Region "Declaracion de Variables"

    Private _Seleccion As Boolean
    Private _id As String
    Private _codigo As String
    Private _fechaingreso As Date
    Private _fechacese As Date
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _disponible As Boolean
    Private _claveseguridad As String
    Private _idEstadoCivil As String
    Private _idGradoInstruccion As String
    Private _idLugarNacimiento As String
    Private _idTipoRelacionLaboral As String
    Private _relacionLaboral As String
    Private _indestado As Integer
    Private _indhijo As Integer
    Private _indtipo As Integer
    Private _indpiloto As Integer

    <DataMember()> _
    Public oeCargo As New e_Cargo
    <DataMember()> _
    Public oeOcupacion As New e_Ocupacion
    <DataMember()> _
    Public Shadows TipoOperacion As String = ""
    <DataMember()> _
    Public Shadows Modificado As Boolean
    <DataMember()> _
    Public oePersona As New e_Persona
    <DataMember()> _
    Public oeArea As New e_Area
    <DataMember()> _
    Public oeCuentaCorriente As New e_CuentaCorriente
    <DataMember()> _
    Public leOcupacionTrabajador As New List(Of e_OcupacionTrabajador)
    <DataMember()> _
    Public leSueldo As New List(Of e_SueldoTrabajador)
    <DataMember()> _
    Public leFondoPension As New List(Of e_FondoPensionTrabajador)
    <DataMember()> _
    Public leRegimenSalud As New List(Of e_RegimenSalud)
    <DataMember()> _
    Public leSeguroComp As New List(Of e_SeguroComplementario)
    <DataMember()> _
    Public leCtaBancaria As New List(Of e_CuentaCtePersonal)
    <DataMember()> _
    Public leContratos As New List(Of e_Contratos)
    <DataMember()> _
    Public leDerechoHabiente As New List(Of e_DerechoHabiente)
    <DataMember()> _
    Public TipoBusca As Integer
    <DataMember()> _
    Public CargaCompleto As Boolean = False
    <DataMember()> _
    Public CantidadRef As Double
    <DataMember()> _
    Public IdCentro As String
    <DataMember()> _
    Public Centro As String
    <DataMember()> _
    Public IndRuta As Integer

    Public Event DatoCambiado()
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""
    <DataMember()>
    Public Property Foto() As Byte()
#End Region

#Region "Constructor"

    Public Sub New()
        _id = ""
        _codigo = ""
        ' _idpersona = ""
        _fechacese = #1/1/1901#
        _fechaingreso = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _activo = True
        _usuariocreacion = ""
        _disponible = True
        _claveseguridad = String.Empty
        Foto = Nothing
    End Sub

    Public Sub New(ByVal lb_Seleccion As Boolean,
          ByVal Id As String _
          , ByVal IdArea As String _
          , ByVal Area As String _
          , ByVal IdCargo As String _
          , ByVal Cargo As String _
          , ByVal IdPersona As String _
          , ByVal Codigo As String _
           , ByVal DNI As String _
           , ByVal ApellidoPaterno As String _
           , ByVal ApellidoMaterno As String _
          , ByVal Nombre As String _
          , ByVal Sexo As e_Sexo _
          , ByVal FechaNacimiento As Date _
          , ByVal FechaIngreso As Date _
          , ByVal FechaCese As Date _
          , ByVal Activo As Boolean _
            , ByVal IdOcupacion As String _
          , ByVal Ocupacion As String _
          , ByVal disponible As Boolean _
          , ByVal idEstadoCivil As String _
          , ByVal idGradoInstruccion As String _
          , ByVal idLugarNacimiento As String _
          , ByVal idTipoRelacionLaboral As String _
          , ByVal relacionLaboral As String _
          , ByVal ln_Estado As Integer _
          , ByVal ln_IndHijo As Integer _
          , ByVal ln_Tipo As Integer _
          , ByVal ln_Piloto As Integer _
          , ByVal ls_ClaveSeguridad As String _
          , ByVal ls_IdCentro As String _
          , ByVal ln_IndRuta As Integer _
          , ByVal ln_Foto As Byte()
          )

        _id = Id
        oeCargo.Id = IdCargo
        oeCargo.Nombre = Cargo
        _codigo = Codigo
        oePersona.Id = IdPersona
        oePersona.Dni = DNI
        oePersona.ApellidoPaterno = ApellidoPaterno
        oePersona.ApellidoMaterno = ApellidoMaterno
        oePersona.Nombre = Nombre
        oePersona.oeSexo.Id = Sexo.Id
        oePersona.oeSexo.Nombre = Sexo.Nombre
        oePersona.FechaNacimiento = FechaNacimiento
        oeArea.Id = IdArea
        oeArea.Nombre = Area
        _fechaingreso = FechaIngreso
        _fechacese = FechaCese
        _activo = Activo
        oeOcupacion.Id = IdOcupacion
        oeOcupacion.Nombre = Ocupacion
        _disponible = disponible
        _idEstadoCivil = IIf(IsDBNull(idEstadoCivil), "", idEstadoCivil)
        _idGradoInstruccion = IIf(IsDBNull(idGradoInstruccion), "", idGradoInstruccion)
        _idLugarNacimiento = IIf(IsDBNull(idLugarNacimiento), "", idLugarNacimiento)
        _idTipoRelacionLaboral = idTipoRelacionLaboral
        _relacionLaboral = relacionLaboral
        _indestado = ln_Estado
        _indhijo = ln_IndHijo
        _indtipo = ln_Tipo
        _indpiloto = ln_Piloto
        _claveseguridad = ls_ClaveSeguridad
        IdCentro = ls_IdCentro
        IndRuta = ln_IndRuta
        Foto = ln_Foto
    End Sub

    Public Sub New(ByVal _oePersona As e_Persona)
        With _oePersona
            oePersona.Id = .Id
            oePersona.Codigo = .Codigo
            oePersona.Activo = .Activo
        End With
        _id = ""
        _codigo = ""
        _fechacese = #1/1/1901#
        _fechaingreso = #1/1/1901#
        _fechacreacion = #1/1/1901#
        _activo = True
        _usuariocreacion = ""
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Seleccion() As Boolean
        Get
            Return _Seleccion
        End Get
        Set(ByVal value As Boolean)
            _Seleccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCese() As Date
        Get
            Return _fechacese
        End Get
        Set(ByVal value As Date)
            _fechacese = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Disponible() As Boolean
        Get
            Return _disponible
        End Get
        Set(ByVal value As Boolean)
            _disponible = value
        End Set
    End Property

    <DataMember()> _
    Public Property ClaveSeguridad() As String
        Get
            Return _claveseguridad
        End Get
        Set(ByVal value As String)
            _claveseguridad = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoCivil() As String
        Get
            Return _idEstadoCivil
        End Get
        Set(ByVal value As String)
            _idEstadoCivil = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdGradoInstruccion() As String
        Get
            Return _idGradoInstruccion
        End Get
        Set(ByVal value As String)
            _idGradoInstruccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdLugarNacimiento() As String
        Get
            Return _idLugarNacimiento
        End Get
        Set(ByVal value As String)
            _idLugarNacimiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoRelacionLaboral() As String
        Get
            Return _idTipoRelacionLaboral
        End Get
        Set(ByVal value As String)
            _idTipoRelacionLaboral = value
        End Set
    End Property

    <DataMember()> _
    Public Property RelacionLaboral() As String
        Get
            Return _relacionLaboral
        End Get
        Set(ByVal value As String)
            _relacionLaboral = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndEstado() As Integer
        Get
            Return _indestado
        End Get
        Set(ByVal value As Integer)
            _indestado = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndHijo() As Integer
        Get
            Return _indhijo
        End Get
        Set(ByVal value As Integer)
            _indhijo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipo() As Integer
        Get
            Return _indtipo
        End Get
        Set(ByVal value As Integer)
            _indtipo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPiloto() As Integer
        Get
            Return _indpiloto
        End Get
        Set(ByVal value As Integer)
            _indpiloto = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

    ''' <summary>
    ''' Obtener una entidad de tipo e_Trabajador
    ''' </summary>
    ''' <param name="trabajador"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal trabajador As e_Trabajador) As e_Trabajador Implements Ie_Trabajador.Obtener
        Return trabajador
    End Function

    Public Overloads Function Equals(ByVal oeTrabajador As e_Trabajador) As Boolean Implements System.IEquatable(Of e_Trabajador).Equals

        Select Case oeTrabajador.TipoBusca
            Case 1 : If Me.Id.Trim = oeTrabajador.Id.Trim Then Return True
            Case 2 : If Me.oePersona.Dni = oeTrabajador.oePersona.Dni Then Return True
            Case 3 : If Me.oePersona.NombreCompleto.Trim = oeTrabajador.oePersona.NombreCompleto.Trim Then Return True
        End Select

        Return False
    End Function

    Public Function InicializaTrabajador() As e_Trabajador
        Dim oeTrabajador As New e_Trabajador
        oeTrabajador.Id = String.Empty
        oeTrabajador.oePersona.Dni = String.Empty
        oeTrabajador.oePersona.ApellidoPaterno = String.Empty
        oeTrabajador.oePersona.ApellidoMaterno = String.Empty
        oeTrabajador.Codigo = String.Empty
        oeTrabajador.oePersona.Nombre = String.Empty
        oeTrabajador.FechaIngreso = #1/1/1901#
        oeTrabajador.FechaCese = #1/1/1901#
        oeTrabajador.oeArea.Id = String.Empty
        oeTrabajador.oeCargo.Id = String.Empty
        oeTrabajador.oePersona.Id = String.Empty
        Return oeTrabajador
    End Function

#End Region

End Class


