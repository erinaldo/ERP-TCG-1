Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Horarios
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_Horarios
        Try
            Dim oeHorarios = New e_Horarios(o_fila("Id").ToString _
                             , o_fila("IdTipoHorario").ToString _
                             , o_fila("TipoHorario").ToString _
                             , o_fila("HoraInicio").ToString _
                             , o_fila("HoraFin").ToString _
                             , o_fila("Lunes").ToString _
                             , o_fila("Martes").ToString _
                             , o_fila("Miercoles").ToString _
                             , o_fila("Jueves").ToString _
                             , o_fila("Viernes").ToString _
                             , o_fila("Sabado").ToString _
                             , o_fila("Domingo").ToString _
                             , o_fila("Vigente").ToString _
                             , o_fila("IndHoraExtra").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString)
            Return oeHorarios
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeHorarios As e_Horarios) As e_Horarios

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_Horarios_Listar", oeHorarios.TipoOperacion, oeHorarios.Id, oeHorarios.IdTipoHorario)
            oeHorarios = New e_Horarios
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeHorarios = Cargar(ds.Tables(0).Rows(0))
                    Return oeHorarios
                Else
                    Return oeHorarios
                End If
            Else
                Return oeHorarios
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeHorarios As e_Horarios) As List(Of e_Horarios)
        Try
            Dim ldHorarios As New List(Of e_Horarios)
            Dim ds As DataSet
            With oeHorarios
                ds = sqlhelper.ExecuteDataset("PER.Isp_Horarios_Listar", .TipoOperacion, .Id, .IdTipoHorario)
            End With
            oeHorarios = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeHorarios = Cargar(o_Fila)
                    ldHorarios.Add(oeHorarios)
                Next
                Return ldHorarios
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeHorarios As e_Horarios) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeHorarios
                sqlhelper.ExecuteNonQuery("PER.Isp_Horarios_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdTipoHorario _
                        , .HoraInicio _
                        , .HoraFin _
                        , .Lunes _
                        , .Martes _
                        , .Miercoles _
                        , .Jueves _
                        , .Viernes _
                        , .Sabado _
                        , .Domingo _
                        , .Vigente _
                        , .IndHoraExtra _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeHorarios As e_Horarios) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_Horarios_IAE", "E", _
             "", oeHorarios.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
