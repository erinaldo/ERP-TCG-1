Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_RevisionTecnica
    Implements Il_RevisionTecnica

    Dim odRevisionTecnica As New d_RevisionTecnica


    Public Function Listar(ByVal oeRevisionTecnica As e_RevisionTecnica) As List(Of e_RevisionTecnica) Implements Il_RevisionTecnica.Listar
        Try
            Return odRevisionTecnica.Listar(oeRevisionTecnica)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeRevisionTecnica As e_RevisionTecnica) As Boolean Implements Il_RevisionTecnica.Validar
        Try
            With oeRevisionTecnica
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRevisionTecnica As e_RevisionTecnica) As Boolean Implements Il_RevisionTecnica.Guardar
        Try
            If Validar(oeRevisionTecnica) Then
                Return odRevisionTecnica.Guardar(oeRevisionTecnica)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
