Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: si cambia aquí el nombre de clase "l_Combo", también debe actualizar la referencia a "l_Combo" tanto en Web.config como en el archivo .svc asociado.
<DataContract(), Serializable()> _
Public Class l_Combo
    Implements Il_Combo
    Dim odCombo As d_Combo

    Public Function ComboGrilla(ByVal Lista As System.Collections.Generic.List(Of EntidadesWCF.e_Combo)) As Object Implements Il_Combo.ComboGrilla
        Try
            odCombo = New d_Combo
            Return odCombo.ComboGrilla(Lista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ComboGrillaEspecial(ByVal Lista As System.Collections.Generic.List(Of EntidadesWCF.e_Combo)) As Object Implements Il_Combo.ComboGrillaEspecial
        Try
            odCombo = New d_Combo
            Return odCombo.ComboGrillaEspecial(Lista)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCombo As EntidadesWCF.e_Combo) As System.Collections.Generic.List(Of EntidadesWCF.e_Combo) Implements Il_Combo.Listar
        Try
            odCombo = New d_Combo
            Return odCombo.Listar(oeCombo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeCombo As EntidadesWCF.e_Combo) As EntidadesWCF.e_Combo Implements Il_Combo.Obtener
        Try
            odCombo = New d_Combo
            Return odCombo.Obtener(oeCombo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCombo As EntidadesWCF.e_Combo) As Boolean Implements Il_Combo.Guardar
        Try
            odCombo = New d_Combo
            Return odCombo.Guardar(oeCombo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
