<DataContract()> _
Public Class e_DetalleRegistroDevolucion
    Implements Ie_DetalleRegistroDevolucion
    Implements IEquatable(Of e_DetalleRegistroDevolucion)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idregistrodevolucion As String
    Private _idvidaneumatico As String
    'Private _marca As String
    'Private _modelo As String
    'Private _disenio As String
    Private _idmaterial As String
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public oeVidaNeumatico As New e_VidaNeumatico
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

#End Region

#Region "Propiedades"

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
    Public Property IdRegistroDevolucion() As String
        Get
            Return _idregistrodevolucion
        End Get
        Set(ByVal value As String)
            _idregistrodevolucion = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdVidaNeumatico() As String
        Get
            Return _idvidaneumatico
        End Get
        Set(ByVal value As String)
            _idvidaneumatico = value
        End Set
    End Property

    '<DataMember()> _
    'Public Property Marca() As String
    '    Get
    '        Return _marca
    '    End Get
    '    Set(ByVal value As String)
    '        _marca = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property Modelo() As String
    '    Get
    '        Return _modelo
    '    End Get
    '    Set(ByVal value As String)
    '        _modelo = value
    '    End Set
    'End Property

    '<DataMember()> _
    'Public Property Disenio() As String
    '    Get
    '        Return _disenio
    '    End Get
    '    Set(ByVal value As String)
    '        _disenio = value
    '    End Set
    'End Property

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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property


#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idregistrodevolucion = String.Empty
        _idvidaneumatico = String.Empty
        '_marca = String.Empty
        '_modelo = String.Empty
        '_disenio = String.Empty
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _activo = True
        TipoOperacion = String.Empty
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRegistroDevolucion As String _
              , ByVal ls_IdVidaNeumatico As String _
              , ByVal ls_IdNeumatico As String _
              , ByVal ls_CodigoNeumatico As String _
              , ByVal ls_Diseño As String _
              , ByVal ls_Marca As String _
              , ByVal ls_Medida As String _
              , ByVal ln_KmTotalNeu As Double _
              , ByVal ln_CocadaMimina As Double _
              , ByVal ln_NroVida As Integer _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ls_Condicion As String _
              , ByVal ls_EstadoActual As String _
              , ByVal ls_Ubicacion As String _
              , ByVal ln_KM As Double _
              , ByVal ln_Ribete1 As Double _
              , ByVal ln_Ribete2 As Double _
              , ByVal ln_Ribete3 As Double _
              , ByVal ln_Cocada As Double _
              , ByVal ln_CocadaOriginal As Double _
              , ByVal ls_Proveedor As String _
              , ByVal ls_IdDisenoNeu As String _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idregistrodevolucion = ls_IdRegistroDevolucion
        _idvidaneumatico = ls_IdVidaNeumatico

        oeVidaNeumatico.IdNeumatico = ls_IdNeumatico
        oeVidaNeumatico.CodigoNeumatico = ls_CodigoNeumatico
        oeVidaNeumatico.Diseño = ls_Diseño
        oeVidaNeumatico.Marca = ls_Marca
        oeVidaNeumatico.Medida = ls_Medida
        oeVidaNeumatico.KmTotalNeumatico = ln_KmTotalNeu
        oeVidaNeumatico.CocadaMinima = ln_CocadaMimina
        oeVidaNeumatico.NroVida = ln_NroVida
        oeVidaNeumatico.FechaIngreso = ld_FechaIngreso
        oeVidaNeumatico.Condicion = ls_Condicion
        oeVidaNeumatico.EstadoActual = ls_EstadoActual
        oeVidaNeumatico.Ubicacion = ls_Ubicacion
        oeVidaNeumatico.Kilometraje = ln_KM
        oeVidaNeumatico.Ribete1 = ln_Ribete1
        oeVidaNeumatico.Ribete2 = ln_Ribete2
        oeVidaNeumatico.Ribete3 = ln_Ribete3
        oeVidaNeumatico.Cocada = ln_Cocada
        oeVidaNeumatico.CocadaOriginal = ln_CocadaOriginal
        oeVidaNeumatico.Proveedor = ls_Proveedor
        oeVidaNeumatico.IdDisenoNeu = ls_IdDisenoNeu

        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _activo = lb_Activo

        TipoOperacion = String.Empty
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal detalleregistrodevolucion As e_DetalleRegistroDevolucion) As e_DetalleRegistroDevolucion Implements Ie_DetalleRegistroDevolucion.Obtener
        Return detalleregistrodevolucion
    End Function

#End Region

    Public Overloads Function Equals(ByVal oeDetalleRV As e_DetalleRegistroDevolucion) As Boolean Implements System.IEquatable(Of e_DetalleRegistroDevolucion).Equals
        If Me.IdVidaNeumatico = oeDetalleRV.IdVidaNeumatico Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
