Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Detraccion_Det

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Detraccion_Det
        Try
            Dim oeDetraccion_Det = New e_Detraccion_Det(o_fila("Id").ToString _
                             , o_fila("IdVenta").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("FechaAplicado").ToString _
                             , o_fila("IndPendiente").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeDetraccion_Det
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetraccion_Det As e_Detraccion_Det) As e_Detraccion_Det
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_Detraccion_Det_Listar", "", oeDetraccion_Det.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeDetraccion_Det = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetraccion_Det
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDetraccion_Det As e_Detraccion_Det) As List(Of e_Detraccion_Det)
        Try
            Dim ldDetraccion_Det As New List(Of e_Detraccion_Det)
            Dim ds As DataSet
            With oeDetraccion_Det
                ds = sqlhelper.ExecuteDataset("CON.Isp_Detraccion_Det_Listar", "" _
                        , .Id _
                        , .IdVenta _
                        , .Monto _
                        , .FechaAplicado _
                        , .Activo _
                        , .UsuarioCreacion _
                        )
            End With
            oeDetraccion_Det = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetraccion_Det = Cargar(o_Fila)
                ldDetraccion_Det.Add(oeDetraccion_Det)
            Next
            Return ldDetraccion_Det
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDetraccion_Det As e_Detraccion_Det) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDetraccion_Det
                sqlhelper.ExecuteNonQuery("CON.Isp_Detraccion_Det_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdVenta _
                        , .Monto _
                        , .FechaAplicado _
                        , .Pendiente _
                        , .Activo _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function GuardarLista(ByVal leDetraccionDet As List(Of e_Detraccion_Det)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeDetracDet As e_Detraccion_Det In leDetraccionDet
                    Guardar(oeDetracDet)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetraccion_Det As e_Detraccion_Det) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_Detraccion_Det_IAE", "E", _
             "", oeDetraccion_Det.Id, oeDetraccion_Det.IdVenta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarLista(ByVal leDetraccionDet As List(Of e_Detraccion_Det)) As Boolean
        Try
            Using TransScope As New TransactionScope()
                For Each oeDetracDet As e_Detraccion_Det In leDetraccionDet
                    Eliminar(oeDetracDet)
                Next
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class