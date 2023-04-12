using System;
using System.IO;

namespace Module1_Assignment_B
{
    public class FileInput
    {
        private readonly StreamReader _streamReader = null;
        private string _fileName;

        public FileInput(string fileName)
        {
            _fileName = fileName;
            try
            {
                _streamReader = new StreamReader(Path.Combine(Environment.CurrentDirectory, _fileName));
            }
            catch(Exception e)
            {
                Console.WriteLine("FileInput Open Error: " + _fileName + " " + e.Message);
            }
        }

        public void FileRead()
        {
            string line;
            try
            {
                line = _streamReader.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = _streamReader.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception FileRead: " + _fileName + e.Message);
            }
        }

        public string FileReadLine()
        {
            try
            {
                return _streamReader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception FileReadLine: " + _fileName + e.Message);
                return null;
            }
        }

        public void FileClose()
        {
            if (_streamReader != null)
            {
                try
                {
                    _streamReader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception FileInput Close: " + _fileName + e.Message);
                }
            }
        }
    }
}