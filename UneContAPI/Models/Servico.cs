using System.Xml.Serialization;

namespace UneContAPI.Models;

public class Servico
{
  public long Id { get; set; }

  [XmlElement("Descricao")]
  public string Descricao { get; set; }

  [XmlElement("Valor")]
  public decimal Valor { get; set; }
}
