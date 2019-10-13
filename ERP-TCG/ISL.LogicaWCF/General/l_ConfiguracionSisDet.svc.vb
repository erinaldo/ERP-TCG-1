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
Public Class l_ConfiguracionSisDet
    Implements Il_ConfiguracionSisDet

    Dim odConfiguracionSisDet As New d_ConfiguracionSisDet

    Public Function Eliminar(ByVal oeConfiguracionSisDet As EntidadesWCF.e_ConfiguracionSisDet) As Boolean Implements Il_ConfiguracionSisDet.Eliminar
        Try
            Return odConfiguracionSisDet.Eliminar(oeConfiguracionSisDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionSisDet As EntidadesWCF.e_ConfiguracionSisDet) As Boolean Implements Il_ConfiguracionSisDet.Guardar
        Try
            If Validar(oeConfiguracionSisDet) Then
                Return odConfiguracionSisDet.Guardar(oeConfiguracionSisDet)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionSisDet As EntidadesWCF.e_ConfiguracionSisDet) As System.Collections.Generic.List(Of EntidadesWCF.e_ConfiguracionSisDet) Implements Il_ConfiguracionSisDet.Listar
        Try
            Return odConfiguracionSisDet.Listar(oeConfiguracionSisDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionSisDet As EntidadesWCF.e_ConfiguracionSisDet) As EntidadesWCF.e_ConfiguracionSisDet Implements Il_ConfiguracionSisDet.Obtener
        Try
            Return odConfiguracionSisDet.Obtener(oeConfiguracionSisDet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeConfiguracionSisDet As EntidadesWCF.e_ConfiguracionSisDet) As Boolean Implements Il_ConfiguracionSisDet.Validar
        Try
            With oeConfiguracionSisDet
                If oeConfiguracionSisDet.IdConfiguracionSis <> "1CH000001" Then
                    Dim oeCuentaContable As New e_CuentaContable
                    Dim olCuentaContable As New l_CuentaContable
                    Dim ListaCuentaContable As New List(Of e_CuentaContable)
                    oeCuentaContable.Ejercicio = oeConfiguracionSisDet.Ejercicio
                    ListaCuentaContable = olCuentaContable.Listar(oeCuentaContable)
                    If ListaCuentaContable.Count > 0 Then
                        Return True
                    Else
                        Throw New Exception("No Exiten Cuentas Contables en el Ejercicio " & .Ejercicio)
                    End If
                Else
                    Return True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
