using System.Xml.Serialization;

namespace OperacjeNaDanych.PlikiXML;
public class Product : BaseEntity
{
    [XmlElement("Name")]
    public string Name { get; set; } = nameof(Product);
    [XmlElement("Cost")]
    public decimal Cost { get; set; } = 0;
    [XmlIgnore]
    public bool IsSold { get; set; }
}
