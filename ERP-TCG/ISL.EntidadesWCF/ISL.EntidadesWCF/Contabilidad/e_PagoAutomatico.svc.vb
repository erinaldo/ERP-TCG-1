''' <summary>
''' Clase para controlar el pago automático de Caja
''' </summary>
''' <remarks></remarks>
<DataContract()> _
Public Class e_PagoAutomatico
    Implements Ie_PagoAutomatico

    <DataMember()> _
    Public IdMovimientoDocumento As String
    <DataMember()> _
    Public IdPeriodo As String
    <DataMember()> _
    Public Glosa As String
    <DataMember()> _
    Public GlosaGrupo As String
    <DataMember()> _
    Public IdMoneda As String
    <DataMember()> _
    Public TipoCambio As Double
    <DataMember()> _
    Public Total As Double
    <DataMember()> _
    Public UsuarioCreacion As String
    <DataMember()> _
    Public Cuenta42 As String
    <DataMember()> _
    Public Cuenta10 As String
    <DataMember()> _
    Public IdFLujo As String
    <DataMember()> _
    Public MacPCLocalCreacion As String
    <DataMember()>
    Public Fecha As Date
    <DataMember()>
    Public PrefijoID As String = ""

    Sub New()

    End Sub

    Public Function Obtener(ByVal pagoAutomatico As e_PagoAutomatico) As e_PagoAutomatico Implements Ie_PagoAutomatico.Obtener
        Return pagoAutomatico
    End Function

End Class
