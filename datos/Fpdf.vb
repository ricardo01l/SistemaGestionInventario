Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO


Public Class Fpdf
    Public fg As New Fgeneral
    Public dt As DataTable
    Public Sub iniciarPdf(ByVal isCompr As Boolean, ByVal tipoInforme As String, Optional ByVal id As String = "", Optional ByVal fechaInicio As String = "", Optional ByVal fechaFinal As String = "")
        If isCompr Then
            Select Case tipoInforme
                Case "SoloFull"
                    If id = "" Then
                        MsgBox("Seleccione un id")
                    Else
                        dt = CType(fg.unionSoloFullCompr(id), DataTable)
                        crearPdf(dt, isCompr, tipoInforme)
                    End If
                Case "Full"
                    dt = CType(fg.unionFullCompr(), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "SinFact"
                    dt = CType(fg.unionSinFactCompr(), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "SinProd"
                    dt = CType(fg.unionSinProdCompr(), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "InterFechas"
                    dt = CType(fg.unionInterFechasCompr(fechaInicio, fechaFinal), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "NombreProd"
                    dt = CType(fg.unionNombreProdCompr(id), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
            End Select
        Else
            Select Case tipoInforme
                Case "SoloFull"
                    If id = "" Then
                        MsgBox("Seleccione un id")
                    Else
                        dt = CType(fg.unionSoloFullVent(id), DataTable)
                        crearPdf(dt, isCompr, tipoInforme)
                    End If
                Case "Full"
                    dt = CType(fg.unionFullVent(), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "SinFact"
                    dt = CType(fg.unionSinFactVent(), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "SinProd"
                    dt = CType(fg.unionSinProdVent(), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "InterFechas"
                    dt = CType(fg.unionInterFechasVent(fechaInicio, fechaFinal), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
                Case "NombreProd"
                    dt = CType(fg.unionNombreProdVent(id), DataTable)
                    crearPdf(dt, isCompr, tipoInforme)
            End Select
        End If
    End Sub

    Public Sub crearPdf(ByVal dt As DataTable, ByVal isCompr As Boolean, ByVal tipoInforme As String)
        Try
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString & "\Informe.pdf", FileMode.Create))

            Dim font8hel As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim fontB8hel As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim font12times As New Font(FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD))
            Dim cVacio As PdfPCell = New PdfPCell(New Phrase(""))
            cVacio.Border = 0

            pdfDoc.Open()


            Dim col1 As PdfPCell
            Dim col2 As PdfPCell
            Dim col3 As PdfPCell
            Dim col4 As PdfPCell
            Dim col5 As PdfPCell
            Dim col6 As PdfPCell
            Dim col7 As PdfPCell
            Dim col8 As PdfPCell
            Dim col9 As PdfPCell
            Dim titulo As String = ""




            If isCompr Then
                titulo = "Informe de Compras "
                Select Case tipoInforme
                    Case "SoloFull"
                        titulo += "de un solo registro"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        infoInformeCompr(pdfDoc, cVacio, col1, col2, col3, font8hel, fontB8hel, font12times, dt)
                        headersFullCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, True)
                        fullInvCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt, True)
                    Case "Full"
                        titulo += "de todos los registros"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersFullCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times)
                        fullInvCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt)
                    Case "SinFact"
                        titulo += "de todos los registros sin las facturas"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersSinFactCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times)
                        sinFactInvCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt)
                    Case "SinProd"
                        titulo += "de todos los registros sin los productos"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersSinProdCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times)
                        sinProdInvCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt)
                    Case "InterFechas"
                        titulo += "de los registros entre dos fechas"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersFullCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times)
                        fullInvCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt)
                    Case "NombreProd"
                        titulo += "de todos los registros"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersFullCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times)
                        fullInvCompr(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt)
                End Select
            Else
                titulo = "Informe de Ventas "
                Select Case tipoInforme
                    Case "SoloFull"
                        titulo += "de un solo registro"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        infoInformeVent(pdfDoc, cVacio, col1, col2, col3, font8hel, fontB8hel, font12times, dt)
                        headersFullVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, True)
                        fullInvVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt, True)
                    Case "Full"
                        titulo += "de todos los registros"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersFullVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times)
                        fullInvVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt)
                    Case "SinFact"
                        titulo += "de todos los registros sin las facturas"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersSinFactVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times)
                        sinFactInvVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt)
                    Case "SinProd"
                        titulo += "de todos los registros sin los productos"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersSinProdVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times)
                        sinProdInvVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, font8hel, fontB8hel, font12times, dt)
                    Case "InterFechas"
                        titulo += "de los registros entre dos fechas"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersFullVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times)
                        fullInvVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt)
                    Case "NombreProd"
                        titulo += "de todos los registros"
                        encabezado(pdfDoc, cVacio, col1, col2, col3, col4, col5, font8hel, fontB8hel, font12times, titulo)
                        headersFullVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times)
                        fullInvVent(pdfDoc, cVacio, col1, col2, col3, col4, col5, col6, col7, col8, col9, font8hel, fontB8hel, font12times, dt)
                End Select
            End If

            pdfDoc.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub encabezado(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal titulo As String)
        ' --------------------------------------------- ENCABEZADO ---------------------------------------------
        Dim table1 As PdfPTable = New PdfPTable(3)
        table1.WidthPercentage = 95
        Dim widths As Single() = New Single() {6.0F, 6.0F, 5.0F}
        table1.SetWidths(widths)
        Dim imagenURL As String = "logo.png"
        Dim imagenBMP As iTextSharp.text.Image
        imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
        imagenBMP.ScaleToFit(80.0F, 100.0F)
        imagenBMP.SpacingBefore = 20.0F
        imagenBMP.SpacingAfter = 10.0F
        imagenBMP.SetAbsolutePosition(40, 750)
        pdfDoc.Add(imagenBMP)

        cVacio.Rowspan = 5
        table1.AddCell(cVacio)


        col1 = New PdfPCell(New Phrase(titulo, font8times))
        col1.VerticalAlignment = Element.ALIGN_MIDDLE
        col1.Border = 0
        col1.Rowspan = 5
        table1.AddCell(col1)

        col1 = New PdfPCell(New Phrase("Rafniel Technology, F. P.", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_RIGHT
        col1.Border = 0
        table1.AddCell(col1)
        col2 = New PdfPCell(New Phrase("Puerto La Cruz, Calle Rivero", font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table1.AddCell(col2)
        col3 = New PdfPCell(New Phrase("Anzoátegui - Anzoátegui - Anzoátegui", font8hel))
        col3.HorizontalAlignment = Element.ALIGN_RIGHT
        col3.Border = 0
        table1.AddCell(col3)
        col4 = New PdfPCell(New Phrase("(+58) 412-1091990", font8hel))
        col4.HorizontalAlignment = Element.ALIGN_RIGHT
        col4.Border = 0
        table1.AddCell(col4)
        col5 = New PdfPCell(New Phrase("https://www.rafnielstore.com.ve/", font8hel))
        col5.HorizontalAlignment = Element.ALIGN_RIGHT
        col5.Border = 0
        table1.AddCell(col5)

        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table1.AddCell(cVacio)

        pdfDoc.Add(table1)
        ' -----------------------------------------------------------------------------------------------------

    End Sub

    Public Sub infoInformeCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable)
        ' INFORMACIÓN DEL INFORME ----------------------------------------------------------------------------
        Dim table2 As PdfPTable = New PdfPTable(3)
        table2.WidthPercentage = 95
        Dim widths2 As Single() = New Single() {8.0F, 2.0F, 2.0F}
        table2.SetWidths(widths2)

        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table2.AddCell(cVacio)

        cVacio.Border = 0
        cVacio.Colspan = 1
        cVacio.Rowspan = 1
        table2.AddCell(cVacio)

        col1 = New PdfPCell(New Phrase("Fecha de Emisión:", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        col1.Border = 0
        table2.AddCell(col1)

        Dim fecha As Date = CDate(dt(0)("FechaFact"))
        col2 = New PdfPCell(New Phrase(fecha.ToShortDateString, font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)

        table2.AddCell(cVacio)
        col1 = New PdfPCell(New Phrase("Código de Factura:", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        col1.Border = 0
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase(dt(0)("CodFactCompr").ToString, font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)

        table2.AddCell(cVacio)
        col1 = New PdfPCell(New Phrase("Modena:", fontB8hel))
        col1.Border = 0
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase("Bolívares", font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)

        table2.AddCell(cVacio)
        col1 = New PdfPCell(New Phrase("Estatus:", fontB8hel))
        col1.Border = 0
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table2.AddCell(col1)

        Dim estatus As String = ""
        If Not IsDBNull(dt(0)("EstatusFact")) Then
            If CBool(dt(0)("EstatusFact")) Then
                estatus = "Válido"
            Else
                estatus = "No válido"
            End If
        End If
        col2 = New PdfPCell(New Phrase(estatus, font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)


        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table2.AddCell(cVacio)

        pdfDoc.Add(table2)
        ' -----------------------------------------------------------------------------------------------------
    End Sub
    Public Sub infoInformeVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable)
        ' INFORMACIÓN DEL INFORME ----------------------------------------------------------------------------
        Dim table2 As PdfPTable = New PdfPTable(3)
        table2.WidthPercentage = 95
        Dim widths2 As Single() = New Single() {8.0F, 2.0F, 2.0F}
        table2.SetWidths(widths2)

        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table2.AddCell(cVacio)

        cVacio.Border = 0
        cVacio.Colspan = 1
        cVacio.Rowspan = 1
        table2.AddCell(cVacio)

        col1 = New PdfPCell(New Phrase("Fecha de Emisión:", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        col1.Border = 0
        table2.AddCell(col1)

        col2 = New PdfPCell(New Phrase(dt(0)("FechaFact").ToString, font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)

        table2.AddCell(cVacio)
        col1 = New PdfPCell(New Phrase("Código de Factura:", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        col1.Border = 0
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase(dt(0)("CodFactVent").ToString, font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)

        table2.AddCell(cVacio)
        col1 = New PdfPCell(New Phrase("Modena:", fontB8hel))
        col1.Border = 0
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table2.AddCell(col1)


        col2 = New PdfPCell(New Phrase("Bolívares", font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)

        table2.AddCell(cVacio)
        col1 = New PdfPCell(New Phrase("Estatus:", fontB8hel))
        col1.Border = 0
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table2.AddCell(col1)

        Dim estatus As String = ""
        If Not IsDBNull(dt(0)("EstatusFact")) Then
            If CBool(dt(0)("EstatusFact")) Then
                estatus = "Válido"
            Else
                estatus = "No válido"
            End If
        End If
        col2 = New PdfPCell(New Phrase(estatus, font8hel))
        col2.HorizontalAlignment = Element.ALIGN_RIGHT
        col2.Border = 0
        table2.AddCell(col2)


        cVacio.Colspan = 5
        cVacio.Border = 1
        cVacio.Rowspan = 1
        table2.AddCell(cVacio)

        pdfDoc.Add(table2)
        ' -----------------------------------------------------------------------------------------------------
    End Sub

    ' ---------------------------------------------------------------------------------------------
    Public Sub headersFullCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal col8 As PdfPCell, ByVal col9 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, Optional ByVal solo As Boolean = False)
        Dim table3 As PdfPTable
        Dim widths3 As Single()

        If Not solo Then
            table3 = New PdfPTable(9)
            widths3 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        Else
            table3 = New PdfPTable(6)
            widths3 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F}
        End If

        table3.SpacingBefore = 20.0F
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)

        col1 = New PdfPCell(New Phrase("Id", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Código del Producto", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Nombre", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Descipción", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Cantidad comprada", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Precio de compra", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col6)
        If Not solo Then
            col7 = New PdfPCell(New Phrase("Código de la Factura", fontB8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col7)

            col8 = New PdfPCell(New Phrase("Fecha de la factura", fontB8hel))
            col8.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col8)

            col9 = New PdfPCell(New Phrase("Estatus de la factura", fontB8hel))
            col9.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col9)
        End If

        pdfDoc.Add(table3)
    End Sub
    Public Sub fullInvCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal col8 As PdfPCell, ByVal col9 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable, Optional ByVal solo As Boolean = False)
        Dim table4 As PdfPTable
        Dim widths4 As Single()

        If Not solo Then
            table4 = New PdfPTable(9)
            widths4 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        Else
            table4 = New PdfPTable(6)
            widths4 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F}
        End If

        table4.WidthPercentage = 95
        table4.SetWidths(widths4)
        Dim i As Integer

        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("IdInvCompr").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("CodProd").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("NombreProd").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("DescripProd").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col4)

            col5 = New PdfPCell(New Phrase(dt(i)("CantidadCompr").ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col5)

            col6 = New PdfPCell(New Phrase(dt(i)("PrecioCompr").ToString, font8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col6)

            If Not solo Then
                col7 = New PdfPCell(New Phrase(dt(i)("CodFactCompr").ToString, font8hel))
                col7.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col7)
                Dim fecha As Date = New Date
                If Not IsDBNull(dt(i)("FechaFact")) Then
                    fecha = CDate(CDate(dt(i)("FechaFact")).ToShortDateString())
                End If
                col8 = New PdfPCell(New Phrase(fecha.ToString, font8hel))
                col8.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col8)
                Dim estatus As String = ""
                If Not IsDBNull(dt(i)("EstatusFact")) Then
                    If CBool(dt(i)("EstatusFact")) Then
                        estatus = "Válido"
                    Else
                        estatus = "No válido"
                    End If
                End If
                col9 = New PdfPCell(New Phrase(estatus, font8hel))
                col9.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col9)
            End If
        Next

        pdfDoc.Add(table4)
    End Sub

    Public Sub headersSinFactCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font)
        Dim table3 As PdfPTable = New PdfPTable(7)
        Dim widths3 As Single() = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F}
        table3.SpacingBefore = 20.0F
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)

        col1 = New PdfPCell(New Phrase("Id", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Código del Producto", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Nombre", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Descipción", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Cantidad comprada", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Precio de compra", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col6)

        col7 = New PdfPCell(New Phrase("Código de la factura", fontB8hel))
        col7.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col7)


        pdfDoc.Add(table3)
    End Sub
    Public Sub sinFactInvCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable)
        Dim table4 As PdfPTable = New PdfPTable(7)
        Dim widths4 As Single() = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F}
        table4.WidthPercentage = 95
        table4.SetWidths(widths4)
        Dim i As Integer

        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("IdInvCompr").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("CodProd").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("NombreProd").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("DescripProd").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col4)

            col5 = New PdfPCell(New Phrase(dt(i)("CantidadCompr").ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col5)

            col6 = New PdfPCell(New Phrase(dt(i)("PrecioCompr").ToString, font8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col6)

            col7 = New PdfPCell(New Phrase(dt(i)("CodFactCompr").ToString, font8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col7)
        Next

        pdfDoc.Add(table4)
    End Sub

    Public Sub headersSinProdCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font)
        Dim table4 As PdfPTable = New PdfPTable(7)
        Dim widths4 As Single() = New Single() {1.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        table4.SpacingBefore = 20.0F
        table4.WidthPercentage = 95
        table4.SetWidths(widths4)

        col1 = New PdfPCell(New Phrase("Id", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Cantidad comprada", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Precio de compra", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Código de la Factura", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Fecha de la factura", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Estatus de la factura", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col6)

        col7 = New PdfPCell(New Phrase("Código del Producto", fontB8hel))
        col7.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col7)

        pdfDoc.Add(table4)
    End Sub
    Public Sub sinProdInvCompr(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable)
        Dim table5 As PdfPTable = New PdfPTable(7)
        Dim widths5 As Single() = New Single() {1.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        table5.WidthPercentage = 95
        table5.SetWidths(widths5)
        Dim i As Integer

        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("IdInvCompr").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("CantidadCompr").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("PrecioCompr").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("CodFactCompr").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col4)
            Dim fecha As Date = New Date
            If Not IsDBNull(dt(i)("EstatusFact")) Then
                fecha = CDate(CDate(dt(i)("FechaFact")).ToShortDateString())
            End If
            col5 = New PdfPCell(New Phrase(fecha.ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col5)
            Dim estatus As String = ""
            If Not IsDBNull(dt(i)("EstatusFact")) Then
                If CBool(dt(i)("EstatusFact")) Then
                    estatus = "Válido"
                Else
                    estatus = "No válido"
                End If
            End If
            col6 = New PdfPCell(New Phrase(estatus, font8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col6)

            col7 = New PdfPCell(New Phrase(dt(i)("CodProd").ToString, font8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col7)
        Next

        pdfDoc.Add(table5)
    End Sub
    ' ---------------------------------------------------------------------------------------------

    ' ---------------------------------------------------------------------------------------------
    Public Sub headersFullVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal col8 As PdfPCell, ByVal col9 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, Optional ByVal solo As Boolean = False)
        Dim table3 As PdfPTable
        Dim widths3 As Single()
        If Not solo Then
            table3 = New PdfPTable(9)
            widths3 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        Else
            table3 = New PdfPTable(6)
            widths3 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F}
        End If
        table3.SpacingBefore = 20.0F
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)

        col1 = New PdfPCell(New Phrase("Id", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Código del Producto", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Nombre", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Descipción", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Cantidad vendida", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Precio de venta", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col6)

        If Not solo Then
            col7 = New PdfPCell(New Phrase("Código de la Factura", fontB8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col7)

            col8 = New PdfPCell(New Phrase("Fecha de la factura", fontB8hel))
            col8.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col8)

            col9 = New PdfPCell(New Phrase("Estatus de la factura", fontB8hel))
            col9.HorizontalAlignment = Element.ALIGN_LEFT
            table3.AddCell(col9)
        End If

        pdfDoc.Add(table3)
    End Sub
    Public Sub fullInvVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal col8 As PdfPCell, ByVal col9 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable, Optional ByVal solo As Boolean = False)
        Dim table4 As PdfPTable
        Dim widths4 As Single()
        If Not solo Then
            table4 = New PdfPTable(9)
            widths4 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        Else
            table4 = New PdfPTable(6)
            widths4 = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F}
        End If
        
        table4.WidthPercentage = 95
        table4.SetWidths(widths4)
        Dim i As Integer
        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("IdInvVent").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("CodProd").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("NombreProd").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("DescripProd").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col4)

            col5 = New PdfPCell(New Phrase(dt(i)("CantidadVent").ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col5)

            col6 = New PdfPCell(New Phrase(dt(i)("PrecioVent").ToString, font8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col6)
            If Not solo Then
                col7 = New PdfPCell(New Phrase(dt(i)("CodFactVent").ToString, font8hel))
                col7.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col7)
                Dim fecha As Date = New Date
                If Not IsDBNull(dt(i)("FechaFact")) Then
                    fecha = CDate(CDate(dt(i)("FechaFact")).ToShortDateString())
                End If
                col8 = New PdfPCell(New Phrase(fecha.ToString, font8hel))
                col8.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col8)
                Dim estatus As String = ""
                If Not IsDBNull(dt(i)("EstatusFact")) Then
                    If CBool(dt(i)("EstatusFact")) Then
                        estatus = "Válido"
                    Else
                        estatus = "No válido"
                    End If
                End If
                col9 = New PdfPCell(New Phrase(estatus, font8hel))
                col9.HorizontalAlignment = Element.ALIGN_LEFT
                table4.AddCell(col9)
            End If
        Next

        pdfDoc.Add(table4)
    End Sub

    Public Sub headersSinFactVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font)
        Dim table3 As PdfPTable = New PdfPTable(7)
        Dim widths3 As Single() = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F}
        table3.SpacingBefore = 20.0F
        table3.WidthPercentage = 95
        table3.SetWidths(widths3)

        col1 = New PdfPCell(New Phrase("Id", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Código del Producto", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Nombre", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Descipción", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Cantidad vendida", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Precio de venta", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col6)

        col7 = New PdfPCell(New Phrase("Código de la factura", fontB8hel))
        col7.HorizontalAlignment = Element.ALIGN_LEFT
        table3.AddCell(col7)

        pdfDoc.Add(table3)
    End Sub
    Public Sub sinFactInvVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable)
        Dim table4 As PdfPTable = New PdfPTable(7)
        Dim widths4 As Single() = New Single() {1.0F, 2.0F, 2.0F, 4.0F, 2.0F, 2.0F, 2.0F}
        table4.WidthPercentage = 95
        table4.SetWidths(widths4)
        Dim i As Integer

        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("IdInvVent").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("CodProd").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("NombreProd").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("DescripProd").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col4)

            col5 = New PdfPCell(New Phrase(dt(i)("CantidadVent").ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col5)

            col6 = New PdfPCell(New Phrase(dt(i)("PrecioVent").ToString, font8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col6)

            col7 = New PdfPCell(New Phrase(dt(i)("CodFactVent").ToString, font8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table4.AddCell(col7)
        Next

        pdfDoc.Add(table4)
    End Sub

    Public Sub headersSinProdVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font)
        Dim table4 As PdfPTable = New PdfPTable(7)
        Dim widths4 As Single() = New Single() {1.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        table4.SpacingBefore = 20.0F
        table4.WidthPercentage = 95
        table4.SetWidths(widths4)

        col1 = New PdfPCell(New Phrase("Id", fontB8hel))
        col1.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col1)

        col2 = New PdfPCell(New Phrase("Cantidad vendida", fontB8hel))
        col2.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col2)

        col3 = New PdfPCell(New Phrase("Precio de venta", fontB8hel))
        col3.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col3)

        col4 = New PdfPCell(New Phrase("Código de la Factura", fontB8hel))
        col4.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col4)

        col5 = New PdfPCell(New Phrase("Fecha de la factura", fontB8hel))
        col5.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col5)

        col6 = New PdfPCell(New Phrase("Estatus de la factura", fontB8hel))
        col6.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col6)

        col7 = New PdfPCell(New Phrase("Código del Producto", fontB8hel))
        col7.HorizontalAlignment = Element.ALIGN_LEFT
        table4.AddCell(col7)

        pdfDoc.Add(table4)
    End Sub
    Public Sub sinProdInvVent(ByVal pdfDoc As Document, ByVal cVacio As PdfPCell, ByVal col1 As PdfPCell, ByVal col2 As PdfPCell, ByVal col3 As PdfPCell, ByVal col4 As PdfPCell, ByVal col5 As PdfPCell, ByVal col6 As PdfPCell, ByVal col7 As PdfPCell, ByVal font8hel As Font, ByVal fontB8hel As Font, ByVal font8times As Font, ByVal dt As DataTable)
        Dim table5 As PdfPTable = New PdfPTable(7)
        Dim widths5 As Single() = New Single() {1.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F, 2.0F}
        table5.WidthPercentage = 95
        table5.SetWidths(widths5)
        Dim i As Integer

        For i = 0 To (dt.Rows.Count - 1)
            col1 = New PdfPCell(New Phrase(dt(i)("IdInvVent").ToString, font8hel))
            col1.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col1)

            col2 = New PdfPCell(New Phrase(dt(i)("CantidadVent").ToString, font8hel))
            col2.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col2)

            col3 = New PdfPCell(New Phrase(dt(i)("PrecioVent").ToString, font8hel))
            col3.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col3)

            col4 = New PdfPCell(New Phrase(dt(i)("CodFactVent").ToString, font8hel))
            col4.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col4)
            Dim fecha As Date = New Date
            If Not IsDBNull(dt(i)("EstatusFact")) Then
                fecha = CDate(CDate(dt(i)("FechaFact")).ToShortDateString())
            End If
            col5 = New PdfPCell(New Phrase(fecha.ToString, font8hel))
            col5.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col5)
            Dim estatus As String = ""
            If Not IsDBNull(dt(i)("EstatusFact")) Then
                If CBool(dt(i)("EstatusFact")) Then
                    estatus = "Válido"
                Else
                    estatus = "No válido"
                End If
            End If
            col6 = New PdfPCell(New Phrase(estatus, font8hel))
            col6.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col6)

            col7 = New PdfPCell(New Phrase(dt(i)("CodProd").ToString, font8hel))
            col7.HorizontalAlignment = Element.ALIGN_LEFT
            table5.AddCell(col7)
        Next

        pdfDoc.Add(table5)
    End Sub
    ' ---------------------------------------------------------------------------------------------

End Class
