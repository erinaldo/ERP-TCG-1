Imports ISL.EntidadesWCF

''' <summary>
''' Clase parcial de lo que es ubigeo para acceder a la información de los Direccions.
''' Fecha de Actualizacion:17/11/2011
''' </summary>
''' <remarks>Clase que controla los metodos de accesos la tabla Ubigeo,Capa del Sistema: Capa de Acceso a Datos.</remarks>
Public Class d_Direccion

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Direccion
        Try
            Dim oeDireccion = New e_Direccion( _
                             o_fila("Id").ToString _
                             , o_fila("IdTipoVia").ToString _
                             , o_fila("Via").ToString _
                             , o_fila("Numero").ToString _
                             , o_fila("Departamento").ToString _
                             , o_fila("NumeroInterior").ToString _
                             , o_fila("Manzana").ToString _
                             , o_fila("Lote").ToString _
                             , o_fila("Kilometro").ToString _
                             , o_fila("Block").ToString _
                             , o_fila("Etapa").ToString _
                             , o_fila("IdTipoZona").ToString _
                             , o_fila("Zona").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("CCPP").ToString _
                             , o_fila("NOMBCCPP").ToString _
                             , o_fila("Activo") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("IdLugar").ToString _
                             , o_fila("Lugar").ToString _
                             , o_fila("CentroCosto").ToString _
                             , o_fila("CentroAsistenciaEsSalud") _
                             , o_fila("IdPais").ToString)
            Return oeDireccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDireccion As e_Direccion) As e_Direccion

        Try
            Dim ds As DataSet
            With oeDireccion
                ds = sqlhelper.ExecuteDataset("STD.Isp_Direccion_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTipoVia _
                        , .Via _
                        , .Numero _
                        , .NumeroInterior _
                        , .IdTipoZona _
                        , .Zona _
                        , .Referencia _
                        , .CCPP _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeDireccion = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDireccion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDireccion As e_Direccion) As List(Of e_Direccion)
        Try
            Dim ldDireccion As New List(Of e_Direccion)
            Dim ds As DataSet
            With oeDireccion
                ds = sqlhelper.ExecuteDataset("STD.Isp_Direccion_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTipoVia _
                        , .Via _
                        , .Numero _
                        , .NumeroInterior _
                        , .IdTipoZona _
                        , .Zona _
                        , .Referencia _
                        , .CCPP _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDireccion = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeDireccion = Cargar(o_Fila)
                    ldDireccion.Add(oeDireccion)
                Next
            Else
                ldDireccion = New List(Of e_Direccion)
            End If

            Return ldDireccion
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDireccion As e_Direccion) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim id As String = ""
            With oeDireccion
                id = sqlhelper.ExecuteScalar("STD.Isp_Direccion_IAE", .TipoOperacion, _
                        .Id _
                        , .IdTipoVia _
                        , .Via _
                        , .Numero _
                        , .Departamento _
                        , .NumeroInterior _
                        , .Manzana _
                        , .Lote _
                        , .Kilometro _
                        , .Block _
                        , .Etapa _
                        , .IdTipoZona _
                        , .Zona _
                        , .Referencia _
                        , .CCPP _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .IdLugar _
                        , .PrefijoID _
                        , .CentroCosto _
                        , .CentroAsistenciaEsSalud _
                        , .IdPais)
            End With
            Return id
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDireccion As e_Direccion) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_Direccion_IAE", "E", oeDireccion.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
