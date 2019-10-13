<DataContract()> _
Public Class e_LiquidacionTrabajador_Asiento
    Implements Ie_LiquidacionTrabajador_Asiento

#Region "Propiedad"

   Private _id As String
    Private _idliquidaciontrabajador As String
    Private _idasiento As String
    Private _tipo As String
    Private _activo As Boolean
    Private _fechacrea As Date
    Private _usuariocrea As String
    Public TipoOperacion As String
    Public Event DatoCambiado()
    <DataMember()>
    Public PrefijoID As String = ""
    <DataMember()>
    Public IdEmpresaSistema As String = ""
    <DataMember()>
    Public IdSucursalSistema As String = ""

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
    Public Property idliquidaciontrabajador() As String
        Get
            Return _idliquidaciontrabajador
        End Get
        Set(ByVal value As String)
            _idliquidaciontrabajador = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property idasiento() As String
        Get
            Return _idasiento
        End Get
        Set(ByVal value As String)
            _idasiento = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property usuariocrea() As String
        Get
            Return _usuariocrea
        End Get
        Set(ByVal value As String)
            _usuariocrea = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

    <DataMember()> _
    Public Property fechacrea() As Date
        Get
            Return _fechacrea
        End Get
        Set(ByVal value As Date)
            _fechacrea = value
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
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
            RaiseEvent DatoCambiado()
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        TipoOperacion = ""
        Id = ""
        Activo = True
        fechacrea = Date.Parse("01/01/1901")
        usuariocrea = ""
        Tipo = ""
        idliquidaciontrabajador = ""
        idasiento = ""
    End Sub

    Public Sub New(l_Id As String, l_idliquidaciontrabajador As String, l_idasiento As String, l_Tipo As String, l_Activo As Boolean)
        Id = l_Id
        Activo = l_Activo
        Tipo = l_Tipo
        idliquidaciontrabajador = l_idliquidaciontrabajador
        idasiento = l_idasiento
    End Sub

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal liquidaciontrabajador_asiento As e_LiquidacionTrabajador_Asiento) As e_LiquidacionTrabajador_Asiento Implements Ie_LiquidacionTrabajador_Asiento.Obtener
        Return liquidaciontrabajador_asiento
    End Function

#End Region

End Class
