using System.IO;
using System.Xml.Serialization;

namespace XlsxParser
{
    public static class XMLSerializer
    {
        public static void WriteAsXml<T>(T obj, string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(T));
            using (FileStream file = File.Create(path))
            {
                writer.Serialize(file, obj);
            }
        }

        public static T ReadXmlToObj<T>(string FilePath)
        {
            XmlSerializer XmlReader = new XmlSerializer(typeof(T));
            using (Stream reader = new FileStream(FilePath, FileMode.Open))
            {
                return (T)XmlReader.Deserialize(reader);
            }
        }
    }
}