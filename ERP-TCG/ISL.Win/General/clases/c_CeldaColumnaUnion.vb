Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class c_CeldaColumnaUnion

    Implements IUIElementCreationFilter
    Public mensajeEmergente As New c_Alertas

    Public Sub AfterCreateChildElements(parent As UIElement) Implements IUIElementCreationFilter.AfterCreateChildElements
        Try
            Dim Fila As RowCellAreaUIElement = TryCast(parent, RowCellAreaUIElement)
            If Not IsNothing(Fila) AndAlso Fila.HasChildElements Then
                Dim leCelda As New List(Of CellUIElement)
                Dim Celda As CellUIElement = Fila.ChildElements(0)
                For i = 1 To Fila.ChildElements.Count - 1
                    Dim ProxCelda As CellUIElement = Fila.ChildElements(i)
                    If Not IsDBNull(Celda.Cell.Value) Then
                        If (Celda.Cell.Value.ToString = "V" Or Celda.Cell.Value.ToString = "I" Or Celda.Cell.Value.ToString = "C") _
                            AndAlso Celda.Cell.Value.ToString = ProxCelda.Cell.Value.ToString Then
                            Dim s As Size = Celda.Rect.Size
                            s.Width += ProxCelda.Rect.Width
                            Celda.Rect = New Rectangle(Celda.Rect.Location, s)
                            ProxCelda.Rect = New Rectangle(0, 0, 0, 0)
                            leCelda.Add(ProxCelda)
                        Else
                            Celda = ProxCelda
                        End If
                    End If
                Next
                For Each _celda In leCelda
                    Fila.ChildElements.Remove(_celda)
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Function BeforeCreateChildElements(parent As UIElement) As Boolean Implements IUIElementCreationFilter.BeforeCreateChildElements
        Return False
    End Function

End Class
