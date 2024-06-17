using Microsoft.AspNetCore.Mvc;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;

[ApiController]
[Route("[controller]")]
public class PdfController : ControllerBase {
    [HttpPost]
    [Route("download-pdf")]
    public async Task<IActionResult> DownloadPdf() {
        using (var memoryStream = new MemoryStream())
        {
            await Request.Body.CopyToAsync(memoryStream);
            var pdfBytes = memoryStream.ToArray();
            // Return the generated PDF as a file result
            return File(pdfBytes, "application/pdf", "Estadisticas_OMB.pdf");
        }
    }
}