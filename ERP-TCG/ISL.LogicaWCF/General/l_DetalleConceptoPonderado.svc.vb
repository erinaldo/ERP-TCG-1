Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleConceptoPonderado
    Implements Il_DetalleConceptoPonderado

    Dim oddetalleConceptoPonderado As New d_DetalleConceptoPonderado
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean Implements Il_DetalleConceptoPonderado.Eliminar
        Try
            Return oddetalleConceptoPonderado.Eliminar(oeDetalleConceptoPonderado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean Implements Il_DetalleConceptoPonderado.Guardar
        Try
            If Validar(oeDetalleConceptoPonderado) Then
                Return oddetalleConceptoPonderado.Guardar(oeDetalleConceptoPonderado)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As List(Of e_DetalleConceptoPonderado) Implements Il_DetalleConceptoPonderado.Listar
        Try
            Return oddetalleConceptoPonderado.Listar(oeDetalleConceptoPonderado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As e_DetalleConceptoPonderado Implements Il_DetalleConceptoPonderado.Obtener
        Try
            Return oddetalleConceptoPonderado.Obtener(oeDetalleConceptoPonderado)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleConceptoPonderado As e_DetalleConceptoPonderado) As Boolean Implements Il_DetalleConceptoPonderado.Validar
        Try
            With oeDetalleConceptoPonderado
                l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "Ingrese Codigo")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Ingrese Nombre")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Ingrese Abreviatura")
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function
End Class
