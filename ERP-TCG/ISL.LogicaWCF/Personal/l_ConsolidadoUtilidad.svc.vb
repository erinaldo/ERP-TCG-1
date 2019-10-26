Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConsolidadoUtilidad
    Implements Il_ConsolidadoUtilidad

    Private odDetalleUtilidad As New d_ConsolidadoUtilidad
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleUtilidad As e_ConsolidadoUtilidad) As Boolean Implements Il_ConsolidadoUtilidad.Eliminar
        Try
            Return odDetalleUtilidad.Eliminar(oeDetalleUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleUtilidad As e_ConsolidadoUtilidad) As Boolean Implements Il_ConsolidadoUtilidad.Guardar
        Try
            If Validar(oeDetalleUtilidad) Then
                Return odDetalleUtilidad.Guardar(oeDetalleUtilidad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleUtilidad As e_ConsolidadoUtilidad) As List(Of e_ConsolidadoUtilidad) Implements Il_ConsolidadoUtilidad.Listar
        Try
            Return odDetalleUtilidad.Listar(oeDetalleUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleUtilidad As e_ConsolidadoUtilidad) As e_ConsolidadoUtilidad Implements Il_ConsolidadoUtilidad.Obtener
        Try
            Return odDetalleUtilidad.Obtener(oeDetalleUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleUtilidad As e_ConsolidadoUtilidad) As Boolean Implements Il_ConsolidadoUtilidad.Validar
        Try
            With oeDetalleUtilidad

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_ConsolidadoUtilidad.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_ConsolidadoUtilidad.CrearDT
        Dim ConUti As New Data.DataTable
        With ConUti
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdUtilidad", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndSituacion", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("SueldoAnual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Subsidios", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("SueldoNetoAnual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("UtilidadporSueldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DiasTrabajadosAnual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("UtilidadporDiasTrabajados", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("UtilidadTotal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return ConUti
    End Function

End Class
