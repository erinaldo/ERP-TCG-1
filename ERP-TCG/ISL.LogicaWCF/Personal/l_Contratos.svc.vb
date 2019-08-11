' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_Contratos" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_Contratos.svc o l_Contratos.svc.vb en el Explorador de soluciones e inicie la depuración.
Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

Public Class l_Contratos
    Implements Il_Contratos

    Dim odContratos As New d_Contratos

    Public Function Obtener(ByVal oeContratos As e_Contratos) As e_Contratos Implements Il_Contratos.Obtener
        Try
            Return odContratos.Obtener(oeContratos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeContratos As e_Contratos) As List(Of e_Contratos) Implements Il_Contratos.Listar
        Try
            Return odContratos.Listar(oeContratos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeContratos As e_Contratos) As Boolean Implements Il_Contratos.Validar
        Try
            With oeContratos
                If .TipoOperacion = "I" Then
                    Dim oeCntr As New e_Contratos
                    oeCntr.TipoOperacion = "3"
                    oeCntr.IdTrabajador = .IdTrabajador
                    oeCntr.Vigencia = True
                    oeCntr = odContratos.Obtener(oeCntr)
                    If oeCntr.Id <> "" Then
                        Throw New Exception("Trabajador con Contrato Vigente. Verificar")
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeContratos As e_Contratos) As Boolean Implements Il_Contratos.Guardar
        Try
            If Validar(oeContratos) Then
                Return odContratos.Guardar(oeContratos)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeContratos As e_Contratos) As Boolean Implements Il_Contratos.Eliminar
        Try
            Return odContratos.Eliminar(oeContratos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Clonar(ByVal oeContrato1 As e_Contratos, ByVal oeContrato2 As e_Contratos) As Boolean Implements Il_Contratos.Clonar
        Try
            Return odContratos.Clonar(oeContrato1, oeContrato2)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
