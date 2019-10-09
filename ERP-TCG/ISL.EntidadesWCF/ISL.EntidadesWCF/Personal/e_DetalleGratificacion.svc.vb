<DataContract()> _
Public Class e_DetalleGratificacion
    Implements Ie_DetalleGratificacion
    Implements IEquatable(Of e_DetalleGratificacion)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idgratificacion As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _idcentro As String
    Private _centro As String
    Private _idarea As String
    Private _area As String
    Private _idocupacion As String
    Private _ocupacion As String
    Private _idcuentacorriente As String
    Private _cuentacorriente As String
    Private _datoapoyo As Double
    Private _indtipoaux As Integer
    Private _fechaingreso As Date
    Private _tempingreso As Double
    Private _sueldo As Double
    Private _asignacionfamiliar As Double
    Private _renumeracion As Double
    Private _horaextra1 As Double
    Private _horaextra2 As Double
    Private _horaextra3 As Double
    Private _horaextra4 As Double
    Private _horaextra5 As Double
    Private _horaextra6 As Double
    Private _indpromextra As Integer
    Private _promediohoraextra As Double
    Private _bono1 As Double
    Private _bono2 As Double
    Private _bono3 As Double
    Private _bono4 As Double
    Private _bono5 As Double
    Private _bono6 As Double
    Private _indpromedio As Integer
    Private _promediobono As Double
    Private _gratificacion As Double
    Private _fracciongrati As Double
    Private _renumeracioncomputable As Double
    Private _tiempolaborado As Double
    Private _diasfaltas As Integer
    Private _mesesfalta As Double
    Private _periodocomputable As Double
    Private _importe As Double
    Private _bonoextra As Double
    Private _total As Double
    Private _descuentosjudiciales As Double
    Private _adelantosueldo As Double
    Private _totaldescuento As Double
    Private _netototal As Double
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean
    Private _indpendiente As Integer

    <DataMember()> _
     Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public TempInicio As Double
    <DataMember()> _
    Public TempFin As Double
    <DataMember()> _
    Public FecInicio As Date
    <DataMember()> _
    Public FecFin As Date
    <DataMember()> _
    Public Periodo As Integer
    <DataMember()> _
    Public CantBono As Integer
    <DataMember()> _
    Public IndTipo As Integer = 0
    <DataMember()> _
    Public PorExt As Double
    <DataMember()> _
    Public Calcula As Integer = 0
    <DataMember()>
    Public Equivale As Integer = 0
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
    Public Property IdGratificacion() As String
        Get
            Return _idgratificacion
        End Get
        Set(ByVal value As String)
            _idgratificacion = value
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
    Public Property IdCentro() As String
        Get
            Return _idcentro
        End Get
        Set(ByVal value As String)
            _idcentro = value
        End Set
    End Property

    <DataMember()> _
    Public Property Centro() As String
        Get
            Return _centro
        End Get
        Set(ByVal value As String)
            _centro = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdArea() As String
        Get
            Return _idarea
        End Get
        Set(ByVal value As String)
            _idarea = value
        End Set
    End Property

    <DataMember()> _
    Public Property Area() As String
        Get
            Return _area
        End Get
        Set(ByVal value As String)
            _area = value
        End Set
    End Property

    <DataMember()> _
    Public Property IdOcupacion() As String
        Get
            Return _idocupacion
        End Get
        Set(ByVal value As String)
            _idocupacion = value
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
    Public Property IdCuentaCorriente() As String
        Get
            Return _idcuentacorriente
        End Get
        Set(ByVal value As String)
            _idcuentacorriente = value
        End Set
    End Property

    <DataMember()> _
    Public Property CuentaCorriente() As String
        Get
            Return _cuentacorriente
        End Get
        Set(ByVal value As String)
            _cuentacorriente = value
        End Set
    End Property

    <DataMember()> _
    Public Property DatoApoyo() As Double
        Get
            Return _datoapoyo
        End Get
        Set(ByVal value As Double)
            _datoapoyo = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndTipoAux() As Integer
        Get
            Return _indtipoaux
        End Get
        Set(ByVal value As Integer)
            _indtipoaux = value
        End Set
    End Property

    <DataMember()> _
    Public Property FechaIngreso() As Date
        Get
            Return _fechaingreso
        End Get
        Set(ByVal value As Date)
            _fechaingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property TempIngreso() As Double
        Get
            If Calcula = 1 Then _tempingreso = DateDiff(DateInterval.Day, #1/1/1900#, _fechaingreso)
            Return _tempingreso
        End Get
        Set(ByVal value As Double)
            _tempingreso = value
        End Set
    End Property

    <DataMember()> _
    Public Property Sueldo() As Double
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Double)
            _sueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property AsignacionFamiliar() As Double
        Get
            Return _asignacionfamiliar
        End Get
        Set(ByVal value As Double)
            _asignacionfamiliar = value
        End Set
    End Property

    <DataMember()> _
    Public Property Renumeracion() As Double
        Get
            If Calcula = 1 Then _renumeracion = Sueldo + AsignacionFamiliar
            Return _renumeracion
        End Get
        Set(ByVal value As Double)
            _renumeracion = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra1() As Double
        Get
            Return _horaextra1
        End Get
        Set(ByVal value As Double)
            _horaextra1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra2() As Double
        Get
            Return _horaextra2
        End Get
        Set(ByVal value As Double)
            _horaextra2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra3() As Double
        Get
            Return _horaextra3
        End Get
        Set(ByVal value As Double)
            _horaextra3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra4() As Double
        Get
            Return _horaextra4
        End Get
        Set(ByVal value As Double)
            _horaextra4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra5() As Double
        Get
            Return _horaextra5
        End Get
        Set(ByVal value As Double)
            _horaextra5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra6() As Double
        Get
            Return _horaextra6
        End Get
        Set(ByVal value As Double)
            _horaextra6 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPromExtra() As Integer
        Get
            Return _indpromextra
        End Get
        Set(ByVal value As Integer)
            _indpromextra = value
        End Set
    End Property

    <DataMember()> _
    Public Property PromedioHoraExtra() As Double
        Get
            If Calcula = 1 Then
                If IndPromExtra = 1 Then
                    _promediohoraextra = (HoraExtra1 + HoraExtra2 + HoraExtra3 + HoraExtra4 + HoraExtra5 + HoraExtra6) / 6
                Else
                    _promediohoraextra = 0
                End If
            End If
            Return _promediohoraextra
        End Get
        Set(ByVal value As Double)
            _promediohoraextra = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bono1() As Double
        Get
            Return _bono1
        End Get
        Set(ByVal value As Double)
            _bono1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bono2() As Double
        Get
            Return _bono2
        End Get
        Set(ByVal value As Double)
            _bono2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bono3() As Double
        Get
            Return _bono3
        End Get
        Set(ByVal value As Double)
            _bono3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bono4() As Double
        Get
            Return _bono4
        End Get
        Set(ByVal value As Double)
            _bono4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bono5() As Double
        Get
            Return _bono5
        End Get
        Set(ByVal value As Double)
            _bono5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Bono6() As Double
        Get
            Return _bono6
        End Get
        Set(ByVal value As Double)
            _bono6 = value
        End Set
    End Property

    <DataMember()> _
    Public Property IndPromedio() As Integer
        Get
            Return _indpromedio
        End Get
        Set(ByVal value As Integer)
            _indpromedio = value
        End Set
    End Property

    <DataMember()> _
    Public Property PromedioBono() As Double
        Get
            If Calcula = 1 Then
                If IndPromedio = 1 Then
                    _promediobono = (Bono1 + Bono2 + Bono3 + Bono4 + Bono5 + Bono6) / CantBono
                Else
                    _promediobono = 0
                End If
            End If
            Return _promediobono
        End Get
        Set(ByVal value As Double)
            _promediobono = value
        End Set
    End Property

    <DataMember()> _
    Public Property Gratificacion() As Double
        Get
            Return _gratificacion
        End Get
        Set(ByVal value As Double)
            _gratificacion = value
        End Set
    End Property

    <DataMember()> _
    Public Property FraccionGrati() As Double
        Get
            If Calcula = 1 Then _fracciongrati = Gratificacion / 6
            Return _fracciongrati
        End Get
        Set(ByVal value As Double)
            _fracciongrati = value
        End Set
    End Property

    <DataMember()> _
    Public Property RenumeracionComputable() As Double
        Get
            If Calcula = 1 Then _renumeracioncomputable = Renumeracion + PromedioHoraExtra + PromedioBono + FraccionGrati
            Return _renumeracioncomputable
        End Get
        Set(ByVal value As Double)
            _renumeracioncomputable = value
        End Set
    End Property

    <DataMember()> _
    Public Property TiempoLaborado() As Double
        Get
            Dim _nromes As Integer = 0, _pro As Double = 0, _cantdiv As Double = 0
            Dim _cant As Integer = 0, _cantfin As Integer = 0, _cantdif As Integer = 0
            Dim _fec As Date = #1/1/1901#
            If Calcula = 1 Then
                If TempIngreso <= TempInicio Then
                    _cantdif = IIf(Month(FecFin) = 12, 0, 1)
                    If Year(FechaIngreso) = Periodo And Month(FechaIngreso) = (Month(FecInicio) - _cantdif) Then
                        _nromes = Month(FechaIngreso)
                        If _nromes = 1 Or _nromes = 3 Or _nromes = 5 Or _nromes = 7 Or _nromes = 8 Or _nromes = 10 Or _nromes = 12 Then _cant = -1
                        If _nromes = 2 Then _cant = ObtieneDif2()
                        If Day(FechaIngreso) = 1 Then
                            _pro = 0
                        Else
                            _fec = gf_InicioFinMes("F", Periodo, Month(FechaIngreso))
                            If Day(FechaIngreso) = Day(_fec) Then
                                _pro = (30 - (Day(FechaIngreso) + _cant)) / 30
                            Else
                                _pro = (30 - Day(FechaIngreso) + 1) / 30
                            End If

                        End If
                        _tiempolaborado = 6 + _pro
                    Else
                        _tiempolaborado = 6
                    End If
                Else
                    _cantdiv = IIf(Month(FecFin) = 12, 29.5, 30)
                    _nromes = Month(FechaIngreso)
                    If _nromes = 1 Or _nromes = 3 Or _nromes = 5 Or _nromes = 7 Or _nromes = 8 Or _nromes = 10 Or _nromes = 12 Then
                        _cant = -1 : _cantfin = IIf(Month(FecFin) = 12, 0, 1)
                    End If
                    If _nromes = 2 Then _cant = ObtieneDif2()
                    If Day(FechaIngreso) = 1 Then
                        _pro = 1
                    Else
                        _fec = gf_InicioFinMes("F", Periodo, Month(FechaIngreso))
                        If Day(FechaIngreso) = Day(_fec) Then
                            _pro = (30 - (Day(FechaIngreso) + _cant)) / _cantdiv
                        Else
                            _pro = (30 - Day(FechaIngreso) + 1 + _cantfin) / _cantdiv
                        End If
                    End If
                    _tiempolaborado = ObtieneDif(Month(FechaIngreso)) + _pro
                End If
            End If
            Return _tiempolaborado
        End Get
        Set(ByVal value As Double)
            _tiempolaborado = value
        End Set
    End Property

    <DataMember()> _
    Public Property DiasFaltas() As Integer
        Get
            Return _diasfaltas
        End Get
        Set(ByVal value As Integer)
            _diasfaltas = value
        End Set
    End Property

    <DataMember()> _
    Public Property MesesFalta() As Double
        Get
            If Calcula = 1 Then _mesesfalta = DiasFaltas / 30
            Return _mesesfalta
        End Get
        Set(ByVal value As Double)
            _mesesfalta = value
        End Set
    End Property

    <DataMember()> _
    Public Property PeriodoComputable() As Double
        Get
            If Calcula = 1 Then _periodocomputable = TiempoLaborado - MesesFalta
            Return _periodocomputable
        End Get
        Set(ByVal value As Double)
            _periodocomputable = value
        End Set
    End Property

    <DataMember()> _
    Public Property Importe() As Double
        Get
            If Calcula = 1 Then
                If IndTipo = 1 Then _importe = RenumeracionComputable / 6 * PeriodoComputable
                'If IndTipo = 2 Then _importe = 0
            End If
            Return _importe
        End Get
        Set(ByVal value As Double)
            _importe = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoExtra() As Double
        Get
            If Calcula = 1 Then
                If IndTipo = 1 Then _bonoextra = Importe * PorExt
                If IndTipo = 2 Then _bonoextra = 0
            End If
            Return _bonoextra
        End Get
        Set(ByVal value As Double)
            _bonoextra = value
        End Set
    End Property

    <DataMember()> _
    Public Property Total() As Double
        Get
            If Calcula = 1 Then
                If IndTipo = 1 Then _total = Importe + BonoExtra + DatoApoyo
                If IndTipo = 2 Then _total = (RenumeracionComputable / 12 * PeriodoComputable)
            End If
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    <DataMember()> _
    Public Property DescuentosJudiciales() As Double
        Get
            Return _descuentosjudiciales
        End Get
        Set(ByVal value As Double)
            _descuentosjudiciales = value
        End Set
    End Property

    <DataMember()> _
    Public Property AdelantoSueldo() As Double
        Get
            Return _adelantosueldo
        End Get
        Set(ByVal value As Double)
            _adelantosueldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalDescuento() As Double
        Get
            If Calcula = 1 Then _totaldescuento = AdelantoSueldo + DescuentosJudiciales
            Return _totaldescuento
        End Get
        Set(ByVal value As Double)
            _totaldescuento = value
        End Set
    End Property

    <DataMember()> _
    Public Property NetoTotal() As Double
        Get
            If Calcula = 1 Then
                If IndTipo = 1 Then _netototal = Total - TotalDescuento
                If IndTipo = 2 Then _netototal = Total - TotalDescuento + Importe
            End If
            Return _netototal
        End Get
        Set(ByVal value As Double)
            _netototal = value
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
    Public Property FechaModifica() As Date
        Get
            Return _fechamodifica
        End Get
        Set(ByVal value As Date)
            _fechamodifica = value
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

    <DataMember()> _
    Public Property IndPendiente() As Integer
        Get
            Return _indpendiente
        End Get
        Set(ByVal value As Integer)
            _indpendiente = value
        End Set
    End Property

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idgratificacion = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _idcentro = String.Empty
        _centro = String.Empty
        _idarea = String.Empty
        _area = String.Empty
        _idocupacion = String.Empty
        _ocupacion = String.Empty
        _idcuentacorriente = String.Empty
        _cuentacorriente = String.Empty
        _datoapoyo = 0
        _indtipoaux = 0
        _fechaingreso = #1/1/1901#
        _tempingreso = 0
        _sueldo = 0
        _asignacionfamiliar = 0
        _renumeracion = 0
        _horaextra1 = 0
        _horaextra2 = 0
        _horaextra3 = 0
        _horaextra4 = 0
        _horaextra5 = 0
        _horaextra6 = 0
        _indpromextra = 0
        _promediohoraextra = 0
        _bono1 = 0
        _bono2 = 0
        _bono3 = 0
        _bono4 = 0
        _bono5 = 0
        _bono6 = 0
        _indpromedio = 0
        _promediobono = 0
        _gratificacion = 0
        _fracciongrati = 0
        _renumeracioncomputable = 0
        _tiempolaborado = 0
        _diasfaltas = 0
        _mesesfalta = 0
        _periodocomputable = 0
        _importe = 0
        _bonoextra = 0
        _total = 0
        _descuentosjudiciales = 0
        _adelantosueldo = 0
        _totaldescuento = 0
        _netototal = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
        _indpendiente = 0
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdGratificacion As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ls_IdCentro As String _
              , ByVal ls_Centro As String _
              , ByVal ls_IdArea As String _
              , ByVal ls_Area As String _
              , ByVal ls_IdOcupacion As String _
              , ByVal ls_Ocupacion As String _
              , ByVal ls_IdCuentaCorriente As String _
              , ByVal ls_CuentaCorriente As String _
              , ByVal ln_DatoApoyo As Double _
              , ByVal ln_IndTipoAux As Integer _
              , ByVal ld_FechaIngreso As Date _
              , ByVal ln_TempIngreso As Double _
              , ByVal ln_Sueldo As Double _
              , ByVal ln_AsignacionFamiliar As Double _
              , ByVal ln_Renumeracion As Double _
              , ByVal ln_HoraExtra1 As Double _
              , ByVal ln_HoraExtra2 As Double _
              , ByVal ln_HoraExtra3 As Double _
              , ByVal ln_HoraExtra4 As Double _
              , ByVal ln_HoraExtra5 As Double _
              , ByVal ln_HoraExtra6 As Double _
              , ByVal ln_IndPromExtra As Integer _
              , ByVal ln_PromedioHoraExtra As Double _
              , ByVal ln_Bono1 As Double _
              , ByVal ln_Bono2 As Double _
              , ByVal ln_Bono3 As Double _
              , ByVal ln_Bono4 As Double _
              , ByVal ln_Bono5 As Double _
              , ByVal ln_Bono6 As Double _
              , ByVal ln_IndPromedio As Integer _
              , ByVal ln_PromedioBono As Double _
              , ByVal ln_Gratificacion As Double _
              , ByVal ln_FraccionGrati As Double _
              , ByVal ln_RenumeracionComputable As Double _
              , ByVal ln_TiempoLaborado As Double _
              , ByVal ln_DiasFaltas As Integer _
              , ByVal ln_MesesFalta As Double _
              , ByVal ln_PeriodoComputable As Double _
              , ByVal ln_Importe As Double _
              , ByVal ln_BonoExtra As Double _
              , ByVal ln_Total As Double _
              , ByVal ln_DescuentosJudiciales As Double _
              , ByVal ln_AdelantoSueldo As Double _
              , ByVal ln_TotalDescuento As Double _
              , ByVal ln_NetoTotal As Double _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
              , ByVal ln_IndPendiente As Integer _
           )
        Calcula = 0
        _id = ls_Id
        _idgratificacion = ls_IdGratificacion
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _idcentro = ls_IdCentro
        _centro = ls_Centro
        _idarea = ls_IdArea
        _area = ls_Area
        _idocupacion = ls_IdOcupacion
        _ocupacion = ls_Ocupacion
        _idcuentacorriente = ls_IdCuentaCorriente
        _cuentacorriente = ls_CuentaCorriente
        _datoapoyo = ln_DatoApoyo
        _indtipoaux = ln_IndTipoAux
        _fechaingreso = ld_FechaIngreso
        _tempingreso = ln_TempIngreso
        _sueldo = ln_Sueldo
        _asignacionfamiliar = ln_AsignacionFamiliar
        _renumeracion = ln_Renumeracion
        _horaextra1 = ln_HoraExtra1
        _horaextra2 = ln_HoraExtra2
        _horaextra3 = ln_HoraExtra3
        _horaextra4 = ln_HoraExtra4
        _horaextra5 = ln_HoraExtra5
        _horaextra6 = ln_HoraExtra6
        _indpromextra = ln_IndPromExtra
        _promediohoraextra = ln_PromedioHoraExtra
        _bono1 = ln_Bono1
        _bono2 = ln_Bono2
        _bono3 = ln_Bono3
        _bono4 = ln_Bono4
        _bono5 = ln_Bono5
        _bono6 = ln_Bono6
        _indpromedio = ln_IndPromedio
        _promediobono = ln_PromedioBono
        _gratificacion = ln_Gratificacion
        _fracciongrati = ln_FraccionGrati
        _renumeracioncomputable = ln_RenumeracionComputable
        _tiempolaborado = ln_TiempoLaborado
        _diasfaltas = ln_DiasFaltas
        _mesesfalta = ln_MesesFalta
        _periodocomputable = ln_PeriodoComputable
        _importe = ln_Importe
        _bonoextra = ln_BonoExtra
        _total = ln_Total
        _descuentosjudiciales = ln_DescuentosJudiciales
        _adelantosueldo = ln_AdelantoSueldo
        _totaldescuento = ln_TotalDescuento
        _netototal = ln_NetoTotal
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
        _indpendiente = ln_IndPendiente
    End Sub

