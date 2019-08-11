Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ValesRendir

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ValesRendir
        Try
            Dim oeValesRendir = New e_ValesRendir(o_fila("Seleccion").ToString _
                             , o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Importe").ToString _
                             , o_fila("NroVale").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdTrabajadorAutoriza").ToString _
                             , o_fila("Autoriza").ToString _
                             , o_fila("IndRendido") _
                             , o_fila("IdCentro").ToString _
                             , o_fila("Centro").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("Ingreso") _
                             , o_fila("Egreso"))
            Return oeValesRendir
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeValesRendir As e_ValesRendir) As e_ValesRendir

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_ValesRendir_Listar", oeValesRendir.TipoOperacion, oeValesRendir.Id)
            oeValesRendir = New e_ValesRendir
            If ds.Tables(0).Rows.Count > 0 Then
                oeValesRendir = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeValesRendir
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeValesRendir As e_ValesRendir) As List(Of e_ValesRendir)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldValesRendir As New List(Of e_ValesRendir)
            Dim ds As DataSet
            With oeValesRendir
                ds = sqlhelper.ExecuteDataset("TES.Isp_ValesRendir_Listar", .TipoOperacion _
                                              , .Id _
                        , .IndRendido _
                        , .Importe _
                        , .NroVale _
                        , .Fecha _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .IdCentro _
                        , .IdCuentaCorriente _
                        , .IdCaja)
            End With
            oeValesRendir = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeValesRendir = Cargar(o_Fila)
                    ldValesRendir.Add(oeValesRendir)
                Next
            End If
            Return ldValesRendir
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeValesRendir As e_ValesRendir) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            With oeValesRendir
                id = sqlhelper.ExecuteScalar("TES.Isp_ValesRendir_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdTrabajador _
                        , .Glosa _
                        , .Importe _
                        , .NroVale _
                        , .IndRendido _
                        , .IdTrabajadorAutoriza _
                        , .Fecha _
                        , "01/01/1901" _
                        , .UsuarioCreacion _
                        , .IdVale _
                        , .IdCentro _
                        , .IdCuentaCorriente _
                        , .IndCerrado _
                        , .FechaCierre, .IdCaja)
                .Id = id
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Rendir(ByVal oeValesRendir As e_ValesRendir, ByVal oeValesRendido As e_ValesRendir) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id1 As String = ""
            Dim id2 As String = ""
            Using TransScope As New TransactionScope()
                With oeValesRendir
                    id1 = sqlhelper.ExecuteScalar("TES.Isp_ValesRendir_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .IdTrabajador _
                            , .Glosa _
                            , .Importe _
                            , .NroVale _
                            , .IndRendido _
                            , .IdTrabajadorAutoriza _
                            , .Fecha _
                            , "01/01/1901" _
                            , .UsuarioCreacion _
                            , .IdVale _
                            , .IdCentro _
                            , .IdCuentaCorriente _
                            , .IndCerrado _
                            , .FechaCierre)
                    .Id = id1
                End With
                With oeValesRendido
                    .IdVale = id1
                    id2 = sqlhelper.ExecuteScalar("TES.Isp_ValesRendir_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                            .Id _
                            , .IdTrabajador _
                            , .Glosa _
                            , .Importe _
                            , .NroVale _
                            , .IndRendido _
                            , .IdTrabajadorAutoriza _
                            , .Fecha _
                            , "01/01/1901" _
                            , .UsuarioCreacion _
                            , .IdVale _
                            , .IdCentro _
                            , .IdCuentaCorriente _
                            , .IndCerrado _
                            , .FechaCierre, .IdCaja)
                    .Id = id2
                End With
                TransScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeValesRendir As e_ValesRendir) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_ValesRendir_IAE", "E", _
             "", oeValesRendir.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
