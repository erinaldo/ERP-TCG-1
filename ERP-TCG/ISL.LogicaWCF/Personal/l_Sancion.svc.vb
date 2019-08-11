Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Sancion
    Implements Il_Sancion

    Dim odSancion As New d_Sancion
    Dim IslFuncion As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeSancion As EntidadesWCF.e_Sancion) As Boolean Implements Il_Sancion.Eliminar
        Try
            Return odSancion.Eliminar(oeSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSancion As EntidadesWCF.e_Sancion) As Boolean Implements Il_Sancion.Guardar
        Try
            If Validar(oeSancion) Then
                Return odSancion.Guardar(oeSancion)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSancion As EntidadesWCF.e_Sancion) As System.Collections.Generic.List(Of EntidadesWCF.e_Sancion) Implements Il_Sancion.Listar
        Try
            Return odSancion.Listar(oeSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeSancion As EntidadesWCF.e_Sancion) As EntidadesWCF.e_Sancion Implements Il_Sancion.Obtener
        Try
            Return odSancion.Obtener(oeSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeSancion As EntidadesWCF.e_Sancion) As Boolean Implements Il_Sancion.Validar
        Try
            With oeSancion
                IslFuncion.ValidarCampoNoNulo(.IdTrabajador, "Seleccione Trabajador")
                IslFuncion.ValidarCampoNoNulo(.IdArea, "Seleccione Area")
                IslFuncion.ValidarCampoNoNulo(.IdGrupo, "Seleccione Grupo")
                IslFuncion.ValidarCampoNoNulo(.IdConcepto, "Seleccione Concepto")
                If .Monto = 0 Then Throw New Exception("El Monto debe ser Mayor a Cero")
                If .NroCuota > 0 Then
                    Dim _coe As Integer = 0
                    _coe = IIf(.Monto < 80, 1, .Monto / 80)
                    If .NroCuota > _coe Then Throw New Exception("Como máximo puede ingresar " & _coe & " cuotas.")
                End If
            End With
            Return True
        Catch ex As Exception
            Throw

        End Try
    End Function

    Public Function GuardarLista(leSancion As List(Of e_Sancion)) As Boolean Implements Il_Sancion.GuardarLista
        Try
            Return odSancion.GuardarLista(leSancion)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
