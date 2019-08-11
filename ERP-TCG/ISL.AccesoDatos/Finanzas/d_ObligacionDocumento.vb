Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ObligacionDocumento
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ObligacionDocumento
        Try
            Dim oeObligacionDocumento = New e_ObligacionDocumento( _
                             o_fila("Id").ToString _
                             , o_fila("IdMovimientoDocumento").ToString _
                             , o_fila("IdObligacionFinanciera").ToString _
                             , o_fila("MontoMN").ToString _
                             , o_fila("MontoME").ToString _
                             , o_fila("Activo").ToString _
                            , o_fila("IdCuentaxCyP").ToString _
                            , o_fila("RetencionMN").ToString _
                            , o_fila("RetencionME").ToString
                            )
                            

            Return oeObligacionDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeObligacionDocumento As e_ObligacionDocumento) As e_ObligacionDocumento

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.Isp_ObligacionDocumento_Listar", "", _
            Left(d_DatosConfiguracion.PrefijoID, 1), "", oeObligacionDocumento.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeObligacionDocumento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeObligacionDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeObligacionDocumento As e_ObligacionDocumento) As List(Of e_ObligacionDocumento)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldObligacionDocumento As New List(Of e_ObligacionDocumento)
            Dim ds As DataSet
            With oeObligacionDocumento
                ds = sqlhelper.ExecuteDataset("FIN.Isp_ObligacionDocumento_Listar", "" _
        , Left(d_DatosConfiguracion.PrefijoID, 1), "" _
                        , .Id _
                        , .IdMovimientoDocumento _
                        , .IdObligacionFinanciera _
                        , .MontoMN _
                        , .MontoME _
                        , .Activo _
                        )
            End With
            oeObligacionDocumento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeObligacionDocumento = Cargar(o_Fila)
                    ldObligacionDocumento.Add(oeObligacionDocumento)
                Next
            End If
            Return ldObligacionDocumento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeObligacionDocumento As e_ObligacionDocumento) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeObligacionDocumento
                sqlhelper.ExecuteNonQuery("FIN.Isp_ObligacionDocumento_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdMovimientoDocumento _
                        , .IdObligacionFinanciera _
                        , .MontoMN _
                        , .MontoME _
                        , .Activo _
                        , .IdCuentaxCyP _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .RetencionMN _
                        , .RetencionME _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeObligacionDocumento As e_ObligacionDocumento) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("FIN.Isp_ObligacionDocumento_IAE", "E", _
             "", oeObligacionDocumento.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "FIN.ObligacionDocumento", d_DatosConfiguracion.PrefijoID _
                                  )
            Return IIf(stResultado Is Nothing, d_DatosConfiguracion.PrefijoID & "000000000001", stResultado)
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
