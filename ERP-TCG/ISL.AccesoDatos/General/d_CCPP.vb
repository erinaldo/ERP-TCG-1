'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_CCPP
    Private sqlhelper As New SqlHelper

    Private oeCCPP As New e_CCPP

    Public Function Cargar(ByVal fila As DataRow) As e_CCPP
        Try
            Dim oeCCPP = New e_CCPP(fila("Id"), _
                                    fila("CCDD"), _
                                    fila("CCPP"), _
                                    fila("CCDI"), _
                                    fila("CODCCPP"), _
                                    fila("NOMBCCPP"), _
                                    fila("Activo"), _
                                    fila("IdEmpresa"))
            Return oeCCPP
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCCPP As e_CCPP) As e_CCPP
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_CCPP_Listar", "", oeCCPP.Id)
            If ds.Tables.Count > 0 Then
                oeCCPP = Cargar(ds.Tables(0).Rows(0))
                Return oeCCPP
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    ''' <remarks>Si el dataset no contiene ningun registro se devuelve un valor nothing,Capa del Sistema:Capa de Acceso a Datos</remarks>
    Public Function Listar(ByVal oeCCPP As e_CCPP) As List(Of e_CCPP)
        Try
            Dim ds As New DataSet
            Dim lista As New List(Of e_CCPP)
            With oeCCPP
                ds = sqlhelper.ExecuteDataset("STD.Isp_CCPP_Listar", _
                                              .TipoOperacion, _
                                              .Id, _
                                              .CodigoDepartamento, _
                                              .CodigoProvincia, _
                                              .CodigoDistrito, _
                                              .Codigo, _
                                              .Nombre, _
                                              .Activo)
                If ds.Tables.Count > 0 Then
                    For Each fila As DataRow In ds.Tables(0).Rows
                        oeCCPP = Cargar(fila)
                        lista.Add(oeCCPP)
                    Next
                End If
                Return lista
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCCPP As e_CCPP) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeCCPP
                sqlhelper.ExecuteNonQuery("STD.Isp_CCPP_IAE", .TipoOperacion, .Id, .CodigoDepartamento, .CodigoProvincia, .CodigoDistrito, .Codigo, .Nombre, .Activo)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeCCPP As e_CCPP) As Boolean
        Try
            Dim resultado As Boolean = False
            With oeCCPP
                sqlhelper.ExecuteNonQuery("STD.Isp_CCPP_IAE", "E", "", .Id)
                resultado = True
            End With
            Return resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
