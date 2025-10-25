using Microsoft.EntityFrameworkCore;
using UneContAPI.Data;
using UneContAPI.Models;

namespace UneContAPI.DAO;

public class TomadorDAO
{
    private readonly ApplicationDbContext _context;

    public TomadorDAO(ApplicationDbContext context)
    {
        _context = context;
    }

    public Tomador Insert(Models.Tomador tomador)
    {
        _context.Tomador.Add(tomador);
        _context.SaveChanges();

        return tomador;
    }

  public Models.Tomador GetById(long id)
    {
        return _context.Tomador.FirstOrDefault(t => t.Id == id);
    }

    public Models.Tomador GetByCNPJ(long cnpj)
    {
        return _context.Tomador.FirstOrDefault(t => t.CNPJ == cnpj);
    }
}
