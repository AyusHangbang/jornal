using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

public void Export(List<Journal> entries, string path)
{
    var doc = new PdfDocument();
    foreach (var e in entries)
    {
        var p = doc.AddPage();
        var g = XGraphics.FromPdfPage(p);
        g.DrawString(e.Title, new XFont("Arial",12), XBrushes.Black, 20, 40);
        g.DrawString(e.Content, new XFont("Arial",10), XBrushes.Black, 20, 80);
    }
    doc.Save(path);
}
