using Microsoft.EntityFrameworkCore;
using System;
using UneContAPI.Data;

namespace UneContAPI.DAO;

public class NotaFiscalDAO
{
    private readonly ApplicationDbContext _context;

    public NotaFiscalDAO(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Insert(Models.NotaFiscal notaFiscal)
    {
        _context.NotaFiscal.Add(notaFiscal);
        _context.SaveChanges();
    }

    public List<Models.NotaFiscal> GetAll()
    {
        return _context.NotaFiscal
          .Include(nf => nf.Prestador)
          .Include(nf => nf.Tomador)
          .Include(nf => nf.Servico)
          .ToList();
    }

    public Models.NotaFiscal GetById(long id)
    {
        return _context.NotaFiscal
                .Include(nf => nf.Prestador)
                .Include(nf => nf.Tomador)
                .Include(nf => nf.Servico)
                .FirstOrDefault(nf => nf.Id == id);
  }
}
