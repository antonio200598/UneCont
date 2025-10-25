using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml.Serialization;
using UneContAPI.BUS;
using UneContAPI.DAO;
using UneContAPI.Data;
using UneContAPI.Models;

namespace UneContAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UneContApiController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private readonly NotaFiscalBUS _notaFiscalBus;
    private readonly PrestadorBUS _prestadorBUS;
    private readonly TomadorBUS _tomadorBUS;
    private readonly ServicoBUS _servicoBUS;

    public UneContApiController(ApplicationDbContext context)
    {
        _context = context;
        _notaFiscalBus = new NotaFiscalBUS(new NotaFiscalDAO(_context));
        _prestadorBUS = new PrestadorBUS(new PrestadorDAO(_context));
        _tomadorBUS = new TomadorBUS(new TomadorDAO(_context));
        _servicoBUS = new ServicoBUS(new ServicoDAO(_context));
    }

    [HttpPost("Save-NotaFiscal")]
    [Consumes("application/xml")]
    public IActionResult SaveNotaFiscal([FromBody] NotaFiscal notaFiscal)
    {
        if (notaFiscal == null)
          return BadRequest("XML inválido.");

        try
        {

            _notaFiscalBus.InsertNotaFiscal(notaFiscal);

            return Ok("Nota Fiscal salva com sucesso.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


}
