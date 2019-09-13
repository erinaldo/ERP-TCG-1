Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ParticipacionAccion
    Private sqlhelper As New SqlHelper

    Public Function Guardar(ByVal oeParticipacionAccion As e_ParticipacionAccion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id() As String
            Using transScope As New TransactionScope()
                With oeParticipacionAccion
                    id = sqlhelper.ExecuteScalar("CON.ISP_Participacion_Accion_IAE" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , .TipoDoc _
                            , .NroDoc _
                            , .TipoAccion _
                            , .IdTrabajador _
                            , .NroAcciones _
                            , .PorcParticipacion _
                            , .Fecha _
                            , .FechaBaja _
                            , .UsuarioCreacion _
                            , .FechaCreacion _
                            , .Activo _
                        ).ToString.Split("-")
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar(ByVal o_fila As DataRow) As e_ParticipacionAccion
        Try
            Dim oeParticipacionAccion As New e_ParticipacionAccion(o_fila("Id"), _
                                          o_fila("TipoDoc"), _
                                          o_fila("NroDoc"), _
                                          o_fila("CodigoDoc"), _
                                          o_fila("Accionista"), _
                                          o_fila("TipoAccion"), _
                                           o_fila("CodigoAcc"), _
                                          o_fila("NroAcciones"), _
                                          o_fila("PorcParticipacion"), _
                                          o_fila("Activo"), _
                                          o_fila("Fecha"), _
                                          o_fila("FechaBaja"))
            Return oeParticipacionAccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar2(ByVal o_fila As DataRow) As e_ParticipacionAccion
        Try
            Dim oeParticipacionAccion As New e_ParticipacionAccion(o_fila("Id"), _
                                          o_fila("IdTrabajador"), _
                                          o_fila("IdTipoDocumento"), _
                                          o_fila("NroDoc"), _
                                          o_fila("IdTipoAccion"), _
                                          o_fila("NroAcciones"), _
                                           o_fila("Activo"), _
                                          o_fila("Fecha"), _
                                           o_fila("FechaBaja"))
            Return oeParticipacionAccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeParticipacionAccion As e_ParticipacionAccion) As List(Of e_ParticipacionAccion)
        Try
            Dim lstParticipacionAccion As New List(Of e_ParticipacionAccion)
            Dim ds As DataSet

            ds = sqlhelper.ExecuteDataset("CON.ISP_Participacion_Accion_Listar" _
                                        , oeParticipacionAccion.TipoOperacion _
                                        , oeParticipacionAccion.Id _
                                        , oeParticipacionAccion.TipoDoc _
                                        , oeParticipacionAccion.NroDoc _
                                        , oeParticipacionAccion.TipoAccion _
                                        , oeParticipacionAccion.IdTrabajador _
                                        , oeParticipacionAccion.NroAcciones _
                                        , oeParticipacionAccion.PorcParticipacion _
                                        , oeParticipacionAccion.Fecha _
                                        , oeParticipacionAccion.FechaBaja _
                                        , oeParticipacionAccion.UsuarioCreacion _
                                        , oeParticipacionAccion.FechaCreacion _
                                        , oeParticipacionAccion.Activo)

            If ds.Tables.Count > 0 Then
                If oeParticipacionAccion.TipoOperacion = "" Then
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeParticipacionAccion = Cargar(o_Fila)
                        lstParticipacionAccion.Add(oeParticipacionAccion)
                    Next
                Else
                    For Each o_Fila As DataRow In ds.Tables(0).Rows
                        oeParticipacionAccion = Cargar2(o_Fila)
                        lstParticipacionAccion.Add(oeParticipacionAccion)
                    Next
                End If

                Return lstParticipacionAccion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
