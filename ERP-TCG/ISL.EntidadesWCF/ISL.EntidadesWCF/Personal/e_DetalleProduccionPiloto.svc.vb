<DataContract()> _
Public Class e_DetalleProduccionPiloto
    Implements Ie_DetalleProduccionPiloto
    Implements IEquatable(Of e_DetalleProduccionPiloto)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idproduccionpiloto As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _indruta As Integer
    Private _ocupacion As String
    Private _diastrabajados As Integer
    Private _diasinduccion As Integer
    Private _renumeracion As Double
    Private _asignacionfamiliar As Double
    Private _descuentos As Double
    Private _ingresoneto As Double
    Private _produccion As Double
    Private _reintegro As Double
    Private _totalproduccion As Double
    Private _bonoproduccion As Double
    Private _listaporcentaje As String
    Private _totalponderado As Double
    Private _produccioncaja As Double
    Private _montoproduccion As Double
    Private _montosancion As Double
    Private _descuentosancion As Double
    Private _netobonoproduccion As Double
    Private _regularizacion As Double
    Private _totalcaja As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifca As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public Cuota As Double = 0
    <DataMember()> _
    Public indCalcular As Boolean = False
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
    Public Property IdProduccionPiloto() As String
        Get
            Return _idproduccionpiloto
        End Get
        Set(ByVal value As String)
            _idproduccionpiloto = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTrabajador() As String
        Get
            Return _idtrabajador
        End Get
        Set(ByVal value As String)
            _idtrabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property

    <DataMember()> _
    Public Property Trabajador() As String
        Get
            Return _trabajador
        End Get
        Set(ByVal value As String)
            _trabajador = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndRuta() As Integer
        Get
            Return _indruta
        End Get
        Set(ByVal value As Integer)
            _indruta = value
        End Set
    End Property

    <DataMember()> _
    Public Property Ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            _ocupacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasTrabajados() As Integer
        Get
            Return _diastrabajados
        End Get
        Set(ByVal value As Integer)
            _diastrabajados = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasInduccion() As Integer
        Get
            Return _diasinduccion
        End Get
        Set(ByVal value As Integer)
            _diasinduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Renumeracion() As Double
        Get
            Return _renumeracion
        End Get
        Set(ByVal value As Double)
            _renumeracion = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoFijo2() As Double
        Get
            Return _asignacionfamiliar
        End Get
        Set(ByVal value As Double)
            _asignacionfamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoFijo() As Double
        Get
            Return _descuentos
        End Get
        Set(ByVal value As Double)
            _descuentos = value
        End Set
    End Property

    <DataMember()> _
    Public Property IngresoNeto() As Double
        Get
            If indCalcular Then _ingresoneto = Renumeracion / 30 * (DiasTrabajados - DiasInduccion)
            Return _ingresoneto
        End Get
        Set(ByVal value As Double)
            _ingresoneto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Produccion() As Double
        Get
            Return _produccion
        End Get
        Set(ByVal value As Double)
            _produccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Reintegro() As Double
        Get
            Return _reintegro
        End Get
        Set(ByVal value As Double)
            _reintegro = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalProduccion() As Double
        Get
            If indCalcular Then _totalproduccion = Produccion + Reintegro + BonoFijo
            Return _totalproduccion
        End Get
        Set(ByVal value As Double)
            _totalproduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoProduccion() As Double
        Get
            If indCalcular AndAlso IndRuta = 0 AndAlso TotalProduccion >= IngresoNeto Then _bonoproduccion = TotalProduccion - IngresoNeto
            If indCalcular AndAlso IndRuta = 0 AndAlso TotalProduccion < IngresoNeto Then _bonoproduccion = 0
            If indCalcular AndAlso IndRuta = 1 Then _bonoproduccion = TotalProduccion
            Return _bonoproduccion
        End Get
        Set(ByVal value As Double)
            _bonoproduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property ListaPorcentaje() As String
        Get
            Return _listaporcentaje
        End Get
        Set(ByVal value As String)
            _listaporcentaje = value
        End Set
    End Property

    <DataMember()> _
Public Property TotalPonderado() As Double
        Get
            Return _totalponderado
        End Get
        Set(ByVal value As Double)
            _totalponderado = value
        End Set
    End Property

    <DataMember()> _
    Public Property ProduccionCaja() As Double
        Get
            If indCalcular Then
                Select Case IndRuta
                    Case 0
                        _produccioncaja = BonoProduccion * TotalPonderado / 100
                End Select
            End If
            Return _produccioncaja
        End Get
        Set(ByVal value As Double)
            _produccioncaja = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoProduccion() As Double
        Get
            If indCalcular Then _montoproduccion = BonoProduccion - ProduccionCaja
            Return _montoproduccion
        End Get
        Set(ByVal value As Double)
            _montoproduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property MontoSancion() As Double
        Get
            Return _montosancion
        End Get
        Set(ByVal value As Double)
            _montosancion = value
        End Set
    End Property

    <DataMember()> _
