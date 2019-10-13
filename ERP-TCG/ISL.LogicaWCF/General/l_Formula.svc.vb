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
Public Class l_Formula
    Implements Il_Formula

    Dim odFormula As New d_Formula
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeformula As EntidadesWCF.e_Formula) As Boolean Implements Il_Formula.Eliminar
        Try
            Return odFormula.Eliminar(oeformula)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeformula As EntidadesWCF.e_Formula) As Boolean Implements Il_Formula.Guardar
        Try
            If Validar(oeformula) Then
                Return odFormula.Guardar(oeformula)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeformula As EntidadesWCF.e_Formula) As List(Of EntidadesWCF.e_Formula) Implements Il_Formula.Listar
        Try
            Return odFormula.Listar(oeformula)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeformula As EntidadesWCF.e_Formula) As EntidadesWCF.e_Formula Implements Il_Formula.Obtener
        Try
            Return odFormula.Obtener(oeformula)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeformula As EntidadesWCF.e_Formula) As Boolean Implements Il_Formula.Validar
        Try
            With oeformula
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese Nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Descripcion, "Ingrese Descripcion")
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function


End Class
