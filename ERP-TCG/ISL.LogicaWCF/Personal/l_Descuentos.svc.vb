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

Public Class l_Descuentos
    Implements Il_Descuentos

    Private odDescuentos As New d_Descuentos
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_Descuentos.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_Descuentos.CrearDT
        Dim Dscto As New Data.DataTable
        With Dscto
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MontoAdelanto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("MontoSancion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndTipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("IdEstado", Type.GetType("System.String")))
        End With
        Return Dscto
    End Function

    Public Function Eliminar(oeDescuentos As EntidadesWCF.e_Descuentos) As Boolean Implements Il_Descuentos.Eliminar
        Try
            Return odDescuentos.Eliminar(oeDescuentos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDescuentos As EntidadesWCF.e_Descuentos) As Boolean Implements Il_Descuentos.Guardar
        Try
            If Validar(oeDescuentos) Then
                Return odDescuentos.Guardar(oeDescuentos)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarMasivo(leDescuentos As List(Of EntidadesWCF.e_Descuentos), ByVal PrefijoID As String) As Boolean Implements Il_Descuentos.GuardarMasivo
        Try
            Dim dtDscto As Data.DataTable = CrearDT()
            Dim id As String = odDescuentos.UltimoIdInserta(PrefijoID)
            Dim lsPrefijo As String = Left(id, 3)
            Dim lsNumero As Integer = CInt(Right(id, Len(id) - 3))

            For Each oeDscto In leDescuentos
                Dim rw As Data.DataRow
                rw = dtDscto.NewRow
                With oeDscto
                    rw("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, Len(id) - 3)
                    rw("IdPlanilla") = .IdPlanilla
                    rw("IdTrabajador") = .IdTrabajador
                    rw("MontoAdelanto") = .MontoAdelanto
                    rw("MontoSancion") = .MontoSancion
                    rw("IndTipo") = .IndTipo
                    rw("IdEstado") = .IdEstado
                    rw("FechaCreacion") = Date.Now
                    rw("UsuarioCreacion") = .UsuarioCreacion
                    rw("Activo") = True
                End With
                dtDscto.Rows.Add(rw)
                lsNumero = lsNumero + 1
            Next
            Return odDescuentos.GuardarMasivo(dtDscto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDescuentos As EntidadesWCF.e_Descuentos) As List(Of EntidadesWCF.e_Descuentos) Implements Il_Descuentos.Listar
        Try
            Return odDescuentos.Listar(oeDescuentos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDescuentos As EntidadesWCF.e_Descuentos) As EntidadesWCF.e_Descuentos Implements Il_Descuentos.Obtener
        Try
            Return odDescuentos.Obtener(oeDescuentos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDescuentos As EntidadesWCF.e_Descuentos) As Boolean Implements Il_Descuentos.Validar
        Try
            With oeDescuentos
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
