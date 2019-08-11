Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "l_TipoBien" en el código, en svc y en el archivo de configuración a la vez.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione l_TipoBien.svc o l_TipoBien.svc.vb en el Explorador de soluciones e inicie la depuración.

<DataContract(), Serializable()> _
Public Class l_TipoBien
    Implements Il_TipoBien

    Private odTipoBien As d_TipoBien

    Public Function ComboGrilla(Lista As List(Of e_TipoBien)) As Object 'Implements Il_Combo.ComboGrilla
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Id")
            ds.Columns.Add("Nombre")
            For Each item As e_TipoBien In Lista
                Dim newRow As DataRow = ds.NewRow()
                newRow("Id") = item.Id
                If item.Nombre.Length > 50 Then
                    newRow("Nombre") = item.Codigo + " - " + item.Nombre.Substring(0, 50)
                Else
                    newRow("Nombre") = item.Codigo + " - " + item.Nombre
                End If
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeTipoBien As e_TipoBien) As e_TipoBien Implements Il_TipoBien.Obtener
        Try
            odTipoBien = New d_TipoBien
            Return odTipoBien.Obtener(oeTipoBien)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeTipoBien As e_TipoBien) As List(Of e_TipoBien) Implements Il_TipoBien.Listar
        Try
            odTipoBien = New d_TipoBien
            Return odTipoBien.Listar(oeTipoBien)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function Guardar(ByVal oeTipoBien As e_TipoBien) As Boolean Implements Il_TipoBien.Guardar
    '    Try
    '        Dim bol_guardado As Boolean = False
    '        If Validar(oeTipoBien) Then
    '            bol_guardado = odTipoBien.Guardar(oeTipoBien)
    '        End If
    '        Return bol_guardado
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Public Function Eliminar(ByVal oeTipoBien As e_TipoBien) As Boolean Implements Il_TipoBien.Eliminar
    '    Try
    '        Return odTipoBien.Eliminar(oeTipoBien)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    'Private Function Validar(ByVal oeTipoBien As e_TipoBien) As Boolean
    '    Try
    '        With oeTipoBien
    '            '---------VALIDARRRRRRRRRR-------------
    '        End With
    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

End Class
