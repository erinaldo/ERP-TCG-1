Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_BolsaViaje

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_BolsaViaje
        Try
            Dim oeBolsaViaje = New e_BolsaViaje( _
                             o_fila("Id").ToString _
                             , o_fila("IdRuta").ToString _
                            , o_fila("TipoVehiculo").ToString _
                             , o_fila("ConceptoGasto").ToString _
                             , o_fila("Minimo").ToString _
                             , o_fila("DescripcionMinimo").ToString _
                             , o_fila("Normal").ToString _
                             , o_fila("DescripcionNormal").ToString _
                             , o_fila("Maximo").ToString _
                             , o_fila("DescripcionMaximo").ToString _
                             , o_fila("Activo").ToString)
            Return oeBolsaViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeBolsaViaje As e_BolsaViaje) As e_BolsaViaje

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("[OPE].[Isp_BolsaViaje_Listar]", _
                                          oeBolsaViaje.TipoOperacion, oeBolsaViaje.Id, oeBolsaViaje.IdRuta)
            oeBolsaViaje = New e_BolsaViaje
            If ds.Tables(0).Rows.Count > 0 Then
                oeBolsaViaje = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeBolsaViaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeBolsaViaje As e_BolsaViaje) As List(Of e_BolsaViaje)
        Try
            Dim ldBolsaViaje As New List(Of e_BolsaViaje)
            Dim ds As DataSet
            With oeBolsaViaje
                ds = sqlhelper.ExecuteDataset("[OPE].[Isp_BolsaViaje_Listar]", "" _
                                            , .Id _
                                            , .IdRuta _
                                            , .TipoVehiculo _
                                            , .ConceptoGasto)
            End With
            oeBolsaViaje = Nothing
            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeBolsaViaje = Cargar(o_Fila)
                    ldBolsaViaje.Add(oeBolsaViaje)
                Next
                Return ldBolsaViaje
            Else
                ldBolsaViaje = New List(Of e_BolsaViaje)
                Return ldBolsaViaje
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeBolsaViaje
                sqlhelper.ExecuteNonQuery("[OPE].[Isp_BolsaViaje_IAE]",
                                          "I",
                                          .PrefijoID,
                                            .Id _
                                            , .IdRuta _
                                            , .TipoVehiculo _
                                            , .ConceptoGasto _
                                            , .Minimo _
                                            , .DescripcionMinimo _
                                            , .Normal _
                                            , .DescripcionNormal _
                                            , .Maximo _
                                            , .DescripcionMaximo _
                                            , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeBolsaViaje As e_BolsaViaje) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("[OPE].[Isp_BolsaViaje_IAE]", _
                                        "E", _
                                         "", _
                                         oeBolsaViaje.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
   
End Class