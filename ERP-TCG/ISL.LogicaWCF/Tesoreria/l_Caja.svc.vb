Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Caja
    Implements Il_Caja

    Dim odCaja As New d_Caja
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeCaja As EntidadesWCF.e_Caja) As Boolean Implements Il_Caja.Eliminar
        Try
            Return odCaja.Eliminar(oeCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCaja As EntidadesWCF.e_Caja) As Boolean Implements Il_Caja.Guardar
        Try
            If Validar(oeCaja) Then
                Return odCaja.Guardar(oeCaja)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal loCaja As List(Of e_Caja)) As Object Implements Il_Caja.ComboGrilla
        Try
            Return odCaja.ComboGrilla(loCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCaja As EntidadesWCF.e_Caja) As System.Collections.Generic.List(Of EntidadesWCF.e_Caja) Implements Il_Caja.Listar
        Try
            Return odCaja.Listar(oeCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCaja As EntidadesWCF.e_Caja) As EntidadesWCF.e_Caja Implements Il_Caja.Obtener
        Try
            Return odCaja.Obtener(oeCaja)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeCaja As EntidadesWCF.e_Caja) As Boolean Implements Il_Caja.Validar
        Try
            With oeCaja
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese el codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese un nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCentro, "Seleccione Centro")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Ingrese la abreviatura")
                ValidarDuplicado(.Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ID As String, ByVal NOMBRE As String) As Boolean Implements Il_Caja.ValidarDuplicado
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(NOMBRE, "No ha Ingresado")
            Dim oeCaja As New e_Caja
            oeCaja.Nombre = NOMBRE
            oeCaja.Activo = True
            oeCaja = odCaja.Obtener(oeCaja)
            If oeCaja.Id <> "" Then
                If ID = "" Then
                    Throw New Exception("Ya existe: " & NOMBRE)
                ElseIf oeCaja.Id <> ID Then
                    Throw New Exception("Ya existe: " & NOMBRE)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
