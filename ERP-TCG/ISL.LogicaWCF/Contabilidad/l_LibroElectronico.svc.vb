Imports ERP.EntidadesWCF
Imports ERP.AccesoDatos

Public Class l_LibroElectronico
    Implements Il_LibroElectronico

    Dim odLibroElectronico As New d_LibroElectronico
    Dim olDetalleLibroElectronico As New l_DetalleLibroElectronico
    Dim odDetalleLibroElectronico As New d_DetalleLibroElectronico

    Public Function Eliminar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean Implements Il_LibroElectronico.Eliminar
        Try
            Return odLibroElectronico.Eliminar(oeLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean Implements Il_LibroElectronico.Guardar
        Try
            'Se cambio el procedimiento de guardar en la BD el detalle antes "I"
            Dim dtDLE As Data.DataTable = olDetalleLibroElectronico.CrearDT
            If oeLibroElectronico.TipoOperacion = "CAMBIO" Then


                Dim Id As String = odDetalleLibroElectronico.UltimoIdInserta(oeLibroElectronico.PrefijoID)
                Dim lsPrefijo As String = Left(Id, 3)
                Dim lsNumero As Integer = CInt(Right(Id, Len(Id) - 3))

                For Each oeDetLE As e_DetalleLibroElectronico In oeLibroElectronico.leDetallePLE
                    If oeDetLE.Id = "" Or IsDBNull(oeDetLE.Id = "") Then
                        Dim rwDetalleLE As Data.DataRow
                        rwDetalleLE = dtDLE.NewRow
                        With oeDetLE
                            rwDetalleLE("Id") = lsPrefijo & CompletaConCeros(lsNumero.ToString, 9)
                            rwDetalleLE("IdLibroElectronico") = ""
                            rwDetalleLE("IdMovimientoDocumento") = .IdMovimientoDocumento
                            rwDetalleLE("Periodo") = .Periodo
                            rwDetalleLE("CodigoUnicoOperacion") = .CodigoUnicoOperacion
                            rwDetalleLE("NumeroCorrelativo") = .NumeroCorrelativo
                            rwDetalleLE("FechaEmision") = .FechaEmision
                            rwDetalleLE("FechaVencimiento") = .FechaVencimiento
                            rwDetalleLE("TipoDocumento") = .TipoDocumento
                            rwDetalleLE("SerieDoc") = .SerieDoc
                            rwDetalleLE("AnioEmisionDUA") = .AnioEmisionDUA
                            rwDetalleLE("NumeroDoc") = .NumeroDoc
                            rwDetalleLE("NumeroDoc2") = .NumeroDoc2
                            rwDetalleLE("TipoDocIdentidad") = .TipoDocIdentidad
                            rwDetalleLE("NumeroDocIdentidad") = .NumeroDocIdentidad
                            rwDetalleLE("Denominacion") = .Denominacion
                            rwDetalleLE("SubTotal1") = .SubTotal1
                            rwDetalleLE("IGV1") = .IGV1
                            rwDetalleLE("SubTotal2") = .SubTotal2
                            rwDetalleLE("IGV2") = .IGV2
                            rwDetalleLE("SubTotal3") = .SubTotal3
                            rwDetalleLE("IGV3") = .IGV3
                            rwDetalleLE("NoGravada") = .NoGravada
                            rwDetalleLE("ISC") = .ISC
                            rwDetalleLE("OtrosTributos") = .OtrosTributos
                            rwDetalleLE("Total") = .Total
                            rwDetalleLE("TipoCambio") = .TipoCambio
                            rwDetalleLE("FechaEmisionAso") = .FechaEmisionAso
                            rwDetalleLE("TipoDocumentoAso") = .TipoDocumentoAso
                            rwDetalleLE("SerieAso") = .SerieAso
                            rwDetalleLE("NumeroDocAso") = .NumeroDocAso
                            rwDetalleLE("NumeroDocAso2") = .NumeroDocAso2
                            rwDetalleLE("FechaEmisionDetraccion") = .FechaEmisionDetraccion
                            rwDetalleLE("NroConstanciaDetraccion") = .NroConstanciaDetraccion
                            rwDetalleLE("CodigoDuaDsi") = .CodigoDuaDsiFob
                            If .CodigoDuaDsiFob = "" Then
                                rwDetalleLE("ValorFob") = 0
                            Else
                                rwDetalleLE("ValorFob") = .CodigoDuaDsiFob
                            End If
                            rwDetalleLE("NroCorrelativoVenta") = .NroCorrelativoVenta
                            rwDetalleLE("NroCorrelativoCompra") = .NroCorrelativoCompra
                            rwDetalleLE("NroCorrelativoConsignacion") = .NroCorrelativoConsignacion
                            rwDetalleLE("Retencion") = .Retencion
                            rwDetalleLE("Indicador") = .Indicador
                            rwDetalleLE("Activo") = True
                            dtDLE.Rows.Add(rwDetalleLE)
                        End With
                        lsNumero = lsNumero + 1
                    End If
                Next
                oeLibroElectronico.dtDetalleLE = dtDLE
            Else
                oeLibroElectronico.dtDetalleLE = dtDLE
            End If

            Return odLibroElectronico.Guardar(oeLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeLibroElectronico As e_LibroElectronico) As System.Collections.Generic.List(Of e_LibroElectronico) Implements Il_LibroElectronico.Listar
        Try
            Return odLibroElectronico.Listar(oeLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLibroElectronico As e_LibroElectronico) As e_LibroElectronico Implements Il_LibroElectronico.Obtener
        Try
            Return odLibroElectronico.Obtener(oeLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Validar(ByVal oeLibroElectronico As e_LibroElectronico) As Boolean Implements Il_LibroElectronico.Validar
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CompletaConCeros(ByVal ls_Tex As String, ByVal lnCantidad As Integer) As String Implements Il_LibroElectronico.CompletaConCeros
        Dim Retorna As String = ""
        For i As Integer = 1 To lnCantidad - Len(ls_Tex)
            Retorna = Retorna & "0"
        Next
        Return Retorna + ls_Tex
    End Function

    Public Function ActualizarCUO(oeLibroElectronico As e_LibroElectronico) As Boolean Implements Il_LibroElectronico.ActualizarCUO
        Try
            Return odLibroElectronico.ActualizarCUO(oeLibroElectronico)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
