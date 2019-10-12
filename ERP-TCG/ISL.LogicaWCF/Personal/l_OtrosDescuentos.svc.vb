'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_OtrosDescuentos
    Implements Il_OtrosDescuentos

    Private odOtrosDescuentos As New d_OtrosDescuentos
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeOtrosDescuentos As EntidadesWCF.e_OtrosDescuentos) As Boolean Implements Il_OtrosDescuentos.Eliminar
        Try
            Return odOtrosDescuentos.Eliminar(oeOtrosDescuentos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeOtrosDescuentos As EntidadesWCF.e_OtrosDescuentos) As Boolean Implements Il_OtrosDescuentos.Guardar
        Try
            If Validar(oeOtrosDescuentos) Then
                Return odOtrosDescuentos.Guardar(oeOtrosDescuentos)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeOtrosDescuentos As EntidadesWCF.e_OtrosDescuentos) As List(Of EntidadesWCF.e_OtrosDescuentos) Implements Il_OtrosDescuentos.Listar
        Try
            Return odOtrosDescuentos.Listar(oeOtrosDescuentos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeOtrosDescuentos As EntidadesWCF.e_OtrosDescuentos) As EntidadesWCF.e_OtrosDescuentos Implements Il_OtrosDescuentos.Obtener
        Try
            Return odOtrosDescuentos.Obtener(oeOtrosDescuentos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeOtrosDescuentos As EntidadesWCF.e_OtrosDescuentos) As Boolean Implements Il_OtrosDescuentos.Validar
        Try
            With oeOtrosDescuentos
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdPlanilla, "Seleccione un Planilla")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "Seleccione un Trabajador")
                Select Case .IndTipo
                    Case 0 : l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresaConvenio, "Seleccione un Empresa")
                        'Case 1 : l_FuncionesGenerales.ValidarCampoNoNulo(.IdCuentaBeneficiario, "Seleccione una Cuenta del Beneficiario")
                    Case 2 : l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresaConvenio, "Seleccione Otros Entidad")
                End Select
                If .Monto = 0 Then Throw New Exception("Ingrese Monto a Descontar")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_OtrosDescuentos.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_OtrosDescuentos.CrearDT
        Dim OtroDscto As New Data.DataTable
        With OtroDscto
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndTipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IdEmpresaConvenio", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaBeneficiario", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEstado", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndReferencia", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IdReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModfica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return OtroDscto
    End Function

    Public Function GuardarMasivo(leOtrosDescuentos As List(Of e_OtrosDescuentos), ByVal PrefijoID As String) As Boolean Implements Il_OtrosDescuentos.GuardarMasivo
        Try
            Dim dtOD As Data.DataTable = CrearDT()
            Dim id As String = odOtrosDescuentos.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeRegPen In leOtrosDescuentos
                Dim rwOD As Data.DataRow
                rwOD = dtOD.NewRow
                With oeRegPen
                    rwOD("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwOD("IdPlanilla") = .IdPlanilla
                    rwOD("IdTrabajador") = .IdTrabajador
                    rwOD("IndTipo") = .IndTipo
                    rwOD("Monto") = .Monto
                    rwOD("IdEmpresaConvenio") = .IdEmpresaConvenio
                    rwOD("IdCuentaBeneficiario") = .IdCuentaBeneficiario
                    rwOD("IdEstado") = .IdEstado
                    rwOD("IndReferencia") = .IndReferencia
                    rwOD("IdReferencia") = .IdReferencia
                    rwOD("FechaCreacion") = Date.Now.Date
                    rwOD("UsuarioCreacion") = .UsuarioCreacion
                    rwOD("FechaModifica") = .FechaModifica
                    rwOD("UsuarioModfica") = .UsuarioModifica
                    rwOD("Activo") = True
                End With
                dtOD.Rows.Add(rwOD)
                lsNumero = lsNumero + 1
            Next
            Return odOtrosDescuentos.GuardarMasivo(dtOD)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(leOtrosDescuentos As List(Of e_OtrosDescuentos)) As Boolean Implements Il_OtrosDescuentos.GuardarLista
        Try
            Return odOtrosDescuentos.GuardarLista(leOtrosDescuentos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
