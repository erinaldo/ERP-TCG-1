Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_Periodo
    Implements Il_Periodo

    Dim odEjercicio As New d_Periodo

    Public Function Eliminar(ByVal oeEjercicio As EntidadesWCF.e_Periodo) As Boolean Implements Il_Periodo.Eliminar
        Try
            Return odEjercicio.Eliminar(oeEjercicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEjercicio As EntidadesWCF.e_Periodo) As Boolean Implements Il_Periodo.Guardar
        Try
            If Validar(oeEjercicio) Then
                Return odEjercicio.Guardar(oeEjercicio)
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEjercicio As EntidadesWCF.e_Periodo) As System.Collections.Generic.List(Of EntidadesWCF.e_Periodo) Implements Il_Periodo.Listar
        Try
            Return odEjercicio.Listar(oeEjercicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeEjercicio As EntidadesWCF.e_Periodo) As EntidadesWCF.e_Periodo Implements Il_Periodo.Obtener
        Try
            Return odEjercicio.Obtener(oeEjercicio)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ObtenerPeriodoVigente(ByVal oePeriodo As e_Periodo, ByVal Mes As Integer) As e_Periodo Implements Il_Periodo.ObtenerPeriodoVigente
        Try
            oePeriodo.TipoOperacion = "P"
            oePeriodo.Mes = Mes
            Return odEjercicio.Obtener(oePeriodo)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Validar(ByVal oePeriodo As EntidadesWCF.e_Periodo) As Boolean Implements Il_Periodo.Validar
        Try
            With oePeriodo
                ValidarDuplicado(.Id, .Codigo, "codigo")
                ValidarTipoCambio(.CambioCompra, .CambioVenta)
            End With
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function ValidarDuplicado(ByVal id As String, ByVal valor As String, ByVal campo As String) As Boolean Implements Il_Periodo.ValidarDuplicado
        Dim oePerido As New e_Periodo
        Try
            If String.IsNullOrEmpty(valor) Then Throw New Exception("No se ha definido que información se va a verificar si existe")
            If String.IsNullOrEmpty(campo) Then Throw New Exception("No se ha especificado el campo que se va a validar")
            Select Case campo
                Case "codigo"
                    oePerido.Codigo = valor
                    'Case "nombre"
                    '    oePerido.Nombre = valor
            End Select
            Dim lePeriodo As New List(Of e_Periodo)
            lePeriodo.AddRange(Listar(oePerido))
            If id = "" Then 'inserta
                If lePeriodo.Count > 0 Then '  existe con el mismo nombre, no puede insertar,  error
                    Throw New Exception("Esta Periodo ya existe: " & lePeriodo(0).Codigo)
                End If
            Else 'aqctualiza
                If lePeriodo.Count > 0 AndAlso lePeriodo(0).Id <> id Then ' existe con el mismo nombre y diferente id,  error
                    Throw New Exception("Esta Periodo ya existe: " & lePeriodo(0).Codigo)
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ValidarTipoCambio(ByVal Com As Double, ByVal Ven As Double) As Boolean Implements Il_Periodo.ValidarTipoCambio
        Try
            If Ven > Com Then
                Return True
            ElseIf Com > Ven Then
                Throw New Exception("El Tipo De Cambio Compra No Puede Ser Mayor Que El Tipo De Cambio Venta")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
