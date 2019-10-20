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

Public Class d_Concepto_Prestamo

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Concepto_Prestamo
        Try
            Dim oeConcepto_Prestamo = New e_Concepto_Prestamo( _
                             o_fila("Id").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Tipo").ToString _
                             , o_fila("IdConceptoPadre").ToString _
                             , o_fila("IdArea").ToString _
                             , o_fila("NombreArea").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
            )
            Return oeConcepto_Prestamo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As e_Concepto_Prestamo

        Try
            Dim ds As DataSet
            With oeConcepto_Prestamo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Concepto_Prestamo_Listar", .TipoOperacion, .Id, .Codigo, .Nombre, .Tipo)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeConcepto_Prestamo = Cargar(ds.Tables(0).Rows(0))
            End If

            Dim oe As New e_Concepto_Prestamo
            ' Dim le As New List(Of e_Concepto_Prestamo)
            oe.TipoOperacion = ""
            oe.Tipo = 2
            oe.IdConceptoPadre = oeConcepto_Prestamo.Id
            oeConcepto_Prestamo.leConceptoSancion = Listar(oe)

            Return oeConcepto_Prestamo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As List(Of e_Concepto_Prestamo)
        Try
            Dim ldConcepto_Prestamo As New List(Of e_Concepto_Prestamo)
            Dim ds As DataSet
            With oeConcepto_Prestamo
                ds = sqlhelper.ExecuteDataset("TES.Isp_Concepto_Prestamo_Listar", .TipoOperacion _
                        , .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Tipo _
                        , .IdConceptoPadre _
                        , .IdArea _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion )
            End With
            oeConcepto_Prestamo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConcepto_Prestamo = Cargar(o_Fila)
                ldConcepto_Prestamo.Add(oeConcepto_Prestamo)
            Next
            Return ldConcepto_Prestamo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarSancion(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As Boolean
        Try
            With oeConcepto_Prestamo
                sqlhelper.ExecuteNonQuery("TES.Isp_Concepto_Prestamo_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .Codigo _
                        , .Nombre _
                        , .Tipo _
                        , .IdConceptoPadre _
                        , .IdArea _
                        , .Activo _
                        , .FechaCreacion _
                        , .UsuarioCreacion
                    ).ToString.Split("_")
            End With

            Return True

        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function GuardarPrestamo(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope
                With oeConcepto_Prestamo
                    stResultado = sqlhelper.ExecuteScalar("TES.Isp_Concepto_Prestamo_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Codigo _
                            , .Nombre _
                            , .Tipo _
                            , .IdConceptoPadre _
                            , .IdArea _
                            , .Activo _
                            , .FechaCreacion _
                            , .UsuarioCreacion
                        ).ToString.Split("_")

                    For Each oeConcepSancion As e_Concepto_Prestamo In .leConceptoSancion
                        oeConcepSancion.IdConceptoPadre = stResultado(0)
                        oeConcepSancion.PrefijoID = oeConcepto_Prestamo.PrefijoID '@0001
                        GuardarSancion(oeConcepSancion)
                    Next

                End With
                transScope.Complete()
                Return True
            End Using

        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConcepto_Prestamo As e_Concepto_Prestamo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Concepto_Prestamo_IAE", "E", _
             "", oeConcepto_Prestamo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function


End Class
