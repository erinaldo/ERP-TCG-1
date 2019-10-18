'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_Distrito
    Private sqlhelper As New SqlHelper

    Private oeDistrito As New e_Distrito

    Public Function Cargar(ByVal fila As DataRow) As e_Distrito
        Try
            Dim oeDistrito = New e_Distrito(fila("Id"), fila("CODDPTO"), fila("CODPROV"), fila("CODDIST"), fila("Nombre"), fila("Activo"))
            Return oeDistrito
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Obtener(ByVal oeDistrito As e_Distrito) As e_Distrito
        Try

            'Dim datos As New 
            'Dim tablita As List(Of e_Tabla) = datos.Obtener_Estructura_Tabla("Direccion", "STD")

            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Distrito_Listar", "", oeDistrito.Id)
            If ds.Tables.Count > 0 Then
                oeDistrito = Cargar(ds.Tables(0).Rows(0))
                Return oeDistrito
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeDistrito As e_Distrito) As List(Of e_Distrito)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Distrito)
            With oeDistrito
                ds = sqlhelper.ExecuteDataset("STD.Isp_Distrito_Listar", "", .Id, .CodigoDepartamento, .CodigoProvincia, .Codigo,
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeDistrito = Cargar(fila)
                        lista.Add(oeDistrito)
                    Next
                    Return lista
                Else
                    Return Nothing
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeDistrito As e_Distrito) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeDistrito
                sqlhelper.ExecuteNonQuery("STD.Isp_Distrito_IAE", .TipoOperacion, .Id, .CodigoDepartamento, .CodigoProvincia, .Codigo, .Nombre, .Activo)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeDistrito As e_Distrito) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeDistrito
                sqlhelper.ExecuteNonQuery("STD.Isp_Distrito_IAE", "E", "", .Id)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
