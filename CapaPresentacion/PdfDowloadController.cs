using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
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

        public void ReporteActoresProyectos()
        {

            FileStream fs = new FileStream(@"D:\LECTOR.pdf", FileMode.Create);

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
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            
            Style style = new Style()
                .SetFontSize(24)
                .SetFont(font)
                .SetFontColor(ColorConstants.GREEN)
                .SetBackgroundColor(ColorConstants.RED);

            //doc.Add(new Paragraph("REPORTE ACTORES").AddStyle(style));

            Table table = new Table(1).UseAllAvailableWidth();
            Cell cell = new Cell().Add(new Paragraph("Reporte de Actores y Proyectos")
                .SetFontSize(14))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBorder(Border.NO_BORDER);
            table.AddCell(cell);
            cell = new Cell().Add(new Paragraph("Actores "))
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

            foreach(var item in listActores)
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
            Cell cellT = new Cell().Add(new Paragraph("Proyectos "))
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
                .Add(new Paragraph("Departamento de Recursos Materiales\n").SetFont(bold))
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
                .SetFontColor(ColorConstants.LIGHT_GRAY);

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