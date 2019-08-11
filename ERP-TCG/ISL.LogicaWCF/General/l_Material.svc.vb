Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Material
    Implements Il_Material

    Dim odMaterial As New d_Material
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function ComboGrilla(ByVal ListaMaterial As System.Collections.Generic.List(Of EntidadesWCF.e_Material)) As Object Implements Il_Material.ComboGrilla
        Try
            Return odMaterial.ComboGrilla(ListaMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterial As EntidadesWCF.e_Material) As Boolean Implements Il_Material.Eliminar
        Try
            Return odMaterial.Eliminar(oeMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterial As EntidadesWCF.e_Material) As Boolean Implements Il_Material.Guardar
        Try
            If Validar(oeMaterial) Then
                Return odMaterial.Guardar(oeMaterial)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterial As EntidadesWCF.e_Material) As System.Collections.Generic.List(Of EntidadesWCF.e_Material) Implements Il_Material.Listar
        Try
            Return odMaterial.Listar(oeMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar_(ByVal oeMaterial As EntidadesWCF.e_Material) As System.Collections.Generic.List(Of EntidadesWCF.e_Material) Implements Il_Material.Listar_
        Try
            Return odMaterial.Listar_(oeMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarDS(ByVal oeMaterial As EntidadesWCF.e_Material) As System.Data.DataSet Implements Il_Material.ListarDS
        Try
            Return odMaterial.ListarDS(oeMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarMatAlm(ByVal oeMaterial As EntidadesWCF.e_Material) As System.Collections.Generic.List(Of EntidadesWCF.e_MaterialAlmacen) Implements Il_Material.ListarMatAlm
        Try
            Dim lstMat As New List(Of e_Material)
            Dim lstMatAlm As New List(Of e_MaterialAlmacen)
            Dim oeMatAlm As e_MaterialAlmacen
            lstMat = odMaterial.Listar(oeMaterial)
            For Each Item As e_Material In lstMat
                oeMatAlm = New e_MaterialAlmacen
                oeMatAlm.Id = ""
                oeMatAlm.IdMaterial = Item.Id
                oeMatAlm.CodigoMaterial = Item.Codigo
                oeMatAlm.Material = Item.CodigoNombre
                oeMatAlm.UnidadMedida = Item.UnidadMedida
                oeMatAlm.IdAlmacen = ""
                oeMatAlm.Almacen = ""
                oeMatAlm.StockMaximo = 0
                oeMatAlm.StockMinimo = 0
                oeMatAlm.StockActual = 0
                lstMatAlm.Add(oeMatAlm)
            Next
            Return lstMatAlm
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterial As EntidadesWCF.e_Material) As EntidadesWCF.e_Material Implements Il_Material.Obtener
        Try
            Return odMaterial.Obtener(oeMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerMatNeu(ByVal oeMaterial As EntidadesWCF.e_Material) As EntidadesWCF.e_Material Implements Il_Material.ObtenerMatNeu
        Try
            Return odMaterial.ObtenerMatNeu(oeMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerMaterialSegunAlmacen(ByVal oeMaterial As EntidadesWCF.e_Material) As EntidadesWCF.e_Material Implements Il_Material.ObtenerMaterialSegunAlmacen
        Try
            Return odMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMaterial As EntidadesWCF.e_Material) As Boolean Implements Il_Material.Validar
        Try
            With oeMaterial
                l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "Debe ingresar el nombre")
                If .TipoOperacion = "I" Then ValidarDuplicado(.Id, .Nombre)
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdSubFamilia, "Debe ingresar la Sub familia")
                ValidarSubFamilia(.IdSubFamilia)
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdUnidadMedida, "Debe ingresar la unidad de medida")
                ValidarUnidadMedida(.IdUnidadMedida)
                'l_FuncionesGenerales.ValidarCampoNoNulo(.IdMarca, "Debe ingresar la marca")
                'ValidarMarca(.IdMarca)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarMarca(ByVal id As String) As Boolean Implements Il_Material.ValidarMarca
        Try
            Dim oeMarca As New e_Marca
            Dim odMarca As New d_Marca
            oeMarca.Id = id
            oeMarca = odMarca.Obtener(oeMarca)
            If oeMarca.Id = "" Then
                Throw New Exception("Marca no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarSubFamilia(ByVal id As String) As Boolean Implements Il_Material.ValidarSubFamilia
        Try
            Dim oeSubFamilia As New e_SubFamiliaMaterial
            Dim odSubFamilia As New d_SubFamiliaMaterial
            oeSubFamilia.Id = id
            oeSubFamilia = odSubFamilia.Obtener(oeSubFamilia)
            If oeSubFamilia.Id = "" Then
                Throw New Exception("SubFamilia seleccionada no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarUnidadMedida(ByVal id As String) As Boolean Implements Il_Material.ValidarUnidadMedida
        Try
            Dim oeUnidadMedida As New e_UnidadMedida
            Dim odUnidadMedida As New d_UnidadMedida
            oeUnidadMedida.Id = id
            oeUnidadMedida = odUnidadMedida.Obtener(oeUnidadMedida)
            If oeUnidadMedida.Id = "" Then
                Throw New Exception("Unidad de Medida no existe")
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal ls_Id As String, ByVal ls_Nombre As String) As Boolean Implements Il_Material.ValidarDuplicado
        Try
            Dim objMaterial As New e_Material
            objMaterial.TipoOperacion = "G"
            objMaterial.Nombre = ls_Nombre
            objMaterial = odMaterial.Obtener(objMaterial)
            If Not objMaterial Is Nothing Then
                If objMaterial.Id <> "" Then
                    Throw New Exception("Ya existe: " & ls_Nombre)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener_(oeMaterial As e_Material) As e_Material Implements Il_Material.Obtener_
        Try
            Return odMaterial.Obtener_(oeMaterial)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
