'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF


Public Class d_Centro
    Private oeCentro As New e_Centro
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Centro
        Try
            Dim oeCentro = New e_Centro( _
                             o_fila("Id").ToString.Trim _
                             , o_fila("Codigo").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("IdLugar").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Abreviatura").ToString _
                             , o_fila("Principal").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeCentro
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Obtener(ByVal oeCentro As e_Centro) As e_Centro
        Try

            Dim ds As DataSet
            Dim Prefijo As String = IIf(oeCentro.TipoOperacion = "3", oeCentro.Abreviatura, oeCentro.PrefijoID)
            ds = sqlhelper.ExecuteDataset("STD.Isp_Centro_Listar", oeCentro.TipoOperacion _
                                        , oeCentro.Id _
                                        , oeCentro.Codigo _
                                        , oeCentro.Nombre _
                                        , 1 _
                                        , "" _
                                        , Prefijo)

            If ds.Tables(0).Rows.Count > 0 Then
                oeCentro = Cargar(ds.Tables(0).Rows(0))
            Else
                oeCentro = New e_Centro
            End If
            Return oeCentro
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCentroSAlmacen(ByVal oeCentro As e_Centro) As e_Centro
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Centro_Listar", oeCentro.TipoOperacion, oeCentro.Id, "", "", oeCentro.Activo, oeCentro.IdAlmacen)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeCentro = Cargar(ds.Tables(0).Rows(0))
            Else
                oeCentro = New e_Centro
            End If
            Return oeCentro
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeCentro As e_Centro) As List(Of e_Centro)
        Try
            Dim ldCentro As New List(Of e_Centro)
            Dim ds As DataSet
            With oeCentro
                ds = sqlhelper.ExecuteDataset("STD.Isp_Centro_Listar", .TipoOperacion _
                                        , .Id _
                                        , .Codigo _
                                        , .Nombre _
                                        , .Activo)

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeCentro = Cargar(fila)
                        ldCentro.Add(oeCentro)
                    Next
                Else
                    ldCentro = New List(Of e_Centro)
                End If
            End With
            Return ldCentro

        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Guardar(ByVal oeCentro As e_Centro) As Boolean
        Try

            With oeCentro
                sqlhelper.ExecuteNonQuery("STD.Isp_Centro_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                        .Id _
                                        , .Codigo _
                                        , .IdEmpresa _
                                        , .IdLugar _
                                        , .Nombre _
                                        , .Abreviatura _
                                        , .Principal _
                                        , .FechaCreacion _
                                        , .UsuarioCreacion _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function



    Public Function Eliminar(ByVal oeCentro As e_Centro) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Centro_IAE", _
                                      "E", _
                                        "", _
                                        oeCentro.Id.Trim)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaCentro As List(Of e_Centro))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Centro In ListaCentro
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

End Class
