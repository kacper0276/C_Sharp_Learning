using System.Xml.Serialization;

namespace OperacjeNaDanych.PlikiXML
{
    public class BaseEntity
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
    }
}
