Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_TablaDinamica_Dato" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_TablaDinamica_Dato.svc o l_TablaDinamica_Dato.svc.vb en el Explorador de soluciones e inicie la depuración.
Public Class l_TablaDinamica_Dato
    Implements Il_TablaDinamica_Dato

    Private odTablaDinamica_Dato As New d_TablaDinamica_Dato

    Public Function Obtener(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As e_TablaDinamica_Dato Implements Il_TablaDinamica_Dato.Obtener

        Try
            oeTablaDinamica_Dato = odTablaDinamica_Dato.Obtener(oeTablaDinamica_Dato)
            Return oeTablaDinamica_Dato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As List(Of e_TablaDinamica_Dato) Implements Il_TablaDinamica_Dato.Listar
        Try
            Dim lstTablaDinamica_Dato As New List(Of e_TablaDinamica_Dato)
            lstTablaDinamica_Dato = odTablaDinamica_Dato.Listar(oeTablaDinamica_Dato)
            Return lstTablaDinamica_Dato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean Implements Il_TablaDinamica_Dato.Guardar
        Try
            Dim bol_guardado As Boolean = False
            If Validar(oeTablaDinamica_Dato) Then
                bol_guardado = odTablaDinamica_Dato.Guardar(oeTablaDinamica_Dato)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean Implements Il_TablaDinamica_Dato.Eliminar
        Try
            Return odTablaDinamica_Dato.Eliminar(oeTablaDinamica_Dato)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean
        Try
            With oeTablaDinamica_Dato
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_TablaDinamica_Dato.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_TablaDinamica_Dato.CrearDT
        Dim CtaCtePer As New Data.DataTable
        With CtaCtePer
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdColumna", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NroFila", Type.GetType("System.Int32")))
            .Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("TipoReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdReferencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCrea", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCrea", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return CtaCtePer
    End Function

End Class
