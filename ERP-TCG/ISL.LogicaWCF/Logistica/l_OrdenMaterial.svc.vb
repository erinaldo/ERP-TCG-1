Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OrdenMaterial
    Implements Il_OrdenMaterial

    Dim odOrdenMaterial As New d_OrdenMaterial
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As Boolean Implements Il_OrdenMaterial.Eliminar
        Try
            Return odOrdenMaterial.Eliminar(oeOrdenMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As Boolean Implements Il_OrdenMaterial.Guardar
        Try
            If Validar(oeOrdenMaterial) Then
                Return odOrdenMaterial.Guardar(oeOrdenMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenMaterial) Implements Il_OrdenMaterial.Listar
        Try
            Return odOrdenMaterial.Listar(oeOrdenMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDS(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As Data.DataSet Implements Il_OrdenMaterial.ListarDS
        Try
            Return odOrdenMaterial.ListarDS(oeOrdenMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarOSNeumaticos(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenMaterial) Implements Il_OrdenMaterial.ListarOSNeumaticos
        Try
            Return odOrdenMaterial.ListarOSNeumaticos(oeOrdenMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarParaOCC(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As System.Data.DataSet Implements Il_OrdenMaterial.ListarParaOCC
        Try
            ValidarParaOCC(oeOrdenMaterial)
            Return odOrdenMaterial.ListarParaOCC(oeOrdenMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalle(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenMaterial) Implements Il_OrdenMaterial.ListarDetalle
        Try
            Return odOrdenMaterial.ListarDetalle(oeOrdenMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As EntidadesWCF.e_OrdenMaterial Implements Il_OrdenMaterial.Obtener
        Try
            Return odOrdenMaterial.Obtener(oeOrdenMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As Boolean Implements Il_OrdenMaterial.Validar
        Try
            With oeOrdenMaterial
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdAlmacen, "Seleccione un almacen")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdUnidadMedida, "Seleccione una Unidad de Medida")

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarParaOCC(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial) As Boolean Implements Il_OrdenMaterial.ValidarParaOCC
        Try
            With oeOrdenMaterial
                If oeOrdenMaterial.FechaFin.Date < oeOrdenMaterial.FechaInicio.Date Then
                    Throw New Exception("La fecha de fin debe ser mayor o igual a la fecha de inicio.")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
