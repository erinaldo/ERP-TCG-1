'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_Departamento
    Private sqlhelper As New SqlHelper

    Private oeDepartamento As New e_Departamento

    Public Function Cargar(ByVal fila As DataRow) As e_Departamento
        Try
            Dim oeDepartamento = New e_Departamento(fila("Id"), fila("CODDPTO"), fila("Nombre"), fila("Activo"))
            Return oeDepartamento
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeDepartamento As e_Departamento) As e_Departamento
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Departamento_Listar", "", oeDepartamento.Id)
            If ds.Tables.Count > 0 Then
                oeDepartamento = Cargar(ds.Tables(0).Rows(0))
                Return oeDepartamento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDepartamento As e_Departamento) As List(Of e_Departamento)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Departamento)
            With oeDepartamento
                ds = sqlhelper.ExecuteDataset("STD.Isp_Departamento_Listar", "", .Id, .Codigo,
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeDepartamento = Cargar(fila)
                        lista.Add(oeDepartamento)
                    Next
                    Return lista
                Else
                    Return Nothing
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDepartamento As e_Departamento) As Boolean
        Try
            With oeDepartamento
                sqlhelper.ExecuteNonQuery("STD.Isp_Departamento_IAE", .TipoOperacion, .Id, .Codigo, .Nombre, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeDepartamento As e_Departamento) As Boolean
        Try
            With oeDepartamento
                sqlhelper.ExecuteNonQuery("STD.Isp_Departamento_IAE", .TipoOperacion, .Id)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
