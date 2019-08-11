Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Cliente
    Implements Il_Cliente

    Dim odCliente As New d_Cliente
    Dim olPersona As New l_Persona
    Dim olEmpresa As New l_Empresa

    Public Function ComboGrilla(ByVal ListaCliente As System.Collections.Generic.List(Of EntidadesWCF.e_Cliente)) As Object Implements Il_Cliente.ComboGrilla
        Try
            Return odCliente.ComboGrilla(ListaCliente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Eliminación de un cliente específico
    ''' </summary>
    ''' <param name="oeCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Eliminar(ByVal oeCliente As EntidadesWCF.e_Cliente) As Boolean Implements Il_Cliente.Eliminar
        Try
            Return odCliente.Eliminar(oeCliente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Retorna la foto del Cliente a partir de su DNI
    ''' </summary>
    ''' <param name="DNI">Número de DNI del cliente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Foto(ByVal DNI As String) As System.Drawing.Bitmap Implements Il_Cliente.Foto
        Try
            Return olPersona.Foto(DNI)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Guardar la información del cliente
    ''' </summary>
    ''' <param name="oeCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar(ByVal oeCliente As EntidadesWCF.e_Cliente) As Boolean Implements Il_Cliente.Guardar
        Try
            If Validar(oeCliente) Then
                Return odCliente.Guardar(oeCliente)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GuardarCliente(ByVal oeCliente As EntidadesWCF.e_Cliente) As Integer
        Try
            If Validar(oeCliente) Then
                Return odCliente.GuardarClienteCom(oeCliente)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Generar una lista de clientes
    ''' </summary>
    ''' <param name="oeCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Listar(ByVal oeCliente As EntidadesWCF.e_Cliente) As System.Collections.Generic.List(Of EntidadesWCF.e_Cliente) Implements Il_Cliente.Listar
        Try
            Return odCliente.Listar(oeCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Recuperar un cliente específico - Debe tener asignado el Id del cliente
    ''' </summary>
    ''' <param name="oeCliente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal oeCliente As EntidadesWCF.e_Cliente) As EntidadesWCF.e_Cliente Implements Il_Cliente.Obtener
        Try
            Return odCliente.Obtener(oeCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Obtener un cliente a partir de su Id
    ''' </summary>
    ''' <param name="id">Id del cliente que se va a recuperar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerId(ByVal id As String) As EntidadesWCF.e_Cliente Implements Il_Cliente.ObtenerId
        Try
            Dim oeCliente As New e_Cliente
            Return odCliente.Obtener(oeCliente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeCliente As EntidadesWCF.e_Cliente) As Boolean Implements Il_Cliente.Validar
        Try
            With oeCliente
                If .TipoPersonaEmpresa = 1 Then
                    olPersona.Validar(oeCliente.oePersona)
                Else
                    olEmpresa.Validar(oeCliente.oeEmpresa)
                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
