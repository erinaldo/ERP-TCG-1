'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_ConceptoPonderado
    Implements Il_ConceptoPonderado

    Dim odConceptoPonderado As New d_ConceptoPonderado
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeConceptoPonderado As e_ConceptoPonderado) As Boolean Implements Il_ConceptoPonderado.Eliminar
        Try
            Return odConceptoPonderado.Eliminar(oeConceptoPonderado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeConceptoPonderado As e_ConceptoPonderado) As Boolean Implements Il_ConceptoPonderado.Guardar
        Try
            If Validar(oeConceptoPonderado) Then
                Return odConceptoPonderado.Guardar(oeConceptoPonderado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeConceptoPonderado As e_ConceptoPonderado) As List(Of e_ConceptoPonderado) Implements Il_ConceptoPonderado.Listar
        Try
            Return odConceptoPonderado.Listar(oeConceptoPonderado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeConceptoPonderado As e_ConceptoPonderado) As e_ConceptoPonderado Implements Il_ConceptoPonderado.Obtener
        Try
            Return odConceptoPonderado.Obtener(oeConceptoPonderado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeConceptoPonderado As e_ConceptoPonderado) As Boolean Implements Il_ConceptoPonderado.Validar
        Try
            With oeConceptoPonderado
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese Nombre")
                Dim _leAux = .leDetalle.Where(Function(it) it.Activo = True).ToList
                If _leAux.Count = 0 Then Throw New Exception("Debe Ingresar al menos un Registro de Detalle")
                If Not .lbExcluir Then
                    If _leAux.Sum(Function(it) it.Porcentaje) > 100 Then Throw New Exception("El Total Ponderado no debe ser Mayor al 100 %")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
