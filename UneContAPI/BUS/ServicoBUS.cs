using UneContAPI.DAO;
using UneContAPI.Models;

namespace UneContAPI.BUS;

public class ServicoBUS
{
    private readonly ServicoDAO _dao;

    public ServicoBUS(ServicoDAO dao)
    {
        _dao = dao;
    }

    public void Cadastrar(Servico entity)
    {
        _dao.Insert(entity);
    }

    public Servico GetById(long id)
    {
        var entity = _dao.GetById(id);

        if (entity == null || entity.Id != id)
          throw new Exception("Serviço não encontrado.");

        return entity;
    }
}
