Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Impuesto
    Implements Il_Impuesto
    Private oeImpuesto As New e_Impuesto
    Private odImpuesto As New d_Impuesto
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeImpuesto As e_Impuesto) As Boolean Implements Il_Impuesto.Eliminar
        Try
            l_FuncionesGenerales.ValidarCampoNoNulo(oeImpuesto.Id, "Falta especificar el Id del impuesto que se va a eliminar")
            Return odImpuesto.Eliminar(oeImpuesto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeImpuesto As e_Impuesto) As Boolean Implements Il_Impuesto.Guardar
        Try
            If Validar(oeImpuesto) Then
                Return odImpuesto.Guardar(oeImpuesto)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function IGV(ByVal fecha As Date) As e_Impuesto Implements Il_Impuesto.IGV
        Try
            If Not IsDate(fecha) Then fecha = Now
            Return odImpuesto.IGV(fecha)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeImpuesto As e_Impuesto) As System.Collections.Generic.List(Of e_Impuesto) Implements Il_Impuesto.Listar
        Try
            Return odImpuesto.Listar(oeImpuesto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeImpuesto As e_Impuesto) As e_Impuesto Implements Il_Impuesto.Obtener
        Try
            Return odImpuesto.Obtener(oeImpuesto)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeImpuesto As e_Impuesto) As Boolean Implements Il_Impuesto.Validar
        Try
            With oeImpuesto
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre completo del Impuesto")
                l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "Debe ingresar la abreviatura del impuesto")
                If Not IsDate(.FechaInicio) Then Throw New Exception("La fecha de inicio de vigencia del impuesto es obligatoria")
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
