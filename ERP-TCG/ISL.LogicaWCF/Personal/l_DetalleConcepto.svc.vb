Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleConcepto
    Implements Il_DetalleConcepto

    Private odDetalleConcepto As New d_DetalleConcepto
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleConcepto As e_DetalleConcepto) As Boolean Implements Il_DetalleConcepto.Eliminar
        Try
            Return odDetalleConcepto.Eliminar(oeDetalleConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleConcepto As e_DetalleConcepto) As Boolean Implements Il_DetalleConcepto.Guardar
        Try
            If Validar(oeDetalleConcepto) Then
                Return odDetalleConcepto.Guardar(oeDetalleConcepto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleConcepto As e_DetalleConcepto) As List(Of e_DetalleConcepto) Implements Il_DetalleConcepto.Listar
        Try
            Return odDetalleConcepto.Listar(oeDetalleConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleConcepto As e_DetalleConcepto) As e_DetalleConcepto Implements Il_DetalleConcepto.Obtener
        Try
            Return odDetalleConcepto.Obtener(oeDetalleConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleConcepto As e_DetalleConcepto) As Boolean Implements Il_DetalleConcepto.Validar
        Try
            With oeDetalleConcepto
                ' l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                ' l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                If .Importe = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetalleConcepto.CrearDT
        Dim DetalleCon As New Data.DataTable
        With DetalleCon
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdDetallePlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAporteDescuento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Importe", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Tipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return DetalleCon
    End Function
End Class
