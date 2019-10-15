'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DocumentoVenta
    Implements Il_DocumentoVenta
    Dim odDocumentoVenta As New d_DocumentoVenta
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeDocumentoVenta As EntidadesWCF.e_DocumentoVenta) As Boolean Implements Il_DocumentoVenta.Eliminar
        Try
            Return odDocumentoVenta.Eliminar(oeDocumentoVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDocumentoVenta As EntidadesWCF.e_DocumentoVenta) As Boolean Implements Il_DocumentoVenta.Guardar
        Try
            If Validar(oeDocumentoVenta) Then
                Return odDocumentoVenta.Guardar(oeDocumentoVenta)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDocumentoVenta As EntidadesWCF.e_DocumentoVenta) As System.Collections.Generic.List(Of EntidadesWCF.e_DocumentoVenta) Implements Il_DocumentoVenta.Listar
        Try
            Return odDocumentoVenta.Listar(oeDocumentoVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDocumentoVenta As EntidadesWCF.e_DocumentoVenta) As EntidadesWCF.e_DocumentoVenta Implements Il_DocumentoVenta.Obtener
        Try
            Return odDocumentoVenta.Obtener(oeDocumentoVenta)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDocumentoVenta As EntidadesWCF.e_DocumentoVenta) As Boolean Implements Il_DocumentoVenta.Validar
        Try
            With oeDocumentoVenta
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoDocumento, "Seleccione Tipo Dcumento")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoPago, "Seleccion Tipo Pago")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "Seleccione Moneda")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCliente, "Seleccione Cliente")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Serie, "Ingrese Serie")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Ingrese Numero")
                If .TotalEfectivo >= .TotalFacturado Then Throw New Exception("El monto igresado es mayor al monto facturado")
                If .TotalFacturado = .TotalEfectivo Then .IdEstado = "TERMINADO"
                If .TotalFacturado - .TotalEfectivo > 0 Then .IdEstado = "PARCIAL"
                If .TotalFacturado - .TotalCredito = 0 Then .IdEstado = "GENERADO"
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