#End Region

#Region "Metodos"

    Public Function obtener(oeDetalleGratificacion As e_DetalleGratificacion) As e_DetalleGratificacion Implements Ie_DetalleGratificacion.obtener
        Return oeDetalleGratificacion
    End Function

    Public Overloads Function Equals(ByVal oeDBC As e_DetalleGratificacion) As Boolean Implements System.IEquatable(Of e_DetalleGratificacion).Equals
        Select Case oeDBC.Equivale
            Case 0 : If Me.Id = oeDBC.Id Then Return True
            Case 1 : If Me.IdTrabajador = oeDBC.IdTrabajador Then Return True
        End Select
        Return False
    End Function

    Private Function ObtieneDif(ln_MesIngreso As Integer) As Integer
        Dim _valor As Integer = 0, i As Integer = 0, _aux As Integer = 0
        If Year(FechaIngreso) = Periodo Then
            For i = (ln_MesIngreso + 1) To Month(FecFin)
                _aux = _aux + 1
            Next
        End If
        If Year(FechaIngreso) = (Periodo - 1) Then
            For i = (ln_MesIngreso + 1) To 12
                _aux = _aux + 1
            Next
            For i = 1 To Month(FecFin)
                _aux = _aux + 1
            Next
        End If
        'If Year(FechaIngreso) = (Periodo - 1) Then
        '    _aux = 1
        '    For i = 1 To Month(FecFin)
        '        If i = 1 Or i = 3 Or i = 5 Or i = 7 Or i = 8 Or i = 10 Or i = 12 Then _aux = _aux + 1
        '    Next
        'End If
        _valor = _aux
        Return _valor
    End Function

    Private Function ObtieneDif2() As Integer
        Dim _valor As Integer = 0
        Dim _fecaux As Date = #1/1/1901#
        _fecaux = gf_InicioFinMes("F", Year(FecFin), 2)
        _valor = 30 - Day(_fecaux)
        Return _valor
    End Function

    Private Function gf_InicioFinMes(ByVal ls_Tipo As String, ByVal ln_Anio As Integer, ByVal ln_Mes As Integer) As String
        Dim ld_Fecha As Date = Now.Date
        If ls_Tipo = "P" Then
            ld_Fecha = Date.Parse("01/" & ln_Mes.ToString & "/" & ln_Anio.ToString)
        Else
            ld_Fecha = DateSerial(ln_Anio, ln_Mes + 1, 0)
        End If
        Return ld_Fecha
    End Function

#End Region

End Class