Public Property DescuentoSancion() As Double
        Get
            Return _descuentosancion
        End Get
        Set(ByVal value As Double)
            _descuentosancion = value
        End Set
    End Property

    <DataMember()> _
    Public Property NetoBonoProduccion() As Double
        Get
            If indCalcular Then _netobonoproduccion = MontoProduccion - DescuentoSancion
            Return _netobonoproduccion
        End Get
        Set(ByVal value As Double)
            _netobonoproduccion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Regularizacion() As Double
        Get
            Return _regularizacion
        End Get
        Set(ByVal value As Double)
            _regularizacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalCaja() As Double
        Get
            If indCalcular AndAlso IndRuta = 0 Then _totalcaja = ProduccionCaja + Regularizacion + BonoFijo2
            'If indCalcular AndAlso IndRuta <> 0 Then _totalcaja = ProduccionCaja + Regularizacion - DescuentoSancion
            Return _totalcaja
        End Get
        Set(ByVal value As Double)
            _totalcaja = value
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
    Public Property FechaModifca() As Date
        Get
            Return _fechamodifca
        End Get
        Set(ByVal value As Date)
            _fechamodifca = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioModifica() As String
        Get
            Return _usuariomodifica
        End Get
        Set(ByVal value As String)
            _usuariomodifica = value
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
        _idproduccionpiloto = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _ocupacion = String.Empty
        _indruta = -1
        _diastrabajados = 0
        _diasinduccion = 0
        _renumeracion = 0
        _asignacionfamiliar = 0
        _descuentos = 0
        _ingresoneto = 0
        _produccion = 0
        _reintegro = 0
        _totalproduccion = 0
        _bonoproduccion = 0
        _listaporcentaje = String.Empty
        _totalponderado = 0
        _produccioncaja = 0
        _montoproduccion = 0
        _montosancion = 0
        _descuentosancion = 0
        _netobonoproduccion = 0
        _regularizacion = 0
        _totalcaja = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifca = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdProduccionPiloto As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_Ocupacion As String _
              , ByVal ln_IndRuta As Integer _
              , ByVal ln_DiasTrabajados As Integer _
              , ByVal ln_DiasInduccion As Integer _
              , ByVal ln_Renumeracion As Double _
              , ByVal ln_AsignacionFamiliar As Double _
              , ByVal ln_Descuentos As Double _
              , ByVal ln_IngresoNeto As Double _
              , ByVal ln_Produccion As Double _
              , ByVal ln_Reintegro As Double _
              , ByVal ln_TotalProduccion As Double _
              , ByVal ln_BonoProduccion As Double _
              , ByVal ls_ListaPorcentaje As String _
              , ByVal ln_TotalPonderado As Double _
              , ByVal ln_ProduccionCaja As Double _
              , ByVal ln_MontoProduccion As Double _
              , ByVal ln_DescuentoSancion As Double _
              , ByVal ln_NetoBonoProduccion As Double _
              , ByVal ln_Regularizacion As Double _
              , ByVal ln_TotalCaja As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifca As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idproduccionpiloto = ls_IdProduccionPiloto
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _ocupacion = ls_Ocupacion
        _indruta = ln_IndRuta
        _diastrabajados = ln_DiasTrabajados
        _diasinduccion = ln_DiasInduccion
        _renumeracion = ln_Renumeracion
        _asignacionfamiliar = ln_AsignacionFamiliar
        _descuentos = ln_Descuentos
        _ingresoneto = ln_IngresoNeto
        _produccion = ln_Produccion
        _reintegro = ln_Reintegro
        _totalproduccion = ln_TotalProduccion
        _bonoproduccion = ln_BonoProduccion
        _listaporcentaje = ls_ListaPorcentaje
        _totalponderado = ln_TotalPonderado
        _produccioncaja = ln_ProduccionCaja
        _montoproduccion = ln_MontoProduccion
        _montosancion = 0
        _descuentosancion = ln_DescuentoSancion
        _netobonoproduccion = ln_NetoBonoProduccion
        _regularizacion = ln_Regularizacion
        _totalcaja = ln_TotalCaja
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifca = ld_FechaModifca
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As e_DetalleProduccionPiloto Implements Ie_DetalleProduccionPiloto.obtener
        Return oeDetalleProduccionPiloto
    End Function

    Public Overloads Function Equals(ByVal oeDPP As e_DetalleProduccionPiloto) As Boolean Implements System.IEquatable(Of e_DetalleProduccionPiloto).Equals

        Select Case oeDPP.Equivale
            Case 1 : If Me.IdTrabajador = oeDPP.IdTrabajador Then Return True
        End Select

        Return False
    End Function

#End Region

End Class
