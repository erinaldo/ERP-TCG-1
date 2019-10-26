Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_Material_DisenoNeu
    Implements Il_Material_DisenoNeu

    Dim odMaterial_DisenoNeu As New d_Material_DisenoNeu

    Public Function Eliminar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean Implements Il_Material_DisenoNeu.Eliminar
        Try
            Return odMaterial_DisenoNeu.Eliminar(oeMaterial_DisenoNeu)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean Implements Il_Material_DisenoNeu.Guardar
        Try
            If Validar(oeMaterial_DisenoNeu) Then
                Return odMaterial_DisenoNeu.Guardar(oeMaterial_DisenoNeu)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As System.Collections.Generic.List(Of e_Material_DisenoNeu) Implements Il_Material_DisenoNeu.Listar
        Try
            Return odMaterial_DisenoNeu.Listar(oeMaterial_DisenoNeu)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As e_Material_DisenoNeu Implements Il_Material_DisenoNeu.Obtener
        Try
            Return odMaterial_DisenoNeu.Obtener(oeMaterial_DisenoNeu)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean Implements Il_Material_DisenoNeu.Validar
        Try
            With oeMaterial_DisenoNeu
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
