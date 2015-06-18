using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MebelkiLogic
{
    public class FileManager
    {
        public static void SaveFile(OrderSingleton order, Stream stream)
        {
            StreamWriter file =  StreamWriter.Null;
            try
            {
                var serializer = new XmlSerializer(typeof(OrderSingleton));
                file = new StreamWriter(stream);
                serializer.Serialize(file, order);
            }
            finally
            {
                file.Close();
                stream.Close();
            }
        }

        public static OrderSingleton OpenFile(Stream stream)
        {
            OrderSingleton o = null;
            StreamReader file = StreamReader.Null;
            try
            {
                var serializer = new XmlSerializer(typeof(OrderSingleton));
                file = new StreamReader(stream);
                o = (OrderSingleton)serializer.Deserialize(file);
            }
            finally
            {
                file.Close();
                stream.Close();
            }
            return o;
        }

    }
}
