Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_CtaCtbleSubFamiliaMat" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_CtaCtbleSubFamiliaMat.svc o l_CtaCtbleSubFamiliaMat.svc.vb en el Explorador de soluciones e inicie la depuración.

Public Class l_CtaCtbleSubFamiliaMat
    Implements Il_CtaCtbleSubFamiliaMat

    Dim odCtaCtble_SubFamiliaMat As New d_CtaCtbleSubFamiliaMat

    Public Function Obtener(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As e_CtaCtbleSubFamiliaMat Implements Il_CtaCtbleSubFamiliaMat.Obtener
        Try
            Return odCtaCtble_SubFamiliaMat.Obtener(oeCtaCtble_SubFamiliaMat)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As List(Of e_CtaCtbleSubFamiliaMat) Implements Il_CtaCtbleSubFamiliaMat.Listar
        Try
            Return odCtaCtble_SubFamiliaMat.Listar(oeCtaCtble_SubFamiliaMat)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean Implements Il_CtaCtbleSubFamiliaMat.Validar
        Try
            With oeCtaCtble_SubFamiliaMat
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean Implements Il_CtaCtbleSubFamiliaMat.Guardar
        Try
            If Validar(oeCtaCtble_SubFamiliaMat) Then
                Return odCtaCtble_SubFamiliaMat.Guardar(oeCtaCtble_SubFamiliaMat)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCtble_SubFamiliaMat As e_CtaCtbleSubFamiliaMat) As Boolean Implements Il_CtaCtbleSubFamiliaMat.Eliminar
        Try
            Return odCtaCtble_SubFamiliaMat.Eliminar(oeCtaCtble_SubFamiliaMat)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
