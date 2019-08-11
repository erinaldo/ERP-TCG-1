Public Class s_Funciones

    ''' <summary>
    ''' Convertir el monto numero de un comprobante electronico a letras
    ''' </summary>
    ''' <param name="numero">Monto del Comprobante Electronico</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function gfc_Convertir(ByVal numero As Double) As String
        Dim letraNumero, letraDecimal, numeroCadena, numeroEnteroCadena As String
        Dim caracterUnidad, caracterDecena, caracterCentena As String
        Dim arrayConector(5), arrayGrupos(4) As String
        Dim i As Integer
        letraNumero = ""
        numeroCadena = numero.ToString("N2").Trim
        letraDecimal = "CON " & numeroCadena.Substring(numeroCadena.IndexOf(".") + 1, 2) & "/100"
        numeroEnteroCadena = Int(numero).ToString.Trim.PadLeft(15, "0")

        'Formacion de grupos de tres
        For i = 0 To 4
            arrayGrupos(4 - i) = numeroEnteroCadena.Substring(i * 3, 3)
        Next

        For i = 4 To 0 Step -1
            caracterUnidad = arrayGrupos(i).Substring(2, 1)
            caracterDecena = arrayGrupos(i).Substring(1, 1)
            caracterCentena = arrayGrupos(i).Substring(0, 1)
            letraNumero = letraNumero & Me.gfc_ProcesarCentena(caracterCentena, caracterDecena, caracterUnidad, i) & _
                Me.gfc_ProcesarDecena(caracterDecena, caracterUnidad) & _
                Me.gfc_ProcesarUnidad(caracterUnidad, caracterDecena, numeroEnteroCadena, i, arrayGrupos) & _
                Me.gfc_ProcesarConector(i, arrayGrupos)
        Next
        Return (letraNumero & letraDecimal)
    End Function

    ''' <summary>
    ''' Procesa la cantidad de unidades de un monto a letras
    ''' </summary>
    ''' <param name="caracterUnidad">Cantidad de Unidades</param>
    ''' <param name="caracterDecena">Cantidad de Decenas</param>
    ''' <param name="numeroEnteroCadena">Parte Entera</param>
    ''' <param name="numeroGrupo">Cantidad de Grupo</param>
    ''' <param name="arraygrupos">Coleecion de Grupos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function gfc_ProcesarUnidad(ByVal caracterUnidad As String, ByVal caracterDecena As String, ByVal numeroEnteroCadena As String, ByVal numeroGrupo As Integer, ByVal arraygrupos() As String) As String
        Dim cadenaRetorno As String = ""
        Select Case caracterUnidad
            Case "0"
                cadenaRetorno = IIf(Val(numeroEnteroCadena) = 0 And numeroGrupo = 0, "CERO ", "")
            Case "1"
                If caracterDecena = "1" Then
                    cadenaRetorno = "ONCE "
                Else
                    If arraygrupos(numeroGrupo) = "001" And (numeroGrupo = 1 Or numeroGrupo = 3) Then
                        cadenaRetorno = ""
                    Else
                        If numeroGrupo >= 1 Then
                            cadenaRetorno = "UN "
                        Else
                            cadenaRetorno = "UNO "
                        End If
                    End If
                End If
            Case "2"
                cadenaRetorno = IIf(caracterDecena = "1", "DOCE ", "DOS ")
            Case "3"
                cadenaRetorno = IIf(caracterDecena = "1", "TRECE ", "TRES ")
            Case "4"
                cadenaRetorno = IIf(caracterDecena = "1", "CATORCE ", "CUATRO ")
            Case "5"
                cadenaRetorno = IIf(caracterDecena = "1", "QUINCE ", "CINCO ")
            Case "6"
                cadenaRetorno = IIf(caracterDecena = "1", "DIECISEIS ", "SEIS ")
            Case "7"
                cadenaRetorno = IIf(caracterDecena = "1", "DIECISIETE ", "SIETE ")
            Case "8"
                cadenaRetorno = IIf(caracterDecena = "1", "DIECIOCHO ", "OCHO ")
            Case "9"
                cadenaRetorno = IIf(caracterDecena = "1", "DIECINUEVE ", "NUEVE ")

        End Select
        Return cadenaRetorno
    End Function

    ''' <summary>
    ''' Procesa la cantidad de decenas de un monto a letras
    ''' </summary>
    ''' <param name="caracterDecena">Cantidad de Decenas</param>
    ''' <param name="caracterUnidad">Cantidad de Unidades</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function gfc_ProcesarDecena(ByVal caracterDecena As String, ByVal caracterUnidad As String) As String
        Dim cadenaRetorno As String = ""
        Select Case caracterDecena
            Case "0"
                cadenaRetorno = ""
            Case "1"
                cadenaRetorno = IIf(caracterUnidad = "0", "DIEZ ", "")
            Case "2"
                cadenaRetorno = IIf(caracterUnidad = "0", "VEINTE ", "VEINTI")
            Case "3"
                cadenaRetorno = "TREINTA " & IIf(caracterUnidad <> "0", "Y ", "")
            Case "4"
                cadenaRetorno = "CUARENTA " & IIf(caracterUnidad <> "0", "Y ", "")
            Case "5"
                cadenaRetorno = "CINCUENTA " & IIf(caracterUnidad <> "0", "Y ", "")
            Case "6"
                cadenaRetorno = "SESENTA " & IIf(caracterUnidad <> "0", "Y ", "")
            Case "7"
                cadenaRetorno = "SETENTA " & IIf(caracterUnidad <> "0", "Y ", "")
            Case "8"
                cadenaRetorno = "OCHENTA " & IIf(caracterUnidad <> "0", "Y ", "")
            Case "9"
                cadenaRetorno = "NOVENTA " & IIf(caracterUnidad <> "0", "Y ", "")

        End Select
        Return cadenaRetorno
    End Function

    ''' <summary>
    ''' Procesa la cantidad de centenas de un monto a letras
    ''' </summary>
    ''' <param name="caracterCentena">Cantidad de Centenas</param>
    ''' <param name="caracterDecena">Cantidad de Decenas</param>
    ''' <param name="caracterUnidad">Cantidad de Unidades</param>
    ''' <param name="numeroGrupo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function gfc_ProcesarCentena(ByVal caracterCentena As String, ByVal caracterDecena As String, ByVal caracterUnidad As String, ByVal numeroGrupo As Integer) As String
        Dim cadenaRetorno As String = ""
        Select Case caracterCentena
            Case "0"
                cadenaRetorno = ""
            Case "1"
                cadenaRetorno = IIf(caracterDecena & caracterUnidad = "00", "CIEN ", "CIENTO ")
            Case "2"
                cadenaRetorno = "DOSCIENTOS "
            Case "3"
                cadenaRetorno = "TRESCIENTOS "
            Case "4"
                cadenaRetorno = "CUATROCIENTOS "
            Case "5"
                cadenaRetorno = "QUINIENTOS "
            Case "6"
                cadenaRetorno = "SEISCIENTOS "
            Case "7"
                cadenaRetorno = "SETECIENTOS "
            Case "8"
                cadenaRetorno = "OCHOCIENTOS "
            Case "9"
                cadenaRetorno = "NOVECIENTOS "

        End Select
        Return cadenaRetorno
    End Function

    ''' <summary>
    ''' Procesar Montos superiores a Millares
    ''' </summary>
    ''' <param name="numeroGrupo">Cantidad de Grupo</param>
    ''' <param name="arraygrupos">Coleccion de Grupos</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function gfc_ProcesarConector(ByVal numeroGrupo As Integer, ByVal arraygrupos() As String) As String
        Dim cadenaRetorno As String = ""
        Select Case numeroGrupo
            Case 0
                cadenaRetorno = ""
            Case 1
                cadenaRetorno = IIf(arraygrupos(1) > "000", "MIL ", "")
            Case 2
                If arraygrupos(2) > "000" Or arraygrupos(3) > "000" Then
                    If arraygrupos(2) = "001" Then
                        cadenaRetorno = "MILLON "
                    Else
                        cadenaRetorno = "MILLONES "
                    End If
                Else
                    cadenaRetorno = ""
                End If
            Case 3
                cadenaRetorno = IIf(arraygrupos(3) > "000", "MIL ", "")
            Case 4
                If arraygrupos(4) > "000" Then
                    If arraygrupos(4) = "001" Then
                        cadenaRetorno = "BILLON "
                    Else
                        cadenaRetorno = "BILLONES "
                    End If
                Else
                    cadenaRetorno = ""
                End If
        End Select
        Return cadenaRetorno
    End Function

End Class
