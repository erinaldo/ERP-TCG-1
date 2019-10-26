' NOTA: si cambia aquí el nombre de clase "l_AlmacenMermas", también debe actualizar la referencia a "l_AlmacenMermas" tanto en Web.config como en el archivo .svc asociado.
Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

Public Class l_AlmacenMermas
    Implements Il_AlmacenMermas

    'Public Sub DoWork() Implements Il_AlmacenMermas.DoWork
    'End Sub
    Dim odAlmacenMermas As New d_AlmacenMermas

    Public Function Obtener(ByVal oeAlmacenMermas As e_AlmacenMermas) As e_AlmacenMermas Implements Il_AlmacenMermas.Obtener
        Try
            Return odAlmacenMermas.Obtener(oeAlmacenMermas)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAlmacenMermas As e_AlmacenMermas) As List(Of e_AlmacenMermas) Implements Il_AlmacenMermas.Listar
        Try
            Return odAlmacenMermas.Listar(oeAlmacenMermas)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean Implements Il_AlmacenMermas.Validar
        Try
            With oeAlmacenMermas
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean Implements Il_AlmacenMermas.Guardar
        Try
            If Validar(oeAlmacenMermas) Then
                Return odAlmacenMermas.Guardar(oeAlmacenMermas)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeAlmacenMermas As e_AlmacenMermas) As Boolean Implements Il_AlmacenMermas.Eliminar
        Try
            Return odAlmacenMermas.Eliminar(oeAlmacenMermas)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
