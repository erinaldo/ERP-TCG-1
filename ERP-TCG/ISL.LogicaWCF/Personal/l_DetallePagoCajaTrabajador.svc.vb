Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_DetallePagoCajaTrabajador" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_DetallePagoCajaTrabajador.svc o l_DetallePagoCajaTrabajador.svc.vb en el Explorador de soluciones e inicie la depuración.
<DataContract(), Serializable()> _
Public Class l_DetallePagoCajaTrabajador
    Implements Il_DetallePagoCajaTrabajador

    Private odDetallePagoCajaTrabajador As New d_DetallePagoCajaTrabajador
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As Boolean Implements Il_DetallePagoCajaTrabajador.Eliminar
        Try
            Return odDetallePagoCajaTrabajador.Eliminar(oeDetallePagoCajaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As Boolean Implements Il_DetallePagoCajaTrabajador.Guardar
        Try
            If Validar(oeDetallePagoCajaTrabajador) Then
                Return odDetallePagoCajaTrabajador.Guardar(oeDetallePagoCajaTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As List(Of e_DetallePagoCajaTrabajador) Implements Il_DetallePagoCajaTrabajador.Listar
        Try
            Return odDetallePagoCajaTrabajador.Listar(oeDetallePagoCajaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As e_DetallePagoCajaTrabajador Implements Il_DetallePagoCajaTrabajador.Obtener
        Try
            Return odDetallePagoCajaTrabajador.Obtener(oeDetallePagoCajaTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetallePagoCajaTrabajador As e_DetallePagoCajaTrabajador) As Boolean Implements Il_DetallePagoCajaTrabajador.Validar
        Try
            With oeDetallePagoCajaTrabajador
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CompletaConCeros(ls_Tex As String, lnCantidad As Integer) As String Implements Il_DetallePagoCajaTrabajador.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function CrearDT() As DataTable Implements Il_DetallePagoCajaTrabajador.CrearDT
        Dim DetPA As New Data.DataTable
        With DetPA
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdPagoCajaTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IndTipo", Type.GetType("System.Int16")))
            .Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("Redondeo", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("TotalPagar", Type.GetType("System.Decimal")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaModifica", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioModifica", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return DetPA
    End Function

    Public Sub DoWork() Implements Il_DetallePagoCajaTrabajador.DoWork
    End Sub

End Class
