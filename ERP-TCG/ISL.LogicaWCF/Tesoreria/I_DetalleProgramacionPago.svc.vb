Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions
Imports ISL.ServicioExterno



<DataContract(), Serializable()> _
Public Class I_DetalleProgramacionPago
    Implements Il_DetalleProgramacionPago
    Dim dDetalleProgramacionPago As New d_DetalleProgramacionPago
    ' Para usar HTTP GET, agregue el atributo <WebGet()>. (El valor predeterminado de ResponseFormat es WebMessageFormat.Json)
    ' Para crear una operación que devuelva XML,
    '     agregue <WebGet(ResponseFormat:=WListarListarebMessageFormat.Xml)>
    '     e incluya la siguiente línea en el cuerpo de la operación:
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"

    Public Function Guardar(ByVal oe_DetalleProgramacionPago As EntidadesWCF.e_DetalleProgramacionPago) As Boolean Implements Il_DetalleProgramacionPago.Guardar
        Try
            Using TS As New TransactionScope
                dDetalleProgramacionPago.Guardar(oe_DetalleProgramacionPago)
                TS.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <OperationContract()>
    Public Function Listar(oeDetalleProgramacionPago As e_DetalleProgramacionPago) As DataTable Implements Il_DetalleProgramacionPago.Listar
        Try
            Dim dat As DataTable = Nothing
            If oeDetalleProgramacionPago.TipoOperacion <> "R" Then
                Dim DatTableC As DataTable = dDetalleProgramacionPago.Listar(oeDetalleProgramacionPago)
                Dim ctacte As String = ""
                If DatTableC.Rows.Count > 0 Then ctacte = DatTableC.Rows(0).Item("CtaCte")
                Dim SumaSaldoSoles As Double = 0
                Dim SumaSaldoDolares As Double = 0
                Dim SumaAlTCV As Double = 0

                Dim SumaSaldoSolesTo As Double = 0
                Dim SumaSaldoDolaresTo As Double = 0
                Dim SumaAlTCVTo As Double = 0

                Dim SumaMontoOriginal As Double = 0
                Dim SumaAfectacion As Double = 0
                Dim SumaMontoPago As Double = 0
                Dim SumaMontoOriginalX As Double = 0
                Dim SumaAfectacionX As Double = 0
                Dim SumaMontoPagoX As Double = 0
                Dim SumaSaldo As Double = 0
                Dim SumaSaldoX As Double = 0

                Dim DtTPasPat As DataTable

                DtTPasPat = DatTableC.Copy
                If DtTPasPat.Rows.Count > 0 Then
                    For Each obj As DataRow In DtTPasPat.Rows
                        If ctacte = obj.Item("CtaCte") Then
                            SumaSaldoSoles = SumaSaldoSoles + obj.Item("SALDO_S")
                            SumaSaldoDolares = SumaSaldoDolares + obj.Item("SALDO_D")
                            SumaAlTCV = SumaAlTCV + obj.Item("SALDO_AL_TCV")
                            SumaMontoOriginal = SumaMontoOriginal + obj.Item("MontoOriginal")
                            SumaAfectacion = SumaAfectacion + obj.Item("Afectacion")
                            SumaMontoPago = SumaMontoPago + obj.Item("MontoPago")
                            SumaSaldo = SumaSaldo + obj.Item("Saldo")
                        Else
                            Dim fila As DataRow = DatTableC.NewRow
                            fila.Item("CtaCte") = ctacte
                            fila.Item("Dni") = ""
                            fila.Item("IdTipoGasto") = ""
                            fila.Item("tipoDoc") = ""
                            fila.Item("Serie") = ""
                            fila.Item("Numero") = "SubTotal"
                            fila.Item("FechaEmision") = ""
                            fila.Item("FechaVencimiento") = ""
                            fila.Item("FACT_S") = 0
                            fila.Item("FACT_D") = 0
                            fila.Item("SALDO_S") = SumaSaldoSoles
                            fila.Item("SALDO_D") = SumaSaldoDolares
                            fila.Item("SALDO_AL_TCV") = SumaAlTCV
                            fila.Item("Fecha") = "31/12/2099"
                            fila.Item("IdEstado") = ""
                            fila.Item("Estado") = ""
                            fila.Item("IDetProgPag") = ""
                            fila.Item("MontoOriginal") = SumaMontoOriginal
                            fila.Item("Afectacion") = SumaAfectacion
                            fila.Item("MontoPago") = SumaMontoPago
                            fila.Item("Saldo") = SumaSaldo
                            DatTableC.Rows.Add(fila)
                            SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
                            SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
                            SumaMontoOriginalX = SumaMontoOriginalX + SumaMontoOriginal
                            SumaAfectacionX = SumaAfectacionX + SumaAfectacion
                            SumaSaldoX = SumaSaldoX + SumaSaldo
                            SumaMontoPagoX = SumaMontoPagoX + SumaMontoPago
                            SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
                            SumaSaldoSoles = obj.Item("SALDO_S")
                            SumaSaldoDolares = obj.Item("SALDO_D")
                            SumaAlTCV = obj.Item("SALDO_AL_TCV")

                            SumaMontoOriginal = obj.Item("MontoOriginal")
                            SumaAfectacion = obj.Item("Afectacion")
                            SumaMontoPago = obj.Item("MontoPago")
                            SumaSaldo = obj.Item("Saldo")


                            ctacte = obj.Item("CtaCte")
                        End If
                    Next
                    Dim fila2 As DataRow = DatTableC.NewRow
                    fila2.Item("CtaCte") = ctacte
                    fila2.Item("Dni") = ""
                    fila2.Item("IdTipoGasto") = ""
                    fila2.Item("tipoDoc") = ""
                    fila2.Item("Serie") = ""
                    fila2.Item("Numero") = "SubTotal"
                    fila2.Item("FechaEmision") = ""
                    fila2.Item("FechaVencimiento") = ""
                    fila2.Item("FACT_S") = 0
                    fila2.Item("FACT_D") = 0
                    fila2.Item("SALDO_S") = SumaSaldoSoles
                    fila2.Item("SALDO_D") = SumaSaldoDolares
                    fila2.Item("SALDO_AL_TCV") = SumaAlTCV
                    fila2.Item("Fecha") = "31/12/2099"
                    fila2.Item("IdEstado") = ""
                    fila2.Item("Estado") = ""
                    fila2.Item("IDetProgPag") = ""
                    fila2.Item("MontoOriginal") = SumaMontoOriginal
                    fila2.Item("Afectacion") = SumaAfectacion
                    fila2.Item("MontoPago") = SumaMontoPago
                    fila2.Item("Saldo") = SumaSaldo
                    DatTableC.Rows.Add(fila2)
                    SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
                    SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
                    SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
                    SumaMontoOriginalX = SumaMontoOriginalX + SumaMontoOriginal
                    SumaAfectacionX = SumaAfectacionX + SumaAfectacion
                    SumaSaldoX = SumaSaldoX + SumaSaldo
                    SumaMontoPagoX = SumaMontoPagoX + SumaMontoPago
                    Dim Dt As DataRow() = DatTableC.Select(Nothing, "CtaCte")
                    dat = Dt.CopyToDataTable
                    Dim fila3 As DataRow = dat.NewRow
                    fila3.Item("CtaCte") = ""
                    fila3.Item("Dni") = ""
                    fila3.Item("IdTipoGasto") = ""
                    fila3.Item("tipoDoc") = ""
                    fila3.Item("Serie") = ""
                    fila3.Item("Numero") = "TOTALES"
                    fila3.Item("FechaEmision") = ""
                    fila3.Item("FechaVencimiento") = ""
                    fila3.Item("FACT_S") = 0
                    fila3.Item("FACT_D") = 0
                    fila3.Item("SALDO_S") = SumaSaldoSolesTo
                    fila3.Item("SALDO_D") = SumaSaldoDolaresTo
                    fila3.Item("SALDO_AL_TCV") = SumaAlTCVTo
                    fila3.Item("Fecha") = "31/12/2199"
                    fila3.Item("IdEstado") = ""
                    fila3.Item("Estado") = ""
                    fila3.Item("IDetProgPag") = ""
                    fila3.Item("MontoOriginal") = SumaMontoOriginalX
                    fila3.Item("Afectacion") = SumaAfectacionX
                    fila3.Item("MontoPago") = SumaMontoPagoX
                    fila3.Item("Saldo") = SumaSaldoX
                    dat.Rows.Add(fila3)
                Else
                    dat = DatTableC.Copy
                End If
            Else
                dat = dDetalleProgramacionPago.Listar(oeDetalleProgramacionPago)
            End If
            Return dat
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ' Agregue aquí más operaciones y márquelas con <OperationContract()>

End Class
