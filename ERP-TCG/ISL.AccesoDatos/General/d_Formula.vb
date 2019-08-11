Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Formula

    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Formula
        Try
            Dim oeFormula = New e_Formula( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("DatoTrabajador").ToString _
                             , o_fila("Parametros").ToString _
                             , o_fila("Constantes").ToString _
                             , o_fila("Variables").ToString _
                             , o_fila("Instrucciones").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeFormula
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeFormula As e_Formula) As e_Formula

        Try
            Dim ds As DataSet
            With oeFormula
                ds = SqlHelper.ExecuteDataset("STD.Isp_Formula_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeFormula = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeFormula
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFormula As e_Formula) As List(Of e_Formula)
        Try
            Dim ldFormula As New List(Of e_Formula)
            Dim ds As DataSet
            With oeFormula
                ds = SqlHelper.ExecuteDataset("STD.Isp_Formula_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Parametros _
                        , .Constantes _
                        , .Instrucciones _
                        , .Descripcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeFormula = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeFormula = Cargar(o_Fila)
                ldFormula.Add(oeFormula)
            Next
            Return ldFormula
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFormula As e_Formula) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idFor As String = ""
            With oeFormula
                _idFor = SqlHelper.ExecuteScalar("STD.Isp_Formula_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .DatoTrabajador _
                        , .Parametros _
                        , .Constantes _
                        , .Variables _
                        , .Instrucciones _
                        , .Descripcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
                .Id = _idFor
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeFormula As e_Formula) As Boolean
        Try
            SqlHelper.ExecuteNonQuery("STD.Isp_Formula_IAE", "E", _
             "", oeFormula.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
