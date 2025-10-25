using Microsoft.AspNetCore.Mvc;
using System;
using UneContAPI.BUS;
using UneContAPI.Data;

namespace UneContAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UneContApiController : ControllerBase
  {
    private readonly ApplicationDbContext _context;
    private readonly NotaFiscalBUS _bus;


    // GET: api/<UneContApiController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<UneContApiController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<UneContApiController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<UneContApiController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UneContApiController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
