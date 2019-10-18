'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF

Public Class d_Impuesto

    Private sqlHelper As New SqlHelper
    Private oeImpuesto As New e_Impuesto

    Public Function IGV(ByVal fecha As Date) As e_Impuesto
        Try
            Dim ds As New DataSet
            ds = sqlHelper.ExecuteDataset("[STD].[Isp_IGV_Obtener]", fecha)
            If ds.Tables.Count > 0 Then
                oeImpuesto = Cargar(ds.Tables(0).Rows(0))
                Return oeImpuesto
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeImpuesto As e_Impuesto) As e_Impuesto
        Try
            Dim ds As New DataSet
            With oeImpuesto
                ds = sqlHelper.ExecuteDataset("STD.Isp_Impuesto_Listar", "", .Id, .Codigo, .Nombre, .Abreviatura, .FechaInicio, .Activo)
            End With
            If ds.Tables.Count > 0 Then
                oeImpuesto = Cargar(ds.Tables(0).Rows(0))
                Return oeImpuesto
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cargar(ByVal fila As DataRow) As e_Impuesto
        Try
            If Not IsDate(fila("fechaFin")) Then
                fila("fechaFin") = Date.Now
            End If
            Dim oeImpuesto = New e_Impuesto(fila("id"), fila("codigo"), fila("nombre"), fila("abreviatura"), fila("porcentaje"), fila("fechaInicio"), fila("fechaFin"), fila("Activo"))
            Return oeImpuesto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeImpuesto As e_Impuesto) As List(Of e_Impuesto)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_Impuesto)
            With oeImpuesto
                ds = sqlHelper.ExecuteDataset("STD.Isp_Impuesto_Listar", "", .Id, .Codigo, _
                        .Nombre, .Abreviatura, .FechaInicio, .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeImpuesto = Cargar(fila)
                        lista.Add(oeImpuesto)
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

    Public Function Guardar(ByVal oeImpuesto As e_Impuesto) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeImpuesto
                sqlHelper.ExecuteNonQuery("STD.Isp_Impuesto_IAE", .TipoOperacion, .Id, .Codigo, .Nombre, .Abreviatura, .Porcentaje, .FechaInicio, .FechaFin, .Activo)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeImpuesto As e_Impuesto) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeImpuesto
                sqlHelper.ExecuteNonQuery("STD.Isp_Impuesto_IAE", "E", "", .Id)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
