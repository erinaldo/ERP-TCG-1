Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GuiasControl
    Implements Il_GuiasControl

    Dim odGuiasControl As New d_GuiasControl

    Public Function Eliminar(ByVal oeGuiasControl As EntidadesWCF.e_GuiasControl) As Boolean Implements Il_GuiasControl.Eliminar
        Try
            Return odGuiasControl.Eliminar(oeGuiasControl)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function EliminarGuiasTalonarios(ByVal oeGuiasTalonarios As EntidadesWCF.e_GuiasTalonarios) As Boolean Implements Il_GuiasControl.EliminarGuiasTalonarios
        Try
            Return odGuiasControl.Eliminar(oeGuiasTalonarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiasControl As EntidadesWCF.e_GuiasControl) As Boolean Implements Il_GuiasControl.Guardar
        Try
            If Validar(oeGuiasControl) Then
                Return odGuiasControl.Guardar(oeGuiasControl)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function GuardarGuiasTalonarios(ByVal oeGuiasTalonarios As EntidadesWCF.e_GuiasTalonarios) As Boolean Implements Il_GuiasControl.GuardarGuiasTalonarios
        Try
            If ValidarGuiasTalonarios(oeGuiasTalonarios) Then
                Return odGuiasControl.Guardar(oeGuiasTalonarios)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiasControl As EntidadesWCF.e_GuiasControl) As System.Collections.Generic.List(Of EntidadesWCF.e_GuiasControl) Implements Il_GuiasControl.Listar
        Try
            Return odGuiasControl.Listar(oeGuiasControl)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ListarGuiasTalonarios(ByVal oeGuiasTalonarios As EntidadesWCF.e_GuiasTalonarios) As System.Collections.Generic.List(Of EntidadesWCF.e_GuiasTalonarios) Implements Il_GuiasControl.ListarGuiasTalonarios
        Try
            Return odGuiasControl.Listar(oeGuiasTalonarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiasControl As EntidadesWCF.e_GuiasControl) As EntidadesWCF.e_GuiasControl Implements Il_GuiasControl.Obtener
        Try
            Return odGuiasControl.Obtener(oeGuiasControl)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerGuiasTalonarios(ByVal oeGuiasTalonarios As EntidadesWCF.e_GuiasTalonarios) As EntidadesWCF.e_GuiasTalonarios Implements Il_GuiasControl.ObtenerGuiasTalonarios
        Try
            Return odGuiasControl.Obtener(oeGuiasTalonarios)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGuiasControl As EntidadesWCF.e_GuiasControl) As Boolean Implements Il_GuiasControl.Validar
        Try
            With oeGuiasControl
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function ValidarGuiasTalonarios(ByVal oeGuiasTalonarios As EntidadesWCF.e_GuiasTalonarios) As Boolean Implements Il_GuiasControl.ValidarGuiasTalonarios
        Try
            With oeGuiasTalonarios
                '---------VALIDARRRRRRRRRR-------------
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
