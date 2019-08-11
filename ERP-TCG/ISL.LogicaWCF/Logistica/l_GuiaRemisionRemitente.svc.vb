Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_GuiaRemisionRemitente
    Implements Il_GuiaRemisionRemitente

    Dim odGuiaRemisionRemitente As New d_GuiaRemisionRemitente
    Dim l_FuncionesGenerales As New l_FuncionesGenerales

    Public Function Eliminar(ByVal oeGuiaRemisionRemitente As EntidadesWCF.e_GuiaRemisionRemitente) As Boolean Implements Il_GuiaRemisionRemitente.Eliminar
        Try
            Return odGuiaRemisionRemitente.Eliminar(oeGuiaRemisionRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGuiaRemisionRemitente As EntidadesWCF.e_GuiaRemisionRemitente) As Boolean Implements Il_GuiaRemisionRemitente.Guardar
        Try
            If Validar(oeGuiaRemisionRemitente) Then
                Return odGuiaRemisionRemitente.Guardar(oeGuiaRemisionRemitente)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGuiaRemisionRemitente As EntidadesWCF.e_GuiaRemisionRemitente) As System.Collections.Generic.List(Of EntidadesWCF.e_GuiaRemisionRemitente) Implements Il_GuiaRemisionRemitente.Listar
        Try
            Return odGuiaRemisionRemitente.Listar(oeGuiaRemisionRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeGuiaRemisionRemitente As EntidadesWCF.e_GuiaRemisionRemitente) As EntidadesWCF.e_GuiaRemisionRemitente Implements Il_GuiaRemisionRemitente.Obtener
        Try
            Return odGuiaRemisionRemitente.Obtener(oeGuiaRemisionRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerDetallesGr(ByVal oeGuiaRemisionRemitente As EntidadesWCF.e_GuiaRemisionRemitente) As System.Collections.Generic.List(Of EntidadesWCF.e_Material) Implements Il_GuiaRemisionRemitente.ObtenerDetallesGr
        Try
            Return odGuiaRemisionRemitente.ListarDetallesGRemision(oeGuiaRemisionRemitente)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oeGuiaRemisionRemitente As EntidadesWCF.e_GuiaRemisionRemitente) As Boolean Implements Il_GuiaRemisionRemitente.Validar
        Try
            With oeGuiaRemisionRemitente
                '---------VALIDARRRRRRRRRR-------------
                If oeGuiaRemisionRemitente.TipoOperacion = "I" Then
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdEmpresaProveedor, "Seleccione un Proveedor a la Guia de Remision Remitente")
                    ValidarProveedor(oeGuiaRemisionRemitente)
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Serie, "Ingrese N° Serie a la Guia de Remision remitente")
                    l_FuncionesGenerales.ValidarCampoNoNulo(.Numero, "Ingrese Numero a la Guia de Remision remitente")
                    ValidarGuiaRemisionRemitente(oeGuiaRemisionRemitente)
                    l_FuncionesGenerales.ValidarCampoNoNulo(.IdMotivoTraslado, "Seleccione el Motivo de Traslado a la Guia de Remision Remitente")

                End If
                'l_FuncionesGenerales.ValidarCampoNoNulo(.PlacaVehiculo, "Ingrese Placa del Vehiculo a la Guia de Remision remitente")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.PlacaCarreta, "Ingrese Carreta a la Guia de Remision remitente")
                'l_FuncionesGenerales.ValidarCampoNoNulo(.Piloto, "Ingrese Piloto a la Guia de Remision remitente")

                l_FuncionesGenerales.ValidarNumero(.lstGRRMaterial.Count, "Debe agregar materiales para generar una Guia de Remision Remitente.")
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ValidarGuiaRemisionRemitente(ByVal oeGRRemitente As EntidadesWCF.e_GuiaRemisionRemitente) Implements Il_GuiaRemisionRemitente.ValidarGuiaRemisionRemitente
        Try
            Dim oeGRR As New e_GuiaRemisionRemitente, olGRR As New l_GuiaRemisionRemitente
            oeGRR.Serie = oeGRRemitente.Serie
            oeGRR.Numero = oeGRRemitente.Numero
            oeGRR.IdEmpresaProveedor = oeGRRemitente.IdEmpresaProveedor
            oeGRR.TipoOperacion = 2
            oeGRR = olGRR.Obtener(oeGRR)
            If Not oeGRR.Id = "" Then
                Throw New Exception("La Serie y Numero de la Guia de Remision Remitente ya se encuentra registrado")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ValidarProveedor(ByVal oeGRRemitente As EntidadesWCF.e_GuiaRemisionRemitente) Implements Il_GuiaRemisionRemitente.ValidarProveedor
        Try
            Dim oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor
            oeProveedor.Id = oeGRRemitente.IdEmpresaProveedor
            oeProveedor.Activo = True
            oeProveedor = olProveedor.Obtener(oeProveedor)
            l_FuncionesGenerales.ValidarCampoNoNulo(oeProveedor.Id, "No existe el proveedor seleccionado")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
