Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleRegConformidadOT
    Implements Il_DetalleRegConformidadOT

    Dim odDetalleRegConformidadOT As New d_DetalleRegConformidadOT

    Public Function Eliminar(ByVal oeDetalleRegConformidadOT As EntidadesWCF.e_DetalleRegConformidadOT) As Boolean Implements Il_DetalleRegConformidadOT.Eliminar
        Try
            Return odDetalleRegConformidadOT.Eliminar(oeDetalleRegConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleRegConformidadOT As EntidadesWCF.e_DetalleRegConformidadOT) As Boolean Implements Il_DetalleRegConformidadOT.Guardar
        Try
            If Validar(oeDetalleRegConformidadOT) Then
                Return odDetalleRegConformidadOT.Guardar(oeDetalleRegConformidadOT)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleRegConformidadOT As EntidadesWCF.e_DetalleRegConformidadOT) As System.Data.DataSet Implements Il_DetalleRegConformidadOT.Listar
        Try
            Return odDetalleRegConformidadOT.Listar(oeDetalleRegConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleRegConformidadOT As EntidadesWCF.e_DetalleRegConformidadOT) As EntidadesWCF.e_DetalleRegConformidadOT Implements Il_DetalleRegConformidadOT.Obtener
        Try
            Return odDetalleRegConformidadOT.Obtener(oeDetalleRegConformidadOT)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleRegConformidadOT As EntidadesWCF.e_DetalleRegConformidadOT) As Boolean Implements Il_DetalleRegConformidadOT.Validar
        Try
            With oeDetalleRegConformidadOT
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
