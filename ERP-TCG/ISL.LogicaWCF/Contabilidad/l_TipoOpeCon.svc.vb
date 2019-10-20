Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_TipoOpecon" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_TipoOpecon.svc o l_TipoOpecon.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract(), Serializable()> _
Public Class l_TipoOpeCon
    Implements Il_TipoOpeCon

    Private odTipoOpeCon As d_TipoOpeCon

    Public Function ComboGrillaCodigo(ByVal TipoOperacion As System.Collections.Generic.List(Of e_TipoOpeCon)) As Object
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_TipoOpeCon In TipoOperacion
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                If item.Nombre.Length > 50 Then
                    newRow("Nombre") = item.Codigo + " - " + item.Nombre.Substring(0, 50)
                Else
                    newRow("Nombre") = item.Codigo + " - " + item.Nombre
                End If
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoOpeCon As e_TipoOpeCon) As e_TipoOpeCon Implements Il_TipoOpeCon.Obtener
        Try
            odTipoOpeCon = New d_TipoOpeCon
            Return odTipoOpeCon.Obtener(oeTipoOpeCon)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoOpeCon As e_TipoOpeCon) As List(Of e_TipoOpeCon) Implements Il_TipoOpeCon.Listar
        Try
            odTipoOpeCon = New d_TipoOpeCon
            Return odTipoOpeCon.Listar(oeTipoOpeCon)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean Implements Il_TipoOpeCon.Guardar
        Try
            odTipoOpeCon = New d_TipoOpeCon
            Dim bol_guardado As Boolean = False
            If Validar(oeTipoOpeCon) Then
                bol_guardado = odTipoOpeCon.Guardar(oeTipoOpeCon)
            End If
            Return bol_guardado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean Implements Il_TipoOpeCon.Eliminar
        Try
            odTipoOpeCon = New d_TipoOpeCon
            Return odTipoOpeCon.Eliminar(oeTipoOpeCon)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal oeTipoOpeCon As e_TipoOpeCon) As Boolean
        Try
            With oeTipoOpeCon
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
