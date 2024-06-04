using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
    internal class PdfCreator
    {
        public static void createPdf(List<OrderedItem> items, string worker, string sum)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF document (*.pdf)|*.pdf";
            string currentDateTime = DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss");
            saveDialog.FileName = currentDateTime;

            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
              
                    PdfWriter writer = new PdfWriter(saveDialog.FileName);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    Table table = new Table(3);
                    Cell cell11 = new Cell(0, 0)
                         .SetBackgroundColor(ColorConstants.GRAY)
                         .SetTextAlignment(TextAlignment.CENTER)
                         .Add(new Paragraph("Name"));
                    Cell cell12 = new Cell(0, 1)
                        .SetBackgroundColor(ColorConstants.GRAY)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph("Quantity"));
                    Cell cell13 = new Cell(0, 2)
                        .SetBackgroundColor(ColorConstants.GRAY)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph("Price"));
                    table.AddCell(cell11);
                    table.AddCell(cell12);
                    table.AddCell(cell13);

                    for (int i = 0; i < items.Count; i++)
                    {
                        OrderedItem item = items[i];
                        Cell newCell1 = new Cell(i, 0)
                             .SetTextAlignment(TextAlignment.CENTER)
                             .Add(new Paragraph(item.name));
                        Cell newCell2 = new Cell(i, 1)
                             .SetTextAlignment(TextAlignment.CENTER)
                             .Add(new Paragraph(item.quantity.ToString()));
                        Cell newCell3 = new Cell(i, 2)
                             .SetTextAlignment(TextAlignment.CENTER)
                             .Add(new Paragraph(item.priceSum.ToString()));

                        table.AddCell(newCell1);
                        table.AddCell(newCell2);
                        table.AddCell(newCell3);
                    }

                    Paragraph dateP = new Paragraph($"date and time: {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(12);
                    Paragraph workerP = new Paragraph($"server: {worker}")
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetFontSize(12);
                    Paragraph sumP = new Paragraph($"to be paid: {sum} €")
                       .SetTextAlignment(TextAlignment.LEFT)
                       .SetFontSize(12);

                    document.Add(table);
                    document.Add(dateP);
                    document.Add(workerP);
                    document.Add(sumP);
                    document.Close();
            }
        }

    }
}
