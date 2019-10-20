Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConceptoGasto
    Implements Il_ConceptoGasto

    Dim odConceptoGasto As New d_ConceptoGasto

    Public Function ComboGrilla(ByVal ListaConceptoGasto As System.Collections.Generic.List(Of e_ConceptoGasto)) As Object Implements Il_ConceptoGasto.ComboGrilla
        Try
            Return odConceptoGasto.ComboGrilla(ListaConceptoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean Implements Il_ConceptoGasto.Eliminar
        Try
            Return odConceptoGasto.Eliminar(oeConceptoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean Implements Il_ConceptoGasto.Guardar
        Try
            If Validar(oeConceptoGasto) Then
                Return odConceptoGasto.Guardar(oeConceptoGasto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConceptoGasto As e_ConceptoGasto) As System.Collections.Generic.List(Of e_ConceptoGasto) Implements Il_ConceptoGasto.Listar
        Try
            Return odConceptoGasto.Listar(oeConceptoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeConceptoGasto As e_ConceptoGasto) As e_ConceptoGasto Implements Il_ConceptoGasto.Obtener
        Try
            Return odConceptoGasto.Obtener(oeConceptoGasto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeConceptoGasto As e_ConceptoGasto) As Boolean Implements Il_ConceptoGasto.Validar
        Try
            With oeConceptoGasto
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
