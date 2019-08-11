Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_FlujoCaja
    Implements Il_FlujoGasto
    Dim odFlujoGasto As New d_FlujoGasto
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Buscar(ByVal oeFlujoGasto As EntidadesWCF.e_FlujoCaja) As Boolean Implements Il_FlujoGasto.Buscar
        Try
            Return odFlujoGasto.Buscar(oeFlujoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal ListaFlujo As System.Collections.Generic.List(Of EntidadesWCF.e_FlujoCaja)) As Object Implements Il_FlujoGasto.ComboGrilla
        Try
            Return odFlujoGasto.ComboGrilla(ListaFlujo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeFlujoGasto As EntidadesWCF.e_FlujoCaja) As Boolean Implements Il_FlujoGasto.Eliminar
        Try
            Return odFlujoGasto.Eliminar(oeFlujoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeFlujoGasto As EntidadesWCF.e_FlujoCaja) As Boolean Implements Il_FlujoGasto.Guardar
        Try
            If Validar(oeFlujoGasto) Then
                Return odFlujoGasto.Guardar(oeFlujoGasto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeFlujoGasto As EntidadesWCF.e_FlujoCaja) As System.Collections.Generic.List(Of EntidadesWCF.e_FlujoCaja) Implements Il_FlujoGasto.Listar
        Try
            Return odFlujoGasto.Listar(oeFlujoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeFlujoGasto As EntidadesWCF.e_FlujoCaja) As EntidadesWCF.e_FlujoCaja Implements Il_FlujoGasto.Obtener
        Try
            Return odFlujoGasto.Obtener(oeFlujoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeFlujoGasto As EntidadesWCF.e_FlujoCaja) As Boolean Implements Il_FlujoGasto.Validar
        Try
            With oeFlujoGasto
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese el codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese un nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Ingrese la abreviatura")
                ValidarDuplicado(.Id, .Nombre)
            End With
            ' proceso que verifica en la lista de objetos si ya se ha registrado el banco 
            'If oeFlujoGasto.TipoOperacion = "I" Then
            '    Nombre = oeFlujoGasto.Nombre
            '    Dim oeFlujoGastoBusqueda As New e_FlujoGasto
            '    With oeFlujoGastoBusqueda
            '        .Id = ""
            '        .Nombre = ""
            '        .Activo = True
            '    End With
            '    Dim Resultado As e_FlujoGasto = Listar(oeFlujoGastoBusqueda).Find(AddressOf VerificarDuplicado)
            '    If Resultado IsNot Nothing Then
            '        Throw New Exception("Ya se encuentra registrado el Flujo Caja : " + Nombre)
            '    Else
            '        Return True
            '    End If
            'End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean Implements Il_FlujoGasto.ValidarDuplicado
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(NOMBRE, "No ha Ingresado")
            Dim oeFlujoGasto As New e_FlujoCaja
            oeFlujoGasto.Nombre = NOMBRE
            oeFlujoGasto = odFlujoGasto.Obtener(oeFlujoGasto)
            If oeFlujoGasto.Id <> "" Then
                If ID = "" Then
                    Throw New Exception("Ya existe: " & NOMBRE)
                ElseIf oeFlujoGasto.Id <> ID Then
                    Throw New Exception("Ya existe: " & NOMBRE)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
