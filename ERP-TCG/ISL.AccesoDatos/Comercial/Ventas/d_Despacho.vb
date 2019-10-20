'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class d_Despacho
    Private bd As New SqlHelper
    Private odDespachoOperacion As New d_DespachoOperaciones

    Private Function Cargar(Fila As DataRow) As e_Despacho
        Try
            Dim oeDespacho = New e_Despacho With {
                             .Id = Fila("Id").ToString _
                             , .IdCentro = Fila("IdCentro").ToString _
                             , .Codigo = Fila("Codigo").ToString _
                             , .Fecha = Fila("Fecha") _
                             , .ProdReal = Fila("ProdReal") _
                             , .ProdProgramado = Fila("ProdProgramado") _
                             , .ProdTotal = Fila("ProdTotal") _
                             , .IdEstado = Fila("IdEstado").ToString.Trim _
                             , .Glosa = Fila("Glosa") _
                             , .Observacion = Fila("Observacion").ToString _
                             , .UsuarioCrea = Fila("UsuarioCrea").ToString _
                             , .FechaCrea = Fila("FechaCrea") _
                             , .UsuarioModifica = Fila("UsuarioModifica").ToString _
                             , .FechaModifica = Fila("FechaModifica") _
                             , .Activo = Fila("Activo") _
            }
            Return oeDespacho
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(oeDespacho As e_Despacho) As DataSet
        Try
            Dim ds As DataSet
            bd = New SqlHelper
            With oeDespacho
                ds = bd.ExecuteDataset("[OPE].[Isp_Despacho_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdCentro _
                        , .Codigo _
                        , .Fecha _
                        , .FechaHasta _
                        , .FechaValida _
                        , .IdEstado _
                        , .Glosa _
                        , .Observacion _
                        , .Activo _
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(oeDespacho As e_Despacho) As e_Despacho
        Try
            Dim ds As DataSet = ExecuteLST(oeDespacho)
            If ds.Tables(0).rows.Count > 0 Then
                If ds.Tables(0).rows.Count > 1 Then
                    Throw New Exception("Verificar funcion obtener retorna mas de un valor")
                Else
                    oeDespacho = Cargar(ds.Tables(0).Rows(0))
                End If
            Else
                oeDespacho = New e_Despacho
            End If
            Return oeDespacho
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeDespacho As e_Despacho) As List(Of e_Despacho)
        Try
            Dim lstDespacho As New List(Of e_Despacho)
            Dim ds As DataSet = ExecuteLST(oeDespacho)
            oeDespacho = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDespacho = Cargar(o_Fila)
                    lstDespacho.Add(oeDespacho)
                Next
            End If
            Return lstDespacho
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(oeDespacho As e_Despacho) As Boolean
        Try
            Using transScope As New TransactionScope()
                odDespachoOperacion = New d_DespachoOperaciones
                Dim IdResultado As String
                With oeDespacho
                    IdResultado = bd.ExecuteScalar("[OPE].[Isp_Despacho_IAE]" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , .IdCentro _
                            , .Codigo _
                            , .Fecha _
                            , .ProdReal _
                            , .ProdProgramado _
                            , .ProdTotal _
                            , .IdEstado _
                            , .Glosa _
                            , .Observacion _
                            , .UsuarioCrea _
                            , .Activo
                        ).ToString()
                    .Id = IdResultado
                    For Each DespachoOperaciones As e_DespachoOperaciones In .ListDespachoOperaciones
                        DespachoOperaciones.PrefijoID = oeDespacho.PrefijoID '@0001
                        With oeDespacho
                            If DespachoOperaciones.TipoOperacion = "E" Then
                                DespachoOperaciones.UsuarioCrea = .UsuarioCrea
                                odDespachoOperacion.Eliminar(DespachoOperaciones)
                            Else
                                DespachoOperaciones.TipoOperacion = "I"
                                DespachoOperaciones.IdDespacho = .Id
                                DespachoOperaciones.UsuarioCrea = .UsuarioCrea
                                odDespachoOperacion.Guardar(DespachoOperaciones)
                            End If
                        End With
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeDespacho As e_Despacho) As Boolean
        Try
            Using transScope As New TransactionScope()
                Dim oeDespachoOperaciones As New e_DespachoOperaciones
                oeDespachoOperaciones.IdDespacho = oeDespacho.Id
                Dim loDespachoOperacion As List(Of e_DespachoOperaciones)
                odDespachoOperacion = New d_DespachoOperaciones
                loDespachoOperacion = odDespachoOperacion.Listar(oeDespachoOperaciones)
                For Each Op As e_DespachoOperaciones In loDespachoOperacion
                    odDespachoOperacion.Eliminar(Op)
                Next
                With oeDespacho
                    bd.ExecuteNonQuery("[OPE].[Isp_Despacho_IAE]" _
                            , "E" _
                            , "" _
                            , .Id _
                            , .IdCentro _
                            , .Codigo _
                            , .Fecha _
                            , .ProdReal _
                            , .ProdProgramado _
                            , .ProdTotal _
                            , .IdEstado _
                            , .Glosa _
                            , .Observacion _
                            , .UsuarioCrea _
                            , .Activo _
                       )
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
