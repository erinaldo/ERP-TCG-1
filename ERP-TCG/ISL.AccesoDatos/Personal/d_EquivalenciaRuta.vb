'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_EquivalenciaRuta
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_EquivalenciaRuta
        Try
            Dim oeEquivalenciaRuta = New e_EquivalenciaRuta(o_fila("Id").ToString _
                             , o_fila("IdRuta").ToString _
                             , o_fila("IdOrigen").ToString _
                             , o_fila("Origen").ToString _
                             , o_fila("IdDestino").ToString _
                             , o_fila("Destino").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Monto").ToString _
                             , o_fila("Equivalencia").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString)
            Return oeEquivalenciaRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As e_EquivalenciaRuta
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_EquivalenciaRuta_Listar", oeEquivalenciaRuta.TipoOperacion, oeEquivalenciaRuta.Id, oeEquivalenciaRuta.IdRuta)
            If ds.Tables(0).Rows.Count > 0 Then
                oeEquivalenciaRuta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEquivalenciaRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As List(Of e_EquivalenciaRuta)
        Try
            Dim ldEquivalenciaRuta As New List(Of e_EquivalenciaRuta)
            Dim ds As DataSet
            With oeEquivalenciaRuta
                ds = sqlhelper.ExecuteDataset("PER.Isp_EquivalenciaRuta_Listar", .TipoOperacion _
                        , .Id _
                        , .IdRuta )
            End With
            oeEquivalenciaRuta = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeEquivalenciaRuta = Cargar(o_Fila)
                ldEquivalenciaRuta.Add(oeEquivalenciaRuta)
            Next
            Return ldEquivalenciaRuta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean
        Try
            With oeEquivalenciaRuta
                sqlhelper.ExecuteNonQuery("PER.Isp_EquivalenciaRuta_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdRuta _
                        , .Cuenta _
                        , .Monto _
                        , .Equivalencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeEquivalenciaRuta As e_EquivalenciaRuta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_EquivalenciaRuta_IAE", "E", _
             "", oeEquivalenciaRuta.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtEquivalenciaRuta As DataTable) As Boolean
        Try
            sqlhelper.InsertarMasivo("PER.EquivalenciaRuta", dtEquivalenciaRuta)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta(ByVal PrefijoID As String) As String
        Try
            Dim stResultado As String
            stResultado = sqlhelper.ExecuteScalar("STD.Isp_UltimoId_Inserta", "PER.EquivalenciaRuta", PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
