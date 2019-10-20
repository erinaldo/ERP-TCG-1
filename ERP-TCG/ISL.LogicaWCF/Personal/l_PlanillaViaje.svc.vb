'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_PlanillaViaje
    Implements Il_PlanillaViaje

    Dim odPlanillaViaje As New d_PlanillaViaje

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_PlanillaViaje.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As System.Data.DataTable Implements Il_PlanillaViaje.CrearDT
        Dim PlanillaViaje As New Data.DataTable
        With PlanillaViaje
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPlanillaPiloto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdViaje", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRuta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndPago", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IdPiloto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoPiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdCopiloto", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoCopiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdAyudante", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoAyudante", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoSolo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoAcompañado", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PorcentajeCopiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("CuentaPiloto", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("CuentaCoPiloto", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("BonoSolo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoCruceroPiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoCruceroCopiloto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Tipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return PlanillaViaje
    End Function

    Public Function GuardarMasivo(ByVal loPlanillaViaje As System.Collections.Generic.List(Of e_PlanillaViaje), ByVal PrefijoID As String) As Boolean Implements Il_PlanillaViaje.GuardarMasivo
        Try
            Dim dtCCP As Data.DataTable = CrearDT()
            Dim id As String = odPlanillaViaje.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))
            For Each planillaviaje In loPlanillaViaje
                Dim rwCCP As Data.DataRow
                rwCCP = dtCCP.NewRow
                With planillaviaje
                    rwCCP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 12)
                    rwCCP("IdPlanillaPiloto") = .IdPlanillaPiloto
                    rwCCP("IdViaje") = .IdViaje
                    rwCCP("IdRuta") = .IdRuta
                    rwCCP("IndPago") = .IndPago
                    rwCCP("IdPiloto") = .IdPiloto
                    rwCCP("MontoPiloto") = .MontoPiloto
                    rwCCP("IdCopiloto") = .IdCopiloto
                    rwCCP("MontoCopiloto") = .MontoCopiloto
                    rwCCP("IdAyudante") = .IdAyudante
                    rwCCP("MontoAyudante") = .MontoAyudante
                    rwCCP("MontoSolo") = .MontoSolo
                    rwCCP("MontoAcompañado") = .MontoAcompañado
                    rwCCP("PorcentajeCopiloto") = .PorcentajeCopiloto
                    rwCCP("CuentaPiloto") = .CuentaPiloto
                    rwCCP("CuentaCoPiloto") = .CuentaCoPiloto
                    rwCCP("BonoSolo") = .BonoSolo
                    rwCCP("BonoCruceroPiloto") = .BonoCruceroPiloto
                    rwCCP("BonoCruceroCopiloto") = .BonoCruceroCopiloto
                    rwCCP("FechaCreacion") = Date.Now
                    rwCCP("UsuarioCreacion") = .UsuarioCreacion
                    rwCCP("Activo") = True
                    rwCCP("Tipo") = .Tipo
                End With
                dtCCP.Rows.Add(rwCCP)
                lsNumero = lsNumero + 1
            Next
            Return odPlanillaViaje.GuardarMasivo(dtCCP)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlanillaViaje As e_PlanillaViaje) As List(Of e_PlanillaViaje) Implements Il_PlanillaViaje.Listar
        Try
            Return odPlanillaViaje.Listar(oePlanillaViaje)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
