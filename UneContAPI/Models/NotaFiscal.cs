using System.Xml.Serialization;

namespace UneContAPI.Models;

[XmlRoot("NotaFiscal")]
public class NotaFiscal
{
  public long Id { get; set; }

  public long Numero { get; set; }

  public DateTime DataEmissao { get; set; }

  public Prestador Prestador { get; set; }

  public Tomador Tomador { get; set; }

  public Servico Servico { get; set; }
}
