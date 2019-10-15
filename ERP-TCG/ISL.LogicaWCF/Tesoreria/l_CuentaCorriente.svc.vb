'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_CuentaCorriente
    Implements Il_CuentaCorriente

    Dim odCuentaCorriente As New d_CuentaCorriente
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCuentaCorriente As EntidadesWCF.e_CuentaCorriente) As Boolean Implements Il_CuentaCorriente.Eliminar
        Try
            Return odCuentaCorriente.Eliminar(oeCuentaCorriente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaCorriente As EntidadesWCF.e_CuentaCorriente) As Boolean Implements Il_CuentaCorriente.Guardar
        Try
            If Validar(oeCuentaCorriente) Then
                Return odCuentaCorriente.Guardar(oeCuentaCorriente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaCorriente As EntidadesWCF.e_CuentaCorriente) As System.Collections.Generic.List(Of EntidadesWCF.e_CuentaCorriente) Implements Il_CuentaCorriente.Listar
        Try
            Return odCuentaCorriente.Listar(oeCuentaCorriente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaCorriente As EntidadesWCF.e_CuentaCorriente) As EntidadesWCF.e_CuentaCorriente Implements Il_CuentaCorriente.Obtener
        Try
            Return odCuentaCorriente.Obtener(oeCuentaCorriente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCuentaCorriente As EntidadesWCF.e_CuentaCorriente) As Boolean Implements Il_CuentaCorriente.Validar
        Try
            With oeCuentaCorriente
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTrabajador, "Ingrese el trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMoneda, "Ingrese tipo moneda")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Glosa, "Ingrese glosa")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Saldo, "Ingrese el saldo")
                ValidarDuplicado(.Id, .IdTrabajador, .Trabajador, .Tipo)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal IDTRABAJADOR As String, ByVal TRABAJADOR As String, ByVal Tipo As Integer) As Boolean Implements Il_CuentaCorriente.ValidarDuplicado
        Try
            Dim oeCuentaCorriente As New e_CuentaCorriente
            oeCuentaCorriente.IdTrabajador = IDTRABAJADOR
            oeCuentaCorriente.Tipo = Tipo
            oeCuentaCorriente.Activo = True
            oeCuentaCorriente = odCuentaCorriente.Obtener(oeCuentaCorriente)
            If oeCuentaCorriente.Id <> "" Then
                If ID = "" Then Throw New Exception("Ya existe cuenta de : " & TRABAJADOR)
                If oeCuentaCorriente.Id <> ID Then Throw New Exception("Ya existe cuenta de : " & TRABAJADOR)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
