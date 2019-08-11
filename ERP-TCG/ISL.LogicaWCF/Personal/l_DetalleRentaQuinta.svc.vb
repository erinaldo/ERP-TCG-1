Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleRentaQuinta
    Implements Il_DetalleRentaQuinta

    Private odDetalleRentaQuinta As New d_DetalleRentaQuinta
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleRentaQuinta As EntidadesWCF.e_DetalleRentaQuinta) As Boolean Implements Il_DetalleRentaQuinta.Eliminar
        Try
            Return odDetalleRentaQuinta.Eliminar(oeDetalleRentaQuinta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleRentaQuinta As EntidadesWCF.e_DetalleRentaQuinta) As Boolean Implements Il_DetalleRentaQuinta.Guardar
        Try
            If Validar(oeDetalleRentaQuinta) Then
                Return odDetalleRentaQuinta.Guardar(oeDetalleRentaQuinta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleRentaQuinta As EntidadesWCF.e_DetalleRentaQuinta) As List(Of EntidadesWCF.e_DetalleRentaQuinta) Implements Il_DetalleRentaQuinta.Listar
        Try
            Return odDetalleRentaQuinta.Listar(oeDetalleRentaQuinta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleRentaQuinta As EntidadesWCF.e_DetalleRentaQuinta) As EntidadesWCF.e_DetalleRentaQuinta Implements Il_DetalleRentaQuinta.Obtener
        Try
            Return odDetalleRentaQuinta.Obtener(oeDetalleRentaQuinta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleRentaQuinta As EntidadesWCF.e_DetalleRentaQuinta) As Boolean Implements Il_DetalleRentaQuinta.Validar
        Try
            With oeDetalleRentaQuinta
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_DetalleRentaQuinta.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetalleRentaQuinta.CrearDT
        Dim DetR5 As New Data.DataTable
        With DetR5
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdRetencionQuinta", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Sueldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("AsignacionFamiliar", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Renumeracion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico4", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico5", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico6", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico7", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico8", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico9", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico10", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico11", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Basico12", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BasicoPercibido", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Utilidad", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BasicoG1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoExtG1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono4", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono5", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono6", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono7", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono8", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono9", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono10", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono11", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono12", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoPercibido", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BasicoPendiente", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoPendiente", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BasicoG2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoExtG2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("RentaBrutaAnual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DeduccionIUT", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("RentaNetaAnual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TipoRetencion", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("ImpuestoAnual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion4", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion5", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion6", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion7", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion8", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion9", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion10", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion11", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Retencion12", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalRetencion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("RentaSaldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Operacion", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return DetR5
    End Function

End Class
