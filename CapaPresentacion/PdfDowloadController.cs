using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.Fase2;
using CapaNegocio.Fase3;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace CapaPresentacion
{
    public class PDFDownloadController
    {
        public string RetornarRuta()
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                string ruta = "";
                if (result == DialogResult.OK)
                {
                    ruta = dialog.SelectedPath;

                }
                return ruta;
            }
        }

        public void ReporteMediosEstrategicos()
        {
            string ruta = RetornarRuta();
            if (ruta != "")
            {
                ruta = ruta + @"\ReporteMediosEstrategicos_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

                FileStream fs = new FileStream(ruta, FileMode.Create);

                ModeloRecursoImportante estrat = new ModeloRecursoImportante();

                DataTable dt = estrat.CargarDGVrecursoImportante();

                PdfWriter pw = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER.Rotate());

                doc.SetMargins(75, 35, 70, 35);

                string pathLogo = ("../../Resources/logoPacha_png.png");
                Image img = new Image(ImageDataFactory.Create(pathLogo));

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img));

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler());

                Style styleTitulo = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                    .SetFontSize(10);

                Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Reporte Fase 3.1: Medios Estratégicos de Vida")
                    .SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                cell = new Cell().Add(new Paragraph("\n"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                Table tableRecursos = new Table(8).UseAllAvailableWidth();
                Cell cellRecursos = new Cell(1, 1).Add(new Paragraph("Sector"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Tipo de Recurso"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Recurso"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Cantidad"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Calidad"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Acceso"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Control"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));
                cellRecursos = new Cell(1, 1).Add(new Paragraph("Notas"));
                tableRecursos.AddHeaderCell(cellRecursos.AddStyle(styleTitulo));

                List<ModeloRecursoImportante> listRecursos = new List<ModeloRecursoImportante>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloRecursoImportante datatable = new ModeloRecursoImportante();
                    datatable.Sector = dt.Rows[i]["Sector"].ToString();
                    datatable.TipoRecurso = dt.Rows[i]["Tipo de Recurso"].ToString();
                    datatable.Recurso = dt.Rows[i]["Recurso"].ToString();
                    datatable.Cantidad = dt.Rows[i]["Cantidad"].ToString();
                    datatable.Calidad = dt.Rows[i]["Calidad"].ToString();
                    datatable.Acceso = dt.Rows[i]["Acceso"].ToString();
                    datatable.Control = dt.Rows[i]["Control"].ToString();
                    datatable.Notas = dt.Rows[i]["Notas"].ToString();
                    listRecursos.Add(datatable);
                }

                foreach (var item in listRecursos)
                {
                    cellRecursos = new Cell().Add(new Paragraph(item.Sector));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.TipoRecurso));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.Recurso));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.Cantidad));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.Calidad));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.Acceso));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.Control));
                    tableRecursos.AddCell(cellRecursos);
                    cellRecursos = new Cell().Add(new Paragraph(item.Notas));
                    tableRecursos.AddCell(cellRecursos);
                }

                doc.Add(tableRecursos);


                doc.Close();
                pw.Close();

                MessageBox.Show("Reporte generado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("No ha seleccionado una ruta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ReporteRiesgoClimatico()
        {
            string ruta = RetornarRuta();
            if (ruta != "")
            {
                ruta = ruta + @"\ReporteRiesgoClimatico_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

                FileStream fs = new FileStream(ruta, FileMode.Create);

                ModeloRiesgoClimatico riesgo = new ModeloRiesgoClimatico();

                DataTable dt = riesgo.CargarDGVriesgoClimatico();

                PdfWriter pw = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER);

                doc.SetMargins(75, 35, 70, 35);

                string pathLogo = ("../../Resources/logoPacha_png.png");
                Image img = new Image(ImageDataFactory.Create(pathLogo));

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img));

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler());

                Style styleTitulo = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                    .SetFontSize(10);

                Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Reporte Fase 2.3: Riesgo Climático")
                    .SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);
                
                cell = new Cell().Add(new Paragraph("\n"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                Table tableRiesgo = new Table(7).UseAllAvailableWidth();
                Cell cellRiesgo = new Cell(1, 1).Add(new Paragraph("Sector"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));
                cellRiesgo = new Cell(1, 1).Add(new Paragraph("Amenaza"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));
                cellRiesgo = new Cell(1, 1).Add(new Paragraph("Impacto"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));
                cellRiesgo = new Cell(1, 1).Add(new Paragraph("Respuesta"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));
                cellRiesgo = new Cell(1, 1).Add(new Paragraph("Riesgo"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));
                cellRiesgo = new Cell(1, 1).Add(new Paragraph("Importancia"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));
                cellRiesgo = new Cell(1, 1).Add(new Paragraph("Observaciones"));
                tableRiesgo.AddHeaderCell(cellRiesgo.AddStyle(styleTitulo));

                List<ModeloRiesgoClimatico> listRiesgo = new List<ModeloRiesgoClimatico>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloRiesgoClimatico datatable = new ModeloRiesgoClimatico();
                    datatable.Sector = dt.Rows[i]["Sector"].ToString();
                    datatable.Amenaza = dt.Rows[i]["Amenaza"].ToString();
                    datatable.Impacto = dt.Rows[i]["Impacto"].ToString();
                    datatable.Respuesta = dt.Rows[i]["Respuesta"].ToString();
                    datatable.Riesgo = dt.Rows[i]["Riesgo"].ToString();
                    datatable.Importancia = dt.Rows[i]["Importancia"].ToString();
                    datatable.Observaciones = dt.Rows[i]["OBSERVACIONES"].ToString();
                    listRiesgo.Add(datatable);
                }

                foreach (var item in listRiesgo)
                {
                    cellRiesgo = new Cell().Add(new Paragraph(item.Sector));
                    tableRiesgo.AddCell(cellRiesgo);
                    cellRiesgo = new Cell().Add(new Paragraph(item.Amenaza));
                    tableRiesgo.AddCell(cellRiesgo);
                    cellRiesgo = new Cell().Add(new Paragraph(item.Impacto));
                    tableRiesgo.AddCell(cellRiesgo);
                    cellRiesgo = new Cell().Add(new Paragraph(item.Respuesta));
                    tableRiesgo.AddCell(cellRiesgo);
                    cellRiesgo = new Cell().Add(new Paragraph(item.Riesgo));
                    tableRiesgo.AddCell(cellRiesgo);
                    cellRiesgo = new Cell().Add(new Paragraph(item.Importancia));
                    tableRiesgo.AddCell(cellRiesgo);
                    cellRiesgo = new Cell().Add(new Paragraph(item.Observaciones));
                    tableRiesgo.AddCell(cellRiesgo);
                }

                doc.Add(tableRiesgo);


                doc.Close();
                pw.Close();

                MessageBox.Show("Reporte generado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("No ha seleccionado una ruta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void ReporteAnalisisSocioambiental()
        {
            string ruta = RetornarRuta();
            if (ruta != "")
            {
                ruta = ruta + @"\ReporteAnalisisSocioambiental_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

                FileStream fs = new FileStream(ruta, FileMode.Create);

                ModeloCurvaDemo curva = new ModeloCurvaDemo();

                DataTable dt = curva.CargarDGVcurva();

                PdfWriter pw = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER.Rotate());
                
                doc.SetMargins(75, 35, 70, 35);

                string pathLogo = ("../../Resources/logoPacha_png.png");
                Image img = new Image(ImageDataFactory.Create(pathLogo));

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img));

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler());

                Style styleTitulo = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                    .SetFontSize(10);

                Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Reporte Fase 2.2: Analisis Socioambiental")
                    .SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                Table tableTCurva = new Table(1).UseAllAvailableWidth();
                Cell cellTCurva = new Cell().Add(new Paragraph("\nCurva Demográfica"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTCurva.AddCell(cellTCurva);

                doc.Add(tableTCurva);

                Table tableCurva = new Table(9).UseAllAvailableWidth();
                Cell cellCurva = new Cell(1, 1).Add(new Paragraph("Información"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("1950"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("1960"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("1970"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("1980"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("1990"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("2000"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("2010"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));
                cellCurva = new Cell(1, 1).Add(new Paragraph("2020"));
                tableCurva.AddHeaderCell(cellCurva.AddStyle(styleTitulo));

                List<ModeloCurvaDemo> listCurva = new List<ModeloCurvaDemo>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloCurvaDemo datatable = new ModeloCurvaDemo();
                    datatable.Informacion = dt.Rows[i]["Información"].ToString();
                    datatable.Decada1 = dt.Rows[i]["1950"].ToString();
                    datatable.Decada2 = dt.Rows[i]["1960"].ToString();
                    datatable.Decada3 = dt.Rows[i]["1970"].ToString();
                    datatable.Decada4 = dt.Rows[i]["1980"].ToString();
                    datatable.Decada5 = dt.Rows[i]["1990"].ToString();
                    datatable.Decada6 = dt.Rows[i]["2000"].ToString();
                    datatable.Decada7 = dt.Rows[i]["2010"].ToString();
                    datatable.Decada8 = dt.Rows[i]["2020"].ToString();
                    listCurva.Add(datatable);
                }

                foreach (var item in listCurva)
                {

                    cellCurva = new Cell().Add(new Paragraph(item.Informacion));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada1));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada2));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada3));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada4));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada5));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada6));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada7));
                    tableCurva.AddCell(cellCurva);
                    cellCurva = new Cell().Add(new Paragraph(item.Decada8));
                    tableCurva.AddCell(cellCurva);
                }

                doc.Add(tableCurva);

                ModeloOcuTerritorio ocup = new ModeloOcuTerritorio();
                dt = ocup.CargarDGVocupacion();

                Table tableOcupTerrit = new Table(1).UseAllAvailableWidth();
                Cell cellOcupTerrit = new Cell().Add(new Paragraph("\nOcupacion Territorial"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableOcupTerrit.AddCell(cellOcupTerrit);

                doc.Add(tableOcupTerrit);

                tableOcupTerrit = new Table(9).UseAllAvailableWidth();
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("Información"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("1950"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("1960"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("1970"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("1980"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("1990"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("2000"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("2010"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));
                cellOcupTerrit = new Cell(1, 1).Add(new Paragraph("2020"));
                tableOcupTerrit.AddHeaderCell(cellOcupTerrit.AddStyle(styleTitulo));

                List<ModeloOcuTerritorio> listOcupTerrit = new List<ModeloOcuTerritorio>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloOcuTerritorio datatable = new ModeloOcuTerritorio();
                    datatable.Informacion = dt.Rows[i]["Información"].ToString();
                    datatable.Decada1 = dt.Rows[i]["1950"].ToString();
                    datatable.Decada2 = dt.Rows[i]["1960"].ToString();
                    datatable.Decada3 = dt.Rows[i]["1970"].ToString();
                    datatable.Decada4 = dt.Rows[i]["1980"].ToString();
                    datatable.Decada5 = dt.Rows[i]["1990"].ToString();
                    datatable.Decada6 = dt.Rows[i]["2000"].ToString();
                    datatable.Decada7 = dt.Rows[i]["2010"].ToString();
                    datatable.Decada8 = dt.Rows[i]["2020"].ToString();
                    listOcupTerrit.Add(datatable);
                }

                foreach (var item in listOcupTerrit)
                {

                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Informacion));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada1));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada2));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada3));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada4));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada5));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada6));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada7));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                    cellOcupTerrit = new Cell().Add(new Paragraph(item.Decada8));
                    tableOcupTerrit.AddCell(cellOcupTerrit);
                }

                doc.Add(tableOcupTerrit);


                ModeloRecursoHidrico recurso = new ModeloRecursoHidrico();

                dt = recurso.CargarDGVrecurso();

                Table tableTRecurso = new Table(1).UseAllAvailableWidth();
                Cell cellTRecurso = new Cell().Add(new Paragraph("\nRecurso Hídrico"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTRecurso.AddCell(cellTRecurso);

                doc.Add(tableTRecurso);

                Table tableRecurso = new Table(9).UseAllAvailableWidth();
                Cell cellRecurso = new Cell(1, 1).Add(new Paragraph("Información"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("1950"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("1960"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("1970"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("1980"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("1990"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("2000"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("2010"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));
                cellRecurso = new Cell(1, 1).Add(new Paragraph("2020"));
                tableRecurso.AddHeaderCell(cellRecurso.AddStyle(styleTitulo));

                List<ModeloRecursoHidrico> listRecurso = new List<ModeloRecursoHidrico>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloRecursoHidrico datatable = new ModeloRecursoHidrico();
                    datatable.Informacion = dt.Rows[i]["Información"].ToString();
                    datatable.Decada1 = dt.Rows[i]["1950"].ToString();
                    datatable.Decada2 = dt.Rows[i]["1960"].ToString();
                    datatable.Decada3 = dt.Rows[i]["1970"].ToString();
                    datatable.Decada4 = dt.Rows[i]["1980"].ToString();
                    datatable.Decada5 = dt.Rows[i]["1990"].ToString();
                    datatable.Decada6 = dt.Rows[i]["2000"].ToString();
                    datatable.Decada7 = dt.Rows[i]["2010"].ToString();
                    datatable.Decada8 = dt.Rows[i]["2020"].ToString();
                    listRecurso.Add(datatable);
                }

                foreach (var item in listRecurso)
                {

                    cellRecurso = new Cell().Add(new Paragraph(item.Informacion));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada1));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada2));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada3));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada4));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada5));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada6));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada7));
                    tableRecurso.AddCell(cellRecurso);
                    cellRecurso = new Cell().Add(new Paragraph(item.Decada8));
                    tableRecurso.AddCell(cellRecurso);
                }

                doc.Add(tableRecurso);

                ModeloBiodiversidad bio = new ModeloBiodiversidad();

                dt = bio.CargarDGVbiodiversidad();

                Table tableTBio = new Table(1).UseAllAvailableWidth();
                Cell cellTBio = new Cell().Add(new Paragraph("\nBiodiversidad"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTBio.AddCell(cellTBio);

                doc.Add(tableTBio);

                Table tableBio = new Table(10).UseAllAvailableWidth();
                Cell cellBio = new Cell(1, 1).Add(new Paragraph("Sector"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("Información"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("1950"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("1960"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("1970"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("1980"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("1990"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("2000"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("2010"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));
                cellBio = new Cell(1, 1).Add(new Paragraph("2020"));
                tableBio.AddHeaderCell(cellBio.AddStyle(styleTitulo));

                List<ModeloBiodiversidad> listBio = new List<ModeloBiodiversidad>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloBiodiversidad datatable = new ModeloBiodiversidad();
                    datatable.Sector = dt.Rows[i]["Sector"].ToString();
                    datatable.Informacion = dt.Rows[i]["Información"].ToString();
                    datatable.Decada1 = dt.Rows[i]["1950"].ToString();
                    datatable.Decada2 = dt.Rows[i]["1960"].ToString();
                    datatable.Decada3 = dt.Rows[i]["1970"].ToString();
                    datatable.Decada4 = dt.Rows[i]["1980"].ToString();
                    datatable.Decada5 = dt.Rows[i]["1990"].ToString();
                    datatable.Decada6 = dt.Rows[i]["2000"].ToString();
                    datatable.Decada7 = dt.Rows[i]["2010"].ToString();
                    datatable.Decada8 = dt.Rows[i]["2020"].ToString();
                    listBio.Add(datatable);
                }

                foreach (var item in listBio)
                {
                    cellBio = new Cell().Add(new Paragraph(item.Sector));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Informacion));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada1));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada2));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada3));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada4));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada5));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada6));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada7));
                    tableBio.AddCell(cellBio);
                    cellBio = new Cell().Add(new Paragraph(item.Decada8));
                    tableBio.AddCell(cellBio);
                }

                doc.Add(tableBio);

                ModeloEventoClimatico evento = new ModeloEventoClimatico();

                dt = evento.CargarDGVevento();

                Table tableTEvento = new Table(1).UseAllAvailableWidth();
                Cell cellTEvento = new Cell().Add(new Paragraph("\nEventos Climáticos Extremos"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTEvento.AddCell(cellTEvento);

                doc.Add(tableTEvento);

                Table tableEvento = new Table(10).UseAllAvailableWidth();
                Cell cellEvento = new Cell(1, 1).Add(new Paragraph("Sector"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("Información"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("1950"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("1960"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("1970"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("1980"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("1990"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("2000"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("2010"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));
                cellEvento = new Cell(1, 1).Add(new Paragraph("2020"));
                tableEvento.AddHeaderCell(cellEvento.AddStyle(styleTitulo));

                List<ModeloEventoClimatico> listEvento = new List<ModeloEventoClimatico>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloEventoClimatico datatable = new ModeloEventoClimatico();
                    datatable.Sector = dt.Rows[i]["Sector"].ToString();
                    datatable.Informacion = dt.Rows[i]["Información"].ToString();
                    datatable.Decada1 = dt.Rows[i]["1950"].ToString();
                    datatable.Decada2 = dt.Rows[i]["1960"].ToString();
                    datatable.Decada3 = dt.Rows[i]["1970"].ToString();
                    datatable.Decada4 = dt.Rows[i]["1980"].ToString();
                    datatable.Decada5 = dt.Rows[i]["1990"].ToString();
                    datatable.Decada6 = dt.Rows[i]["2000"].ToString();
                    datatable.Decada7 = dt.Rows[i]["2010"].ToString();
                    datatable.Decada8 = dt.Rows[i]["2020"].ToString();
                    listEvento.Add(datatable);
                }

                foreach (var item in listEvento)
                {
                    cellEvento = new Cell().Add(new Paragraph(item.Sector));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Informacion));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada1));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada2));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada3));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada4));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada5));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada6));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada7));
                    tableEvento.AddCell(cellEvento);
                    cellEvento = new Cell().Add(new Paragraph(item.Decada8));
                    tableEvento.AddCell(cellEvento);
                }

                doc.Add(tableEvento);

                doc.Close();
                pw.Close();

                MessageBox.Show("Reporte generado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(ruta);

            }
            else
            {
                MessageBox.Show("No ha seleccionado una ruta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ReporteUnidadTerritorial()
        {
            string ruta = RetornarRuta();
            if (ruta != "")
            {

                ruta = ruta + @"\ReporteUnidadTerritorial_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

                FileStream fs = new FileStream(ruta, FileMode.Create);

                ModeloUnidadTerritorial ubic = new ModeloUnidadTerritorial();
                ModeloLimites limites = new ModeloLimites();
                ModeloAsentamiento asen = new ModeloAsentamiento();
                ModeloHitos hitos = new ModeloHitos();
                ModeloUbicHidro hidro = new ModeloUbicHidro();
                ModeloEco eco = new ModeloEco();
                ModeloTiempo tiempo = new ModeloTiempo();

                DataTable dt = ubic.CargarDGV();

                PdfWriter pw = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER);
                doc.SetMargins(75, 35, 70, 35);

                string pathLogo = ("../../Resources/logoPacha_png.png");
                Image img = new Image(ImageDataFactory.Create(pathLogo));

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img));

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler());

                Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Reporte Fase 2.1: Unidad Territorial")
                    .SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                cell = new Cell().Add(new Paragraph("\nUbicación Administrativa"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                Style styleTitulo = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                    .SetFontSize(10);

                Table _table = new Table(6).UseAllAvailableWidth();
                Cell _cell = new Cell(1, 1).Add(new Paragraph("País"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Región"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Provincia"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Cantón"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Parroquia"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Comunidad"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));

                List<ModeloUnidadTerritorial> listUbic = new List<ModeloUnidadTerritorial>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloUnidadTerritorial datatable = new ModeloUnidadTerritorial();
                    datatable.Pais = dt.Rows[i]["Pais"].ToString();
                    datatable.Region = dt.Rows[i]["Region"].ToString();
                    datatable.Provincia = dt.Rows[i]["Provincia"].ToString();
                    datatable.Canton = dt.Rows[i]["Canton"].ToString();
                    datatable.Parroquia = dt.Rows[i]["Parroquia"].ToString();
                    datatable.Comunidad = dt.Rows[i]["Comunidad"].ToString();
                    listUbic.Add(datatable);
                }

                foreach (var item in listUbic)
                {

                    _cell = new Cell().Add(new Paragraph(item.Pais));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Region));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Provincia));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Canton));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Parroquia));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Comunidad));
                    _table.AddCell(_cell);
                }

                doc.Add(_table);

                dt = limites.CargarDGV();
                table = new Table(1).UseAllAvailableWidth();
                cell = new Cell().Add(new Paragraph("\nLímites"))
                   .SetTextAlignment(TextAlignment.CENTER)
                   .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                _table = new Table(6).UseAllAvailableWidth();
                _cell = new Cell(1, 1).Add(new Paragraph("Norte"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Xn"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Yn"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Sur"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Xs"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Ys"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));

                List<ModeloLimites> listLimite = new List<ModeloLimites>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloLimites datatable = new ModeloLimites();
                    datatable.Norte = dt.Rows[i]["Norte"].ToString();
                    datatable.Latnorte = dt.Rows[i]["Xn"].ToString();
                    datatable.Longnorte = dt.Rows[i]["Yn"].ToString();
                    datatable.Sur = dt.Rows[i]["Sur"].ToString();
                    datatable.Latsur = dt.Rows[i]["Xs"].ToString();
                    datatable.Longsur = dt.Rows[i]["Ys"].ToString();
                    datatable.Este = dt.Rows[i]["Este"].ToString();
                    datatable.Lateste = dt.Rows[i]["Xe"].ToString();
                    datatable.Longeste = dt.Rows[i]["Ye"].ToString();
                    datatable.Oeste = dt.Rows[i]["Oeste"].ToString();
                    datatable.Latoeste = dt.Rows[i]["Xo"].ToString();
                    datatable.Longoeste = dt.Rows[i]["Yo"].ToString();
                    listLimite.Add(datatable);
                }

                foreach (var item in listLimite)
                {

                    _cell = new Cell().Add(new Paragraph(item.Norte));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Latnorte));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Longnorte));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Sur));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Latsur));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Longsur));
                    _table.AddCell(_cell);
                }

                doc.Add(_table);

                _table = new Table(6).UseAllAvailableWidth();
                _cell = new Cell(1, 1).Add(new Paragraph("Este"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Xe"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Ye"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Oeste"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Xo"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Yo"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));

                foreach (var item in listLimite)
                {
                    _cell = new Cell().Add(new Paragraph(item.Este));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Lateste));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Longeste));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Oeste));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Latoeste));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Longoeste));
                    _table.AddCell(_cell);
                }

                doc.Add(_table);

                dt = asen.CargarDGV();

                Table tableTA = new Table(1).UseAllAvailableWidth();
                Cell cellTA = new Cell().Add(new Paragraph("\nAsentamientos Humanos"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTA.AddCell(cellTA);

                doc.Add(tableTA);

                Table tableAsen = new Table(5).UseAllAvailableWidth();
                Cell cellA = new Cell(1, 1).Add(new Paragraph("Nombre"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("Sector"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("X"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("Y"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("Poblacion"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));

                List<ModeloAsentamiento> listAsentamiento = new List<ModeloAsentamiento>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloAsentamiento datatable = new ModeloAsentamiento();
                    datatable.Nombre = dt.Rows[i]["Nombre"].ToString();
                    datatable.Sector = dt.Rows[i]["Sector"].ToString();
                    datatable.X = dt.Rows[i]["X"].ToString();
                    datatable.Y = dt.Rows[i]["Y"].ToString();
                    datatable.Poblacion = dt.Rows[i]["Poblacion"].ToString();
                    listAsentamiento.Add(datatable);
                }

                foreach (var item in listAsentamiento)
                {

                    cellA = new Cell().Add(new Paragraph(item.Nombre));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.Sector));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.X));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.Y));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.Poblacion));
                    tableAsen.AddCell(cellA);
                }

                doc.Add(tableAsen);

                dt = hitos.CargarDGV();

                tableTA = new Table(1).UseAllAvailableWidth();
                cellTA = new Cell().Add(new Paragraph("\nHitos"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTA.AddCell(cellTA);

                doc.Add(tableTA);

                tableAsen = new Table(4).UseAllAvailableWidth();
                cellA = new Cell(1, 1).Add(new Paragraph("Tipo"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("Nombre"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("Latitud"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));
                cellA = new Cell(1, 1).Add(new Paragraph("Longitud"));
                tableAsen.AddHeaderCell(cellA.AddStyle(styleTitulo));

                List<ModeloHitos> listHitos = new List<ModeloHitos>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloHitos datatable = new ModeloHitos();
                    datatable.Tipo = dt.Rows[i]["Tipo"].ToString();
                    datatable.Nombre = dt.Rows[i]["Nombre"].ToString();
                    datatable.Latitud = dt.Rows[i]["X"].ToString();
                    datatable.Longitud = dt.Rows[i]["Y"].ToString();
                    listHitos.Add(datatable);
                }

                foreach (var item in listHitos)
                {

                    cellA = new Cell().Add(new Paragraph(item.Tipo));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.Nombre));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.Latitud));
                    tableAsen.AddCell(cellA);
                    cellA = new Cell().Add(new Paragraph(item.Longitud));
                    tableAsen.AddCell(cellA);
                }

                doc.Add(tableAsen);

                DataTable dtUbiHidro = hidro.CargarDGV();

                Table tableTuh = new Table(1).UseAllAvailableWidth();
                Cell cellTuh = new Cell().Add(new Paragraph("\nUbicación Hidrográfica"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTuh.AddCell(cellTuh);

                doc.Add(tableTuh);

                Table tableUbiHidro = new Table(3).UseAllAvailableWidth();
                Cell cellUH = new Cell(1, 1).Add(new Paragraph("Nombre"));
                tableUbiHidro.AddHeaderCell(cellUH.AddStyle(styleTitulo));
                cellUH = new Cell(1, 1).Add(new Paragraph("Código"));
                tableUbiHidro.AddHeaderCell(cellUH.AddStyle(styleTitulo));
                cellUH = new Cell(1, 1).Add(new Paragraph("Nivel"));
                tableUbiHidro.AddHeaderCell(cellUH.AddStyle(styleTitulo));

                List<ModeloUbicHidro> listUbiHidro = new List<ModeloUbicHidro>();

                for (int i = 0; i < dtUbiHidro.Rows.Count; i++)
                {
                    ModeloUbicHidro datatable = new ModeloUbicHidro();
                    datatable.Nombre = dtUbiHidro.Rows[i]["Nombre"].ToString();
                    datatable.Codigo = dtUbiHidro.Rows[i]["Codigo"].ToString();
                    datatable.Nivel = dtUbiHidro.Rows[i]["Nivel"].ToString();
                    listUbiHidro.Add(datatable);
                }

                foreach (var item in listUbiHidro)
                {

                    cellUH = new Cell().Add(new Paragraph(item.Nombre));
                    tableUbiHidro.AddCell(cellUH);
                    cellUH = new Cell().Add(new Paragraph(item.Codigo));
                    tableUbiHidro.AddCell(cellUH);
                    cellUH = new Cell().Add(new Paragraph(item.Nivel));
                    tableUbiHidro.AddCell(cellUH);
                }

                doc.Add(tableUbiHidro);

                dt = eco.CargarDGV();

                Table tableTE = new Table(1).UseAllAvailableWidth();
                Cell cellTE = new Cell().Add(new Paragraph("\nEcosistemas y Formaciones Vegetales"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTE.AddCell(cellTE);

                doc.Add(tableTE);

                Table tableEco = new Table(2).UseAllAvailableWidth();
                Cell cellEco = new Cell(1, 1).Add(new Paragraph("Tipo"));
                tableEco.AddHeaderCell(cellEco.AddStyle(styleTitulo));
                cellEco = new Cell(1, 1).Add(new Paragraph("Nombre"));
                tableEco.AddHeaderCell(cellEco.AddStyle(styleTitulo));

                List<ModeloEco> listEco = new List<ModeloEco>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloEco datatable = new ModeloEco();
                    datatable.Tipo = dt.Rows[i]["Tipo"].ToString();
                    datatable.Nombre = dt.Rows[i]["Nombre"].ToString();
                    listEco.Add(datatable);
                }

                foreach (var item in listEco)
                {

                    cellEco = new Cell().Add(new Paragraph(item.Tipo));
                    tableEco.AddCell(cellEco);
                    cellEco = new Cell().Add(new Paragraph(item.Nombre));
                    tableEco.AddCell(cellEco);
                }

                doc.Add(tableEco);

                dt = tiempo.CargarDGV();

                tableTE = new Table(1).UseAllAvailableWidth();
                cellTE = new Cell().Add(new Paragraph("\nTiempos"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableTE.AddCell(cellTE);

                doc.Add(tableTE);

                tableEco = new Table(2).UseAllAvailableWidth();
                cellEco = new Cell(1, 1).Add(new Paragraph("Tipo"));
                tableEco.AddHeaderCell(cellEco.AddStyle(styleTitulo));
                cellEco = new Cell(1, 1).Add(new Paragraph("Nombre"));
                tableEco.AddHeaderCell(cellEco.AddStyle(styleTitulo));

                List<ModeloTiempo> listTiempo = new List<ModeloTiempo>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloTiempo datatable = new ModeloTiempo();
                    datatable.Tipo = dt.Rows[i]["Tipo"].ToString();
                    datatable.Nombre = dt.Rows[i]["Nombre"].ToString();
                    listTiempo.Add(datatable);
                }

                foreach (var item in listTiempo)
                {

                    cellEco = new Cell().Add(new Paragraph(item.Tipo));
                    tableEco.AddCell(cellEco);
                    cellEco = new Cell().Add(new Paragraph(item.Nombre));
                    tableEco.AddCell(cellEco);
                }

                doc.Add(tableEco);

                doc.Close();
                pw.Close();

                MessageBox.Show("Reporte generado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("No ha seleccionado una ruta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ReporteCambioClimatico()
        {
            string ruta = RetornarRuta();
            if (ruta != "")
            {

                ruta = ruta + @"\ReporteCambioClimatico_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

                FileStream fs = new FileStream(ruta, FileMode.Create);

                ModeloCambioClima clima = new ModeloCambioClima();

                DataTable dt = clima.CargarDGVclima();

                PdfWriter pw = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER);
                doc.SetMargins(75, 35, 70, 35);

                string pathLogo = ("../../Resources/logoPacha_png.png");
                Image img = new Image(ImageDataFactory.Create(pathLogo));

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img));

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler());

                //string nameFont = uri("/fonts/(nombre del font.otf)");

                //doc.Add(new Paragraph("REPORTE ACTORES").AddStyle(style));

                Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Reporte Fase 1.2: Cambio Climático")
                    .SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);
                
                cell = new Cell().Add(new Paragraph("\n"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                Style styleTitulo = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                    .SetFontSize(10);

                Table _table = new Table(7).UseAllAvailableWidth();
                Cell _cell = new Cell(1, 1).Add(new Paragraph("Lugar"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Cambio Potencial"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Amenaza"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Impacto Previsto"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Riesgo Climático"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Estrategia Sugerida"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Política Aplicada"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));

                List<ModeloCambioClima> listClima = new List<ModeloCambioClima>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloCambioClima datatable = new ModeloCambioClima();
                    datatable.Lugar = dt.Rows[i]["Lugar"].ToString();
                    datatable.CambioP = dt.Rows[i]["Cambios Potenciales"].ToString();
                    datatable.Amenaza = dt.Rows[i]["Amenazas"].ToString();
                    datatable.ImpactoPr = dt.Rows[i]["Impactos Previstos"].ToString();
                    datatable.RiesgoClim = dt.Rows[i]["Riesgo Climatico"].ToString();
                    datatable.EstrategiaSug = dt.Rows[i]["Estrategias Sugeridas"].ToString();
                    datatable.PoliticaAp = dt.Rows[i]["Politicas en marcha"].ToString();
                    listClima.Add(datatable);
                }

                foreach (var item in listClima)
                {

                    _cell = new Cell().Add(new Paragraph(item.Lugar));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.CambioP));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Amenaza));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.ImpactoPr));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.RiesgoClim));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.EstrategiaSug));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.PoliticaAp));
                    _table.AddCell(_cell);
                }

                doc.Add(_table);


                doc.Close();
                pw.Close();

                MessageBox.Show("Reporte generado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("No ha seleccionado una ruta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ReporteActoresProyectos()
        {
            string ruta = RetornarRuta();
            if (ruta != "")
            {

                ruta = ruta + @"\ReporteActoresLocales_"+ DateTime.Now.ToString("yyyy-MM-dd") + ".pdf"; 

                FileStream fs = new FileStream(ruta, FileMode.Create);

                ModeloActores actores = new ModeloActores();
                ModeloProyecto proyecto = new ModeloProyecto();

                DataTable dt = actores.CargarReporteActoresProyecto();

                PdfWriter pw = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(pw);
                Document doc = new Document(pdfDocument, PageSize.LETTER);
                doc.SetMargins(75, 35, 70, 35);

                string pathLogo = ("../../Resources/logoPacha_png.png");
                Image img = new Image(ImageDataFactory.Create(pathLogo));

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(img));

                pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler());

                //string nameFont = uri("/fonts/(nombre del font.otf)");

                //doc.Add(new Paragraph("REPORTE ACTORES").AddStyle(style));

                Table table = new Table(1).UseAllAvailableWidth();
                Cell cell = new Cell().Add(new Paragraph("Reporte Fase 1.1: Actores Locales")
                    .SetFontSize(14))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);

                table.AddCell(cell);
                cell = new Cell().Add(new Paragraph("\nActores"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                table.AddCell(cell);

                doc.Add(table);

                Style styleFilas = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(8);
                Style styleTitulo = new Style()
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBold()
                    .SetFontSize(10);

                Table _table = new Table(6).UseAllAvailableWidth();
                Cell _cell = new Cell(1, 1).Add(new Paragraph("Nombre"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Siglas"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Tipo"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Relacion"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Incidencia"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));
                _cell = new Cell(1, 1).Add(new Paragraph("Competencia Relacionada"));
                _table.AddHeaderCell(_cell.AddStyle(styleTitulo));

                List<ModeloActores> listActores = new List<ModeloActores>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloActores datatable = new ModeloActores();
                    datatable.Nombre = dt.Rows[i]["NOMBRE"].ToString();
                    datatable.Siglas = dt.Rows[i]["SIGLAS"].ToString();
                    datatable.Tipo = dt.Rows[i]["TIPO"].ToString();
                    datatable.Relaciones = dt.Rows[i]["RELACIONES"].ToString();
                    datatable.Incidencias = dt.Rows[i]["INCIDENCIAS"].ToString();
                    datatable.Competencias = dt.Rows[i]["COMPETENCIASRELACIONADAS"].ToString();
                    listActores.Add(datatable);
                }

                foreach (var item in listActores)
                {

                    _cell = new Cell().Add(new Paragraph(item.Nombre));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Siglas));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Tipo));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Relaciones));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Incidencias));
                    _table.AddCell(_cell);
                    _cell = new Cell().Add(new Paragraph(item.Competencias));
                    _table.AddCell(_cell);
                }

                doc.Add(_table);

                Table tableT = new Table(1).UseAllAvailableWidth();
                Cell cellT = new Cell().Add(new Paragraph("\nProyectos"))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER);
                tableT.AddCell(cellT);

                doc.Add(tableT);

                Table tableP = new Table(7).UseAllAvailableWidth();
                Cell cellP = new Cell(1, 1).Add(new Paragraph("Actor"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));
                cellP = new Cell(1, 1).Add(new Paragraph("Proyecto"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));
                cellP = new Cell(1, 1).Add(new Paragraph("Objetivo"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));
                cellP = new Cell(1, 1).Add(new Paragraph("Responsable"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));
                cellP = new Cell(1, 1).Add(new Paragraph("Cargo"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));
                cellP = new Cell(1, 1).Add(new Paragraph("Telefono"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));
                cellP = new Cell(1, 1).Add(new Paragraph("E-mail"));
                tableP.AddHeaderCell(cellP.AddStyle(styleTitulo));

                dt = proyecto.CargarReporteActoresProyecto();

                List<ModeloProyecto> listProyectos = new List<ModeloProyecto>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ModeloProyecto datatable = new ModeloProyecto();
                    datatable.Actor = dt.Rows[i]["ACTOR"].ToString();
                    datatable.Proyecto = dt.Rows[i]["NOMBRE"].ToString();
                    datatable.Objetivo = dt.Rows[i]["OBJETIVO"].ToString();
                    datatable.Responsable = dt.Rows[i]["RESPONSABLE"].ToString();
                    datatable.Cargo = dt.Rows[i]["CARGO"].ToString();
                    datatable.Telefono = dt.Rows[i]["TELEFONO"].ToString();
                    datatable.Email = dt.Rows[i]["EMAIL"].ToString();
                    listProyectos.Add(datatable);
                }

                foreach (var item in listProyectos)
                {

                    cellP = new Cell().Add(new Paragraph(item.Actor));
                    tableP.AddCell(cellP);
                    cellP = new Cell().Add(new Paragraph(item.Proyecto));
                    tableP.AddCell(cellP);
                    cellP = new Cell().Add(new Paragraph(item.Objetivo));
                    tableP.AddCell(cellP);
                    cellP = new Cell().Add(new Paragraph(item.Responsable));
                    tableP.AddCell(cellP);
                    cellP = new Cell().Add(new Paragraph(item.Cargo));
                    tableP.AddCell(cellP);
                    cellP = new Cell().Add(new Paragraph(item.Telefono));
                    tableP.AddCell(cellP);
                    cellP = new Cell().Add(new Paragraph(item.Email));
                    tableP.AddCell(cellP);
                }

                doc.Add(tableP);


                doc.Close();
                pw.Close();

                MessageBox.Show("Documento generado...", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(ruta);
            }
            else
            {
                MessageBox.Show("No ha seleccionado una ruta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class HeaderEventHandler : IEventHandler
    {
        Image img;
        public HeaderEventHandler(Image img)
        {
            this.img = img;
        }

        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdfDoc = docEvent.GetDocument();
            PdfPage page = docEvent.GetPage();


            PdfCanvas canvas1 = new PdfCanvas(page.NewContentStreamBefore(), page.GetResources(), pdfDoc);
            Rectangle rootArea = new Rectangle(36,  page.GetPageSize().GetTop() - 75, page.GetPageSize().GetWidth() - 70, 55);
            
            new Canvas(canvas1, rootArea)
                .Add(getTable(docEvent));

           

        }

        public Table getTable(PdfDocumentEvent docEvent)
        {
            float[] cellWidth = { 20f, 80f };
            Table tableEvent = new Table(UnitValue.CreatePercentArray(cellWidth)).UseAllAvailableWidth();
            //tableEvent.SetWidth(UnitValue.CreatePercentValue(100f));
            Style styleCell = new Style()
                .SetBorder(Border.NO_BORDER);

            Style styleText = new Style()
                .SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10f);

            Cell cell = new Cell().Add(img.SetAutoScale(true));

            tableEvent.AddCell(cell
                .AddStyle(styleCell)
                .SetTextAlignment(TextAlignment.LEFT));

            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            cell = new Cell()
                .Add(new Paragraph("Reporte diario\n").SetFont(bold))
                .Add(new Paragraph("Grupo de Investigación de Ambiente y Cambio Climático\n").SetFont(bold))
                .Add(new Paragraph("Fecha de emisión: " +DateTime.Now.ToShortDateString()))
                .AddStyle(styleText).AddStyle(styleCell);

            tableEvent.AddCell(cell);

            return tableEvent;
        }
    }

    public class FooterEventHandler : IEventHandler
    {
        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdfDoc = docEvent.GetDocument();
            PdfPage page = docEvent.GetPage();


            PdfCanvas canvas1 = new PdfCanvas(page.NewContentStreamAfter(), page.GetResources(), pdfDoc);
            Rectangle rootArea = new Rectangle(36, 20, page.GetPageSize().GetWidth() - 70, 50);

            new Canvas(canvas1, rootArea)
                .Add(getTable(docEvent));

        }

        public Table getTable(PdfDocumentEvent docEvent)
        {
            float[] cellWidth = { 92f, 8f };
            Table tableEvent = new Table(UnitValue.CreatePercentArray(cellWidth)).UseAllAvailableWidth();
            //tableEvent.SetWidth(UnitValue.CreatePercentValue(100f));

            int pageNum = docEvent.GetDocument().GetPageNumber(docEvent.GetPage());

            //ColorConstants.GREE = new DeviceRgb(53, 104, 45);

            Style styleCell = new Style()
                .SetPadding(5)
                .SetBorder(Border.NO_BORDER)
                .SetBorderTop(new SolidBorder(ColorConstants.BLACK, 2));

            Cell cell = new Cell().Add(new Paragraph(DateTime.Now.ToLongDateString()));

            tableEvent.AddCell(cell
                .AddStyle(styleCell)
                .SetTextAlignment(TextAlignment.RIGHT))
                .SetFontColor(ColorConstants.LIGHT_GRAY)
                .SetFontSize(8);

            cell = new Cell().Add(new Paragraph(pageNum.ToString()));
            cell.AddStyle(styleCell)
                .SetBackgroundColor(ColorConstants.BLACK)
                .SetFontColor(ColorConstants.WHITE)
                .SetTextAlignment(TextAlignment.CENTER);
            tableEvent.AddCell(cell);

            return tableEvent;
        }
    }
}