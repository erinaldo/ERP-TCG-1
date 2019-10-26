'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConceptosGenerales
    Private oeConceptosGenerales As e_ConceptosGenerales
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_ConceptosGenerales
        Try
            Dim oeConceptosGenerales = New e_ConceptosGenerales(o_fila("Id"), o_fila("IdProcesoNegocio"), o_fila("Codigo"), o_fila("Nombre"), o_fila("Abreviatura"), o_fila("Orden"), o_fila("Activo"), o_fila("Protegido"), o_fila("UsuarioCreacion"))
            Return oeConceptosGenerales
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Obtener(ByVal oeConceptosGenerales As e_ConceptosGenerales) As e_ConceptosGenerales
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ConceptosGenerales_Listar", "", oeConceptosGenerales.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConceptosGenerales = Cargar(ds.Tables(0).Rows(0))
                Return oeConceptosGenerales
            Else
                oeConceptosGenerales = New e_ConceptosGenerales
                Return oeConceptosGenerales
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As List(Of e_ConceptosGenerales)
        Try
            Dim ldConceptosGenerales As New List(Of e_ConceptosGenerales)
            Dim ds As New DataSet
            With oeConceptosGenerales
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConceptosGenerales_Listar", "", .Id, .IdProcesoNegocio, .Codigo, .Nombre, .Abreviatura)
            End With
            oeConceptosGenerales = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeConceptosGenerales = Cargar(o_Fila)
                    ldConceptosGenerales.Add(oeConceptosGenerales)
                Next
                Return ldConceptosGenerales
            Else
                ldConceptosGenerales = New List(Of e_ConceptosGenerales)
                Return ldConceptosGenerales
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean
        Try
            With oeConceptosGenerales
                sqlhelper.ExecuteNonQuery("STD.ISP_ConceptosGenerales_IAE", .TipoOperacion, _
                .PrefijoID, .Id, .IdProcesoNegocio, .Codigo, .Nombre, .Abreviatura, .Orden, .Protegido, .UsuarioCreacion)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Eliminar(ByVal oeConceptosGenerales As e_ConceptosGenerales) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.ISP_ConceptosGenerales_IAE", oeConceptosGenerales.TipoOperacion, "", oeConceptosGenerales.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
