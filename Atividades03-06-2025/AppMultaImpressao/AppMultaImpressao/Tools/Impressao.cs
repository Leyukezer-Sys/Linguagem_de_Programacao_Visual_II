using AppMulta.Models;
using FastReport;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace AppMultaImpressao.Tools
{
    public class Impressao
    {
        //método modelo de impressão
        public async Task GerarImpressaoVeiculos(List<Veiculo> lista1, NavigationManager nav, IJSRuntime jsRuntime)
        {
            try
            {
                var date = DateTime.Now;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @$"Relatorios\VeiculoRelatorio.frx");
                if (!File.Exists(filePath))
                {
                    var report = new FastReport.Report();
                    report.Dictionary.RegisterBusinessObject(lista1, "lista1", 10, true);
                    report.Report.Save(filePath);

                }

                var report1 = new FastReport.Report();
                report1.Report.Load(filePath);
                report1.Dictionary.RegisterBusinessObject(lista1, "lista1", 10, true);
                report1.Prepare();
                using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
                using var reportStream = new MemoryStream();
                pdfExport.Export(report1, reportStream);

                var fileName = $"Relatorio_{Guid.NewGuid()}.pdf";
                var filePathTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "RelatoriosTemp", fileName);

                // Cria a pasta se não existir
                Directory.CreateDirectory(Path.GetDirectoryName(filePathTemp));

                // Salva o arquivo PDF temporariamente na pasta wwwroot/RelatoriosTemp
                File.WriteAllBytes(filePathTemp, reportStream.ToArray());

                // Gera a URL para o arquivo temporário
                var url = nav.ToAbsoluteUri($"/RelatoriosTemp/{fileName}");

                //// Abre o relatório em uma nova guia
                //nav.NavigateTo(url.ToString(), true);

                await jsRuntime.InvokeVoidAsync("NovaGuia", url.ToString()); //alteração 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aqui!: " + ex.Message.ToString());
                throw new Exception(ex.Message);

            }

        }//fim do método modelo de impressão 

        //método modelo de impressão
        public async Task GerarImpressaoMultas(List<Multa> listaMulta, NavigationManager nav, IJSRuntime jsRuntime)
        {
            try
            {
                var date = DateTime.Now;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @$"Relatorios\MultaRelatorio.frx");
                if (!File.Exists(filePath))
                {
                    var report = new FastReport.Report();
                    report.Dictionary.RegisterBusinessObject(listaMulta, "listaMulta", 10, true);
                    report.Report.Save(filePath);

                }

                var report1 = new FastReport.Report();
                report1.Report.Load(filePath);
                report1.Dictionary.RegisterBusinessObject(listaMulta, "listaMulta", 10, true);
                report1.Prepare();
                using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
                using var reportStream = new MemoryStream();
                pdfExport.Export(report1, reportStream);

                var fileName = $"Relatorio_{Guid.NewGuid()}.pdf";
                var filePathTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "RelatoriosTemp", fileName);

                // Cria a pasta se não existir
                Directory.CreateDirectory(Path.GetDirectoryName(filePathTemp));

                // Salva o arquivo PDF temporariamente na pasta wwwroot/RelatoriosTemp
                File.WriteAllBytes(filePathTemp, reportStream.ToArray());

                // Gera a URL para o arquivo temporário
                var url = nav.ToAbsoluteUri($"/RelatoriosTemp/{fileName}");

                //// Abre o relatório em uma nova guia
                //nav.NavigateTo(url.ToString(), true);

                await jsRuntime.InvokeVoidAsync("NovaGuia", url.ToString()); //alteração 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aqui!: " + ex.Message.ToString());
                throw new Exception(ex.Message);

            }

        }//fim do método modelo de impressão

        //método modelo de impressão
        public async Task GerarImpressaoGeral(List<Veiculo> listaVeiculo, List<Multa> listaMulta, NavigationManager nav, IJSRuntime jsRuntime)
        {
            try
            {
                var date = DateTime.Now;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @$"Relatorios\RelatorioGeral.frx");
                if (!File.Exists(filePath))
                {
                    var report = new FastReport.Report();
                    report.Dictionary.RegisterBusinessObject(listaMulta, "Multas", 10, true);
                    report.Dictionary.RegisterBusinessObject(listaVeiculo, "Veiculos", 10, true);
                    report.Report.Save(filePath);

                }

                var report1 = new FastReport.Report();
                report1.Report.Load(filePath);
                report1.Dictionary.RegisterBusinessObject(listaMulta, "Multas", 10, true);
                report1.Dictionary.RegisterBusinessObject(listaVeiculo, "Veiculos", 10, true);
                report1.Prepare();
                using var pdfExport = new FastReport.Export.PdfSimple.PDFSimpleExport();
                using var reportStream = new MemoryStream();
                pdfExport.Export(report1, reportStream);

                var fileName = $"Relatorio_{Guid.NewGuid()}.pdf";
                var filePathTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "RelatoriosTemp", fileName);

                // Cria a pasta se não existir
                Directory.CreateDirectory(Path.GetDirectoryName(filePathTemp));

                // Salva o arquivo PDF temporariamente na pasta wwwroot/RelatoriosTemp
                File.WriteAllBytes(filePathTemp, reportStream.ToArray());

                // Gera a URL para o arquivo temporário
                var url = nav.ToAbsoluteUri($"/RelatoriosTemp/{fileName}");

                //// Abre o relatório em uma nova guia
                //nav.NavigateTo(url.ToString(), true);

                await jsRuntime.InvokeVoidAsync("NovaGuia", url.ToString()); //alteração 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro aqui!: " + ex.Message.ToString());
                throw new Exception(ex.Message);

            }

        }//fim do método modelo de impressão
    }
}
