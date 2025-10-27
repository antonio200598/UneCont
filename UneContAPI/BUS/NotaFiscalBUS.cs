using UneContAPI.DAO;
using UneContAPI.Models;

namespace UneContAPI.BUS;

public class NotaFiscalBUS
{
    private readonly NotaFiscalDAO _dao;

    public NotaFiscalBUS(NotaFiscalDAO dao)
    {
        _dao = dao;
    }

    public void InsertNotaFiscal(NotaFiscal nf)
    {
        if (nf.Prestador.Id <= 0 || nf.Tomador.Id <= 0 || nf.Servico.Id <= 0)
          throw new Exception("Entidades relacionadas não podem ser nulas.");
        
        if (nf.DataEmissao == default)
          nf.DataEmissao = DateTime.Now;

        _dao.Insert(nf);
    }

    public List<NotaFiscal> GetAll() => _dao.GetAll();

    public NotaFiscal GetById(long id)
    {
        var nf = _dao.GetById(id);

        if (nf == null || nf.Id != id)
          throw new Exception("Nota Fiscal não encontrada.");
      
        return nf;
    }

    public NotaFiscal GetByNumero(long numero)
    {
        var nf = _dao.GetByNumero(numero);

        return nf;
    }

}
