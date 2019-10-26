Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_AsientoMov_ObligacionFin
    Implements Il_AsientoMov_ObligacionFin

    Dim odAsientoMov_ObligacionFin As New d_AsientoMov_ObligacionFin
    Private olFunGen As New l_FuncionesGenerales

    Public Function CrearDT() As System.Data.DataTable Implements Il_AsientoMov_ObligacionFin.CrearDT
        Dim Analisis As New Data.DataTable
        With Analisis
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdAsientoMovimiento", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdObligacionFinanciera", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdObligacionPago", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
        End With
        Return Analisis
    End Function

    Public Function Eliminar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean Implements Il_AsientoMov_ObligacionFin.Eliminar
        Try
            Return odAsientoMov_ObligacionFin.Eliminar(oeAsientoMov_ObligacionFin)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean Implements Il_AsientoMov_ObligacionFin.Guardar
        Try
            If Validar(oeAsientoMov_ObligacionFin) Then
                Return odAsientoMov_ObligacionFin.Guardar(oeAsientoMov_ObligacionFin)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As System.Collections.Generic.List(Of e_AsientoMov_ObligacionFin) Implements Il_AsientoMov_ObligacionFin.Listar
        Try
            Return odAsientoMov_ObligacionFin.Listar(oeAsientoMov_ObligacionFin)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As e_AsientoMov_ObligacionFin Implements Il_AsientoMov_ObligacionFin.Obtener
        Try
            Return odAsientoMov_ObligacionFin.Obtener(oeAsientoMov_ObligacionFin)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin) As Boolean Implements Il_AsientoMov_ObligacionFin.Validar
        Try
            With oeAsientoMov_ObligacionFin
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Extornar(oeAsientoMov_ObligacionFin As e_AsientoMov_ObligacionFin, lst_DocRetDet As List(Of e_DocumentoRetencionDetalle)) As Boolean Implements Il_AsientoMov_ObligacionFin.Extornar
        Try
            'olFunGen.ValidarPeriodo(.IdPeriodo, gAreasSGI.Tesoreria, .FechaEmision, "")
            Dim od_DocRetDet As New d_DocumentoRetencionDetalle
            If odAsientoMov_ObligacionFin.Extornar(oeAsientoMov_ObligacionFin) Then
                For Each fila In lst_DocRetDet
                    od_DocRetDet.Guardar(fila)
                Next
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
