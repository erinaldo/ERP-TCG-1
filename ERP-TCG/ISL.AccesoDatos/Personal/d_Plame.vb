'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF

Public Class d_Plame
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_PlameRem
        Try
            Dim obj = New e_PlameRem()
            obj.TipoDocumento = o_fila("TipoDocumento").ToString.Trim
            obj.Dni = o_fila("DNI").ToString.Trim
            obj.CodigoSunat = o_fila("CodigoSunat").ToString.Trim
            obj.Devengado = o_fila("Importe1")
            obj.Pagado = o_fila("Importe2")
            obj.IdTrabajador = o_fila("IdTrabajador")
            Return obj
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oePlame As e_PlameRem) As List(Of e_PlameRem)
        Try
            Dim lista As New List(Of e_PlameRem)
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("PER.Isp_Plame_Listar", oePlame.TipoOperacion, oePlame.IdPeriodo)
            oePlame = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oePlame = Cargar(o_Fila)
                lista.Add(oePlame)
            Next
            Return lista
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
