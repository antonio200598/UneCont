using System.Xml.Serialization;

namespace UneContAPI.Models;

[XmlRoot("NotaFiscal")]
public class NotaFiscal
{
  public long Id { get; set; }

  public long Numero { get; set; }

  public DateTime DataEmissao { get; set; }

  public long PrestadorId { get; set; }

  public Prestador Prestador { get; set; }

  public long TomadorId { get; set; }

  public Tomador Tomador { get; set; }

  public long ServicoId { get; set; }

  public Servico Servico { get; set; }
}
