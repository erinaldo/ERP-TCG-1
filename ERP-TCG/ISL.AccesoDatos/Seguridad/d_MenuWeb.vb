'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF


Public Class d_MenuWeb

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_MenuWeb
        Try
            Dim oeMenuWeb = New e_MenuWeb( _
                             o_fila("IdMenu").ToString _
                             , o_fila("Titulo").ToString _
                             , o_fila("ParentId").ToString _
                             , o_fila("URL").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Descripcion").ToString _
                             , o_fila("EsReporte").ToString _
                             , o_fila("Protegido").ToString _
            )
            Return oeMenuWeb
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMenuWeb As e_MenuWeb) As e_MenuWeb

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("Isp_MenuWeb_Listar", "", oeMenuWeb.IdMenu)
            If ds.Tables.Count > 0 Then
                oeMenuWeb = Cargar(ds.Tables(0).Rows(0))
                Return oeMenuWeb
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMenuWeb As e_MenuWeb) As List(Of e_MenuWeb)
        Try
            Dim ld As New List(Of e_MenuWeb)
            Dim ds As DataSet
            With oeMenuWeb
                ds = sqlhelper.ExecuteDataset("Isp_MenuWeb_Listar", .TipoOperacion _
                        , .IdMenu _
                        , .Activo _
                        )
            End With
            oeMenuWeb = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeMenuWeb = Cargar(o_Fila)
                    ld.Add(oeMenuWeb)
                Next
                Return ld
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMenuWeb As e_MenuWeb) As Boolean
        Try
            '

            'With oeMenuWeb
            '    sqlhelper.ExecuteNonQuery("Isp_MenuWeb_IAE", .TipoOperacion, _
            '            .Id _
            '            , .IdMenuGrupo _
            '            , .Codigo _
            '            , .Nombre _
            '            , .Abreviatura _
            '            , .Activo _
            '            , .Orden _
            '            , .Protegido _
            '            , .PrefijoID _
            '        )
            'End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMenuWeb As e_MenuWeb) As Boolean
        'Try
        '    sqlhelper.ExecuteNonQuery("Isp_MenuWeb_IAE", "E", _
        '     "", oeMenuWeb.Id)
        '    Return True
        'Catch ex As Exception
        '    Throw
        '    Return False
        'End Try
    End Function

End Class
