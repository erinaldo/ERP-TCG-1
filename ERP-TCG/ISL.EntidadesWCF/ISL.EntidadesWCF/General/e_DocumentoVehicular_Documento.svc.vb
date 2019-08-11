' NOTA: si cambia aquí el nombre de clase "e_DocumentoVehicular_Documento", también debe actualizar la referencia a "e_DocumentoVehicular_Documento" tanto en Web.config como en el archivo .svc asociado.
<DataContract()> _
Public Class e_DocumentoVehicular_Documento
    Implements Ie_DocumentoVehicular_Documento
    Implements IEquatable(Of e_DocumentoVehicular_Documento)


#Region "Propiedad"
    Private _id As String
    Private _iddocumentovehicular As String
    Private _tipo As String
    Private _numero As String
    Private _fecha As Date
    Private _afectapoliza As Boolean
    Private _glosa As String
    Private _monto As Double
    Private _saldo As Double
    Private _activo As Boolean
    Private _aplica As Double

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public leDocVehDocPago As New List(Of e_DocVehDocPago)

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
   Public Property IdDocumentoVehicular() As String
        Get
            Return _iddocumentovehicular
        End Get
        Set(ByVal value As String)
            _iddocumentovehicular = value
        End Set
    End Property

    <DataMember()> _
   Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    <DataMember()> _
   Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    <DataMember()> _
   Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    <DataMember()> _
   Public Property AfectaPoliza() As Boolean
        Get
            Return _afectapoliza
        End Get
        Set(ByVal value As Boolean)
            _afectapoliza = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _glosa
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Saldo() As Double
        Get
            Return _saldo
        End Get
        Set(ByVal value As Double)
            _saldo = value
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
   Public Property Aplica() As Double
        Get
            Return _aplica
        End Get
        Set(ByVal value As Double)
            _aplica = value
        End Set
    End Property

#End Region


#Region "Constructor"
    Public Sub New()
        IdDocumentoVehicular = ""
        Tipo = ""
        Numero = ""
        Activo = True
        Aplica = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdDocumentoVehicular As String _
              , ByVal ls_Tipo As String _
              , ByVal ls_Numero As String _
              , ByVal ld_Fecha As Date _
              , ByVal lb_AfectaPoliza As Boolean _
              , ByVal ls_Glosa As String _
              , ByVal ld_Monto As Double _
              , ByVal ld_Saldo As Double _
              , ByVal lb_Activo As Boolean _
              , ByVal ld_aplia As Double _
              )

        _id = ls_Id
        _iddocumentovehicular = ls_IdDocumentoVehicular
        _tipo = ls_Tipo
        _numero = ls_Numero
        _fecha = ld_Fecha
        _afectapoliza = lb_AfectaPoliza
        _glosa = ls_Glosa
        _monto = ld_Monto
        _saldo = ld_Saldo
        _activo = lb_Activo
        _aplica = ld_aplia
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal DocumentoVehicular_Documento As e_DocumentoVehicular_Documento) As e_DocumentoVehicular_Documento Implements Ie_DocumentoVehicular_Documento.Obtener
        Return DocumentoVehicular_Documento
    End Function

    Public Overloads Function Equals(ByVal oeDVD As e_DocumentoVehicular_Documento) _
    As Boolean Implements IEquatable(Of e_DocumentoVehicular_Documento).Equals
        If Me.Numero = oeDVD.Numero Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region



End Class
