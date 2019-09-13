Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Combo
    Dim SqlHelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Combo
        Try
            Dim array As New ArrayList
            Dim oeCombo As New e_Combo
            If band = "Comisionistas" Then
                array.Add(o_fila("apellidoPaterno").ToString)
                array.Add(o_fila("apellidoMaterno").ToString)
                array.Add(o_fila("soloNombre").ToString)
                array.Add(o_fila("telefono").ToString)
                array.Add(o_fila("idPersona").ToString)
            End If

            If band = "ModeloFuncional" Then
                array.Add(o_fila("Motriz").ToString)
            End If
            If band = "Tracto" Or band = "Carreta" Then
                array.Add(o_fila("IdModeloFuncional").ToString)
                array.Add(o_fila("IndPropiedad").ToString)
                array.Add(o_fila("Propietario").ToString)
                array.Add(o_fila("IdMarca").ToString)
                array.Add(o_fila("NroEquipoMovil").ToString)
                array.Add(o_fila("IdModeloFuncional").ToString)
            End If
            If band = "Contacto" Then
                array.Add(o_fila("apellidoPaterno").ToString)
                array.Add(o_fila("apellidoMaterno").ToString)
                array.Add(o_fila("soloNombre").ToString)
                array.Add(o_fila("telefono").ToString)
            End If
            If band = "Trabajador" Then
                array.Add(o_fila("IndTipo").ToString)
                array.Add(o_fila("IndPiloto").ToString)
            End If
            If band = "TD VEHICULAR" Then
                array.Add(o_fila("CodigoSunat").ToString)
            End If
            If band = "Piloto" Then
                array.Add(o_fila("FechaCese").ToString)
            End If
            If band = "Copiloto" Then
                array.Add(o_fila("FechaCese").ToString)
            End If
            If band = "" Then
                oeCombo = New e_Combo( _
                            o_fila("Id").ToString _
                            , o_fila("Nombre").ToString _
                            , o_fila("Descripcion").ToString _
                            )
            Else
                oeCombo = New e_Combo( _
                            o_fila("Id").ToString _
                            , o_fila("Nombre").ToString _
                            , o_fila("Descripcion").ToString _
                            , array)
            End If
            Return oeCombo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCombo As e_Combo) As e_Combo
        Try
            Dim ds As DataSet
            With oeCombo
                ds = SqlHelper.ExecuteDataset("[STD].[Isp_Combo_Listar]", .Id, .Nombre)
            End With
            oeCombo = New e_Combo
            If ds.Tables(0).Rows.Count > 0 Then
                oeCombo = Cargar(ds.Tables(0).Rows(0))
            Else
                oeCombo = New e_Combo
            End If
            Return oeCombo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Dim band As String = ""

    Public Function Listar(ByVal oeCombo As e_Combo) As List(Of e_Combo)
        Try
            Dim lista As New List(Of e_Combo)
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            band = oeCombo.Nombre
            With oeCombo
                If .Nombre = "Guias" Then .Id = .PrefijoID
                If .Nombre = "IdSyNroAsiento" Then .Id = .PrefijoID
                If .Nombre = "ConceptoEliminacion" Or .Nombre = "ConceptoCancelacion" Or .Nombre = "ConceptoAsignacion" Then
                    ds = SqlHelper.ExecuteDataset("[STD].[Isp_ConfiguracionDato_Listar]", _
                                                  "L", _
                                                  "", _
                                                  "", _
                                                  0, _
                                                 .Nombre, _
                                                 .Descripcion.Split(";")(0).ToString, _
                                                 .Descripcion.Split(";")(1).ToString, _
                                                 1, _
                                                 .Descripcion.Split(";")(2).ToString)
                Else
                    ds = SqlHelper.ExecuteDataset("[STD].[Isp_Combo_Listar]", _
                                              .Id, _
                                              .Nombre, _
                                              .Descripcion, _
                                              .Fecha)
                End If
                
            End With
            oeCombo = Nothing

            If ds.Tables(0).Rows.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeCombo = Cargar(o_Fila)
                    lista.Add(oeCombo)
                Next
            Else
                lista = New List(Of e_Combo)
            End If

            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComboGrilla(ByVal Lista As List(Of e_Combo))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Combo In Lista
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Id
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function ComboGrillaEspecial(ByVal Lista As List(Of e_Combo))
        Dim ds = New DataTable
        ds.Columns.Add("Id")
        ds.Columns.Add("Nombre")
        For Each item As e_Combo In Lista
            Dim newRow As DataRow = ds.NewRow()
            newRow("Id") = item.Descripcion
            newRow("Nombre") = item.Nombre
            ds.Rows.Add(newRow)
        Next
        Return ds
    End Function

    Public Function Guardar(ByVal oeCombo As e_Combo) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCombo
                SqlHelper.ExecuteNonQuery("[STD].[Isp_Combo_IAE]", .Tipo, .Id, .Nombre)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class