Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Net.http
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports HtmlAgilityPack
Imports tessnet2

Public Class ConsultaRucSunat
    Private captcha As String = ""
    Private objEncoding As Encoding = Encoding.GetEncoding("UTF-8")
    Private Shared httpClient As HttpClient = New HttpClient(New HttpClientHandler With {
        .UseProxy = True
    })
    Private rutaTessData As String = String.Empty

    Public Sub New()
        If httpClient.BaseAddress Is Nothing Then httpClient.BaseAddress = New Uri("http://www.sunat.gob.pe/")
        rutaTessData = Path.Combine(Application.StartupPath, "Fotos") & "\tessdata\"
    End Sub

    Public Async Function SunatConsultaRuc(ByVal ruc As String) As Task(Of Contribuyente)
        Dim contribuyente As Contribuyente = New Contribuyente()

        Try
            ServicePointManager.DefaultConnectionLimit = 2
            Dim responseMessage As HttpResponseMessage = Await httpClient.GetAsync($"cl-ti-itmrconsruc/captcha?accion=image")

            If responseMessage.IsSuccessStatusCode Then
                Dim responseStream As Stream = Await responseMessage.Content.ReadAsStreamAsync()
                Dim image = New Bitmap(responseStream)
                Dim ocr = New Tesseract()
                ocr.Init(rutaTessData, "eng", False)
                Dim result = ocr.DoOCR(image, Rectangle.Empty)

                For Each word As Word In result
                    captcha += word.Text
                Next
            Else
                Return Nothing
            End If

            Dim ConsultaRuc = Await httpClient.GetAsync($"cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc={ruc}&codigo={captcha.Trim().ToUpper()}&tipodocumento=1")

            If ConsultaRuc.IsSuccessStatusCode Then
                Dim msg As String = String.Empty
                Dim document As HtmlAgilityPack.HtmlDocument = New HtmlAgilityPack.HtmlDocument()
                document.LoadHtml(Await ConsultaRuc.Content.ReadAsStringAsync())
                Dim NodeTable = document.DocumentNode.SelectNodes("//table").FirstOrDefault()

                If NodeTable IsNot Nothing Then
                    Dim listNodeTr = NodeTable.Elements("tr").ToArray()

                    If listNodeTr IsNot Nothing Then
                        Dim nodeRazonSocial = listNodeTr(0).Elements("td").ToArray()

                        If nodeRazonSocial IsNot Nothing Then
                            Dim ConsultaCliente As String = LimpiarEspacios(nodeRazonSocial(1).InnerHtml.Trim())
                            contribuyente.RUC = ConsultaCliente.Substring(0, 11).Trim()
                            contribuyente.RazonSocial = ConsultaCliente.Substring(13, ConsultaCliente.Length - 13).Trim()
                        End If

                        Dim nodeDireccion = listNodeTr(6).Elements("td").ToArray()

                        If ruc.StartsWith("10") Then
                            nodeDireccion = listNodeTr(7).Elements("td").ToArray()
                        End If

                        If nodeDireccion IsNot Nothing Then
                            Dim ConsultaDireccion As String = LimpiarEspacios(nodeDireccion(1).InnerHtml.Trim())
                            contribuyente.Direccion = ConsultaDireccion.Trim()
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            Throw New Exception("El numero Ruc ingresado no existe en la Base de datos de la SUNAT")
        End Try

        Return Await Task.Run(Function() contribuyente)
    End Function

    Private Function LimpiarEspacios(ByVal cadena As String) As String
        While cadena.Contains("  ")
            cadena = cadena.Replace("  ", " ")
        End While

        Return cadena
    End Function
End Class
