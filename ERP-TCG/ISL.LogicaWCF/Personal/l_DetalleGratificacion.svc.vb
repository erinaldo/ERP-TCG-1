Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleGratificacion
    Implements Il_DetalleGratificacion

    Private odDetalleGratificacion As New d_DetalleGratificacion
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleGratificacion As e_DetalleGratificacion) As Boolean Implements Il_DetalleGratificacion.Eliminar
        Try
            Return odDetalleGratificacion.Eliminar(oeDetalleGratificacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleGratificacion As e_DetalleGratificacion) As Boolean Implements Il_DetalleGratificacion.Guardar
        Try
            If Validar(oeDetalleGratificacion) Then
                Return odDetalleGratificacion.Guardar(oeDetalleGratificacion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleGratificacion As e_DetalleGratificacion) As List(Of e_DetalleGratificacion) Implements Il_DetalleGratificacion.Listar
        Try
            Return odDetalleGratificacion.Listar(oeDetalleGratificacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleGratificacion As e_DetalleGratificacion) As e_DetalleGratificacion Implements Il_DetalleGratificacion.Obtener
        Try
            Return odDetalleGratificacion.Obtener(oeDetalleGratificacion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleGratificacion As e_DetalleGratificacion) As Boolean Implements Il_DetalleGratificacion.Validar
        Try
            With oeDetalleGratificacion
                ' l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_DetalleGratificacion.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetalleGratificacion.CrearDT
        Dim DetGra As New Data.DataTable
        With DetGra
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdBonoCompensatorio", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCentro", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdArea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdOcupacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdCuentaCorriente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DatoApoyo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndTipoAux", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaIngreso", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("TempIngreso", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Sueldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("AsignacionFamiliar", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Renumeracion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HoraExtra1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HoraExtra2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HoraExtra3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HoraExtra4", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HoraExtra5", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("HoraExtra6", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndPromExtra", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("PromedioHoraExtra", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono1", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono2", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono3", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono4", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono5", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Bono6", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndPromedio", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("PromedioBono", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Gratificacion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FraccionGrati", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("RenumeracionComputable", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TiempoLaborado", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DiasFaltas", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("MesesFalta", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("PeriodoComputable", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Importe", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BonoExtra", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Total", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("DescuentosJudiciales", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("AdelantoSueldo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalDescuento", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("NetoTotal", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("IndPendiente", Type.GetType("System.Int16")))
        End With
        Return DetGra
    End Function

End Class
