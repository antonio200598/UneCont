using UneContAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace UneContAPI.DAO;

public class ServicoDAO
{
    private readonly ApplicationDbContext _context;

    public ServicoDAO(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Insert(Models.Servico servico)
    {
        _context.Servico.Add(servico);
        _context.SaveChanges();
    }

    public Models.Servico GetById(long id)
    {
        return _context.Servico
          .FirstOrDefault(servico => servico.Id == id);
    }
}
