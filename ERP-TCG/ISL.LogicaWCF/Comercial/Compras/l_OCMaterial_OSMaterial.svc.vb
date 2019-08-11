Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF

' NOTA: si cambia aquí el nombre de clase "l_OCMaterial_OSMaterial", también debe actualizar la referencia a "l_OCMaterial_OSMaterial" tanto en Web.config como en el archivo .svc asociado.
Public Class l_OCMaterial_OSMaterial
    Implements Il_OCMaterial_OSMaterial

    Dim odOCMaterial_OSMaterial As New d_OCMaterial_OSMaterial

    Public Function Obtener(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As e_OCMaterial_OSMaterial Implements Il_OCMaterial_OSMaterial.Obtener
        Try
            Return odOCMaterial_OSMaterial.Obtener(oeOCMaterial_OSMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As List(Of e_OCMaterial_OSMaterial) Implements Il_OCMaterial_OSMaterial.Listar
        Try
            Return odOCMaterial_OSMaterial.Listar(oeOCMaterial_OSMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOCMaterial_OSMaterial As e_OCMaterial_OSMaterial) As Boolean Implements Il_OCMaterial_OSMaterial.Guardar
        Try
            Return odOCMaterial_OSMaterial.Guardar(oeOCMaterial_OSMaterial)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
