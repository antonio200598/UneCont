using UneContAPI.DAO;
using UneContAPI.Models;

namespace UneContAPI.BUS;

public class TomadorBUS
{
    private readonly TomadorDAO _dao;

    public TomadorBUS(TomadorDAO dao)
    {
        _dao = dao;
    }

    public void Cadastrar(Tomador entity)
    {
        _dao.Insert(entity);
    }

    public Tomador GetById(long id)
    {
        var entity = _dao.GetById(id);

        if (entity == null || entity.Id != id)
          throw new Exception("Tomador não encontrado.");

        return entity;
    }

    public Tomador GetByCNPJ(long cnpj)
    {
        var entity = _dao.GetByCNPJ(cnpj);

        return entity;
    }
}
