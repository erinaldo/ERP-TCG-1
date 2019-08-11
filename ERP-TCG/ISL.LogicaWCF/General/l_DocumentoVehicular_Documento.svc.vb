Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: si cambia aquí el nombre de clase "l_DocumentoVehicular_Documento", también debe actualizar la referencia a "l_DocumentoVehicular_Documento" tanto en Web.config como en el archivo .svc asociado.
Public Class l_DocumentoVehicular_Documento
    Implements Il_DocumentoVehicular_Documento

    Dim odDocVeh_Doc As New d_DocumentoVehicular_Documento

    Public Function Listar(ByVal oeDocVev_Doc As e_DocumentoVehicular_Documento) As List(Of e_DocumentoVehicular_Documento) Implements Il_DocumentoVehicular_Documento.Listar
        Try
            Return odDocVeh_Doc.Listar(oeDocVev_Doc)
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Guardar(ByVal oeDocVev_Doc As e_DocumentoVehicular_Documento) As Boolean Implements Il_DocumentoVehicular_Documento.Guardar
        Try
            Return odDocVeh_Doc.Guardar(oeDocVev_Doc)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrilla(ByVal Lista As System.Collections.Generic.List(Of EntidadesWCF.e_DocumentoVehicular_Documento)) As Object Implements Il_DocumentoVehicular_Documento.ComboGrilla
        Try
            Return odDocVeh_Doc.ComboGrilla(Lista)
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
