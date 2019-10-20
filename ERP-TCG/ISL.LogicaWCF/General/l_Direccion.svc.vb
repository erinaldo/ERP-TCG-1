Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

''' <summary>
''' Clase de la capa lógica para validar datos del objeto Direccion
''' </summary>
''' <remarks></remarks>
<DataContract(), Serializable()> _
Public Class l_Direccion
    Implements Il_Direccion

    Dim odDireccion As New d_Direccion

    Public Function Eliminar(ByVal oeDireccion As e_Direccion) As Boolean Implements Il_Direccion.Eliminar
        Try
            Return odDireccion.Eliminar(oeDireccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDireccion As e_Direccion) As Boolean Implements Il_Direccion.Guardar
        Try
            Dim id As String = ""
            Dim band As Boolean = False
            If Validar(oeDireccion) Then
                id = odDireccion.Guardar(oeDireccion)
            End If
            If id <> "" Then band = True
            Return band
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDireccion As e_Direccion) As System.Collections.Generic.List(Of e_Direccion) Implements Il_Direccion.Listar
        Try
            Return odDireccion.Listar(oeDireccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDireccion As e_Direccion) As e_Direccion Implements Il_Direccion.Obtener
        Try
            Return odDireccion.Obtener(oeDireccion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDireccion As e_Direccion) As Boolean Implements Il_Direccion.Validar
        Try
            With oeDireccion
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
