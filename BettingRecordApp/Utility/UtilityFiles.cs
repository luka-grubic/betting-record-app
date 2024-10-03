using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;



namespace BettingRecordApp
{
    public static class UtilityFiles
    {
        public static BettingRecord DeserializeBettingRecord(FILE_TYPE _fileType, string _path)
        {
            return ((_fileType == FILE_TYPE.XML) ?
                DeserializeBettingRecordXML(_path) :
                DeserializeBettingRecordJSON(_path)
            );
        }

        public static BettingRecord DeserializeBettingRecordXML(string _path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BettingRecordXML)); ;

            BettingRecordXML bettingRecordXML = new BettingRecordXML();

            try
            {
                using (StreamReader reader = new StreamReader(_path))
                {
                    bettingRecordXML = (BettingRecordXML)serializer.Deserialize(reader);
                }

                return (new BettingRecord(bettingRecordXML));
            }
            catch
            {
                return null;
            }
        }



        public static BettingRecord DeserializeBettingRecordJSON(string _path)
        {
            try
            {
                string jsonString = File.ReadAllText(_path);
                return (JsonConvert.DeserializeObject<BettingRecord>(jsonString));
            }
            catch
            {
                return null;
            }
        }



        public static bool SerializeBettingRecord(FILE_TYPE _fileType, string _path, BettingRecord _bettingRecord)
        {
            return ((_fileType == FILE_TYPE.XML) ?
                SerializeBettingRecordXML(_path, _bettingRecord) :
                SerializeBettingRecordJSON(_path, _bettingRecord)
            );
        }



        public static bool SerializeBettingRecordXML(string _path, BettingRecord _bettingRecord)
        {
            bool status = (_bettingRecord != null && _path != "");

            if (status)
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(BettingRecordXML));

                    using (StreamWriter writer = new StreamWriter(_path))
                    {
                        serializer.Serialize(writer, new BettingRecordXML(_bettingRecord));
                    }
                }
                catch
                {
                    status = false;
                }
            }

            return status;
        }



        public static bool SerializeBettingRecordJSON(string _path, BettingRecord _bettingRecord)
        {
            bool status = (_bettingRecord != null && _path != "");

            if (status)
            {
                try
                {
                    string jsonString = JsonConvert.SerializeObject(_bettingRecord, Formatting.Indented);
                    File.WriteAllText(_path, jsonString);
                }
                catch
                {
                    status = false;
                }
            }

            return status;
        }
    }
}
