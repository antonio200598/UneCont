using UneContAPI.DAO;
using UneContAPI.Models;

namespace UneContAPI.BUS;

public class PrestadorBUS
{
    private readonly PrestadorDAO _dao;

    public PrestadorBUS(PrestadorDAO dao)
    {
      _dao = dao;
    }

    public Prestador Cadastrar(Prestador entity)
    {
        var prestador = _dao.Insert(entity);

        return prestador;
    }

    public Prestador GetById(long id)
    {
        var entity = _dao.GetById(id);

        if (entity == null || entity.Id != id)
          throw new Exception("Prestador não encontrado.");

        return entity;
    }

    public Prestador GetByCNPJ(long cnpj)
    {
        var entity = _dao.GetByCNPJ(cnpj);

        return entity;
    }
}
