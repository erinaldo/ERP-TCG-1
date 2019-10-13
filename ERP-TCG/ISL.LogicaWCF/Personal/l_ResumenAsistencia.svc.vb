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

Public Class l_ResumenAsistencia
    Implements Il_ResumenAsistencia

    Private odResumenAsistencia As New d_ResumenAsistencia
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeResumenAsistencia As EntidadesWCF.e_ResumenAsistencia) As Boolean Implements Il_ResumenAsistencia.Eliminar
        Try
            Return odResumenAsistencia.Eliminar(oeResumenAsistencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeResumenAsistencia As EntidadesWCF.e_ResumenAsistencia) As Boolean Implements Il_ResumenAsistencia.Guardar
        Try
            If Validar(oeResumenAsistencia) Then
                Return odResumenAsistencia.Guardar(oeResumenAsistencia)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeResumenAsistencia As EntidadesWCF.e_ResumenAsistencia) As List(Of EntidadesWCF.e_ResumenAsistencia) Implements Il_ResumenAsistencia.Listar
        Try
            Return odResumenAsistencia.Listar(oeResumenAsistencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeResumenAsistencia As EntidadesWCF.e_ResumenAsistencia) As EntidadesWCF.e_ResumenAsistencia Implements Il_ResumenAsistencia.Obtener
        Try
            Return odResumenAsistencia.Obtener(oeResumenAsistencia)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeResumenAsistencia As EntidadesWCF.e_ResumenAsistencia) As Boolean Implements Il_ResumenAsistencia.Validar
        Try
            With oeResumenAsistencia
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_ResumenAsistencia.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_ResumenAsistencia.CrearDT
        Dim ResAsis As New Data.DataTable
        With ResAsis
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndTipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("GozedeHaber", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaInicio", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("FechaTermino", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("Observacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DiasNetos", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("IndTipoAux", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IdEstado", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CodigoSuspension", Type.GetType("System.String")))
        End With
        Return ResAsis
    End Function

    Public Function GuardarMasivo(leResumenAsistencia As List(Of e_ResumenAsistencia), ByVal PrefijoID As String) As Boolean Implements Il_ResumenAsistencia.GuardarMasivo
        Try
            Dim dtRA As Data.DataTable = CrearDT()
            Dim id As String = odResumenAsistencia.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeResAis In leResumenAsistencia
                Dim rwRA As Data.DataRow
                rwRA = dtRA.NewRow
                With oeResAis
                    rwRA("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rwRA("IdPlanilla") = .IdPlanilla
                    rwRA("IdTrabajador") = .IdTrabajador
                    rwRA("IndTipo") = .IndTipo
                    rwRA("Cantidad") = .Cantidad
                    rwRA("GozedeHaber") = .GozedeHaber
                    rwRA("FechaCreacion") = Date.Now.Date
                    rwRA("UsuarioCreacion") = .UsuarioCreacion
                    rwRA("FechaModifica") = .FechaModifica
                    rwRA("UsuarioModifica") = .UsuarioModifica
                    rwRA("Activo") = True
                    rwRA("FechaInicio") = .FechaInicio
                    rwRA("FechaTermino") = .FechaTermino
                    rwRA("Observacion") = .Observacion
                    rwRA("DiasNetos") = .DiasNetos
                    rwRA("IndTipoAux") = .IndTipoAux
                    rwRA("IdEstado") = .IdEstado
                    rwRA("CodigoSuspension") = .CodigoSuspension
                End With
                dtRA.Rows.Add(rwRA)
                lsNumero = lsNumero + 1
            Next
            Return odResumenAsistencia.GuardarMasivo(dtRA)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(leResumenAsistencia As List(Of e_ResumenAsistencia)) As Boolean Implements Il_ResumenAsistencia.GuardarLista
        Try
            Return odResumenAsistencia.GuardarLista(leResumenAsistencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarLista(leResumenAsistencia As List(Of e_ResumenAsistencia)) As Boolean Implements Il_ResumenAsistencia.EliminarLista
        Try
            Return odResumenAsistencia.EliminarLista(leResumenAsistencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function AsistenciaOperativos(oeResumenAsistencia As e_ResumenAsistencia) As DataTable Implements Il_ResumenAsistencia.AsistenciaOperativos
        Try
            Return odResumenAsistencia.AsistenciaOperativos(oeResumenAsistencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
