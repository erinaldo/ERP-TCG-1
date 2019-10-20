Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports ISL.Controles

''' <summary>
''' Clase de la capa Windows que permite unificar la información que se muestra en las grillas de trabajadores
''' </summary>
''' <remarks></remarks>
Public Class w_Trabajador

#Region "Declaración de variables"

#End Region

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Función que permite generar una grilla y cargarla con la lista de todos los trabajadores 
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ListarTrabajadores(ByVal grilla As Grilla) As List(Of e_Trabajador)
        Try
            Dim lstTrabajadores As New List(Of e_Trabajador)
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            With grilla
                .ResetDisplayLayout()
                oeTrabajador.Activo = True
                If lstTrabajadores.Count = 0 Then
                    lstTrabajadores = olTrabajador.Listar(oeTrabajador)

                    'Dim _leTrab = From le In lstTrabajadores _
                    '              Select le.Seleccion, le.Id, le.oePersona.Dni _
                    '               , le.oePersona.ApellidoPaterno _
                    '              , le.oePersona.ApellidoMaterno, le.oePersona.Nombre _
                    '              , Ocupacion = le.oeOcupacion.Nombre _
                    '              , Area = le.oeArea.Nombre
                    '.DataSource = _leTrab.ToList

                    .DataSource = lstTrabajadores
                End If
                OcultarCamposConID(grilla)
            End With
            Return lstTrabajadores
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub OcultarCamposConID(ByVal grilla As Grilla)
        With grilla
            '.DisplayLayout.Bands(0).Columns.Add("Selec", "Seleccionar")
            '.DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
            '.DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdArea").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdPersona").Hidden = True
            '.DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
            '.DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
            '.DisplayLayout.Bands(0).Columns("ApellidoPaterno").Hidden = True
            '.DisplayLayout.Bands(0).Columns("ApellidoMaterno").Hidden = True
            '.DisplayLayout.Bands(0).Columns("Nombre").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdCargo").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdOcupacion").Hidden = True
            '.DisplayLayout.Bands(0).Columns("ClaveSeguridad").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdEstadoCivil").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdGradoInstruccion").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdLugarNacimiento").Hidden = True
            '.DisplayLayout.Bands(0).Columns("IdTipoRelacionLaboral").Hidden = True
            .DisplayLayout.Bands(0).Columns("Seleccion").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
            .DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
            .DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
            .DisplayLayout.Bands(0).Columns("Seleccion").Header.VisiblePosition = 0
            '.DisplayLayout.Bands(0).Columns("NombreCompleto").Width = 350
            '.DisplayLayout.Bands(0).Columns("NombreCompleto").Header.VisiblePosition = 1
            '.DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 2
            '.DisplayLayout.Bands(0).Columns("Dni").Width = 70
            '.DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 3
            '.DisplayLayout.Bands(0).Columns("Area").Width = 300
            '.DisplayLayout.Bands(0).Columns("Ocupacion").Header.VisiblePosition = 4
            '.DisplayLayout.Bands(0).Columns("RelacionLaboral").Header.VisiblePosition = 5
        End With
    End Sub

    ''' <summary>
    ''' Oculta un campo específico en la grilla
    ''' </summary>
    ''' <param name="grilla"></param>
    ''' <remarks></remarks>
    Public Sub OcultarCampo(ByVal grilla As Grilla, ByVal campo As String)
        Try
            With grilla
                .DisplayLayout.Bands(0).Columns(campo).Hidden = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class
