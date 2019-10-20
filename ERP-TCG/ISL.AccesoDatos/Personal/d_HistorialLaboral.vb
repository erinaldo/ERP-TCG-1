'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_HistorialLaboral

    Dim oeHistorialLaboral As New e_HistorialLaboral
    Dim odHistorialLaboral As New d_HistorialLaboral

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_HistorialLaboral
        Try
            Dim oeHistorialLaboral = New e_HistorialLaboral( _
                                            o_fila("Id"), _
                                            o_fila("IdTrabajador"), _
                                            o_fila("FechaIngreso"), _
                                            o_fila("FechaCese"), _
                                            o_fila("IdMotivoCese"), _
                                            o_fila("Observaciones"), _
                                            o_fila("Activo"), _
                                            o_fila("UsuarioCreacion"))
            Return oeHistorialLaboral
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Function Obtener(ByVal oeHistorialLaboral As e_HistorialLaboral) As e_HistorialLaboral
        Try
            Dim ds As DataSet
            With oeHistorialLaboral
                ds = sqlhelper.ExecuteDataset("PER.Isp_HistorialLaboral_Listar", .TipoOperacion, _
                                              .Id, _
                                              .IdTrabajador, _
                                              .Activo)
            End With
            oeHistorialLaboral = New e_HistorialLaboral
            If ds.Tables(0).Rows.Count > 0 Then
                oeHistorialLaboral = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeHistorialLaboral
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Function Listar(ByVal oeHistorialLaboral As e_HistorialLaboral) As List(Of e_HistorialLaboral)
        Try
            Dim ldHistorialLaboral As New List(Of e_HistorialLaboral)
            Dim ds As New DataSet
            With oeHistorialLaboral
                ds = sqlhelper.ExecuteDataset("PER.Isp_HistorialLaboral_Listar", "", .Id, .IdTrabajador, .Activo)
            End With
            oeHistorialLaboral = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHistorialLaboral = Cargar(o_Fila)
                    ldHistorialLaboral.Add(oeHistorialLaboral)
                Next
                Return ldHistorialLaboral
            Else
                ldHistorialLaboral = New List(Of e_HistorialLaboral)
                Return ldHistorialLaboral
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Function Guardar(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean

        Try
            With oeHistorialLaboral
                sqlhelper.ExecuteNonQuery("PER.ISP_oeHistorialLaboral_IAE", .TipoOperacion, _
                .PrefijoID, .Id, .IdTrabajador, .FechaIngreso, .FechaCese, .IdMotivoCese, .Observaciones, .Activo, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Overloads Function Eliminar(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean
        Try
            With oeHistorialLaboral
                sqlhelper.ExecuteNonQuery("PER.Isp_HistorialLaboral_IAE" _
                                          , "E" _
                                          , .Id)
            End With
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

End Class
