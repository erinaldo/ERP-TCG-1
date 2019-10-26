Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConceptoIngresos
    Implements Il_ConceptoIngresos

    Dim odConceptoIngresos As New d_ConceptoIngresos
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean Implements Il_ConceptoIngresos.Eliminar
        Try
            Return odConceptoIngresos.Eliminar(oeConceptoIngresos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean Implements Il_ConceptoIngresos.Guardar
        Try
            If Validar(oeConceptoIngresos) Then
                Return odConceptoIngresos.Guardar(oeConceptoIngresos)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As System.Collections.Generic.List(Of e_ConceptoIngresos) Implements Il_ConceptoIngresos.Listar
        Try
            Return odConceptoIngresos.Listar(oeConceptoIngresos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConceptoIngresos As e_ConceptoIngresos) As e_ConceptoIngresos Implements Il_ConceptoIngresos.Obtener
        Try
            Return odConceptoIngresos.Obtener(oeConceptoIngresos)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConceptoIngresos As e_ConceptoIngresos) As Boolean Implements Il_ConceptoIngresos.Validar
        Try
            With oeConceptoIngresos
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No se ha ingresado en Concepto")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
