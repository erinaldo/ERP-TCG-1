Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_DetalleDoc_GuiaTrans
    Implements Il_DetalleDoc_GuiaTrans

    Dim odDetalleDoc_GuiaTrans As New d_DetalleDoc_GuiaTrans

    Public Function CrearDT() As System.Data.DataTable Implements Il_DetalleDoc_GuiaTrans.CrearDT
        Dim DetalleDoc_GuiaTrans As New Data.DataTable
        With DetalleDoc_GuiaTrans
            .Columns.Add(New Data.DataColumn("Id", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdDetalleDoc", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdGuiaTrans", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdEstado", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("FechaCreacion", Type.GetType("System.DateTime")))
            .Columns.Add(New Data.DataColumn("UsuarioCreacion", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Activo", Type.GetType("System.Boolean")))
        End With
        Return DetalleDoc_GuiaTrans
    End Function

    Public Function Eliminar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean Implements Il_DetalleDoc_GuiaTrans.Eliminar
        Try
            Return odDetalleDoc_GuiaTrans.Eliminar(oeDetalleDoc_GuiaTrans)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean Implements Il_DetalleDoc_GuiaTrans.Guardar
        Try
            If Validar(oeDetalleDoc_GuiaTrans) Then
                Return odDetalleDoc_GuiaTrans.Guardar(oeDetalleDoc_GuiaTrans)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As System.Collections.Generic.List(Of e_DetalleDoc_GuiaTrans) Implements Il_DetalleDoc_GuiaTrans.Listar
        Try
            Return odDetalleDoc_GuiaTrans.Listar(oeDetalleDoc_GuiaTrans)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As e_DetalleDoc_GuiaTrans Implements Il_DetalleDoc_GuiaTrans.Obtener
        Try
            Return odDetalleDoc_GuiaTrans.Obtener(oeDetalleDoc_GuiaTrans)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeDetalleDoc_GuiaTrans As e_DetalleDoc_GuiaTrans) As Boolean Implements Il_DetalleDoc_GuiaTrans.Validar
        Try
            With oeDetalleDoc_GuiaTrans
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
