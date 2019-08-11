Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_MovCuentaCte_Asiento
    Implements Il_MovCuentaCte_Asiento

    Dim odMovCuentaCte_Asiento As New d_MovCuentaCte_Asiento
    Dim l_FuncionesGenerales As New l_FuncionesGenerales


    Public Function Eliminar(ByVal oeMovCuentaCte_Asiento As EntidadesWCF.e_MovCuentaCte_Asiento) As Boolean Implements Il_MovCuentaCte_Asiento.Eliminar
        Try
            Return odMovCuentaCte_Asiento.Eliminar(oeMovCuentaCte_Asiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMovCuentaCte_Asiento As EntidadesWCF.e_MovCuentaCte_Asiento) As Boolean Implements Il_MovCuentaCte_Asiento.Guardar
        Try
            If Validar(oeMovCuentaCte_Asiento) Then
                Return odMovCuentaCte_Asiento.Guardar(oeMovCuentaCte_Asiento, Nothing)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMovCuentaCte_Asiento As EntidadesWCF.e_MovCuentaCte_Asiento) As System.Collections.Generic.List(Of EntidadesWCF.e_MovCuentaCte_Asiento) Implements Il_MovCuentaCte_Asiento.Listar
        Try
            Return odMovCuentaCte_Asiento.Listar(oeMovCuentaCte_Asiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeMovCuentaCte_Asiento As EntidadesWCF.e_MovCuentaCte_Asiento) As EntidadesWCF.e_MovCuentaCte_Asiento Implements Il_MovCuentaCte_Asiento.Obtener
        Try
            Return odMovCuentaCte_Asiento.Obtener(oeMovCuentaCte_Asiento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeMovCuentaCte_Asiento As EntidadesWCF.e_MovCuentaCte_Asiento) As Boolean Implements Il_MovCuentaCte_Asiento.Validar
        Try
            With oeMovCuentaCte_Asiento
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function CrearDT() As DataTable Implements Il_MovCuentaCte_Asiento.CrearDT
        Dim MovCuentaCte_Asiento As New Data.DataTable
        With MovCuentaCte_Asiento
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdMovCuentaCte", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return MovCuentaCte_Asiento
    End Function

End Class
