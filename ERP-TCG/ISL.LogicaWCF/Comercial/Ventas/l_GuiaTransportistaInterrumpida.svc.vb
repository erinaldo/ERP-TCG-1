Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GuiaTransportistaInterrumpida
    Implements Il_GuiaTransportistaInterrumpida

    Dim odGuiaTransportistaInterrumpida As New d_GuiaTransportistaInterrumpida

    Public Function Eliminar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean Implements Il_GuiaTransportistaInterrumpida.Eliminar
        Try
            Return odGuiaTransportistaInterrumpida.Eliminar(oeGuiaTransportistaInterrumpida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean Implements Il_GuiaTransportistaInterrumpida.Guardar
        Try
            If Validar(oeGuiaTransportistaInterrumpida) Then
                Return odGuiaTransportistaInterrumpida.Guardar(oeGuiaTransportistaInterrumpida)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As System.Collections.Generic.List(Of e_GuiaTransportistaInterrumpida) Implements Il_GuiaTransportistaInterrumpida.Listar
        Try
            Return odGuiaTransportistaInterrumpida.Listar(oeGuiaTransportistaInterrumpida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As e_GuiaTransportistaInterrumpida Implements Il_GuiaTransportistaInterrumpida.Obtener
        Try
            Return odGuiaTransportistaInterrumpida.Obtener(oeGuiaTransportistaInterrumpida)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGuiaTransportistaInterrumpida As e_GuiaTransportistaInterrumpida) As Boolean Implements Il_GuiaTransportistaInterrumpida.Validar
        Try
            With oeGuiaTransportistaInterrumpida
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
