﻿<DataContract()> _
Public Class e_Orden
    Implements Ie_Orden

#Region "Definicion Variables"

    Private _Id As String
    Private _NroOrden As String
    Private _idMoneda As String
    Private _Moneda As String
    Private _idTipoOrden As String
    Private _TipoOrden As String
    Private _idSubAlmacenOrigen As String
    Private _SubAlmacenOrigen As String
    Private _idSubAlmacenDestino As String
    Private _SubAlmacenDestino As String
    Private _FechaOrden As Date = #1/1/1901#
    Private _Total As Double
    Private _idEstadoOrden As String
    Private _EstadoOrden As String
    Private _subEstadoOrden As String
    Private _idMovimientoInventario As String
    Private _MovimientoInventario As String
    Private _TipoReferencia As String
    Private _Referencia As String
    Private _Activo As Boolean
    Private _NombreUsu As String
    Private _Glosa As String = String.Empty
    <DataMember()> _
    Public fechaFin As Date
    <DataMember()> _
    Public fechaInicio As Date
    Private _Centro As String
    Private _idProveedor As String
    Private _Proveedor As String
    Private _UsuarioCreacion As String
    Private _usuario As New e_Usuario

    '-- Orden Asociada --'
    Private _IdOrdenDocumento As String
    Private _IdDocumento As String
    Private _TipoDocumento As String
    Private _Serie_Numero As String
    <DataMember()> _
    Public TipoOperDocAsoc As String

    <DataMember()> _
    Public lstOrdenMaterial As New List(Of e_OrdenMaterial)
    <DataMember()> _
    Public lstInventario As New List(Of e_Inventario)
    '<DataMember()> _
    'Public lstRegistroInventario As New List(Of e_RegistroInventario)
    <DataMember()> _
    Public lstDetOrdenNeu As New List(Of e_DetalleOrdenNeumatico)
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public IdOrdenCompra As String = ""
    <DataMember()> _
    Public IndMaterialServicio As String = ""
    <DataMember()> _
    Public bandNeu As String = ""
    <DataMember()> _
    Public IdPeriodo As String = ""
    <DataMember()> _
    Public TipoCambio As Double = 0
    <DataMember()> _
    Public loAsientoModelo As New List(Of e_AsientoModelo)
    <DataMember()> _
    Public loCtaCtbleSFam As New List(Of e_CtaCtbleSubFamiliaMat)
    <DataMember()> _
    Public IndAsiento As Boolean = False

#End Region

#Region "Constructor"

    Sub New()
        TipoOperacion = ""
        Activo = True
        IndAsiento = False
        _EstadoOrden = ""
        _TipoReferencia = ""
        _Referencia = ""
        _Glosa = ""
        _Total = 0
    End Sub

    Sub New(ByVal Id As String, _
              ByVal NroOrden As String, _
              ByVal IdMoneda As String, _
              ByVal Moneda As String, _
              ByVal IdTipoOrden As String, _
              ByVal TipoOrden As String, _
              ByVal FechaOrden As Date, _
              ByVal Total As Double, _
              ByVal IdSubAlmacenOrigen As String, _
              ByVal SubAlmacenOrigen As String, _
              ByVal IdSubAlmacenDestino As String, _
              ByVal SubAlmacenDestino As String, _
              ByVal IdMovimientoInventario As String, _
              ByVal MovimientoInventario As String, _
              ByVal TipoReferencia As String, _
              ByVal Referencia As String, _
              ByVal IdCliente As String, _
              ByVal Glosa As String, _
              ByVal Activo As Boolean, _
              ByVal IdEstadoOrden As String, _
              ByVal EstadoOrden As String, _
              ByVal NombUsu As String, _
              ByVal UsuCreacion As String, _
              ByVal IdUsuEjecucion As String, _
              ByVal UsuEjecucion As String, _
              Optional ByVal ls_IdOrdenDocumento As String = "", _
              Optional ByVal ls_IdDocumento As String = "", _
              Optional ByVal ls_TipoDocumento As String = "", _
              Optional ByVal ls_SerieNumero As String = "", _
              Optional ByVal ls_NombreProveedor As String = ""  )
        _Id = Id
        _NroOrden = NroOrden
        _idMoneda = IdMoneda
        _Moneda = Moneda
        _idTipoOrden = IdTipoOrden
        _TipoOrden = TipoOrden
        _FechaOrden = FechaOrden
        _Total = Total
        _idSubAlmacenOrigen = IdSubAlmacenOrigen
        _SubAlmacenOrigen = SubAlmacenOrigen
        _idSubAlmacenDestino = IdSubAlmacenDestino
        _SubAlmacenDestino = SubAlmacenDestino
        _idMovimientoInventario = IdMovimientoInventario
        _MovimientoInventario = MovimientoInventario
        _TipoReferencia = TipoReferencia
        _Referencia = Referencia
        _Activo = Activo
        _idProveedor = IdCliente
        _idEstadoOrden = IdEstadoOrden
        _Glosa = Glosa
        _EstadoOrden = EstadoOrden
        _UsuarioCreacion = UsuCreacion
        _NombreUsu = NombUsu
        _usuario.Id = IdUsuEjecucion
        _usuario.Login = UsuEjecucion
        _IdOrdenDocumento = ls_IdOrdenDocumento
        _IdDocumento = ls_IdDocumento
        _TipoDocumento = ls_TipoDocumento
        _Serie_Numero = ls_SerieNumero
        _Proveedor = ls_NombreProveedor
    End Sub

