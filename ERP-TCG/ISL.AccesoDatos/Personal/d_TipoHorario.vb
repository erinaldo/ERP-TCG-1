Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_TipoHorario

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoHorario
        Try
            Dim oeTipoHorario = New e_TipoHorario( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
            )
            Return oeTipoHorario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoHorario As e_TipoHorario) As e_TipoHorario

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_TipoHorario_Listar", oeTipoHorario.TipoOperacion, oeTipoHorario.Id, oeTipoHorario.Nombre)
            oeTipoHorario = New e_TipoHorario
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count > 0 Then
                    oeTipoHorario = Cargar(ds.Tables(0).Rows(0))
                    Return oeTipoHorario
                Else
                    Return oeTipoHorario
                End If
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoHorario As e_TipoHorario) As List(Of e_TipoHorario)
        Try
            Dim ldTipoHorario As New List(Of e_TipoHorario)
            Dim ds As DataSet
            With oeTipoHorario
                ds = sqlhelper.ExecuteDataset("PER.Isp_TipoHorario_Listar", .TipoOperacion _
                        , .Id)
            End With
            oeTipoHorario = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoHorario = Cargar(o_Fila)
                    ldTipoHorario.Add(oeTipoHorario)
                Next
                Return ldTipoHorario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal loTipoHorario As List(Of e_TipoHorario))
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_TipoHorario In loTipoHorario
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                newRow("Nombre") = item.Nombre
                ds.Rows.Add(newRow)
            Next
            If ds.Rows.Count = 0 Then Throw New Exception("Información no registrada")
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoHorario As e_TipoHorario) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeTipoHorario
                sqlhelper.ExecuteNonQuery("PER.Isp_TipoHorario_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .Activo _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeTipoHorario As e_TipoHorario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_TipoHorario_IAE", "E", _
             "", oeTipoHorario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
