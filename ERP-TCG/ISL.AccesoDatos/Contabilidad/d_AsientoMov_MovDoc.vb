'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_AsientoMov_MovDoc
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_AsientoMov_MovDoc
        Try
            Dim oeAsientoMov_MovDoc = New e_AsientoMov_MovDoc( _
                             o_fila("Id").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IdAsientoMovimiento").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IdCuentaxCyP").ToString _
            )
            Return oeAsientoMov_MovDoc
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As e_AsientoMov_MovDoc

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoMov_MovDoc_Listar", "", oeAsientoMov_MovDoc.Id, oeAsientoMov_MovDoc.IdMovimientoDocumento.Trim)
            If ds.Tables(0).rows.Count > 0 Then
                oeAsientoMov_MovDoc = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAsientoMov_MovDoc
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As List(Of e_AsientoMov_MovDoc)
        Try
            Dim ldAsientoMov_MovDoc As New List(Of e_AsientoMov_MovDoc)
            Dim ds As DataSet
            With oeAsientoMov_MovDoc
                ds = sqlhelper.ExecuteDataset("CON.Isp_AsientoMov_MovDoc_Listar", "" _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IdAsientoMovimiento _
                        , .Activo _
                        )
            End With
            oeAsientoMov_MovDoc = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeAsientoMov_MovDoc = Cargar(o_Fila)
                    ldAsientoMov_MovDoc.Add(oeAsientoMov_MovDoc)
                Next
            End If
            Return ldAsientoMov_MovDoc
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAsientoMov_MovDoc
                sqlhelper.ExecuteNonQuery("CON.Isp_AsientoMov_MovDoc_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdMovimientoDocumento _
                        , .IdAsientoMovimiento _
                        , .Activo _
                        , .IdCuentaxCyP _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeAsientoMov_MovDoc As e_AsientoMov_MovDoc) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_AsientoMov_MovDoc_IAE", "E", _
             "", oeAsientoMov_MovDoc.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Trae Ultimo id de la tabla CON.AsientoMov_MovDoc para casos de insercion masiva
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.AsientoMov_MovDoc", Left(PrefijoID, 1) & "SI"
                                  )
            Return IIf(stResultado Is Nothing, Left(PrefijoID, 1) & "SI" & "000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function UltimoIdInsertar(ByVal PrefijoID As String) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "CON.AsientoMov_MovDoc", PrefijoID
                                  )
            Return IIf(stResultado Is Nothing, PrefijoID & "000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Guarda esta tabla en masivo
    ''' </summary>
    ''' <param name="DTAsientoMov_MovDoc">Estructura de Con.AsientoMov_MovDoc</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GuardarMasivo(ByVal DTAsientoMov_MovDoc As DataTable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            sqlhelper.InsertarMasivo("CON.AsientoMov_MovDoc", DTAsientoMov_MovDoc, False)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
