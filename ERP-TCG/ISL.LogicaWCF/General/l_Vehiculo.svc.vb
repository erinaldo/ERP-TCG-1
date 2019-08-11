Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Vehiculo
    Implements Il_Vehiculo

    Dim oeVehiculo As e_Vehiculo
    Dim odVehiculo As d_Vehiculo
    Dim l_FuncionesGenerales As l_FuncionesGenerales
    Dim odVehiculoEstado As d_VehiculoEstado

    Public Function ComboGrilla(ByVal listaVehiculo As System.Collections.Generic.List(Of EntidadesWCF.e_Vehiculo)) As Object Implements Il_Vehiculo.ComboGrilla
        Try
            odVehiculo = New d_Vehiculo
            Return odVehiculo.ComboGrilla(listaVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As Boolean Implements Il_Vehiculo.Eliminar
        Try
            odVehiculo = New d_Vehiculo
            Return odVehiculo.Eliminar(oeVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarJefeUnidad(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As Boolean
        Try
            odVehiculo = New d_Vehiculo
            Return odVehiculo.Guardar(oeVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As Boolean Implements Il_Vehiculo.Guardar
        Try
            odVehiculo = New d_Vehiculo
            If Validar(oeVehiculo) Then
                Return odVehiculo.Guardar(oeVehiculo)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As System.Collections.Generic.List(Of EntidadesWCF.e_Vehiculo) Implements Il_Vehiculo.Listar
        Try
            odVehiculo = New d_Vehiculo
            Return odVehiculo.Listar(oeVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As EntidadesWCF.e_Vehiculo Implements Il_Vehiculo.Obtener
        Try
            odVehiculo = New d_Vehiculo
            Return odVehiculo.Obtener(oeVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As Boolean Implements Il_Vehiculo.Validar
        Try
            l_FuncionesGenerales = New l_FuncionesGenerales
            If oeVehiculo.TipoActualizacion <> "C" And oeVehiculo.TipoOperacion <> "L" Then
                With oeVehiculo
                    'Valida que la placa no sea nula
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Placa, "Debe ingresar la placa del vehículo")
                    'Valida que la placa tenga al menos 5 dígitos
                    If .Placa.Length < 5 Then Throw New Exception("Verifique la placa de rodaje ingresada")
                    'valida que el color del vehículo debe de ser ingresado
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Color, "Debe ingresar el color del vehículo")
                    'valida que se ingrese la configuración de neumáticos al vehículo
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdConfiguracionNeumaticos, "Seleccione una configuracion para los neumaticos.")
                    'Valida que se ingrese la marca del vehículo
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdMarca, "Debe ingresar la marca del vehículo")
                    'Valida que la placa no se repita
                    If oeVehiculo.TipoActualizacion <> "A" Then ValidarDuplicado(.Placa)
                End With
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarCarretaMantenimiento(ByVal Id As String) As Boolean Implements Il_Vehiculo.ValidarCarretaMantenimiento
        Try
            oeVehiculo = New e_Vehiculo
            odVehiculo = New d_Vehiculo
            oeVehiculo.Id = Id
            oeVehiculo.TipoOperacion = "O"
            oeVehiculo = odVehiculo.Obtener(oeVehiculo)
            If oeVehiculo.Id <> "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Placa As String) As Boolean Implements Il_Vehiculo.ValidarDuplicado
        Try
            odVehiculo = New d_Vehiculo
            l_FuncionesGenerales = New l_FuncionesGenerales
            l_FuncionesGenerales.ValidarCampoNoNulo(ls_Placa, "No ha ingresado la placa de rodaje")
            Dim oeVehiculo As New e_Vehiculo
            oeVehiculo.Placa = ls_Placa
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo = odVehiculo.Obtener(oeVehiculo)
            If oeVehiculo.Id <> "" Then Throw New Exception("Ya existe: " & ls_Placa)
            oeVehiculo = New e_Vehiculo
            oeVehiculo.Placa = ls_Placa
            oeVehiculo.Codigo = "ANTERIORPC"
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo = odVehiculo.Obtener(oeVehiculo)
            If oeVehiculo.Id <> "" Then Throw New Exception("Ya existe es una Placa Antigua: " & ls_Placa)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTractoMantenimiento(ByVal Id As String) As Boolean Implements Il_Vehiculo.ValidarTractoMantenimiento
        Try
            oeVehiculo = New e_Vehiculo
            odVehiculo = New d_Vehiculo
            oeVehiculo.Id = Id
            oeVehiculo.TipoOperacion = "O"
            oeVehiculo = odVehiculo.Obtener(oeVehiculo)
            If oeVehiculo.Id <> "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarVehiculo(ByVal oeVehiculo As EntidadesWCF.e_Vehiculo) As e_Vehiculo Implements Il_Vehiculo.ValidarVehiculo
        Try
            l_FuncionesGenerales = New l_FuncionesGenerales
            odVehiculo = New d_Vehiculo
            oeVehiculo.TipoOperacion = "A"
            oeVehiculo = odVehiculo.Obtener(oeVehiculo)
            l_FuncionesGenerales.ValidarCampoNoNulo(oeVehiculo.Id, "Seleccione el vehículo")
            Return oeVehiculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As e_VehiculoEstado Implements Il_Vehiculo.ObtenerEstado
        Try
            odVehiculoEstado = New d_VehiculoEstado
            Return odVehiculoEstado.Obtener(oeVehiculoEstado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As List(Of e_VehiculoEstado) Implements Il_Vehiculo.ListarEstado
        Try
            odVehiculoEstado = New d_VehiculoEstado
            Return odVehiculoEstado.Listar(oeVehiculoEstado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean Implements Il_Vehiculo.ValidarEstado
        Try
            With oeVehiculoEstado
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function GuardarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean Implements Il_Vehiculo.GuardarEstado
        Try
            odVehiculoEstado = New d_VehiculoEstado
            If ValidarEstado(oeVehiculoEstado) Then
                Return odVehiculoEstado.Guardar(oeVehiculoEstado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarEstado(ByVal oeVehiculoEstado As e_VehiculoEstado) As Boolean Implements Il_Vehiculo.EliminarEstado
        Try
            odVehiculoEstado = New d_VehiculoEstado
            Return odVehiculoEstado.Eliminar(oeVehiculoEstado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarSituacional(oeVehiculo As e_Vehiculo) As DataSet Implements Il_Vehiculo.ListarSituacional
        Try
            odVehiculo = New d_Vehiculo
            Return odVehiculo.ListarSituacional(oeVehiculo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EditarEstado(oeVehiculoEstado As e_VehiculoEstado) As Boolean Implements Il_Vehiculo.EditarEstado
        Try
            odVehiculoEstado = New d_VehiculoEstado
            Return odVehiculoEstado.Guardar(oeVehiculoEstado)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
