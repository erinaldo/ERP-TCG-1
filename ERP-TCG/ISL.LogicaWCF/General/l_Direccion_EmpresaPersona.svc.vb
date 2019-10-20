Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Direccion_EmpresaPersona
    Implements Il_Direccion_EmpresaPersona

    Dim odDireccion_EmpresaPersona As New d_Direccion_EmpresaPersona

    Public Function Eliminar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean Implements Il_Direccion_EmpresaPersona.Eliminar
        Try
            Return odDireccion_EmpresaPersona.Eliminar(oeDireccion_EmpresaPersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean Implements Il_Direccion_EmpresaPersona.Guardar
        Try
            If Validar(oeDireccion_EmpresaPersona) Then
                Return odDireccion_EmpresaPersona.Guardar(oeDireccion_EmpresaPersona)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As System.Collections.Generic.List(Of e_Direccion_EmpresaPersona) Implements Il_Direccion_EmpresaPersona.Listar
        Try
            Return odDireccion_EmpresaPersona.Listar(oeDireccion_EmpresaPersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarTodo(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As System.Collections.Generic.List(Of e_Direccion_EmpresaPersona) Implements Il_Direccion_EmpresaPersona.ListarTodo
        Try
            Return odDireccion_EmpresaPersona.ListarTodo(oeDireccion_EmpresaPersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As e_Direccion_EmpresaPersona Implements Il_Direccion_EmpresaPersona.Obtener
        Try
            Return odDireccion_EmpresaPersona.Obtener(oeDireccion_EmpresaPersona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDireccion_EmpresaPersona As e_Direccion_EmpresaPersona) As Boolean Implements Il_Direccion_EmpresaPersona.Validar
        Try
            With oeDireccion_EmpresaPersona
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDireccionValida(ByVal oeDEP As e_Direccion_EmpresaPersona) As Boolean
        Try
            If oeDEP.oeDireccion.IdTipoVia = "" Then Throw New Exception("No ha Seleccionado Tipo de Via")
            If oeDEP.oeDireccion.Via = "" Then Throw New Exception("No ha ingresado Via")
            If oeDEP.oeDireccion.IdTipoZona = "" Then Throw New Exception("No ha Seleccionado Tipo de Zona")
            If oeDEP.oeDireccion.IdTipoZona <> "1CH000000000" AndAlso oeDEP.oeDireccion.Zona = "" Then Throw New Exception("No ha ingresado Zona")
            If oeDEP.oeDireccion.CCPP = "" Then Throw New Exception("No ha Seleccionado Centro Poblado")
            ValidarDireccionValida = True
            Return ValidarDireccionValida
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
