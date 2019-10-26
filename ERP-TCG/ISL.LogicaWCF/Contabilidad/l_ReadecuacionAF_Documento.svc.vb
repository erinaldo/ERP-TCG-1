Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF

<DataContract(), Serializable()>
Public Class l_ReadecuacionAF_Documento
    Implements Il_ReadecuacionAF_Documento
    Private odReadecuacionAF_Documento As New d_ReadecuacionAF_Documento

    Public Function Obtener(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As e_ReadecuacionAF_Documento Implements Il_ReadecuacionAF_Documento.Obtener
        Try
            Return odReadecuacionAF_Documento.Obtener(oeReadecuacionAF_Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As List(Of e_ReadecuacionAF_Documento) Implements Il_ReadecuacionAF_Documento.Listar
        Try
            Return odReadecuacionAF_Documento.Listar(oeReadecuacionAF_Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As Boolean Implements Il_ReadecuacionAF_Documento.Guardar
        Try
            Return odReadecuacionAF_Documento.Guardar(oeReadecuacionAF_Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(oeReadecuacionAF_Documento As e_ReadecuacionAF_Documento) As Boolean Implements Il_ReadecuacionAF_Documento.Eliminar
        Try
            Return odReadecuacionAF_Documento.Eliminar(oeReadecuacionAF_Documento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class