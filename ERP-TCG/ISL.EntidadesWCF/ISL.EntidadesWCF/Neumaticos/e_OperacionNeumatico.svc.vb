<DataContract()> _
Public Class e_OperacionNeumatico
    Implements Ie_OperacionNeumatico
    Implements IEquatable(Of e_OperacionNeumatico)

#Region "Propiedad"

    Private _id As String
    Private _codigo As String
    Private _idvehiculo As String
    Private _vehiculo As String
    Private _vidaneumatico As String
    Private _codneumatico As String
    Private _disenio As String
    Private _idneumatico As String
    Private _marca As String
    Private _medida As String
    Private _idmotivo As String
    Private _motivo As String
    Private _indmontaje As Integer
    Private _indinspeccion As Integer
    Private _posicion As Integer
    Private _cocada As Double
    Private _fechaoperacion As Date
    Private _kmvehiculo As Double
    Private _kmneumatico As Double
    Private _kmrecorridoneu As Double ' propiedad de apoyo para las inspecciones
    Private _ribete1 As Double
    Private _ribete2 As Double
    Private _ribete3 As Double
    Private _ribete4 As Double
    Private _presion As Double
    Private _descripcion As String
    Private _activo As Boolean
    Private _usuariocreacion As String
    Private _idresponsable As String
    Private _idconductor As String
    Private _indobservacion As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Operacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public IndAct As Integer = 0

    Public Event DatoCambiado()

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
    Public Property IdVidaNeumatico() As String
        Get
            Return _vidaneumatico
        End Get
        Set(ByVal value As String)
            _vidaneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdNeumatico() As String
        Get
            Return _idneumatico
        End Get
        Set(ByVal value As String)
            _idneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property CodigoNeumatico() As String
        Get
            Return _codneumatico
        End Get
        Set(ByVal value As String)
            _codneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    <DataMember()> _
    Public Property Medida() As String
        Get
            Return _medida
        End Get
        Set(ByVal value As String)
            _medida = value
        End Set
    End Property

    <DataMember()> _
    Public Property Diseño() As String
        Get
            Return _disenio
        End Get
        Set(ByVal value As String)
            _disenio = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVehiculo() As String
        Get
            Return _idvehiculo
        End Get
        Set(ByVal value As String)
            _idvehiculo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Placa() As String
        Get
            Return _vehiculo
        End Get
        Set(ByVal value As String)
            _vehiculo = value
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
    Public Property IdMotivo() As String
        Get
            Return _idmotivo
        End Get
        Set(ByVal value As String)
            _idmotivo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property


    <DataMember()> _
    Public Property IndMontaje() As Integer
        Get
            Return _indmontaje
        End Get
        Set(ByVal value As Integer)
            _indmontaje = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IndInspeccion() As Integer
        Get
            Return _indinspeccion
        End Get
        Set(ByVal value As Integer)
            _indinspeccion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Posicion() As Integer
        Get
            Return _posicion
        End Get
        Set(ByVal value As Integer)
            _posicion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Cocada() As Double
        Get
            Return _cocada
        End Get
        Set(ByVal value As Double)
            _cocada = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOperacion() As Date
        Get
            Return _fechaoperacion
        End Get
        Set(ByVal value As Date)
            _fechaoperacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property KmVehiculo() As Double
        Get
            Return _kmvehiculo
        End Get
        Set(ByVal value As Double)
            _kmvehiculo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property KmNeumatico() As Double
        Get
            Return _kmneumatico
        End Get
        Set(ByVal value As Double)
            _kmneumatico = value
        End Set
    End Property

    <DataMember()> _
    Public Property KmRecorridoNeu() As Double
        Get
            Return _kmrecorridoneu
        End Get
        Set(ByVal value As Double)
            _kmrecorridoneu = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete1() As Double
        Get
            Return _ribete1
        End Get
        Set(ByVal value As Double)
            _ribete1 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete2() As Double
        Get
            Return _ribete2
        End Get
        Set(ByVal value As Double)
            _ribete2 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete3() As Double
        Get
            Return _ribete3
        End Get
        Set(ByVal value As Double)
            _ribete3 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Ribete4() As Double
        Get
            Return _ribete4
        End Get
        Set(ByVal value As Double)
            _ribete4 = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Presion() As Double
        Get
            Return _presion
        End Get
        Set(ByVal value As Double)
            _presion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
        Public Property IdResponsable() As String
        Get
            Return _idresponsable
        End Get
        Set(ByVal value As String)
            _idresponsable = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdConductor() As String
        Get
            Return _idconductor
        End Get
        Set(ByVal value As String)
            _idconductor = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndObservacion() As Integer
        Get
            Return _indobservacion
        End Get
        Set(ByVal value As Integer)
            _indobservacion = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        Activo = True
        IndInspeccion = -1
        IndMontaje = -1
        FechaOperacion = Date.Parse("01/01/1901")
        Posicion = 0
        TipoOperacion = String.Empty
        _idresponsable = String.Empty
        _idconductor = String.Empty
        _usuariocreacion = String.Empty
        _indobservacion = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
               , ByVal ls_Codigo As String _
              , ByVal ls_IdVidaNeumatico As String _
              , ByVal ls_IdNeumatico As String _
              , ByVal ls_CodigoNeumatico As String _
              , ByVal ls_Marca As String _
              , ByVal ls_Medida As String _
              , ByVal ls_Diseño As String _
              , ByVal ls_IdVehiculo As String _
              , ByVal ls_Placa As String _
              , ByVal ls_IdMotivo As String _
              , ByVal ls_Motivo As String _
              , ByVal ln_IndMontaje As Integer _
              , ByVal ln_IndInspeccion As Integer _
              , ByVal ln_Posicion As Integer _
              , ByVal ld_FechaOperacion As Date _
              , ByVal ln_KmVehiculo As Double _
              , ByVal ln_KmNeumatico As Double _
              , ByVal ln_Ribete1 As Double _
              , ByVal ln_Ribete2 As Double _
              , ByVal ln_Ribete3 As Double _
              , ByVal ln_Ribete4 As Double _
               , ByVal ln_Cocada As Double _
              , ByVal ln_Presion As Double _
              , ByVal ls_Descripcion As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdResponsable As String _
              , ByVal ls_IdConductor As String _
           )
        _id = ls_Id
        _vidaneumatico = ls_IdVidaNeumatico
        _idneumatico = ls_IdNeumatico
        _codneumatico = ls_CodigoNeumatico
        _marca = ls_Marca
        _medida = ls_Medida
        _disenio = ls_Diseño

        _idvehiculo = ls_IdVehiculo
        _vehiculo = ls_Placa
        _codigo = ls_Codigo
        _idmotivo = ls_IdMotivo
        _motivo = ls_Motivo
        _indmontaje = ln_IndMontaje
        _indinspeccion = ln_IndInspeccion
        _posicion = ln_Posicion
        _cocada = ln_Cocada
        _fechaoperacion = ld_FechaOperacion
        _kmvehiculo = ln_KmVehiculo
        _kmneumatico = ln_KmNeumatico
        _ribete1 = ln_Ribete1
        _ribete2 = ln_Ribete2
        _ribete3 = ln_Ribete3
        _ribete4 = ln_Ribete4
        _presion = ln_Presion
        '_descripcion = ls_Descripcion
        _activo = lb_Activo
        _usuariocreacion = ls_UsuarioCreacion
        _kmrecorridoneu = ln_KmNeumatico

        _idresponsable = ls_IdResponsable
        _idconductor = ls_IdConductor

        If ls_Descripcion.Trim.Length > 0 Then
            If ls_Descripcion.Contains("|") Then
                Dim _cad() As String = ls_Descripcion.Split("|")
                If _cad.Count > 0 Then
                    _descripcion = _cad(0)
                    _indobservacion = _cad(1)
                End If
            Else
                _descripcion = ls_Descripcion
                _indobservacion = 0
            End If
        End If

    End Sub

#End Region

#Region "Métodos"

    ''' <summary>
    ''' Obtener una entidad de tipo e_OperacionNeumatico
    ''' </summary>
    ''' <param name="operacionNeumatico"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal operacionNeumatico As e_OperacionNeumatico) As e_OperacionNeumatico Implements Ie_OperacionNeumatico.Obtener
        Return operacionNeumatico
    End Function

    Public Overloads Function Equals(ByVal oeOpeNeu As e_OperacionNeumatico) As Boolean Implements System.IEquatable(Of e_OperacionNeumatico).Equals
        Select Case oeOpeNeu.Equivale
            Case 1 : If Me.Id = oeOpeNeu.Id Then Return True
            Case 2 : If Me.CodigoNeumatico = oeOpeNeu.CodigoNeumatico Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
