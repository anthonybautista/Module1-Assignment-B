using System;
using System.IO;

namespace Module1_Assignment_B
{
    public class FileOutput
    {
        private StreamWriter _streamWriter = null;

        private string _fileName;

        public FileOutput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _streamWriter = new StreamWriter(Path.Combine(Environment.CurrentDirectory, fileName));
            }
            catch(Exception e)
            {
                Console.WriteLine("FileOutput Open Error: " + e.Message);
            }
        }

        public void FileWrite(string line)
        {
            try
            {
                _streamWriter.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception FileWrite: " + _fileName + e.Message);
            }
        }
        
        public void FileClose()
        {
            if (_streamWriter != null)
            {
                try
                {
                    _streamWriter.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception FileOutput Close: " + _fileName + e.Message);
                }
            }
        }
    }
}