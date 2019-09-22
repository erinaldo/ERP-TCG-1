
Imports ISL.EntidadesWCF

Public Class d_TablaDinamica_Dato

    Dim d_DatosConfiguracion As New d_DatosConfiguracion

    Private Function Cargar(ByVal o_fila As DataRow) As e_TablaDinamica_Dato
        Try
            Dim oeTablaDinamica_Dato = New e_TablaDinamica_Dato(
                             o_fila("Id").ToString _
                             , o_fila("IdColumna").ToString _
                             , o_fila("Columna").ToString _
                             , o_fila("IndClave") _
                             , o_fila("NroFila") _
                             , o_fila("Descripcion").ToString _
                             , o_fila("TipoReferencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("FechaCrea") _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo")
            )
            Return oeTablaDinamica_Dato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As DataSet
        Try
            Dim bd As New SqlHelper
            Dim ds As DataSet
            With oeTablaDinamica_Dato
                ds = bd.ExecuteDataset("[GEN].[Sp_TablaDinamica_Dato_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .IdColumna _
                        , .NroFila _
                        , .Descripcion _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .FechaCrea _
                        , .UsuarioCrea _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As e_TablaDinamica_Dato
        Try
            Dim ds As DataSet = ExecuteLST(oeTablaDinamica_Dato)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTablaDinamica_Dato = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTablaDinamica_Dato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As List(Of e_TablaDinamica_Dato)
        Try
            Dim ldTablaDinamica_Dato As New List(Of e_TablaDinamica_Dato)
            Dim ds As DataSet = ExecuteLST(oeTablaDinamica_Dato)
            oeTablaDinamica_Dato = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTablaDinamica_Dato = Cargar(o_Fila)
                    ldTablaDinamica_Dato.Add(oeTablaDinamica_Dato)
                Next
            End If
            Return ldTablaDinamica_Dato
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean
        Try
            Dim bd As New SqlHelper
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeTablaDinamica_Dato
                stResultado = bd.ExecuteScalar("[GEN].[Sp_TablaDinamica_Dato_IAE]" _
                        , .TipoOperacion _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdColumna _
                        , .NroFila _
                        , .Descripcion _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .UsuarioCrea _
                        , .Activo
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeTablaDinamica_Dato As e_TablaDinamica_Dato) As Boolean
        Try
            Dim bd As New SqlHelper
            With oeTablaDinamica_Dato
                bd.ExecuteNonQuery("[GEN].[Sp_TablaDinamica_Dato_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdColumna _
                       , .NroFila _
                       , .Descripcion _
                       , .TipoReferencia _
                       , .IdReferencia _
                       , .UsuarioCrea _
                       , .Activo
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function UltimoIdInserta() As String
        Try
            Dim bd As New SqlHelper
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim stResultado As String
            stResultado = bd.ExecuteScalar("GEN.Sp_UltimoId_Inserta", "GEN.TablaDinamica_Dato", d_DatosConfiguracion.PrefijoID)
            Return stResultado
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarMasivo(ByVal dtTDDato As DataTable) As Boolean
        Try
            'Dim odMasivo As New d_CopiaMasiva
            'odMasivo.InsertarMasivo("GEN.TablaDinamica_dato", dtTDDato)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
