using GustavoASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ClimaController : Controller
{

    private readonly ServicoClima _servicoClima;

    public ClimaController(ServicoClima servicoClima)
    {
        _servicoClima = servicoClima;
    }

    [Route("Clima/{cidade}")]
    public async Task<IActionResult> Index(string cidade)
    {
        DadosClima dadosClima = await _servicoClima.ObterDadosClima(cidade);

        if (dadosClima != null)
        {
            return View(dadosClima);
        }
        else
        {
            TempData["MensagemErro"] = $"Cidade '{cidade}' não encontrada.";
            return RedirectToAction("Clima/Presidente Prudente");
        }
    }
}