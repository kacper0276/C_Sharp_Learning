namespace ProgramowanieObiektowe.Solid
{
    internal interface ISaveFileManager : ISaveJsonFile, ISaveXmlFile
    {
        
    }

    internal interface ISaveJsonFile
    {
        public byte[] SaveAsJson(object obj);
    }

    internal interface ISaveXmlFile
    {
        public byte[] SaveAsXml(object obj);
    }
}
