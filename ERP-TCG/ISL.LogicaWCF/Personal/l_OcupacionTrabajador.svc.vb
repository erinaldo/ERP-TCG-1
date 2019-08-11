Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_OcupacionTrabajador
    Implements Il_OcupacionTrabajador

    Dim odOcupacionTrabajador As New d_OcupacionTrabajador
    Dim l_FuncionesGenerales As New l_FuncionesGenerales
    Public Function Eliminar(ByVal oeOcupacionTrabajador As EntidadesWCF.e_OcupacionTrabajador) As Boolean Implements Il_OcupacionTrabajador.Eliminar
        Try
            Return odOcupacionTrabajador.Eliminar(oeOcupacionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeOcupacionTrabajador As EntidadesWCF.e_OcupacionTrabajador) As Boolean Implements Il_OcupacionTrabajador.Guardar
        Try
            If Validar(oeOcupacionTrabajador) Then
                Return odOcupacionTrabajador.Guardar(oeOcupacionTrabajador)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeOcupacionTrabajador As EntidadesWCF.e_OcupacionTrabajador) As System.Collections.Generic.List(Of EntidadesWCF.e_OcupacionTrabajador) Implements Il_OcupacionTrabajador.Listar
        Try
            Return odOcupacionTrabajador.Listar(oeOcupacionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeOcupacionTrabajador As EntidadesWCF.e_OcupacionTrabajador) As EntidadesWCF.e_OcupacionTrabajador Implements Il_OcupacionTrabajador.Obtener
        Try
            Return odOcupacionTrabajador.Obtener(oeOcupacionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ObtenerJefeArea(ByVal oeOcupacionTrabajador As EntidadesWCF.e_OcupacionTrabajador) Implements Il_OcupacionTrabajador.ObtenerJefeArea
        Try
            odOcupacionTrabajador.ObtenerJefeArea(oeOcupacionTrabajador)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Validar que la ocupación de trabajador esté completa
    ''' </summary>
    ''' <param name="oeOcupacionTrabajador"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Validar(ByVal oeOcupacionTrabajador As EntidadesWCF.e_OcupacionTrabajador) As Boolean Implements Il_OcupacionTrabajador.Validar
        Try
            With oeOcupacionTrabajador
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdArea, "Falta ingresar el Area donde presta servicios el trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCargo, "Falta ingresar el Cargo del trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdCentro, "Falta indicar el Centro donde presta servicios el trabajador")
                l_FuncionesGenerales.ValidarCampoNoNulo(.IdOcupacion, "Falta indicar la Ocupación específica del trabajador")

                If .FechaCese <> "01/01/1901" And .FechaCese < .FechaIngreso Then
                    Throw New Exception("La fecha de cese no puede ser anterior a la fecha de ingreso")
                End If

            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
