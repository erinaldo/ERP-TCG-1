Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization
Imports System.Transactions
Imports ISL.ServicioExterno



<DataContract(), Serializable()> _
Public Class I_ProgramacionPago
    Implements Il_ProgramacionPago
    Dim dProgramacionPago As New d_ProgramacionPago
    ' Para usar HTTP GET, agregue el atributo <WebGet()>. (El valor predeterminado de ResponseFormat es WebMessageFormat.Json)
    ' Para crear una operación que devuelva XML,
    '     agregue <WebGet(ResponseFormat:=WebMessageFormat.Xml)>
    '     e incluya la siguiente línea en el cuerpo de la operación:
    '         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml"
    <OperationContract()>
    Public Function ObtenerLote(oeProgramacionPago As e_ProgramacionPago) As e_ProgramacionPago Implements Il_ProgramacionPago.ObtenerLote
        Try
            Return dProgramacionPago.ObtenerLote(oeProgramacionPago)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeProgramacionPago As EntidadesWCF.e_ProgramacionPago) As Boolean Implements Il_ProgramacionPago.Guardar
        Try
            Using TS As New TransactionScope
                Dim odProgramacionPago As New d_ProgramacionPago
                odProgramacionPago.Guardar(oeProgramacionPago)
                TS.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ListarProgramacionPagos(oe_ProgramacionPago As e_ProgramacionPago) As DataTable Implements Il_ProgramacionPago.ListarProgramacionPagos
        Try
            Dim DatTableC As DataTable = dProgramacionPago.ListarProgramacionPagos(oe_ProgramacionPago)
            Dim ctacte As String = ""
            Return DatTableC
            'If DatTableC.Rows.Count > 0 Then ctacte = DatTableC.Rows(0).Item("CtaCte")
            'Dim SumaSaldoSoles As Double = 0
            'Dim SumaSaldoDolares As Double = 0
            'Dim SumaAlTCV As Double = 0

            'Dim SumaSaldoSolesTo As Double = 0
            'Dim SumaSaldoDolaresTo As Double = 0
            'Dim SumaAlTCVTo As Double = 0


            'Dim DtTPasPat As DataTable
            'Dim dat As DataTable = Nothing
            'DtTPasPat = DatTableC.Copy
            'If DtTPasPat.Rows.Count > 0 Then
            '    For Each obj As DataRow In DtTPasPat.Rows
            '        If ctacte = obj.Item("CtaCte") Then
            '            SumaSaldoSoles = SumaSaldoSoles + obj.Item("SALDO_S")
            '            SumaSaldoDolares = SumaSaldoDolares + obj.Item("SALDO_D")
            '            SumaAlTCV = SumaAlTCV + obj.Item("SALDO_AL_TCV")
            '        Else
            '            Dim fila As DataRow = DatTableC.NewRow
            '            fila.Item("CtaCte") = ctacte
            '            fila.Item("Dni") = ""
            '            'fila.Item("Seleccion") = False
            '            fila.Item("tipoDoc") = ""
            '            fila.Item("Serie") = ""
            '            fila.Item("Numero") = "SubTotal"
            '            fila.Item("FechaEmision") = ""
            '            fila.Item("FechaVencimiento") = ""
            '            fila.Item("FACT_S") = 0
            '            fila.Item("FACT_D") = 0
            '            fila.Item("SALDO_S") = SumaSaldoSoles
            '            fila.Item("SALDO_D") = SumaSaldoDolares
            '            fila.Item("SALDO_AL_TCV") = SumaAlTCV
            '            fila.Item("Fecha") = "31/12/2099"
            '            fila.Item("IdEstadoPago") = ""
            '            fila.Item("EstadoPago") = ""
            '            DatTableC.Rows.Add(fila)
            '            SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
            '            SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
            '            SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
            '            SumaSaldoSoles = obj.Item("SALDO_S")
            '            SumaSaldoDolares = obj.Item("SALDO_D")
            '            SumaAlTCV = obj.Item("SALDO_AL_TCV")
            '            ctacte = obj.Item("CtaCte")
            '        End If
            '    Next
            '    Dim fila2 As DataRow = DatTableC.NewRow
            '    fila2.Item("CtaCte") = ctacte
            '    fila2.Item("Dni") = ""
            '    'fila2.Item("Seleccion") = False
            '    fila2.Item("tipoDoc") = ""
            '    fila2.Item("Serie") = ""
            '    fila2.Item("Numero") = "SubTotal"
            '    fila2.Item("FechaEmision") = ""
            '    fila2.Item("FechaVencimiento") = ""
            '    fila2.Item("FACT_S") = 0
            '    fila2.Item("FACT_D") = 0
            '    fila2.Item("SALDO_S") = SumaSaldoSoles
            '    fila2.Item("SALDO_D") = SumaSaldoDolares
            '    fila2.Item("SALDO_AL_TCV") = SumaAlTCV
            '    fila2.Item("Fecha") = "31/12/2099"
            '    fila2.Item("IdEstadoPago") = ""
            '    fila2.Item("EstadoPago") = ""
            '    DatTableC.Rows.Add(fila2)
            '    SumaSaldoSolesTo = SumaSaldoSolesTo + SumaSaldoSoles
            '    SumaSaldoDolaresTo = SumaSaldoDolaresTo + SumaSaldoDolares
            '    SumaAlTCVTo = SumaAlTCVTo + SumaAlTCV
            '    Dim Dt As DataRow() = DatTableC.Select(Nothing, "CtaCte,Fecha")
            '    dat = Dt.CopyToDataTable
            '    Dim fila3 As DataRow = dat.NewRow
            '    fila3.Item("CtaCte") = ""
            '    fila3.Item("Dni") = ""
            '    'fila3.Item("Seleccion") = False
            '    fila3.Item("tipoDoc") = ""
            '    fila3.Item("Serie") = ""
            '    fila3.Item("Numero") = "TOTALES"
            '    fila3.Item("FechaEmision") = ""
            '    fila3.Item("FechaVencimiento") = ""
            '    fila3.Item("FACT_S") = 0
            '    fila3.Item("FACT_D") = 0
            '    fila3.Item("SALDO_S") = SumaSaldoSolesTo
            '    fila3.Item("SALDO_D") = SumaSaldoDolaresTo
            '    fila3.Item("SALDO_AL_TCV") = SumaAlTCVTo
            '    fila3.Item("Fecha") = "31/12/2199"
            '    fila3.Item("IdEstadoPago") = ""
            '    fila3.Item("EstadoPago") = ""
            '    dat.Rows.Add(fila3)
            'Else
            '    dat = DatTableC.Copy
            'End If
            'Return dat
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
