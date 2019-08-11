' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Concepto" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Concepto.svc o l_Concepto.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_Concepto
    Implements Il_Concepto

    Dim odConcepto As New d_Concepto

    Public Function Obtener(ByVal oeConcepto As e_Concepto) As e_Concepto Implements Il_Concepto.Obtener
        Try
            Return odConcepto.Obtener(oeConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConcepto As e_Concepto) As List(Of e_Concepto) Implements Il_Concepto.Listar
        Try
            Return odConcepto.Listar(oeConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConcepto As e_Concepto) As Boolean Implements Il_Concepto.Validar
        Try
            With oeConcepto
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeConcepto As e_Concepto) As Boolean Implements Il_Concepto.Guardar
        Try
            If Validar(oeConcepto) Then
                Return odConcepto.Guardar(oeConcepto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConcepto As e_Concepto, ByVal listaAreaTiEoevento As List(Of e_AreaTipoEvento)) As Boolean Implements Il_Concepto.Guardar
        Try
            If Validar(oeConcepto) Then
                Return odConcepto.Guardar(oeConcepto, listaAreaTiEoevento)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeConcepto As e_Concepto) As Boolean Implements Il_Concepto.Eliminar
        Try
            Return odConcepto.Eliminar(oeConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarTipoEvento(ByVal oeConcepto As e_Concepto) As Boolean Implements Il_Concepto.EliminarTipoEvento
        Try
            Return odConcepto.EliminarTipoEvento(oeConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal oeConcepto As e_Concepto) As Object Implements Il_Concepto.ComboGrilla
        Try
            Return odConcepto.ComboGrilla(oeConcepto)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Sub DoWork() Implements Il_Concepto.DoWork
    End Sub

End Class
