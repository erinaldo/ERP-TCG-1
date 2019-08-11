Imports ISL.EntidadesWCF

''' <summary>
''' Clase: HistorialLaboral
''' Fecha: 23/03/2012
''' </summary>
''' <remarks></remarks>
Public Class d_HistorialLaboral

    Dim oeHistorialLaboral As New e_HistorialLaboral
    Dim odHistorialLaboral As New d_HistorialLaboral

    Private sqlhelper As New SqlHelper

    ''' <summary>
    ''' Cargar un HistorialLaboral
    ''' </summary>
    ''' <param name="o_fila">Fila de Dato de HistorialLaboral</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Obtiene un HistorialLaboral
    ''' </summary>
    ''' <param name="oeHistorialLaboral">Objeto HistorialLaboral</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Listar HistorialLaboral
    ''' </summary>
    ''' <param name="oeHistorialLaboral">Objeto HistorialLaboral</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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

    ''' <summary>
    ''' Guardar Datos de HistorialLaboral
    ''' </summary>
    ''' <param name="oeHistorialLaboral">Objeto HistorialLaboral</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Guardar(ByVal oeHistorialLaboral As e_HistorialLaboral) As Boolean
        Dim d_DatosConfiguracion As New d_DatosConfiguracion
        Try
            With oeHistorialLaboral
                sqlhelper.ExecuteNonQuery("PER.ISP_oeHistorialLaboral_IAE", .TipoOperacion, _
                d_DatosConfiguracion.PrefijoID, .Id, .IdTrabajador, .FechaIngreso, .FechaCese, .IdMotivoCese, .Observaciones, .Activo, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Eliminar un HistorialLaboral
    ''' </summary>
    ''' <param name="oeHistorialLaboral">Objeto HistorialLaboral</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
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
