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
Public Class l_Proveedor
    Implements Il_Proveedor

    Dim odProveedor As New d_Proveedor
    Dim olPersona As New l_Persona
    Dim olEmpresa As New l_Empresa

    Public Function ComboGrilla(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As Object Implements Il_Proveedor.ComboGrilla
        Try
            Return odProveedor.ComboGrilla(oeProveedor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As Boolean Implements Il_Proveedor.Eliminar
        Try
            Return odProveedor.Eliminar(oeProveedor)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Retorna la foto del Proveedor a partir de su DNI
    ''' </summary>
    ''' <param name="DNI"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Foto(ByVal DNI As String) As System.Drawing.Bitmap Implements Il_Proveedor.Foto
        Try
            Return olPersona.Foto(DNI)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As Boolean Implements Il_Proveedor.Guardar
        Try
            If Validar(oeProveedor) Then Return odProveedor.Guardar(oeProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As System.Collections.Generic.List(Of EntidadesWCF.e_Proveedor) Implements Il_Proveedor.Listar
        Try
            Return odProveedor.Listar(oeProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As EntidadesWCF.e_Proveedor Implements Il_Proveedor.Obtener
        Try
            Return odProveedor.Obtener(oeProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerNomProveedor(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As EntidadesWCF.e_Proveedor Implements Il_Proveedor.ObtenerNomProveedor
        Try
            Return odProveedor.ObtenerNomProv(oeProveedor)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeProveedor As EntidadesWCF.e_Proveedor) As Boolean Implements Il_Proveedor.Validar
        Try
            With oeProveedor
                If .TipoPersonaEmpresa = 1 Then
                    olPersona.Validar(oeProveedor.oePersona)
                Else
                    olEmpresa.Validar(oeProveedor.oeEmpresa)
                End If

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
