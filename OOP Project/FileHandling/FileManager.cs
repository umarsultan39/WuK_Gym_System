using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace OOP_Project
{
    class FileManager
    {
        
        public void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        public T ReadFromJsonFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                var fileContents = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(fileContents);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public List<T> ReadAll<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var members = JsonConvert.DeserializeObject<List<T>>(json);
            return members;
        }

        public int ReadAllCount<T>(string filePath)
        {
            try
            {
                var json = File.ReadAllText(filePath);
                var members = JsonConvert.DeserializeObject<List<T>>(json);
                return members.Count;
            }
            catch (IOException e)
            {
                return 0;
            }
        }

        public Member GetMember(int id, string filePath)
        {
            var json = File.ReadAllText(filePath);
            var members = JsonConvert.DeserializeObject<List<Member>>(json);
            var result = new Member();

            foreach (var m in members)
            {
                if (m.ID == id)
                {
                    result = m;
                    break;
                }
            }
            return result;
        }
    }
}
