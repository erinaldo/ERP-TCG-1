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
Public Class l_MedidaNeumatico
    Implements Il_MedidaNeumatico

    Dim odMedidaNeumatico As New d_MedidaNeumatico
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeMedidaNeumatico As EntidadesWCF.e_MedidaNeumatico) As Boolean Implements Il_MedidaNeumatico.Eliminar
        Try
            Return odMedidaNeumatico.Eliminar(oeMedidaNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMedidaNeumatico As EntidadesWCF.e_MedidaNeumatico) As Boolean Implements Il_MedidaNeumatico.Guardar
        Try
            If Validar(oeMedidaNeumatico) Then
                Return odMedidaNeumatico.Guardar(oeMedidaNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMedidaNeumatico As EntidadesWCF.e_MedidaNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_MedidaNeumatico) Implements Il_MedidaNeumatico.Listar
        Try
            Return odMedidaNeumatico.Listar(oeMedidaNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMedidaNeumatico As EntidadesWCF.e_MedidaNeumatico) As EntidadesWCF.e_MedidaNeumatico Implements Il_MedidaNeumatico.Obtener
        Try
            Return odMedidaNeumatico.Obtener(oeMedidaNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMedidaNeumatico As EntidadesWCF.e_MedidaNeumatico) As Boolean Implements Il_MedidaNeumatico.Validar
        Try
            With oeMedidaNeumatico
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre")
                l_FuncionesGenerales.ValidarNumero(oeMedidaNeumatico.DiametroAro, "Ingrese un valor al diametro.")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdTipoNeumatico, "Seleccione un tipo neumatico")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
