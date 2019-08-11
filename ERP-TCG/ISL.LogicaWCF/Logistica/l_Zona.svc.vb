Imports ISL.EntidadesWCF
Imports ISL.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Zona
    Implements Il_Zona
    Dim odZona As New d_Zona
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(ByVal oeZona As EntidadesWCF.e_Zona) As Object Implements Il_Zona.ComboGrilla
        Try
            Return odZona.ComboGrilla(oeZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeZona As EntidadesWCF.e_Zona) As Boolean Implements Il_Zona.Eliminar
        Try
            Return odZona.Eliminar(oeZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeZona As EntidadesWCF.e_Zona) As Boolean Implements Il_Zona.Guardar
        Try
            If Validar(oeZona) Then
                Return odZona.Guardar(oeZona)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeZona As EntidadesWCF.e_Zona) As System.Collections.Generic.List(Of EntidadesWCF.e_Zona) Implements Il_Zona.Listar
        Try
            Return odZona.Listar(oeZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeZona As EntidadesWCF.e_Zona) As EntidadesWCF.e_Zona Implements Il_Zona.Obtener
        Try
            Return odZona.Obtener(oeZona)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeZona As EntidadesWCF.e_Zona) As Boolean Implements Il_Zona.Validar
        Try
            'With oeZona
            '    l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
            '    ValidarDuplicado(.Id, .Nombre, "nombre")
            '    ValidarDuplicado(.Id, .Abreviatura, "abreviatura")
            'End With
            'Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Zona.ValidarDuplicado
        Dim oeZona As New e_Zona
        Try
            'If valor = "" Then
            '    Return False
            'Else
            '    Select Case campo
            '        Case "nombre"
            '            oeZona.Nombre = valor
            '        Case "abreviatura"
            '            oeZona.Abreviatura = valor
            '    End Select
            '    oeZona = odZona.Obtener(oeZona)
            '    If Not oeZona Is Nothing Then
            '        If id = "" Then Throw New Exception("Ya existe el " & campo & ":" & valor)
            '        If oeZona.Id <> id Then Throw New Exception("Ya existe el(la) " & campo & ":" & valor)
            '    End If
            '    Return True
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
