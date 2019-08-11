Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

' NOTA: si cambia aquí el nombre de clase "l_MaterialesNegociadosDet", también debe actualizar la referencia a "l_MaterialesNegociadosDet" tanto en Web.config como en el archivo .svc asociado.
Public Class l_MaterialesNegociadosDet
    Implements Il_MaterialesNegociadosDet

    Dim odMaterialesNegociadosDet As New d_MaterialesNegociadosDet

    Public Function Obtener(ByVal oeMaterialesNegociadosDet As ISL.EntidadesWCF.e_MaterialesNegociadosDet) As EntidadesWCF.e_MaterialesNegociadosDet Implements Il_MaterialesNegociadosDet.Obtener
        Try
            Return odMaterialesNegociadosDet.Obtener(oeMaterialesNegociadosDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialesNegociadosDet As ISL.EntidadesWCF.e_MaterialesNegociadosDet) As List(Of EntidadesWCF.e_MaterialesNegociadosDet) Implements Il_MaterialesNegociadosDet.Listar
        Try
            Return odMaterialesNegociadosDet.Listar(oeMaterialesNegociadosDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMaterialesNegociadosDet As ISL.EntidadesWCF.e_MaterialesNegociadosDet) As Boolean Implements Il_MaterialesNegociadosDet.Validar
        Try
            With oeMaterialesNegociadosDet
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeMaterialesNegociadosDet As ISL.EntidadesWCF.e_MaterialesNegociadosDet) As Boolean Implements Il_MaterialesNegociadosDet.Guardar
        Try
            If Validar(oeMaterialesNegociadosDet) Then
                Return odMaterialesNegociadosDet.Guardar(oeMaterialesNegociadosDet)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterialesNegociadosDet As ISL.EntidadesWCF.e_MaterialesNegociadosDet) As Boolean Implements Il_MaterialesNegociadosDet.Eliminar
        Try
            Return odMaterialesNegociadosDet.Eliminar(oeMaterialesNegociadosDet)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
