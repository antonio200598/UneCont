using UneContAPI.Data;
using Microsoft.EntityFrameworkCore;
using UneContAPI.Models;

namespace UneContAPI.DAO;

public class ServicoDAO
{
    private readonly ApplicationDbContext _context;

    public ServicoDAO(ApplicationDbContext context)
    {
        _context = context;
    }

    public Servico Insert(Models.Servico servico)
    {
        _context.Servico.Add(servico);
        _context.SaveChanges();

        return servico;
    }

    public Models.Servico GetById(long id)
    {
        return _context.Servico
          .FirstOrDefault(servico => servico.Id == id);
    }
}
