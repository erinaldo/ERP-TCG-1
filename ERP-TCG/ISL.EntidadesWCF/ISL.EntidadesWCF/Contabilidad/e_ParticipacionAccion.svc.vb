Public Class e_ParticipacionAccion
    Implements Ie_ActivoFijo

#Region "Variables"
    Public TipoOperacion As String = String.Empty
    <DataMember()>
    Public PrefijoID As String = ""
#End Region

#Region "Propiedades"

    <DataMember()> _
    Public Property Id() As String
    <DataMember()> _
    Public Property TipoDoc() As String
    <DataMember()> _
    Public Property NroDoc() As String
    <DataMember()> _
    Public Property CodigoDoc() As String
    <DataMember()> _
    Public Property NroAcciones() As Integer
    <DataMember()> _
    Public Property TipoAccion() As String
    <DataMember()> _
    Public Property CodigoAcc() As String
    <DataMember()> _
    Public Property PorcParticipacion() As Decimal
    <DataMember()> _
    Public Property Fecha() As Date
    <DataMember()> _
    Public Property FechaBaja() As Date
    <DataMember()> _
    Public Property FechaCreacion() As Date
    <DataMember()> _
    Public Property UsuarioCreacion() As String
    <DataMember()> _
    Public Property IdTrabajador() As String

   
    <DataMember()> _
    Public Property Accionista() As String
    <DataMember()> _
    Public Property Activo() As Boolean
#End Region

#Region "Constructor"

    Public Sub New()
        IdTrabajador = String.Empty
        Id = String.Empty
        NroAcciones = 0
        TipoAccion = String.Empty
        PorcParticipacion = 0.0
        Fecha = #1/1/1901#
        FechaBaja = #1/1/1901#
        FechaCreacion = #1/1/1901#
        UsuarioCreacion = String.Empty
        Activo = 1
    End Sub

    Public Sub New(ls_Id As String, ls_IdTrabajador As String, ls_TipoDoc As String, ls_NroDoc As String, ls_TipoAccion As String, _
                   li_NroAcciones As Integer, lb_Activo As Boolean, lf_Fecha As Date, lf_FechaBaja As Date)
        Id = ls_Id
        IdTrabajador = ls_IdTrabajador
        NroDoc = ls_NroDoc
        NroAcciones = li_NroAcciones
        TipoAccion = ls_TipoAccion
        Fecha = lf_Fecha
        TipoDoc = ls_TipoDoc
        Activo = 1
    End Sub

    Public Sub New(ls_Id As String, ls_TipoDoc As String, ls_NroDoc As String, ls_CodigoDoc As String, _
                   ls_Accionista As String, ls_TipoAccion As String, ls_CodigoAcc As String, _
                   li_NroAcciones As Integer, _
                   ld_PorcParticipacion As Decimal, lb_Activo As Boolean, lf_Fecha As Date, lf_FechaBaja As Date)
        Id = ls_Id
        TipoDoc = ls_TipoDoc
        NroDoc = ls_NroDoc
        CodigoDoc = ls_CodigoDoc
        Accionista = ls_Accionista
        TipoAccion = ls_TipoAccion
        CodigoAcc = ls_CodigoAcc
        NroAcciones = li_NroAcciones
        PorcParticipacion = ld_PorcParticipacion
        Fecha = lf_Fecha
        FechaBaja = lf_FechaBaja
        Activo = lb_Activo
    End Sub

#End Region

End Class

