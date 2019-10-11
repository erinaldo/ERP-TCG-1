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
Public Class l_DiseñoNeumatico
    Implements Il_DiseñoNeumatico
    Dim odDiseñoNeumatico As New d_DiseñoNeumatico
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeDiseñoNeumatico As EntidadesWCF.e_DiseñoNeumatico) As Boolean Implements Il_DiseñoNeumatico.Eliminar
        Try
            Return odDiseñoNeumatico.Eliminar(oeDiseñoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDiseñoNeumatico As EntidadesWCF.e_DiseñoNeumatico) As Boolean Implements Il_DiseñoNeumatico.Guardar
        Try
            If Validar(oeDiseñoNeumatico) Then
                Return odDiseñoNeumatico.Guardar(oeDiseñoNeumatico)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDiseñoNeumatico As EntidadesWCF.e_DiseñoNeumatico) As System.Collections.Generic.List(Of EntidadesWCF.e_DiseñoNeumatico) Implements Il_DiseñoNeumatico.Listar
        Try
            Return odDiseñoNeumatico.Listar(oeDiseñoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDiseñoNeumatico As EntidadesWCF.e_DiseñoNeumatico) As EntidadesWCF.e_DiseñoNeumatico Implements Il_DiseñoNeumatico.Obtener
        Try
            Return odDiseñoNeumatico.Obtener(oeDiseñoNeumatico)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDiseñoNeumatico As EntidadesWCF.e_DiseñoNeumatico) As Boolean Implements Il_DiseñoNeumatico.Validar
        Try
            With oeDiseñoNeumatico
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar nombre.")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMarca, "Seleccione una marca.")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdMedidaNeumatico, "Seleccione una medida.")
                l_FuncionesGenerales.ValidarNumero(.NroLonas, "Ingrese un valor al nro. de lonas.")
                l_FuncionesGenerales.ValidarNumero(.Ribete1, "Ingrese un valor al ribete 1.")
                l_FuncionesGenerales.ValidarNumero(.Ribete2, "Ingrese un valor al ribete 2.")
                l_FuncionesGenerales.ValidarNumero(.Ribete3, "Ingrese un valor al ribete 3.")
                l_FuncionesGenerales.ValidarNumero(.Cocada, "Ingrese un valor a la cocada.")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
