<DataContract()> _
Public Class e_DetalleRentaQuinta
    Implements Ie_DetalleRentaQuinta
    Implements IEquatable(Of e_DetalleRentaQuinta)

#Region "Declaracion de Variables"

    Private _id As String
    Private _idretencionquinta As String
    Private _idtrabajador As String
    Private _dni As String
    Private _trabajador As String
    Private _sueldo As Double
    Private _asignacionfamiliar As Double
    Private _renumeracion As Double
    Private _basico1 As Double
    Private _basico2 As Double
    Private _basico3 As Double
    Private _basico4 As Double
    Private _basico5 As Double
    Private _basico6 As Double
    Private _basico7 As Double
    Private _basico8 As Double
    Private _basico9 As Double
    Private _basico10 As Double
    Private _basico11 As Double
    Private _basico12 As Double
    Private _utilidad As Double
    Private _basicog1 As Double
    Private _totalbasico As Double
    Private _bonoextg1 As Double
    Private _bono1 As Double
    Private _bono2 As Double
    Private _bono3 As Double
    Private _bono4 As Double
    Private _bono5 As Double
    Private _bono6 As Double
    Private _bono7 As Double
    Private _bono8 As Double
    Private _bono9 As Double
    Private _bono10 As Double
    Private _bono11 As Double
    Private _bono12 As Double

    Private _bono13 As Double
    Private _bono14 As Double
    Private _bono15 As Double
    Private _bono16 As Double
    Private _bono17 As Double
    Private _bono18 As Double
    Private _bono19 As Double
    Private _bono20 As Double
    Private _bono21 As Double
    

    Private _totalbono As Double
    Private _basicopendiente As Double
    Private _bonopendiente As Double
    Private _basicog2 As Double
    Private _bonoextg2 As Double
    Private _rentabrutaanual As Double
    Private _deduccioniut As Double
    Private _rango1 As Double
    Private _rango2 As Double
    Private _rango3 As Double
    Private _rango4 As Double
    Private _rango5 As Double
    Private _rentanetaanual As Double
    Private _tiporetencion As Integer
    Private _impuestoanual As Double
    Private _retencion1 As Double
    Private _retencion2 As Double
    Private _retencion3 As Double
    Private _retencion4 As Double
    Private _retencion5 As Double
    Private _retencion6 As Double
    Private _retencion7 As Double
    Private _retencion8 As Double
    Private _retencion9 As Double
    Private _retencion10 As Double
    Private _retencion11 As Double
    Private _retencion12 As Double
    Private _totalretencion As Double
    Private _rentasaldo As Double
    Private _monto As Double
    Private _operacion As Integer
    Private _fechacreacion As Date
    Private _usuariocreacion As String
    Private _fechamodifica As Date
    Private _usuariomodifica As String
    Private _activo As Boolean

    <DataMember()> _
    Public TipoOperacion As String
    <DataMember()> _
    Public Modificado As Boolean
    <DataMember()> _
    Public NroMes As Integer = 0
    <DataMember()> _
    Public MontoUIT27 As Double = 0
    <DataMember()> _
    Public PorcSeg As Double = 0
    <DataMember()> _
    Public IndRenta As Boolean = False
    <DataMember()> _
    Public Calcular As Boolean = False
    <DataMember()> _
    Public Equivale As Integer
    <DataMember()> _
    Public PorcRango1 As Double = 0
    <DataMember()> _
    Public PorcRango2 As Double = 0
    <DataMember()> _
    Public PorcRango3 As Double = 0
    <DataMember()> _
    Public PorcRango4 As Double = 0
    <DataMember()> _
    Public PorcRango5 As Double = 0
    <DataMember()> _
    Public UITRango1 As Double = 0
    <DataMember()> _
    Public UITRango2 As Double = 0
    <DataMember()> _
    Public UITRango3 As Double = 0
    <DataMember()> _
    Public UITRango4 As Double = 0

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
    Public Property IdRetencionQuinta() As String
        Get
            Return _idretencionquinta
        End Get
        Set(ByVal value As String)
            _idretencionquinta = value
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
            If Calcular Then
                _renumeracion = Sueldo + AsignacionFamiliar + HoraExtra25 + HoraExtra35 + Movilidad + BonoProduccion + RenumeracionVacacional + CompensacionVacacional + BonoResponsabilidad + DescansoMedico + _
                    VueltaAdicionalPiura + BonoCombustiblePiura + BonoJefeConvoy + VueltaAdicionalLima + Otros + VueltaCaliza + HorasNocturnas + Semaforo + OtroInafecto
            End If
            Return _renumeracion
        End Get
        Set(ByVal value As Double)
            _renumeracion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico1() As Double
        Get
            Return _basico1
        End Get
        Set(ByVal value As Double)
            _basico1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico2() As Double
        Get
            Return _basico2
        End Get
        Set(ByVal value As Double)
            _basico2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico3() As Double
        Get
            Return _basico3
        End Get
        Set(ByVal value As Double)
            _basico3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico4() As Double
        Get
            Return _basico4
        End Get
        Set(ByVal value As Double)
            _basico4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico5() As Double
        Get
            Return _basico5
        End Get
        Set(ByVal value As Double)
            _basico5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico6() As Double
        Get
            Return _basico6
        End Get
        Set(ByVal value As Double)
            _basico6 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico7() As Double
        Get
            Return _basico7
        End Get
        Set(ByVal value As Double)
            _basico7 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico8() As Double
        Get
            Return _basico8
        End Get
        Set(ByVal value As Double)
            _basico8 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico9() As Double
        Get
            Return _basico9
        End Get
        Set(ByVal value As Double)
            _basico9 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico10() As Double
        Get
            Return _basico10
        End Get
        Set(ByVal value As Double)
            _basico10 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico11() As Double
        Get
            Return _basico11
        End Get
        Set(ByVal value As Double)
            _basico11 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Basico12() As Double
        Get
            Return _basico12
        End Get
        Set(ByVal value As Double)
            _basico12 = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalBasico() As Double
        Get
            _totalbasico = Basico1 + Basico2 + Basico3 + Basico4 + Basico5 + Basico6 + Basico7 + Basico8 + Basico9 + Basico10 + Basico11 + Basico12
            Return _totalbasico
        End Get
        Set(ByVal value As Double)
            _totalbasico = value
        End Set
    End Property

    <DataMember()> _
    Public Property Utilidad() As Double
        Get
            Return _utilidad
        End Get
        Set(ByVal value As Double)
            _utilidad = value
        End Set
    End Property

    <DataMember()> _
    Public Property BasicoG1() As Double
        Get
            Return _basicog1
        End Get
        Set(ByVal value As Double)
            _basicog1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoExtG1() As Double
        Get
            If Calcular And NroMes < 7 Then _bonoextg1 = BasicoG1 * PorcSeg / 100
            Return _bonoextg1
        End Get
        Set(ByVal value As Double)
            _bonoextg1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra25() As Double
        Get
            Return _bono1
        End Get
        Set(ByVal value As Double)
            _bono1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property HoraExtra35() As Double
        Get
            Return _bono2
        End Get
        Set(ByVal value As Double)
            _bono2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Movilidad() As Double
        Get
            Return _bono3
        End Get
        Set(ByVal value As Double)
            _bono3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoProduccion() As Double
        Get
            Return _bono4
        End Get
        Set(ByVal value As Double)
            _bono4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property RenumeracionVacacional() As Double
        Get
            Return _bono5
        End Get
        Set(ByVal value As Double)
            _bono5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property CompensacionVacacional() As Double
        Get
            Return _bono6
        End Get
        Set(ByVal value As Double)
            _bono6 = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoResponsabilidad() As Double
        Get
            Return _bono7
        End Get
        Set(ByVal value As Double)
            _bono7 = value
        End Set
    End Property

    <DataMember()> _
    Public Property DescansoMedico() As Double
        Get
            Return _bono8
        End Get
        Set(ByVal value As Double)
            _bono8 = value
        End Set
    End Property

    <DataMember()> _
    Public Property VueltaAdicionalPiura() As Double
        Get
            Return _bono13
        End Get
        Set(ByVal value As Double)
            _bono13 = value
        End Set
    End Property
    <DataMember()> _
    Public Property BonoCombustiblePiura() As Double
        Get
            Return _bono14
        End Get
        Set(ByVal value As Double)
            _bono14 = value
        End Set
    End Property
    <DataMember()> _
    Public Property BonoJefeConvoy() As Double
        Get
            Return _bono15
        End Get
        Set(ByVal value As Double)
            _bono15 = value
        End Set
    End Property
    <DataMember()> _
    Public Property VueltaAdicionalLima() As Double
        Get
            Return _bono16
        End Get
        Set(ByVal value As Double)
            _bono16 = value
        End Set
    End Property
    <DataMember()> _
    Public Property Otros() As Double
        Get
            Return _bono17
        End Get
        Set(ByVal value As Double)
            _bono17 = value
        End Set
    End Property
    <DataMember()> _
    Public Property VueltaCaliza() As Double
        Get
            Return _bono18
        End Get
        Set(ByVal value As Double)
            _bono18 = value
        End Set
    End Property
    
    <DataMember()> _
    Public Property HorasNocturnas() As Double
        Get
            Return _bono19
        End Get
        Set(ByVal value As Double)
            _bono19 = value
        End Set
    End Property
    
    <DataMember()> _
    Public Property Semaforo() As Double
        Get
            Return _bono20
        End Get
        Set(ByVal value As Double)
            _bono20 = value
        End Set
    End Property

    <DataMember()> _
    Public Property OtroInafecto() As Double
        Get
            Return _bono21
        End Get
        Set(ByVal value As Double)
            _bono21 = value
        End Set
    End Property

    <DataMember()> _
    Public Property RentaNeta27IUT2() As Double
        Get
            'If Calcular Then
            '    If RentaNetaAnual > 0 Then _bono9 = IIf(RentaNetaAnual > MontoUIT27, MontoUIT27, RentaNetaAnual)
            'End If
            Return _bono9
        End Get
        Set(ByVal value As Double)
            _bono9 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Diferencia() As Double
        Get
            'If Calcular Then
            '    _bono10 = RentaNetaAnual - RentaNeta27IUT2
            'End If
            Return _bono10
        End Get
        Set(ByVal value As Double)
            _bono10 = value
        End Set
    End Property

    <DataMember()> _
    Public Property RentaQuinta15() As Double
        Get
            'If Calcular Then
            '    _bono11 = RentaNeta27IUT2 * 0.15
            'End If
            Return _bono11
        End Get
        Set(ByVal value As Double)
            _bono11 = value
        End Set
    End Property

    <DataMember()> _
    Public Property RentaQuinta21() As Double
        Get
            'If Calcular Then
            '    _bono12 = Diferencia * 0.21
            'End If
            Return _bono12
        End Get
        Set(ByVal value As Double)
            _bono12 = value
        End Set
    End Property

    <DataMember()> _
    Public Property SueldoContratado() As Double
        Get
            Return _totalbono
        End Get
        Set(ByVal value As Double)
            _totalbono = value
        End Set
    End Property

    <DataMember()> _
    Public Property BasicoPendiente() As Double
        Get
            Return _basicopendiente
        End Get
        Set(ByVal value As Double)
            _basicopendiente = value
        End Set
    End Property

    <DataMember()> _
    Public Property Adicional() As Double
        Get
            Return _bonopendiente
        End Get
        Set(ByVal value As Double)
            _bonopendiente = value
        End Set
    End Property

    <DataMember()> _
    Public Property BasicoG2() As Double
        Get
            Return _basicog2
        End Get
        Set(ByVal value As Double)
            _basicog2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property BonoExtG2() As Double
        Get
            If Calcular And NroMes < 12 Then _bonoextg2 = BasicoG2 * PorcSeg / 100
            Return _bonoextg2
        End Get
        Set(ByVal value As Double)
            _bonoextg2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property RentaBrutaAnual() As Double
        Get
            If Calcular Then _rentabrutaanual = TotalBasico + BasicoPendiente + Utilidad + BasicoG1 + BonoExtG1 + BasicoG2 + BonoExtG2 + Adicional
            Return _rentabrutaanual
        End Get
        Set(ByVal value As Double)
            _rentabrutaanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property DeduccionIUT() As Double
        Get
            Return _deduccioniut
        End Get
        Set(ByVal value As Double)
            _deduccioniut = value
        End Set
    End Property

    <DataMember()> _
    Public Property RentaNetaAnual() As Double
        Get
            If Calcular Then
                If RentaBrutaAnual > DeduccionIUT Then _rentanetaanual = RentaBrutaAnual - DeduccionIUT
            End If
            Return _rentanetaanual
        End Get
        Set(ByVal value As Double)
            _rentanetaanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Administrativo() As Integer
        Get
            Return _tiporetencion
        End Get
        Set(ByVal value As Integer)
            _tiporetencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property Rango1() As Double
        Get
            If Calcular Then
                If RentaNetaAnual > 0 Then
                    If RentaNetaAnual <= UITRango1 Then
                        _rango1 = RentaNetaAnual * PorcRango1
                    Else
                        _rango1 = UITRango1 * PorcRango1
                    End If
                End If
            End If
            Return _rango1
        End Get
        Set(ByVal value As Double)
            _rango1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Rango2() As Double
        Get
            If Calcular Then
                If (RentaNetaAnual - UITRango1) > 0 Then
                    If RentaNetaAnual > UITRango1 And RentaNetaAnual <= UITRango2 Then
                        _rango2 = (RentaNetaAnual - UITRango1) * PorcRango2
                    Else
                        _rango2 = (UITRango2 - UITRango1) * PorcRango2
                    End If
                End If
            End If
            Return _rango2
        End Get
        Set(ByVal value As Double)
            _rango2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Rango3() As Double
        Get
            If Calcular Then
                If (RentaNetaAnual - UITRango2) > 0 Then
                    If RentaNetaAnual > UITRango2 And RentaNetaAnual <= UITRango3 Then
                        _rango3 = (RentaNetaAnual - UITRango2) * PorcRango3
                    Else
                        _rango3 = (UITRango3 - UITRango2) * PorcRango3
                    End If
                End If
            End If
            Return _rango3
        End Get
        Set(ByVal value As Double)
            _rango3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Rango4() As Double
        Get
            If Calcular Then
                If (RentaNetaAnual - UITRango3) > 0 Then
                    If RentaNetaAnual > UITRango3 And RentaNetaAnual <= UITRango4 Then
                        _rango4 = (RentaNetaAnual - UITRango3) * PorcRango4
                    Else
                        _rango4 = (UITRango4 - UITRango3) * PorcRango4
                    End If
                End If
            End If
            Return _rango4
        End Get
        Set(ByVal value As Double)
            _rango4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Rango5() As Double
        Get
            Return _rango5
        End Get
        Set(ByVal value As Double)
            _rango5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property ImpuestoAnual() As Double
        Get
            If Calcular Then _impuestoanual = Rango1 + Rango2 + Rango3 + Rango4 + Rango5
            Return _impuestoanual
        End Get
        Set(ByVal value As Double)
            _impuestoanual = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion1() As Double
        Get
            Return _retencion1
        End Get
        Set(ByVal value As Double)
            _retencion1 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion2() As Double
        Get
            Return _retencion2
        End Get
        Set(ByVal value As Double)
            _retencion2 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion3() As Double
        Get
            Return _retencion3
        End Get
        Set(ByVal value As Double)
            _retencion3 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion4() As Double
        Get
            Return _retencion4
        End Get
        Set(ByVal value As Double)
            _retencion4 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion5() As Double
        Get
            Return _retencion5
        End Get
        Set(ByVal value As Double)
            _retencion5 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion6() As Double
        Get
            Return _retencion6
        End Get
        Set(ByVal value As Double)
            _retencion6 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion7() As Double
        Get
            Return _retencion7
        End Get
        Set(ByVal value As Double)
            _retencion7 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion8() As Double
        Get
            Return _retencion8
        End Get
        Set(ByVal value As Double)
            _retencion8 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion9() As Double
        Get
            Return _retencion9
        End Get
        Set(ByVal value As Double)
            _retencion9 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion10() As Double
        Get
            Return _retencion10
        End Get
        Set(ByVal value As Double)
            _retencion10 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion11() As Double
        Get
            Return _retencion11
        End Get
        Set(ByVal value As Double)
            _retencion11 = value
        End Set
    End Property

    <DataMember()> _
    Public Property Retencion12() As Double
        Get
            Return _retencion12
        End Get
        Set(ByVal value As Double)
            _retencion12 = value
        End Set
    End Property

    <DataMember()> _
    Public Property TotalRetencion() As Double
        Get
            If Calcular Then _totalretencion = Retencion1 + Retencion2 + Retencion3 + Retencion4 + Retencion5 + Retencion6 + Retencion7 + Retencion8 + Retencion9 + Retencion10 + Retencion11 + Retencion12
            Return _totalretencion
        End Get
        Set(ByVal value As Double)
            _totalretencion = value
        End Set
    End Property

    <DataMember()> _
    Public Property RentaSaldo() As Double
        Get
            If Calcular Then
                If TotalRetencion < ImpuestoAnual Then
                    _rentasaldo = ImpuestoAnual - TotalRetencion
                Else
                    _rentasaldo = 0
                End If
            End If
            Return _rentasaldo
        End Get
        Set(ByVal value As Double)
            _rentasaldo = value
        End Set
    End Property

    <DataMember()> _
    Public Property Monto() As Double
        Get
            If Calcular Then
                Dim _den = 12 - (NroMes - 1)
                If _den > 0 Then _monto = RentaSaldo / _den
            End If
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
        End Set
    End Property

    <DataMember()> _
    Public Property Operacion() As Double
        Get
            Return _operacion
        End Get
        Set(ByVal value As Double)
            _operacion = value
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

