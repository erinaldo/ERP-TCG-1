Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Turno

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Turno
        Try
            Dim oeTurno = New e_Turno( _
                             o_Fila("Id").ToString _
                             , o_Fila("HoraInicio").ToString _
                             , o_Fila("HoraSalida").ToString _
                             , o_Fila("Dia").ToString _
                             , o_Fila("Turno").ToString _
                             , o_Fila("FechaCreacion").ToString _
                             , o_Fila("UsuarioCreacion").ToString _
                             , o_Fila("Activo").ToString _
            )
            Return oeTurno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTurno As e_Turno) As e_Turno

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Turno_Listar", "", oeTurno.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeTurno = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTurno
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTurno As e_Turno) As List(Of e_Turno)
        Try
            Dim ldTurno As New List(Of e_Turno)
            Dim ds As DataSet
            With oeTurno
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Turno_Listar", "" _
                        , .Id _
                        , .HoraInicio _
                        , .HoraSalida _
                        , .Dia _
                        , .Turno _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeTurno = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeTurno = Cargar(o_Fila)
                ldTurno.Add(oeTurno)
            Next
            Return ldTurno
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTurno As e_Turno) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTurno
                sqlhelper.ExecuteNonQuery("SGD.Isp_Turno_IAE", .TipoOperacion, _
                        .Id _
                        , .HoraInicio _
                        , .HoraSalida _
                        , .Dia _
                        , .Turno _
                        , .UsuarioCreacion _
                        , .Activo _
                        , .PrefijoID _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTurno As e_Turno) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("SGD.Isp_Turno_IAE", "E", oeTurno.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
