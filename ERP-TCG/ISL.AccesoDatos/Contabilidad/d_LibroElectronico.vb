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

Public Class d_LibroElectronico

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_LibroElectronico
        Try
            Dim oeLibroElectronico = New e_LibroElectronico( _
                             o_fila("Id").ToString _
                             , o_fila("IdPeriodo").ToString _
                             , o_fila("IdTablaContableDet").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("SubTotal1") _
                             , o_fila("SubTotal2") _
                             , o_fila("SubTotal3") _
                             , o_fila("SubTotal4") _
                             , o_fila("SubTotal5") _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeLibroElectronico
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLibroElectronico As e_LibroElectronico) As e_LibroElectronico

        Try
            Dim ds As DataSet
            With oeLibroElectronico
                ds = sqlhelper.ExecuteDataset("CON.Isp_LibroElectronico_Listar", "", .Id, .IdPeriodo, .IdTablaContableDet)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeLibroElectronico = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeLibroElectronico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLibroElectronico As e_LibroElectronico) As List(Of e_LibroElectronico)
        Try
            Dim ldLibroElectronico As New List(Of e_LibroElectronico)
            Dim ds As DataSet
            With oeLibroElectronico
                ds = sqlhelper.ExecuteDataset("CON.Isp_LibroElectronico_Listar", _
                                              .TipoOperacion _
                                            , .Id _
                                            , .IdPeriodo _
                                            , .IdTablaContableDet _
                                            , .IdEstado)
            End With
            oeLibroElectronico = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLibroElectronico = Cargar(o_Fila)
                    ldLibroElectronico.Add(oeLibroElectronico)
                Next
            Else
                ldLibroElectronico = New List(Of e_LibroElectronico)
            End If
            Return ldLibroElectronico
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean
        Try
            Dim odDetalleLE As New d_DetalleLibroElectronico
            Dim id() As String
            Using transScope As New TransactionScope()
                With oeLibroElectronico
                    id = sqlhelper.ExecuteScalar("CON.Isp_LibroElectronico_IAE",
                             .TipoOperacion,
                             .PrefijoID,
                            .Id _
                            , .IdPeriodo _
                            , .IdTablaContableDet _
                            , .IdEstado _
                            , .Observacion _
                            , .SubTotal1 _
                            , .SubTotal2 _
                            , .SubTotal3 _
                            , .SubTotal4 _
                            , .SubTotal5 _
                            , .FechaCreacion _
                            , .UsuarioCreacion _
                            , .Activo
                        ).ToString.Split("-")
                    If id(0) <> "" Then
                        If .TipoOperacion = "I" AndAlso .dtDetalleLE.Rows.Count > 0 Then
                            For Each row As DataRow In .dtDetalleLE.Rows
                                row("IdLibroElectronico") = id(0)
                            Next
                            odDetalleLE.GuardarMasivo(.dtDetalleLE)
                        End If
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_LibroElectronico_IAE", "E", _
             "", oeLibroElectronico.Id)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ActualizarCUO(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_LibroElectronico_IAE", oeLibroElectronico.TipoOperacion, "", oeLibroElectronico.Id, oeLibroElectronico.IdPeriodo)
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
