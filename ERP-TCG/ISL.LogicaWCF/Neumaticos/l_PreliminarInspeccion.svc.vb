Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_PreliminarInspeccion
    Implements Il_PreliminarInspeccion
    Dim odPreliminarInspec As New d_PreliminarInspeccion

    Public Function Listar(ByVal oepreliminarinspeccion As EntidadesWCF.e_PreliminarInspeccion) As System.Collections.Generic.List(Of EntidadesWCF.e_PreliminarInspeccion) Implements Il_PreliminarInspeccion.Listar
        Try
            Return odPreliminarInspec.Listar(oepreliminarinspeccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oepreliminarinspeccion As EntidadesWCF.e_PreliminarInspeccion) As EntidadesWCF.e_PreliminarInspeccion Implements Il_PreliminarInspeccion.Obtener
        Try
            Return odPreliminarInspec.Obtener(oepreliminarinspeccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oepreliminarinspeccion As EntidadesWCF.e_PreliminarInspeccion) As Boolean Implements Il_PreliminarInspeccion.Guardar
        Try
            ' If Validar(oeDetallePreliminar) Then
            Return odPreliminarInspec.Guardar(oepreliminarinspeccion)
            ' End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Enviar(ByVal oepreliminarinspeccion As EntidadesWCF.e_PreliminarInspeccion) As Boolean Implements Il_PreliminarInspeccion.Enviar
        Try
            Return odPreliminarInspec.Enviar(oepreliminarinspeccion)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
