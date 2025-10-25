using UneContAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace UneContAPI.DAO;

public class PrestadorDAO
{
    private readonly ApplicationDbContext _context;

    public PrestadorDAO(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Insert(Models.Prestador prestador)
    {
        _context.Prestador.Add(prestador);
        _context.SaveChanges();
    }

    public Models.Prestador GetById(long id)
    {
        return _context.Prestador
          .FirstOrDefault(p => p.Id == id);
    }

    public Models.Prestador GetByCNPJ(long cnpj)
    {
        return _context.Prestador
          .FirstOrDefault(p => p.CNPJ == cnpj);
    }
}
