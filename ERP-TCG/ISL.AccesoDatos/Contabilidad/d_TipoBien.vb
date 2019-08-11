Imports ISL.EntidadesWCF
Imports System.Data.SqlClient

Public Class d_TipoBien
    Dim d_DatosConfiguracion As New d_DatosConfiguracion
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_TipoBien
        Try
            Dim oeTipoBien = New e_TipoBien( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Porcentaje").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeTipoBien
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeTipoBien As e_TipoBien) As DataSet
        Try
            Dim ds As DataSet
            With oeTipoBien
                ds = sqlhelper.ExecuteDataset("[CON].[Isp_TipoBien_Listar]" _
                        , .TipoOperacion, .Id, .Codigo, .Nombre)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoBien As e_TipoBien) As e_TipoBien
        Try
            Dim ds As DataSet = ExecuteLST(oeTipoBien)
            If ds.Tables(0).Rows.Count > 0 Then
                oeTipoBien = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeTipoBien
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoBien As e_TipoBien) As List(Of e_TipoBien)
        Try
            Dim ldTipoBien As New List(Of e_TipoBien)
            Dim ds As DataSet = ExecuteLST(oeTipoBien)
            oeTipoBien = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeTipoBien = Cargar(o_Fila)
                    ldTipoBien.Add(oeTipoBien)
                Next
            End If
            Return ldTipoBien
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function Guardar(ByVal oeTipoBien As e_TipoBien) As Boolean
    '    Try
    '        'Using transScope As New TransactionScope()
    '        Dim stResultado() As String
    '        With oeTipoBien
    '            stResultado = sqlhelper.ExecuteScalar("[CON].[Sp_TipoBien_IAE]" _
    '                    , .TipoOperacion _
    '                    , d_DatosConfiguracion.PrefijoID _
    '                    , .Id _
    '                    , .Codigo _
    '                    , .Nombre _
    '                    , .Porcentaje _
    '                    , .Activo _
    '                ).ToString.Split("_")
    '            .Id = stResultado(0)
    '        End With
    '        'transScope.Complete()
    '        'End Using
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function Eliminar(ByVal oeTipoBien As e_TipoBien) As Boolean
    '    Try
    '        With oeTipoBien
    '            bd.ExecuteNonQuery("[CON].[Sp_TipoBien_IAE]" _
    '                   , "E" _
    '                   , "" _
    '                   , .Id _
    '                   , .Codigo _
    '                   , .Nombre _
    '                   , .Porcentaje _
    '                   , .Activo _
    '               )

    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

End Class
