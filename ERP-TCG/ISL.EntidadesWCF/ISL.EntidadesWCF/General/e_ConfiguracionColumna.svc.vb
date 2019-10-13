<DataContract()> _
Public Class e_ConfiguracionColumna
    Implements Ie_ConfiguracionColumna
    Implements IEquatable(Of e_ConfiguracionColumna)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idtabla As String
    Private _nroorden As Integer
    Private _codigo As String
    Private _nombre As String
    Private _descripcion As String
    Private _tipodato As String
    Private _longitud As String
    Private _indclave As Integer
    Private _valordefecto As String
    Private _obligatorio As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()>
    Public Equivale As Integer
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
    Public Property IdTabla() As String
        Get
            Return _idtabla
        End Get
        Set(ByVal value As String)
            _idtabla = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As Integer
        Get
            Return _nroorden
        End Get
        Set(ByVal value As Integer)
            _nroorden = value
        End Set
    End Property

    <DataMember()> _
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    <DataMember()> _
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDato() As String
        Get
            Return _tipodato
        End Get
        Set(ByVal value As String)
            _tipodato = value
        End Set
    End Property

    <DataMember()> _
    Public Property Longitud() As String
        Get
            Return _longitud
        End Get
        Set(ByVal value As String)
            _longitud = value
        End Set
    End Property

    Public Property IndClave() As Integer
        Get
            Return _IndClave
        End Get
        Set(ByVal value As Integer)
            _IndClave = value
        End Set
    End Property

    <DataMember()> _
    Public Property ValorDefecto() As String
        Get
            Return _valordefecto
        End Get
        Set(ByVal value As String)
            _valordefecto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Obligatorio() As Integer
        Get
            Return _obligatorio
        End Get
        Set(ByVal value As Integer)
            _obligatorio = value
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

    Public Property UsuarioCreacion() As String
        Get
            Return _usuariocreacion
        End Get
        Set(ByVal value As String)
            _usuariocreacion = value
        End Set
    End Property

    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
        End Set
    End Property

    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
        End Set
    End Property

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
        _idtabla = String.Empty
        _nroorden = 0
        _codigo = String.Empty
        _nombre = String.Empty
        _descripcion = String.Empty
        _tipodato = String.Empty
        _longitud = String.Empty
        _indclave = -1
        _valordefecto = String.Empty
        _obligatorio = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
          ByVal ls_Id As String _
          , ByVal ls_IdTabla As String _
          , ByVal ln_NroOrden As Integer _
          , ByVal ls_Codigo As String _
          , ByVal ls_Nombre As String _
          , ByVal ls_Descripcion As String _
          , ByVal ls_TipoDato As String _
          , ByVal ls_Longitud As String _
          , ByVal lb_IndClave As Boolean _
          , ByVal ls_ValorDefecto As String _
          , ByVal ln_Obligatorio As Integer _
          , ByVal ld_FechaCreacion As Date _
          , ByVal ls_UsuarioCreacion As String _
          , ByVal ld_FechaModifica As Date _
          , ByVal ls_UsuarioModifica As String _
          , ByVal lb_Activo As Boolean _
       )
        _id = ls_Id
        _idtabla = ls_IdTabla
        _nroorden = ln_NroOrden
        _codigo = ls_Codigo
        _nombre = ls_Nombre
        _descripcion = ls_Descripcion
        _tipodato = ls_TipoDato
        _longitud = ls_Longitud
        _indclave = IIf(lb_IndClave, 1, 0)
        _valordefecto = ls_ValorDefecto
        _obligatorio = ln_Obligatorio
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
        TipoOperacion = String.Empty
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(configuracioncolumna As e_ConfiguracionColumna) As e_ConfiguracionColumna Implements Ie_ConfiguracionColumna.Obtener
        Return configuracioncolumna
    End Function

    Public Overloads Function Equals(ByVal oeConCol As e_ConfiguracionColumna) As Boolean Implements System.IEquatable(Of e_ConfiguracionColumna).Equals
        Select Case oeConCol.Equivale
            Case 1 : If Me.Id.Trim = oeConCol.Id.Trim Then Return True
            Case 2 : If Me.Codigo.Trim = oeConCol.Codigo.Trim Then Return True
            Case 3 : If Me.Nombre.Trim = oeConCol.Nombre.Trim Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
