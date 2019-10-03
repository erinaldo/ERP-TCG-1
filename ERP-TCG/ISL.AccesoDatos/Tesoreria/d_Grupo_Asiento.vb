Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Grupo_Asiento

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Grupo_Asiento
        Try
            Dim oeGrupo_Asiento = New e_Grupo_Asiento( _
                             o_fila("Id").ToString _
                             , o_fila("IdGrupo").ToString _
                             , o_fila("IdAsientoMovimiento").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeGrupo_Asiento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGrupo_Asiento As e_Grupo_Asiento) As e_Grupo_Asiento

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Grupo_Asiento_Listar", "", oeGrupo_Asiento.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeGrupo_Asiento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGrupo_Asiento
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGrupo_Asiento As e_Grupo_Asiento) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGrupo_Asiento
                sqlhelper.ExecuteNonQuery("TES.Isp_Grupo_Asiento_IAE", .TipoOperacion, _
                        .Id _
                        , .IdGrupo _
                        , .IdAsientoMovimiento _
                        , .ImporteTotal _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                        , .IdCheque
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarLista(ByVal loGrupoAsiento As List(Of e_Grupo_Asiento), ByVal oeAsiento As e_Asiento) As String
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Using TransScope As New TransactionScope()
                Dim odGrupo As New d_Grupo
                Dim oeGrupo As New e_Grupo
                For Each oeGrupoAsiento As e_Grupo_Asiento In loGrupoAsiento
                    oeGrupo = New e_Grupo
                    With oeGrupoAsiento
                        If .Saldo - .ImportePagar = 0 Then
                            oeGrupo.TipoOperacion = "R"
                            oeGrupo.IdEstado = "REEMBOLSADO"
                        Else
                            oeGrupo.TipoOperacion = "P"
                            oeGrupo.Saldo = .Saldo - .ImportePagar
                        End If
                        oeGrupo.Id = .IdGrupo
                        oeGrupo.IdChequexCobrar = .IdCheque
                        oeGrupo.NroCheque = .NroCheque
                    End With
                    odGrupo.Guardar(oeGrupo)
                Next
                Dim odAsiento As New d_Asiento
                odAsiento.Guardar(oeAsiento, Nothing, False)
                TransScope.Complete()
            End Using
            Return oeAsiento._IdMovimientoCajaBanco
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
