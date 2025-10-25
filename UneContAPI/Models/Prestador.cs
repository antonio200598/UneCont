using System.Xml.Serialization;

namespace UneContAPI.Models;

public class Prestador
{
  public long Id { get; set; }

  [XmlElement("CNPJ")]
  public long CNPJ { get; set; }
}
