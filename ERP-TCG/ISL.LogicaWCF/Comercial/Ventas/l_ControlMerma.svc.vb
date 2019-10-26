Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

' NOTA: si cambia aquí el nombre de clase "l_ControlMerma", también debe actualizar la referencia a "l_ControlMerma" tanto en Web.config como en el archivo .svc asociado.
Public Class l_ControlMerma
    Implements Il_ControlMerma

    Dim odControlMerma As New d_ControlMerma

    Public Function Obtener(ByVal oeControlMerma As e_ControlMerma) As e_ControlMerma Implements Il_ControlMerma.Obtener
        Try
            Return odControlMerma.Obtener(oeControlMerma)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeControlMerma As e_ControlMerma) As List(Of e_ControlMerma) Implements Il_ControlMerma.Listar
        Try
            Return odControlMerma.Listar(oeControlMerma)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeControlMerma As e_ControlMerma, ByVal IndIngresoSalida As Integer) As Boolean Implements Il_ControlMerma.Validar
        Try
            With oeControlMerma
                If .IndIngresoSalida <> 2 And .TipoOperacion = "I" Then
                    If .TipoPago <> 3 Then
                        If .IdClientePersona = "" Then Throw New Exception("Seleccione Cliente/Persona")
                    End If
                    If .Cantidad = 0.0 Then Throw New Exception("Ingrese Cantidad")
                    If .IdMaterial = "" Then Throw New Exception("Ingrese Material")
                    If IndIngresoSalida = 0 Then
                        If .IdViaje = "" Then Throw New Exception("Seleccione un Viaje")
                        If .UnidadCantidad = "" Then Throw New Exception("Seleccione UnidadCantidad")
                        If .IdEstado = "" Then Throw New Exception("Seleccione Estado")
                       
                    End If
                End If
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function Guardar(ByVal oeControlMerma As e_ControlMerma) As Boolean Implements Il_ControlMerma.Guardar
        Try
            If Validar(oeControlMerma, oeControlMerma.IndIngresoSalida) Then
                Return odControlMerma.Guardar(oeControlMerma)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeControlMerma As e_ControlMerma) As Boolean Implements Il_ControlMerma.Eliminar
        Try
            Return odControlMerma.Eliminar(oeControlMerma)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
