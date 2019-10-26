Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DetalleUtilidad" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DetalleUtilidad.svc o l_DetalleUtilidad.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_DetalleUtilidad
    Implements Il_DetalleUtilidad

    Dim odDetalleUtilidad As New d_DetalleUtilidad

    Public Function Obtener(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As e_DetalleUtilidad Implements Il_DetalleUtilidad.Obtener
        Try
            Return odDetalleUtilidad.Obtener(oeDetalleUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As List(Of e_DetalleUtilidad) Implements Il_DetalleUtilidad.Listar
        Try
            Return odDetalleUtilidad.Listar(oeDetalleUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean Implements Il_DetalleUtilidad.Validar
        Try
            With oeDetalleUtilidad
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean Implements Il_DetalleUtilidad.Guardar
        Try
            If Validar(oeDetalleUtilidad) Then
                Return odDetalleUtilidad.Guardar(oeDetalleUtilidad)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleUtilidad As e_DetalleUtilidad) As Boolean Implements Il_DetalleUtilidad.Eliminar
        Try
            Return odDetalleUtilidad.Eliminar(oeDetalleUtilidad)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_DetalleUtilidad.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetalleUtilidad.CrearDT
        Dim DetUti As New Data.DataTable
        With DetUti
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdUtilidad", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPeriodo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Gratificacion", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("BrutoMensual", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("IndEstado", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("DiasMes", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("DiasLaborados", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Faltas", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return DetUti
    End Function

End Class
