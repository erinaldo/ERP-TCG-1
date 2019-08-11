Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DerechoHabiente

    Private sqlhelper As New SqlHelper
    Private odPersona As New d_Persona

    Private Function Cargar(ByVal o_fila As DataRow) As e_DerechoHabiente
        Try
            Dim valorSexo As Integer = IIf(IsDBNull(o_fila("Sexo")), 1, o_fila("Sexo"))
            Dim objSexo As New e_Sexo(CType(valorSexo, String))
            Dim oeDerechoHabiente = New e_DerechoHabiente( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("IdPersona").ToString _
                             , o_fila("Dni").ToString _
                             , o_fila("ApellidoPaterno").ToString _
                             , o_fila("ApellidoMaterno").ToString _
                             , o_fila("Nombre").ToString _
                             , objSexo _
                             , o_fila("FechaNacimiento") _
                             , o_fila("IndVinculo").ToString _
                             , o_fila("TipoDocAcredita").ToString _
                             , o_fila("NroDocumentoAcredita").ToString _
                             , o_fila("MesConcepcion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo") _
            )
            Return oeDerechoHabiente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDerechoHabiente As e_DerechoHabiente) As e_DerechoHabiente

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_DerechoHabiente_Listar", "", oeDerechoHabiente.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDerechoHabiente = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDerechoHabiente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDerechoHabiente As e_DerechoHabiente) As List(Of e_DerechoHabiente)
        Try
            Dim ldDerechoHabiente As New List(Of e_DerechoHabiente)
            Dim ds As DataSet
            With oeDerechoHabiente
                ds = sqlhelper.ExecuteDataset("PER.Isp_DerechoHabiente_Listar", "" _
                        , .Id _
                        , .IdTrabajador _
                        , .IdPersona _
                        , .IndVinculo _
                        , .NroDocumentoAcredita _
                        , .MesConcepcion _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeDerechoHabiente = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDerechoHabiente = Cargar(o_Fila)
                ldDerechoHabiente.Add(oeDerechoHabiente)
            Next
            Return ldDerechoHabiente
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDerechoHabiente As e_DerechoHabiente) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeDerechoHabiente
                If oeDerechoHabiente.oePersona IsNot Nothing Then
                    odPersona.Guardar(oeDerechoHabiente.oePersona)
                    oeDerechoHabiente.IdPersona = oeDerechoHabiente.oePersona.Id
                    sqlhelper.ExecuteNonQuery("PER.Isp_DerechoHabiente_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                       .Id _
                       , .IdTrabajador _
                       , .IdPersona _
                       , .IndVinculo _
                       , .TipoDocAcredita _
                       , .NroDocumentoAcredita _
                       , .MesConcepcion _
                       , .FechaCreacion _
                       , .UsuarioCreacion _
                       , .Activo _
                   )
                Else
                    Throw New Exception("Datos de Persona Incompleta")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDerechoHabiente As e_DerechoHabiente) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_DerechoHabiente_IAE", "E", _
             "", oeDerechoHabiente.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
