Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MaterialAlmacen
    Implements Il_MaterialAlmacen
    Dim odMaterialAlmacen As New d_MaterialAlmacen

    Public Function ComboGrilla(ByVal oeMaterialAlmacen As EntidadesWCF.e_MaterialAlmacen) As Object Implements Il_MaterialAlmacen.ComboGrilla
        Try
            Return odMaterialAlmacen.ComboGrilla(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal llMaterialAlmacen As System.Collections.Generic.List(Of EntidadesWCF.e_MaterialAlmacen)) As Boolean Implements Il_MaterialAlmacen.Eliminar
        Try
            Return odMaterialAlmacen.Eliminar(llMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal listaObj As System.Collections.Generic.List(Of EntidadesWCF.e_MaterialAlmacen)) As Boolean Implements Il_MaterialAlmacen.Guardar
        Try
            Validar(listaObj)
            Return odMaterialAlmacen.Guardar(listaObj)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar1(ByVal oeMaterialAlmacen As e_MaterialAlmacen) As Boolean Implements Il_MaterialAlmacen.Guardar1
        Try
            Return odMaterialAlmacen.GuardarDetalle(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialAlmacen As EntidadesWCF.e_MaterialAlmacen) As System.Collections.Generic.List(Of EntidadesWCF.e_Material) Implements Il_MaterialAlmacen.Listar
        Try
            Return odMaterialAlmacen.Listar(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar_(ByVal oeMaterialAlmacen As EntidadesWCF.e_MaterialAlmacen) As System.Collections.Generic.List(Of EntidadesWCF.e_MaterialAlmacen) Implements Il_MaterialAlmacen.Listar_
        Try
            Return odMaterialAlmacen.Listar_(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAlmacenMateriales(ByVal oeMaterialAlmacen As EntidadesWCF.e_MaterialAlmacen) As System.Data.DataSet Implements Il_MaterialAlmacen.ListarAlmacenMateriales
        Try
            Return odMaterialAlmacen.ListarAlmMat(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMateriales(ByVal oeMaterialAlmacen As EntidadesWCF.e_MaterialAlmacen) As System.Collections.Generic.List(Of EntidadesWCF.e_Material) Implements Il_MaterialAlmacen.ListarMateriales
        Try
            Return odMaterialAlmacen.ListarMateriales(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterialAlmacen As EntidadesWCF.e_MaterialAlmacen) As EntidadesWCF.e_MaterialAlmacen Implements Il_MaterialAlmacen.Obtener
        Try
            Return odMaterialAlmacen.Obtener(oeMaterialAlmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Validar(ByVal listaObj As System.Collections.Generic.List(Of EntidadesWCF.e_MaterialAlmacen)) Implements Il_MaterialAlmacen.Validar
        Try
            If (listaObj.Count = 0) Then
                Throw New Exception("Debe seleccionar materiales y almacenes para proceder a la asignación.")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
