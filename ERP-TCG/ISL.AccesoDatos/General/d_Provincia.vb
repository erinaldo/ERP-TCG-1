'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_Provincia

    Private sqlhelper As New SqlHelper

    Private oeProvincia As New e_Provincia

    Public Function Cargar(ByVal fila As DataRow) As e_Provincia
        Try
            Dim oeProvincia = New e_Provincia(fila("Id"), fila("CODDPTO"), fila("CODPROV"), fila("Nombre"), fila("Activo"))
            Return oeProvincia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProvincia As e_Provincia) As e_Provincia
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_Provincia_Listar", "", oeProvincia.Id)
            If ds.Tables.Count > 0 Then
                oeProvincia = Cargar(ds.Tables(0).Rows(0))
                Return oeProvincia
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeProvincia As e_Provincia) As List(Of e_Provincia)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Provincia)
            With oeProvincia
                ds = sqlhelper.ExecuteDataset("STD.Isp_Provincia_Listar", "", .Id, .CodigoDepartamento, .Codigo,
                        .Nombre, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeProvincia = Cargar(fila)
                        lista.Add(oeProvincia)
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


    Public Function Guardar(ByVal oeProvincia As e_Provincia) As Boolean
        Try
            With oeProvincia
                sqlhelper.ExecuteNonQuery("STD.Isp_Provincia_IAE", .TipoOperacion, .Id, .CodigoDepartamento, .Codigo, .Nombre, .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeProvincia As e_Provincia) As Boolean
        Try
            With oeProvincia
                sqlhelper.ExecuteNonQuery("STD.Isp_Provincia_IAE", "E", "", .Id)
            End With
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
