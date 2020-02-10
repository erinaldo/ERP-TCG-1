Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Transactions

<DataContract(), Serializable()>
Public Class l_ComprobantePagoElectronico_Resumen
    Implements Il_ComprobantePagoElectronico_Resumen
    Private odComprobantePagoElectronico_Resumen As New d_ComprobantePagoElectronico_Resumen
    Private odMovDoc_Imp As d_MovimientoDocumento_Impresion

    Public Function Obtener(ByVal Item As e_ComprobantePagoElectronico_Resumen) As e_ComprobantePagoElectronico_Resumen Implements Il_ComprobantePagoElectronico_Resumen.Obtener
        Try
            Return odComprobantePagoElectronico_Resumen.Obtener(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As List(Of e_ComprobantePagoElectronico_Resumen) Implements Il_ComprobantePagoElectronico_Resumen.Listar
        Try
            Return odComprobantePagoElectronico_Resumen.Listar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDataSet(oe As e_ComprobantePagoElectronico_Resumen) As Data.DataSet Implements Il_ComprobantePagoElectronico_Resumen.ListarDataSet
        Try
            'ADO = New d_Resumen_Doc_Electronico
            Return odComprobantePagoElectronico_Resumen.ListarDS(oe)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal Item As e_ComprobantePagoElectronico_Resumen, lo As List(Of e_ComprobantePagoElectronico)) As Boolean Implements Il_ComprobantePagoElectronico_Resumen.Guardar
        Try
            Validar(Item)
            Dim oeMovDoc_Imp As e_MovimientoDocumento_Impresion
            Using TransScope As New TransactionScope()
                Item = odComprobantePagoElectronico_Resumen.Guardar(Item)
                odMovDoc_Imp = New d_MovimientoDocumento_Impresion
                For Each detalle In lo
                    oeMovDoc_Imp = New e_MovimientoDocumento_Impresion
                    With oeMovDoc_Imp
                        .TipoOperacion = "R"
                        .IdMovimientoDocumento = detalle.Id
                        .UsuarioCreacion = Item.UsuarioCrea
                        .IdComprobantePagoElectronico_Resumen = Item.Id
                    End With
                    odMovDoc_Imp.Guardar(oeMovDoc_Imp)
                Next
                TransScope.Complete()
            End Using
            'Return Item
        Catch ex As Exception
            Throw ex
        End Try
        Return True
    End Function

    Public Function Eliminar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean Implements Il_ComprobantePagoElectronico_Resumen.Eliminar
        Try
            Return odComprobantePagoElectronico_Resumen.Eliminar(Item)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function Validar(ByVal Item As e_ComprobantePagoElectronico_Resumen) As Boolean
        Try
            With Item
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class