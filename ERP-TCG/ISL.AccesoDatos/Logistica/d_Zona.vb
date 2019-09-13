Imports ISL.EntidadesWCF


Public Class d_Zona
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal fila As DataRow) As e_Zona
        Try
            Dim oeZona = New e_Zona(fila("Seleccion"), _
                                    fila("Id"), _
                                    fila("Almacen").ToString, _
                                    fila("Activo"), _
                                    fila("IdDependencia").ToString, _
                                    fila("Zona").ToString, _
                                    fila("SubZona").ToString, _
                                    fila("Ubicacion").ToString, _
                                    fila("Seccion").ToString, _
                                    fila("Nivel").ToString, _
                                    fila("IdAlmacen").ToString)
            Return oeZona
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeZona As e_Zona) As e_Zona

        Try
            Dim ds As DataSet
            With oeZona
                ds = sqlhelper.ExecuteDataset( _
                                                "ALM.Isp_Zona_Listar", _
                                                  "", _
                                                  .Id, _
                                                  "" )
            End With
            If ds.Tables.Count > 0 Then
                oeZona = Cargar(ds.Tables(0).Rows(0))
                Return oeZona
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeZona As e_Zona) As List(Of e_Zona)
        Try
            Dim ds As DataSet
            Dim lista As New List(Of e_Zona)
            With oeZona
                ds = sqlhelper.ExecuteDataset("ALM.Isp_Zona_Listar", _
                                              "", _
                                              .Id, _
                                              .IdAlmacen)
            End With
            If ds.Tables.Count > 0 Then
                For Each fila As DataRow In ds.Tables(0).Rows
                    oeZona = Cargar(fila)
                    lista.Add(oeZona)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeZona As e_Zona)

        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        Dim newRow1 As DataRow = ds.NewRow()
        newRow1("Id") = "            "
        newRow1("Nombre") = "NINGUNA"
        ds.Rows.Add(newRow1)
        For Each item As e_Zona In Listar(oeZona)
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Zona
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function Guardar(ByVal oeZona As e_Zona) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            With oeZona
                sqlhelper.ExecuteScalar("ALM.Isp_Zona_IAE", _
                                          .TipoOperacion, _
                                          .PrefijoID, _
                                          .Id, _
                                          .IdDependencia, _
                                          .IdAlmacen, _
                                          .Zona, _
                                          .SubZona, _
                                          .Ubicacion, _
                                          .Seccion, _
                                          .Nivel, _
                                          Date.Now, _
                                          .UsuarioCreacion, _
                                          .Activo)
                Return True
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeZona As e_Zona) As Boolean
        Try
            With oeZona
                sqlhelper.ExecuteNonQuery("ALM.Isp_Zona_IAE", _
                                          "E", _
                                          "", _
                                          oeZona.Id)
                Return True
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class