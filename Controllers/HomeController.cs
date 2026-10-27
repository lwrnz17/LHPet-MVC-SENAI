using LHPet.Models;
using Microsoft.AspNetCore.Mvc;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Dados em memória, como solicitado nesta primeira etapa.
        var listaClientes = new List<Cliente>
        {
            new(1, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga"),
            new(2, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug"),
            new(3, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron"),
            new(4, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim"),
            new(5, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc")
        };

        var listaFornecedores = new List<Fornecedor>
        {
            new(1, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org"),
            new(2, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br"),
            new(3, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us"),
            new(4, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk"),
            new(5, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us")
        };

        ViewBag.listaClientes = listaClientes;
        ViewBag.listaFornecedores = listaFornecedores;
        return View();
    }
}
