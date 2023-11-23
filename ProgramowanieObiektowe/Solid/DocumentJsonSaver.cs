using System.Text.Json;
using System.Text;

namespace ProgramowanieObiektowe.Solid
{
    public class DocumentJsonSaver
    {
        private readonly Document _document;

        public DocumentJsonSaver(Document document)
        {
            _document = document;
        }

        public byte[] SaveAsJson()
        {
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(_document));
        }
    }
}
