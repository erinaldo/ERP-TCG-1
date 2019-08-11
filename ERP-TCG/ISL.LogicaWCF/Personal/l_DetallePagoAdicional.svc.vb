Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetallePagoAdicional
    Implements Il_DetallePagoAdicional

    Private odDetallePagoAdicional As New d_DetallePagoAdicional
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetallePagoAdicional As EntidadesWCF.e_DetallePagoAdicional) As Boolean Implements Il_DetallePagoAdicional.Eliminar
        Try
            Return odDetallePagoAdicional.Eliminar(oeDetallePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetallePagoAdicional As EntidadesWCF.e_DetallePagoAdicional) As Boolean Implements Il_DetallePagoAdicional.Guardar
        Try
            If Validar(oeDetallePagoAdicional) Then
                Return odDetallePagoAdicional.Guardar(oeDetallePagoAdicional)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetallePagoAdicional As EntidadesWCF.e_DetallePagoAdicional) As List(Of EntidadesWCF.e_DetallePagoAdicional) Implements Il_DetallePagoAdicional.Listar
        Try
            Return odDetallePagoAdicional.Listar(oeDetallePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetallePagoAdicional As EntidadesWCF.e_DetallePagoAdicional) As EntidadesWCF.e_DetallePagoAdicional Implements Il_DetallePagoAdicional.Obtener
        Try
            Return odDetallePagoAdicional.Obtener(oeDetallePagoAdicional)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetallePagoAdicional As EntidadesWCF.e_DetallePagoAdicional) As Boolean Implements Il_DetallePagoAdicional.Validar
        Try
            With oeDetallePagoAdicional
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_DetallePagoAdicional.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetallePagoAdicional.CrearDT
        Dim DetPA As New Data.DataTable
        With DetPA
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPagoAdicional", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Sueldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("AsignacionFamiliar", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndTipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Cantidad", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Redondeo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DiasVacaciones", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("DiasFalta", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("DiasDescanso", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("TotalPagar", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("HorasExtras", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("MinutosExtras", Type.GetType("System.Int32")))
        End With
        Return DetPA
    End Function

End Class
