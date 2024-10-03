using Newtonsoft.Json;
using System;
using System.IO;



namespace BettingRecordApp
{
    public static class UtilityCommon
    {
        public static bool FileExists(string _path)
        {
            return (File.Exists(_path));
        }



        public static FILE_TYPE GetFileTypeFromPath(string _path)
        {
            FILE_TYPE fileType = FILE_TYPE.UNKNOWN;

            switch (Path.GetExtension(_path))
            {
                case ".xml": fileType = FILE_TYPE.XML; break;
                case ".json": fileType = FILE_TYPE.JSON; break;
                default: break;
            }

            return fileType;
        }



        public static T ParseEnum<T>(string _value)
        {
            return ((T)Enum.Parse(typeof(T), _value, true));
        }



        public static T CopyObject<T>(T _value)
        {
            string json = JsonConvert.SerializeObject(_value);
            return (JsonConvert.DeserializeObject<T>(json));
        }



        public static bool StringToBool(string _value)
        {
            return (
                _value.ToUpper() == "YES" ||
                _value.ToUpper() == "TRUE" ||
                _value == "1"
            );
        }



        public static string BoolToString(bool _value)
        {
            return ((_value) ? "TRUE" : "FALSE");
        }
    }
}
