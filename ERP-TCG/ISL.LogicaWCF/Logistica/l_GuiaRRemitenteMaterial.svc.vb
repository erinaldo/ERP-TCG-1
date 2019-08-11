Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GuiaRRemitenteMaterial
    Implements Il_GuiaRRemitenteMaterial

    Dim odGuiaRRemitenteMaterial As New d_GuiaRRemitenteMaterial

    Public Function Eliminar(ByVal oeGuiaRRemitenteMaterial As EntidadesWCF.e_GuiaRRemitenteMaterial) As Boolean Implements Il_GuiaRRemitenteMaterial.Eliminar
        Try
            Return odGuiaRRemitenteMaterial.Eliminar(oeGuiaRRemitenteMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRRemitenteMaterial As EntidadesWCF.e_GuiaRRemitenteMaterial) As Boolean Implements Il_GuiaRRemitenteMaterial.Guardar
        Try
            If Validar(oeGuiaRRemitenteMaterial) Then
                Return odGuiaRRemitenteMaterial.Guardar(oeGuiaRRemitenteMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRRemitenteMaterial As EntidadesWCF.e_GuiaRRemitenteMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_GuiaRRemitenteMaterial) Implements Il_GuiaRRemitenteMaterial.Listar
        Try
            Return odGuiaRRemitenteMaterial.Listar(oeGuiaRRemitenteMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRRemitenteMaterial As EntidadesWCF.e_GuiaRRemitenteMaterial) As EntidadesWCF.e_GuiaRRemitenteMaterial Implements Il_GuiaRRemitenteMaterial.Obtener
        Try
            Return odGuiaRRemitenteMaterial.Obtener(oeGuiaRRemitenteMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGuiaRRemitenteMaterial As EntidadesWCF.e_GuiaRRemitenteMaterial) As Boolean Implements Il_GuiaRRemitenteMaterial.Validar
        Try
            With oeGuiaRRemitenteMaterial
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
