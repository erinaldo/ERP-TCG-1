'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_SeguroContraRiesgo
    Implements Il_SeguroContraRiesgo

    Dim odSeguroContraRiesgo As New d_SeguroContraRiesgo

    Public Function Obtener(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As e_SeguroContraRiesgo Implements Il_SeguroContraRiesgo.Obtener
        Try
            Return odSeguroContraRiesgo.Obtener(oeSeguroContraRiesgo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As List(Of e_SeguroContraRiesgo) Implements Il_SeguroContraRiesgo.Listar
        Try
            Return odSeguroContraRiesgo.Listar(oeSeguroContraRiesgo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean Implements Il_SeguroContraRiesgo.Validar
        Try
            With oeSeguroContraRiesgo
                If .IdEmpresa = "" Then Throw New Exception("Seleccione Empresa")
                If .Descripcion = "" Then Throw New Exception("Escriba una Descripcion")
                If .Importe = 0 Then Throw New Exception("Ingrese Importe")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean Implements Il_SeguroContraRiesgo.Guardar
        Try
            If Validar(oeSeguroContraRiesgo) Then
                Return odSeguroContraRiesgo.Guardar(oeSeguroContraRiesgo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeSeguroContraRiesgo As e_SeguroContraRiesgo) As Boolean Implements Il_SeguroContraRiesgo.Eliminar
        Try
            Return odSeguroContraRiesgo.Eliminar(oeSeguroContraRiesgo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