#End Region

#Region "Contructor"

    Public Sub New()
        _id = String.Empty
        _idretencionquinta = String.Empty
        _idtrabajador = String.Empty
        _dni = String.Empty
        _trabajador = String.Empty
        _sueldo = 0
        _asignacionfamiliar = 0
        _basico1 = 0
        _basico2 = 0
        _basico3 = 0
        _basico4 = 0
        _basico5 = 0
        _basico6 = 0
        _basico7 = 0
        _basico8 = 0
        _basico9 = 0
        _basico10 = 0
        _basico11 = 0
        _basico12 = 0
        _utilidad = 0
        _basicog1 = 0
        _bonoextg1 = 0
        _bono1 = 0
        _bono2 = 0
        _bono3 = 0
        _bono4 = 0
        _bono5 = 0
        _bono6 = 0
        _bono7 = 0
        _bono8 = 0
        _bono9 = 0
        _bono10 = 0
        _bono11 = 0
        _bono12 = 0
        _bono13 = 0
        _bono14 = 0
        _bono15 = 0
        _bono16 = 0
        _bono17 = 0
        _bono18 = 0
        _bono19 = 0
        _bono20 = 0
        _bono21 = 0
        _basicog2 = 0
        _bonoextg2 = 0
        _basicopendiente = 0
        _bonopendiente = 0
        _rentabrutaanual = 0
        _deduccioniut = 0
        _rentanetaanual = 0
        _tiporetencion = 0
        _impuestoanual = 0
        _retencion1 = 0
        _retencion2 = 0
        _retencion3 = 0
        _retencion4 = 0
        _retencion5 = 0
        _retencion6 = 0
        _retencion7 = 0
        _retencion8 = 0
        _retencion9 = 0
        _retencion10 = 0
        _retencion11 = 0
        _retencion12 = 0
        _rentasaldo = 0
        _monto = 0
        _operacion = 0
        _fechacreacion = #1/1/1901#
        _usuariocreacion = String.Empty
        _fechamodifica = #1/1/1901#
        _usuariomodifica = String.Empty
        _activo = True
    End Sub

    Public Sub New( _
              ByVal ls_Id As String _
              , ByVal ls_IdRetencionQuinta As String _
              , ByVal ls_IdTrabajador As String _
              , ByVal ls_Dni As String _
              , ByVal ls_Trabajador As String _
              , ByVal ln_Sueldo As Double _
              , ByVal ln_AsignacionFamiliar As Double _
              , ByVal ln_Renumeracion As Double _
              , ByVal ln_Basico1 As Double _
              , ByVal ln_Basico2 As Double _
              , ByVal ln_Basico3 As Double _
              , ByVal ln_Basico4 As Double _
              , ByVal ln_Basico5 As Double _
              , ByVal ln_Basico6 As Double _
              , ByVal ln_Basico7 As Double _
              , ByVal ln_Basico8 As Double _
              , ByVal ln_Basico9 As Double _
              , ByVal ln_Basico10 As Double _
              , ByVal ln_Basico11 As Double _
              , ByVal ln_Basico12 As Double _
              , ByVal ln_BasicoPercibido As Double _
              , ByVal ln_Utilidad As Double _
              , ByVal ln_BasicoG1 As Double _
              , ByVal ln_BonoExtG1 As Double _
              , ByVal ln_Bono1 As Double _
              , ByVal ln_Bono2 As Double _
              , ByVal ln_Bono3 As Double _
              , ByVal ln_Bono4 As Double _
              , ByVal ln_Bono5 As Double _
              , ByVal ln_Bono6 As Double _
              , ByVal ln_Bono7 As Double _
              , ByVal ln_Bono8 As Double _
              , ByVal ln_Bono9 As Double _
              , ByVal ln_Bono10 As Double _
              , ByVal ln_Bono11 As Double _
              , ByVal ln_Bono12 As Double _
              , ByVal ln_Bono13 As Double _
              , ByVal ln_Bono14 As Double _
              , ByVal ln_Bono15 As Double _
              , ByVal ln_Bono16 As Double _
              , ByVal ln_Bono17 As Double _
              , ByVal ln_Bono18 As Double _
              , ByVal ln_Bono19 As Double _
              , ByVal ln_Bono20 As Double _
              , ByVal ln_Bono21 As Double _
              , ByVal ln_BonoPercibido As Double _
              , ByVal ln_BasicoPendiente As Double _
              , ByVal ln_BonoPendiente As Double _
              , ByVal ln_BasicoG2 As Double _
              , ByVal ln_BonoExtG2 As Double _
              , ByVal ln_RentaBrutaAnual As Double _
              , ByVal ln_DeduccionIUT As Double _
              , ByVal ln_RentaNetaAnual As Double _
              , ByVal ln_TipoRetencion As Integer _
              , ByVal ln_Rango1 As Double _
              , ByVal ln_Rango2 As Double _
              , ByVal ln_Rango3 As Double _
              , ByVal ln_Rango4 As Double _
              , ByVal ln_Rango5 As Double _
              , ByVal ln_ImpuestoAnual As Double _
              , ByVal ln_Retencion1 As Double _
              , ByVal ln_Retencion2 As Double _
              , ByVal ln_Retencion3 As Double _
              , ByVal ln_Retencion4 As Double _
              , ByVal ln_Retencion5 As Double _
              , ByVal ln_Retencion6 As Double _
              , ByVal ln_Retencion7 As Double _
              , ByVal ln_Retencion8 As Double _
              , ByVal ln_Retencion9 As Double _
              , ByVal ln_Retencion10 As Double _
              , ByVal ln_Retencion11 As Double _
              , ByVal ln_Retencion12 As Double _
              , ByVal ln_TotalRetencion As Double _
              , ByVal ln_RentaSaldo As Double _
              , ByVal ln_Monto As Double _
              , ByVal ln_Operacion As Integer _
              , ByVal ld_FechaCreacion As Date _
              , ByVal ls_UsuarioCreacion As String _
              , ByVal ld_FechaModifica As Date _
              , ByVal ls_UsuarioModifica As String _
              , ByVal lb_Activo As Boolean _
           )
        _id = ls_Id
        _idretencionquinta = ls_IdRetencionQuinta
        _idtrabajador = ls_IdTrabajador
        _dni = ls_Dni
        _trabajador = ls_Trabajador
        _sueldo = ln_Sueldo
        _asignacionfamiliar = ln_AsignacionFamiliar
        _renumeracion = ln_Renumeracion
        _basico1 = ln_Basico1
        _basico2 = ln_Basico2
        _basico3 = ln_Basico3
        _basico4 = ln_Basico4
        _basico5 = ln_Basico5
        _basico6 = ln_Basico6
        _basico7 = ln_Basico7
        _basico8 = ln_Basico8
        _basico9 = ln_Basico9
        _basico10 = ln_Basico10
        _basico11 = ln_Basico11
        _basico12 = ln_Basico12
        _basicopendiente = ln_BasicoPercibido
        _utilidad = ln_Utilidad
        _basicog1 = ln_BasicoG1
        _bonoextg1 = ln_BonoExtG1
        _bono1 = ln_Bono1
        _bono2 = ln_Bono2
        _bono3 = ln_Bono3
        _bono4 = ln_Bono4
        _bono5 = ln_Bono5
        _bono6 = ln_Bono6
        _bono7 = ln_Bono7
        _bono8 = ln_Bono8
        _bono9 = ln_Bono9
        _bono10 = ln_Bono10
        _bono11 = ln_Bono11
        _bono12 = ln_Bono12
        _bono13 = ln_Bono13
        _bono14 = ln_Bono14
        _bono15 = ln_Bono15
        _bono16 = ln_Bono16
        _bono17 = ln_Bono17
        _bono18 = ln_Bono18
        _bono19 = ln_Bono19
        _bono20 = ln_Bono20
        _bono21 = ln_Bono21
        _totalbono = ln_BonoPercibido
        _basicopendiente = ln_BasicoPendiente
        _bonopendiente = ln_BonoPendiente
        _basicog2 = ln_BasicoG2
        _bonoextg2 = ln_BonoExtG2
        _rentabrutaanual = ln_RentaBrutaAnual
        _deduccioniut = ln_DeduccionIUT
        _rentanetaanual = ln_RentaNetaAnual
        _tiporetencion = ln_TipoRetencion
        _rango1 = ln_Rango1
        _rango2 = ln_Rango2
        _rango3 = ln_Rango3
        _rango4 = ln_Rango4
        _rango5 = ln_Rango5
        _impuestoanual = ln_ImpuestoAnual
        _retencion1 = ln_Retencion1
        _retencion2 = ln_Retencion2
        _retencion3 = ln_Retencion3
        _retencion4 = ln_Retencion4
        _retencion5 = ln_Retencion5
        _retencion6 = ln_Retencion6
        _retencion7 = ln_Retencion7
        _retencion8 = ln_Retencion8
        _retencion9 = ln_Retencion9
        _retencion10 = ln_Retencion10
        _retencion11 = ln_Retencion11
        _retencion12 = ln_Retencion12
        _totalretencion = ln_TotalRetencion
        _rentasaldo = ln_RentaSaldo
        _monto = ln_Monto
        _operacion = ln_Operacion
        _fechacreacion = ld_FechaCreacion
        _usuariocreacion = ls_UsuarioCreacion
        _fechamodifica = ld_FechaModifica
        _usuariomodifica = ls_UsuarioModifica
        _activo = lb_Activo
    End Sub

#End Region

#Region "Metodo"

    Public Function obtener(oeDetalleRentaQuinta As e_DetalleRentaQuinta) As e_DetalleRentaQuinta Implements Ie_DetalleRentaQuinta.obtener
        Return oeDetalleRentaQuinta
    End Function

    Public Overloads Function Equals(ByVal oeDetR5 As e_DetalleRentaQuinta) As Boolean Implements System.IEquatable(Of e_DetalleRentaQuinta).Equals
        Select Case oeDetR5.Equivale
            Case 1 : If Me.Id = oeDetR5.Id Then Return True
            Case 2 : If Me.IdTrabajador = oeDetR5.IdTrabajador Then Return True
        End Select
        Return False
    End Function

#End Region

End Class
