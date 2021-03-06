﻿'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_Asiento_Existencia
    Private sqlhelper As New SqlHelper

    Public Function Guardar(ByVal oeAsiento_Existencia As e_Asiento_Existencia) As Boolean
        Dim stResultado() As String
        Try
            Using transScope As New TransactionScope()
                With oeAsiento_Existencia
                    stResultado = sqlhelper.ExecuteScalar("CON.Isp_Asiento_Existencia_IAE", _
                                            .TipoOperacion, _
                                            .PrefijoID, _
                                            .Id, _
                                            .IdAsientoDoc, _
                                            .IdAsientoExis, _
                                            .Activo, _
                                            .FechaCreacion, _
                                            .IdUsuarioCrea).ToString.Split("_")

                End With
                transScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
