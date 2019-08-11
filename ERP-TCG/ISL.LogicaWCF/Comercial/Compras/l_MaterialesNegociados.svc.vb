Imports ISL.AccesoDatos
Imports System.Runtime.Serialization
' NOTA: si cambia aquí el nombre de clase "l_MaterialesNegociados", también debe actualizar la referencia a "l_MaterialesNegociados" tanto en Web.config como en el archivo .svc asociado.

<DataContract(), Serializable()> _
Public Class l_MaterialesNegociados

    Implements Il_MaterialesNegociados

    Dim odMaterialesNegociados As New d_MaterialesNegociados

    Public Function Obtener(ByVal oeMaterialesNegociados As EntidadesWCF.e_MaterialesNegociados) As EntidadesWCF.e_MaterialesNegociados Implements Il_MaterialesNegociados.Obtener
        Try
            Return odMaterialesNegociados.Obtener(oeMaterialesNegociados)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialesNegociados As EntidadesWCF.e_MaterialesNegociados) As System.Data.DataSet Implements Il_MaterialesNegociados.Listar
        Try
            Return odMaterialesNegociados.Listar(oeMaterialesNegociados)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMaterialesNegociados As EntidadesWCF.e_MaterialesNegociados) As Boolean Implements Il_MaterialesNegociados.Validar
        Try
            With oeMaterialesNegociados
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeMaterialesNegociados As EntidadesWCF.e_MaterialesNegociados) As Boolean Implements Il_MaterialesNegociados.Guardar
        Try
            If Validar(oeMaterialesNegociados) Then
                Return odMaterialesNegociados.Guardar(oeMaterialesNegociados)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterialesNegociados As EntidadesWCF.e_MaterialesNegociados) As Boolean Implements Il_MaterialesNegociados.Eliminar
        Try
            Return odMaterialesNegociados.Eliminar(oeMaterialesNegociados)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
