
<DataContract()> _
Public Class e_Sancion
    Implements Ie_Sancion
    Implements IEquatable(Of e_Sancion)

#Region "Declaracion de variables"

    Private _id As String
    Private _idtrabajador As String
    Private _Trabajador As String
    Private _idarea As String
    Private _Area As String
    Private _idconcepto As String
    Private _Concepto As String
    Private _idresponsable As String
    Private _Responsable As String
    Private _monto As Double
    Private _glosa As String
    Private _fecha As Date
    Private _activo As Boolean
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _idgrupo As String
    Private _idestado As String
    Private _estado As String
    Private _idusuarioaprueba As String
    Private _fechaaprueba As Date
    Private _nrocuota As Integer

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public _FechaInicio As Date
    <DataMember()> _
    Public _FechaFin As Date
    <DataMember()> _
    Public _CadenaIdGrupo As String
    <DataMember()> _
    Public _GrupoDesc As String
    <DataMember()> _
    Public _Tipo As Integer
    <DataMember()> _
    Public oeReqOASan As New e_ReqOAMSancion

    Public Event DatoCambiado()

#End Region

#Region "Propiedad"

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
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _Trabajador
        End Get
        Set(ByVal value As String)
            _Trabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
   Public Property Area() As String
        Get
            Return _Area
        End Get
        Set(ByVal value As String)
            _Area = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdConcepto() As String
        Get
            Return _idconcepto
        End Get
        Set(ByVal value As String)
            _idconcepto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Concepto() As String
        Get
            Return _Concepto
        End Get
        Set(ByVal value As String)
            _Concepto = value
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
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Responsable() As String
        Get
            Return _Responsable
        End Get
        Set(ByVal value As String)
            _Responsable = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
   Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property NroCuota() As String
        Get
            Return _nrocuota
        End Get
        Set(ByVal value As String)
            _nrocuota = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdGrupo() As String
        Get
            Return _idgrupo
        End Get
        Set(ByVal value As String)
            _idgrupo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstado() As String
        Get
            Return _idestado
        End Get
        Set(ByVal value As String)
            _idestado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    Public Property IdUsuarioAprueba() As String
        Get
            Return _idusuarioaprueba
        End Get
        Set(ByVal value As String)
            _idusuarioaprueba = value
        End Set
    End Property

    Public Property FechaAprobacion() As Date
        Get
            Return _fechaaprueba
        End Get
        Set(ByVal value As Date)
            _fechaaprueba = value
        End Set
    End Property

    <DataMember()> _
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property FechaCreacion() As Date
        Get
            Return _fechacreacion
        End Get
        Set(ByVal value As Date)
            _fechacreacion = value
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
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property


#End Region

#Region "Constructor"

    Public Sub New()
        _id = String.Empty
        _idtrabajador = String.Empty
        _idarea = String.Empty
        _idconcepto = String.Empty
        _idresponsable = String.Empty
        _monto = 0
        _glosa = String.Empty
        _fecha = #1/1/1901#
        _activo = True
        _fechacreacion = #1/1/1901#
        _usuariocreacion = #1/1/1901#
        _idgrupo = String.Empty
        _idestado = String.Empty
        _estado = String.Empty
        _Tipo = 0
        TipoOperacion = String.Empty
        _CadenaIdGrupo = String.Empty
        _GrupoDesc = String.Empty
        _FechaFin = #1/1/1901#
        _FechaInicio = #1/1/1901#
        _nrocuota = 1
        _idusuarioaprueba = String.Empty
        _fechaaprueba = #1/1/1901#
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ls_IdConcepto As String _
              , ByVal ls_Concepto As String _
              , ByVal ls_IdResponsable As String _
              , ByVal ls_Responsable As String _
              , ByVal ln_Monto As Double _
              , ByVal ls_Glosa As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ls_IdGrupo As String _
              , ByVal ls_IdEstado As String _
              , ByVal ls_Estado As String _
              , ByVal ln_Tipo As Integer _
           )

        _id = ls_Id
        _idtrabajador = ls_IdTrabajador
        _Trabajador = ls_Trabajador
        _idarea = ls_IdArea
        _Area = ls_Area
        _idconcepto = ls_IdConcepto
        _Concepto = ls_Concepto
        _idresponsable = ls_IdResponsable
        _Responsable = ls_Responsable
        _monto = ln_Monto
        _fecha = ld_Fecha
        _activo = lb_Activo
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _idgrupo = ls_IdGrupo
        _idestado = ls_IdEstado
        _estado = ls_Estado
        _Tipo = ln_Tipo
        TipoOperacion = String.Empty
        If ls_Glosa.Trim.Length > 0 Then
            If ls_Glosa.Contains("|") Then
                Dim _cad() As String = ls_Glosa.Split("|")
                If _cad.Count > 0 Then
                    _glosa = _cad(0)
                    _nrocuota = _cad(1)
                    _idusuarioaprueba = _cad(2)
                    _fechaaprueba = _cad(3)
                End If
            Else
                _glosa = ls_Glosa
                _nrocuota = 1
                _fechaaprueba = #1/1/1901#
                _idusuarioaprueba = "NINGUNO"
            End If
        End If
    End Sub

#End Region

#Region "Métodos"

    Public Overloads Function Equals(ByVal oeSancion As e_Sancion) As Boolean Implements IEquatable(Of ISL.EntidadesWCF.e_Sancion).Equals
        If Me.Id = oeSancion.Id Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Obtener(ByVal sancion As e_Sancion) As e_Sancion Implements Ie_Sancion.Obtener
        Return sancion
    End Function

#End Region

End Class

