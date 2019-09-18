Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Sancion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Sancion
        Try
            Dim oeSancion = New e_Sancion( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdConcepto").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("IdResponsable").ToString _
                             , o_fila("Responsable").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Tipo") _
            )
            Return oeSancion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Cargar2(ByVal o_fila As DataRow) As e_Sancion
        Try
            Dim oeSancion = New e_Sancion( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Trabajador").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("Area").ToString _
                             , o_fila("IdConcepto").ToString _
                             , o_fila("Concepto").ToString _
                             , o_fila("IdResponsable").ToString _
                             , o_fila("Responsable").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("Tipo") _
            )
            oeSancion.NroCuota = o_fila("NroCuota").ToString
            Return oeSancion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSancion As e_Sancion) As e_Sancion

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Sancion_Listar", oeSancion.TipoOperacion, oeSancion.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeSancion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSancion As e_Sancion) As List(Of e_Sancion)
        Try
            Dim ldSancion As New List(Of e_Sancion)
            Dim ds As DataSet
            With oeSancion
                ds = sqlhelper.ExecuteDataset("TES.Isp_Sancion_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .IdArea _
                        , .IdConcepto _
                        , .IdResponsable _
                        , .Activo _
                        , .IdGrupo _
                        , .IdEstado _
                        , ._FechaInicio _
                        , ._FechaFin _
                        , ._CadenaIdGrupo _
                        , ._GrupoDesc _
                        )
            End With

            If oeSancion.TipoOperacion.Trim = "2" Then
                oeSancion = Nothing
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeSancion = Cargar2(o_Fila)
                    ldSancion.Add(oeSancion)
                Next
            Else
                oeSancion = Nothing
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeSancion = Cargar(o_Fila)
                    ldSancion.Add(oeSancion)
                Next
            End If
            Return ldSancion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSancion As e_Sancion) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odReqOASan As New d_ReqOAMSancion
            Dim stResultado() As String
            With oeSancion
                stResultado = sqlhelper.ExecuteScalar("TES.Isp_Sancion_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                            .Id _
                                            , .IdTrabajador _
                                            , .IdArea _
                                            , .IdConcepto _
                                            , .IdResponsable _
                                            , .Monto _
                                            , .Glosa & "|" & .NroCuota & "|" & .IdUsuarioAprueba & "|" & .FechaAprobacion _
                                            , .Fecha _
                                            , .Activo _
                                            , .UsuarioCreacion _
                                            , .IdGrupo _
                                            , .IdEstado).ToString.Split("_")
                .Id = stResultado(0)
                If .oeReqOASan.TipoOperacion = "I" Then
                    .oeReqOASan.IdSancion = .Id
                    odReqOASan.Guardar(.oeReqOASan)
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarLista(ByVal leSancion As List(Of e_Sancion))
        Try
            Using TransScope As New TransactionScope()
                For Each oeSanc In leSancion
                    Guardar(oeSanc)
                Next
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeSancion As e_Sancion) As Boolean
        Try
            With oeSancion
                sqlhelper.ExecuteNonQuery("TES.Isp_Sancion_IAE", "E", _
                            "", .Id _
                        , .IdTrabajador _
                        , .IdArea _
                        , .IdConcepto _
                        , .IdResponsable _
                        , .Monto _
                        , .Glosa _
                        , .Fecha _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IdGrupo _
                        , .IdEstado _
                        )
            End With

            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
