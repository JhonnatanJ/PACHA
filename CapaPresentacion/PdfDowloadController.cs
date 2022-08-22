using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace CapaPresentacion
{
    public class PDFDownloadController
    {

        public void Pdf()
        {
            FileStream fs = new FileStream(@"D:\LECTOR.pdf", FileMode.Create);

            PdfWriter pw = new PdfWriter(fs);
            PdfDocument pdfDocument = new PdfDocument(pw);
            Document doc = new Document(pdfDocument, PageSize.LETTER);

            doc.Add(new Paragraph("Hola Mundo"));
            doc.Close();
            pw.Close();

            MessageBox.Show("Documento generado...", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}