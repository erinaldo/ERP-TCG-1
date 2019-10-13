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
Public Class l_TipoCambio
    Implements Il_TipoCambio

    Dim odTipoCambio As New d_TipoCambio
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeTipoCambio As EntidadesWCF.e_TipoCambio) As Boolean Implements Il_TipoCambio.Eliminar
        Try
            Return odTipoCambio.Eliminar(oeTipoCambio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeTipoCambio As EntidadesWCF.e_TipoCambio) As Boolean Implements Il_TipoCambio.Guardar
        Try
            If Validar(oeTipoCambio) Then
                Return odTipoCambio.Guardar(oeTipoCambio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeTipoCambio As EntidadesWCF.e_TipoCambio) As System.Collections.Generic.List(Of EntidadesWCF.e_TipoCambio) Implements Il_TipoCambio.Listar
        Try
            Return odTipoCambio.Listar(oeTipoCambio)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoCambio As EntidadesWCF.e_TipoCambio) As EntidadesWCF.e_TipoCambio Implements Il_TipoCambio.Obtener
        Try
            Return odTipoCambio.Obtener(oeTipoCambio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeTipoCambio As EntidadesWCF.e_TipoCambio) As Boolean Implements Il_TipoCambio.Validar
        Try
            With oeTipoCambio
                If oeTipoCambio.CambioCompra <= 0 Then Throw New Exception("Falta ingresar el tipo de cambio de compra")
                If oeTipoCambio.CambioVenta <= 0 Then Throw New Exception("Falta ingresar el tipo de cambio de venta")

                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMonedaOrigen, "Falta seleccionar la moneda de origen")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMonedaDestino, "Falta seleccionar la moneda de destino")

                ValidarDuplicado(oeTipoCambio.Id, oeTipoCambio.FechaCambio)

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Validar que no exista más de un tipo de cambio por día
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ValidarDuplicado(ByVal id As String, ByVal fecha As Date) As Boolean Implements Il_TipoCambio.ValidarDuplicado
        Dim oeTipoCambio As New e_TipoCambio
        Try
            If String.IsNullOrEmpty(fecha) Then Throw New Exception("No se ha definido que información se va a verificar si existe")
            oeTipoCambio.FechaCambio = fecha
            oeTipoCambio.TipoOperacion = "D"
            Dim lista As New List(Of e_TipoCambio)
            lista = odTipoCambio.Listar(oeTipoCambio)
            If lista.Count > 0 AndAlso Not String.IsNullOrEmpty(lista.Item(0).Id) AndAlso lista.Item(0).Id <> id Then Throw New Exception("El tipo de cambio de " & fecha.ToShortDateString & ", ya se encuentra registrado")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
