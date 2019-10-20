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

<DataContract(), Serializable()> _
Public Class l_DetallePlanilla
    Implements Il_DetallePlanilla

    Private odDetallePlanilla As New d_DetallePlanilla
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetallePlanilla As e_DetallePlanilla) As Boolean Implements Il_DetallePlanilla.Eliminar
        Try
            Return odDetallePlanilla.Eliminar(oeDetallePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetallePlanilla As e_DetallePlanilla) As Boolean Implements Il_DetallePlanilla.Guardar
        Try
            If Validar(oeDetallePlanilla) Then
                Return odDetallePlanilla.Guardar(oeDetallePlanilla)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetallePlanilla As e_DetallePlanilla) As List(Of e_DetallePlanilla) Implements Il_DetallePlanilla.Listar
        Try
            Return odDetallePlanilla.Listar(oeDetallePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetallePlanilla As e_DetallePlanilla) As e_DetallePlanilla Implements Il_DetallePlanilla.Obtener
        Try
            Return odDetallePlanilla.Obtener(oeDetallePlanilla)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetallePlanilla As e_DetallePlanilla) As Boolean Implements Il_DetallePlanilla.Validar
        Try
            With oeDetallePlanilla
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                If .ImportePagar = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetallePlanilla.CrearDT
        Dim DetallePla As New Data.DataTable

        With DetallePla
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCentro", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdArea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdOcupacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndRuta", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IndEstado", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IndHijo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IdEmpresaAFP", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndTipoAFP", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IndTipoAux", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("DiasFaltas", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("DiasDescanso", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("DiasVacaciones", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("DiasCompra", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("IdCuentaCorriente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Ingresos", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Deducciones", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Aportes", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("ImportePagar", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IsPagado", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndTipo", Type.GetType("System.Int16")))
        End With
        Return DetallePla
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_DetallePlanilla.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function GuardarMasivo(leDetallePla As List(Of e_DetallePlanilla), ByVal PrefijoID As String) As Boolean Implements Il_DetallePlanilla.GuardarMasivo
        Try
            Dim dtPla As Data.DataTable = CrearDT()
            Dim id As String = odDetallePlanilla.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeDetPla In leDetallePla
                Dim rwDP As Data.DataRow
                rwDP = dtPla.NewRow
                With oeDetPla
                    rwDP("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwDP("IdPlanilla") = .IdPlanilla
                    rwDP("IdTrabajador") = .IdTrabajador
                    rwDP("IdCentro") = .IdCentro
                    rwDP("IdArea") = .IdArea
                    rwDP("IdOcupacion") = .IdOcupacion
                    rwDP("IndRuta") = .IndRuta
                    rwDP("IndEstado") = .IndEstado
                    rwDP("IndHijo") = .IndHijo
                    rwDP("IdEmpresaAFP") = .IdEmpresaAFP
                    rwDP("IndTipoAFP") = .IndTipoAFP
                    rwDP("IndTipoAux") = .IndTipoAux
                    rwDP("DiasFaltas") = .DiasFaltas
                    rwDP("DiasDescanso") = .DiasDescanso
                    rwDP("DiasVacaciones") = .DiasVacaciones
                    rwDP("DiasCompra") = .DiasCompra
                    rwDP("IdCuentaCorriente") = .IdCuentaCorriente
                    rwDP("Ingresos") = .Ingresos
                    rwDP("Deducciones") = .Deducciones
                    rwDP("Aportes") = .Aportes
                    rwDP("ImportePagar") = .ImportePagar
                    rwDP("FechaCreacion") = Date.Now
                    rwDP("UsuarioCreacion") = .UsuarioCreacion
                    rwDP("FechaModifica") = .FechaModifica
                    rwDP("UsuarioModifica") = .UsuarioModifica
                    rwDP("Activo") = True
                End With
                dtPla.Rows.Add(rwDP)
                lsNumero = lsNumero + 1
            Next
            Return odDetallePlanilla.GuardarMasivo(dtPla)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
