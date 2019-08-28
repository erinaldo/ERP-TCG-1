﻿Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Material_DisenoNeu

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Material_DisenoNeu
        Try
            Dim oeMaterial_DisenoNeu = New e_Material_DisenoNeu( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdDisenoNeumatico").ToString _
                             , o_fila("IdMarcaNeu").ToString _
                             , o_fila("IdMedidaNeu").ToString _
                             , o_fila("TipoBanda").ToString _
                             , o_fila("EstadoNeu").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeMaterial_DisenoNeu
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As e_Material_DisenoNeu

        Try
            Dim ds As DataSet
            With oeMaterial_DisenoNeu
                ds = sqlhelper.ExecuteDataset("STD.Isp_Material_DisenoNeu_Listar", .TipoOperacion, .Id, .IdMaterial)
            End With

            If ds.Tables(0).rows.Count > 0 Then
                oeMaterial_DisenoNeu = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMaterial_DisenoNeu
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As List(Of e_Material_DisenoNeu)
        Try
            Dim ldMaterial_DisenoNeu As New List(Of e_Material_DisenoNeu)
            Dim ds As DataSet
            With oeMaterial_DisenoNeu
                ds = sqlhelper.ExecuteDataset("STD.Isp_Material_DisenoNeu_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .IdDisenoNeumatico _
                        , .TipoBanda _
                        , .EstadoNeu _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                        )
            End With
            oeMaterial_DisenoNeu = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMaterial_DisenoNeu = Cargar(o_Fila)
                ldMaterial_DisenoNeu.Add(oeMaterial_DisenoNeu)
            Next
            Return ldMaterial_DisenoNeu
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMaterial_DisenoNeu
                sqlhelper.ExecuteNonQuery("STD.Isp_Material_DisenoNeu_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdMaterial _
                        , .IdDisenoNeumatico _
                        , .TipoBanda _
                        , .EstadoNeu _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterial_DisenoNeu As e_Material_DisenoNeu) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_DisenoNeu_IAE", "E", _
             "", oeMaterial_DisenoNeu.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class