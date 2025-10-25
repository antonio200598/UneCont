using System.Xml.Serialization;

namespace UneContAPI.Models;

public class Tomador
{
  public long Id { get; set; }

  [XmlElement("CNPJ")]
  public long CNPJ { get; set; }
}
