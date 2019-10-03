Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConceptoPonderado

    Private sqlhelper As New SqlHelper
    Private oeDetalleCP As New e_DetalleConceptoPonderado
    Private odDetalleCP As New d_DetalleConceptoPonderado

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConceptoPonderado
        Try
            Dim oeConceptoPonderado = New e_ConceptoPonderado( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Tipo") _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeConceptoPonderado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConceptoPonderado As e_ConceptoPonderado) As e_ConceptoPonderado

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ConceptoPonderado_Listar", oeConceptoPonderado.TipoOperacion, oeConceptoPonderado.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeConceptoPonderado = Cargar(ds.Tables(0).Rows(0))
                oeDetalleCP = New e_DetalleConceptoPonderado
                oeDetalleCP.TipoOperacion = ""
                oeDetalleCP.IdConceptoPonderado = oeConceptoPonderado.Id
                oeConceptoPonderado.leDetalle = odDetalleCP.Listar(oeDetalleCP)
            End If
            Return oeConceptoPonderado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As List(Of e_ConceptoPonderado)
        Try
            Dim ldConceptoPonderado As New List(Of e_ConceptoPonderado)
            Dim ds As DataSet
            With oeConceptoPonderado
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConceptoPonderado_Listar", "" _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Tipo _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeConceptoPonderado = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConceptoPonderado = Cargar(o_Fila)
                ldConceptoPonderado.Add(oeConceptoPonderado)
            Next
            Return ldConceptoPonderado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim _idcp As String = ""
            Using TransScope As New TransactionScope()
                With oeConceptoPonderado
                    _idcp = sqlhelper.ExecuteScalar("STD.Isp_ConceptoPonderado_IAE", .TipoOperacion, .PrefijoID, _
                            .Id _
                            , .Codigo _
                            , .Nombre _
                            , .Tipo _
                            , .Vigente _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .FechaModifica _
                            , .UsuarioModifica _
                            , .Activo _
                        )

                    For Each oeDet In .leDetalle
                        oeDet.IdConceptoPonderado = _idcp
                        If oeDet.TipoOperacion <> "" Then
                            If oeDet.TipoOperacion = "E" Then
                                odDetalleCP.Eliminar(oeDet)
                            Else
                                odDetalleCP.Guardar(oeDet)
                            End If
                        End If
                    Next

                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConceptoPonderado As e_ConceptoPonderado) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ConceptoPonderado_IAE", "E", _
             "", oeConceptoPonderado.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
