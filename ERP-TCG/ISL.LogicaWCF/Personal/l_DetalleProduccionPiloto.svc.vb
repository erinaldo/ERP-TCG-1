Imports ERP.AccesoDatos
Imports ERP.EntidadesWCF
Imports System.Runtime.Serialization

Public Class l_DetalleProduccionPiloto
    Implements Il_DetalleProduccionPiloto

    Private odDetalleProduccionPiloto As New d_DetalleProduccionPiloto
    Private l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean Implements Il_DetalleProduccionPiloto.Eliminar
        Try
            Return odDetalleProduccionPiloto.Eliminar(oeDetalleProduccionPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean Implements Il_DetalleProduccionPiloto.Guardar
        Try
            If Validar(oeDetalleProduccionPiloto) Then
                Return odDetalleProduccionPiloto.Guardar(oeDetalleProduccionPiloto)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As List(Of e_DetalleProduccionPiloto) Implements Il_DetalleProduccionPiloto.Listar
        Try
            Return odDetalleProduccionPiloto.Listar(oeDetalleProduccionPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As e_DetalleProduccionPiloto Implements Il_DetalleProduccionPiloto.Obtener
        Try
            Return odDetalleProduccionPiloto.Obtener(oeDetalleProduccionPiloto)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(oeDetalleProduccionPiloto As e_DetalleProduccionPiloto) As Boolean Implements Il_DetalleProduccionPiloto.Validar
        Try
            With oeDetalleProduccionPiloto
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Codigo, "No ha Ingresado Codigo")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Nombre, "No ha Ingresado Nombre")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Abreviatura, "No ha Ingresado Abreviatura")
                'If .leHistorial.Where(Function(it) it.Vigencia = 1).Count = 0 Then Throw New Exception("No ha ingresado valor")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