#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property IdOrdenDocumento() As String
        Get
            Return _IdOrdenDocumento
        End Get
        Set(ByVal value As String)
            _IdOrdenDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdDocumento() As String
        Get
            Return _IdDocumento
        End Get
        Set(ByVal value As String)
            _IdDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdUsuarioEjecucion() As String
        Get
            Return _usuario.Id
        End Get
        Set(ByVal value As String)
            _usuario.Id = value
        End Set
    End Property

    <DataMember()> _
        Public Property UsuarioEjecucion() As String
        Get
            Return _usuario.Login
        End Get
        Set(ByVal value As String)
            _usuario.Login = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get
        Set(ByVal value As String)
            _TipoDocumento = value
        End Set
    End Property

    <DataMember()> _
    Public Property SerieNumero() As String
        Get
            Return _Serie_Numero
        End Get
        Set(ByVal value As String)
            _Serie_Numero = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreSubEstado() As String
        Get
            Return _subEstadoOrden
        End Get
        Set(ByVal value As String)
            _subEstadoOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdCentro() As String
        Get
            Return _Centro
        End Get
        Set(ByVal value As String)
            _Centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    <DataMember()> _
    Public Property NroOrden() As String
        Get
            Return _NroOrden
        End Get
        Set(ByVal value As String)
            _NroOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMoneda() As String
        Get
            Return _idMoneda
        End Get
        Set(ByVal value As String)
            _idMoneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property Moneda() As String
        Get
            Return _Moneda
        End Get
        Set(ByVal value As String)
            _Moneda = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdTipoOrden() As String
        Get
            Return _idTipoOrden
        End Get
        Set(ByVal value As String)
            _idTipoOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoOrden() As String
        Get
            Return _TipoOrden
        End Get
        Set(ByVal value As String)
            _TipoOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaOrden() As Date
        Get
            Return _FechaOrden
        End Get
        Set(ByVal value As Date)
            _FechaOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdMovimientoInventario() As String
        Get
            Return _idMovimientoInventario
        End Get
        Set(ByVal value As String)
            _idMovimientoInventario = value
        End Set
    End Property

    <DataMember()> _
    Public Property MovimientoInventario() As String
        Get
            Return _MovimientoInventario
        End Get
        Set(ByVal value As String)
            _MovimientoInventario = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubAlmacenOrigen() As String
        Get
            Return _SubAlmacenOrigen
        End Get
        Set(ByVal value As String)
            _SubAlmacenOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacenOrigen() As String
        Get
            Return _idSubAlmacenOrigen
        End Get
        Set(ByVal value As String)
            _idSubAlmacenOrigen = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdSubAlmacenDestino() As String
        Get
            Return _idSubAlmacenDestino
        End Get
        Set(ByVal value As String)
            _idSubAlmacenDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property SubAlmacenDestino() As String
        Get
            Return _SubAlmacenDestino
        End Get
        Set(ByVal value As String)
            _SubAlmacenDestino = value
        End Set
    End Property

    <DataMember()> _
    Public Property TipoReferencia() As String
        Get
            Return _TipoReferencia
        End Get
        Set(ByVal value As String)
            _TipoReferencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property Referencia() As String
        Get
            Return _Referencia
        End Get
        Set(ByVal value As String)
            _Referencia = value
        End Set
    End Property

    <DataMember()> _
    Public Property UsuarioCreacion() As String
        Get
            Return _UsuarioCreacion
        End Get
        Set(ByVal value As String)
            _UsuarioCreacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get
        Set(ByVal value As Boolean)
            _Activo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Glosa() As String
        Get
            Return _Glosa
        End Get
        Set(ByVal value As String)
            _Glosa = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdEstadoOrden() As String
        Get
            Return _idEstadoOrden
        End Get
        Set(ByVal value As String)
            _idEstadoOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property EstadoOrden() As String
        Get
            Return _EstadoOrden
        End Get
        Set(ByVal value As String)
            _EstadoOrden = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreProveedor() As String
        Get
            Return _Proveedor
        End Get
        Set(ByVal value As String)
            _Proveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdProveedor() As String
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As String)
            _idProveedor = value
        End Set
    End Property

    <DataMember()> _
    Public Property NombreUsuario() As String
        Get
            Return _NombreUsu
        End Get
        Set(ByVal value As String)
            _NombreUsu = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Obtener(ByVal orden As e_Orden) As e_Orden Implements Ie_Orden.Obtener
        Return orden
    End Function

#End Region
    
End Class