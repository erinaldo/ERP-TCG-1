Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ParticipacionAccion
    Implements Il_ParticipacionAccion

    Dim odParticipacionAccion As New d_ParticipacionAccion
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Guardar(ByVal oeParticipacionAccion As EntidadesWCF.e_ParticipacionAccion) As Boolean Implements Il_ParticipacionAccion.Guardar
        Try
            Return odParticipacionAccion.Guardar(oeParticipacionAccion)

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeParticipacionAccion As EntidadesWCF.e_ParticipacionAccion) As List(Of e_ParticipacionAccion) Implements Il_ParticipacionAccion.Listar
        Try
            Return odParticipacionAccion.Listar(oeParticipacionAccion)

        Catch ex As Exception
            Throw
        End Try
    End Function
End Class

