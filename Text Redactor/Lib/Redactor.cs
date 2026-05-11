using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace Text_Redactor.Lib
{
    internal class Redactor
    {
        private RedactorParameters _Parameters;
        public Redactor(RedactorParameters redactorParameters)
        {
            _Parameters = redactorParameters;
        }

        public void Redact() 
        {
            using (var writer = new StreamWriter(_Parameters.OutputFile, !_Parameters.OverwriteFile))
            {
                List<string> existingFiles = _Parameters.InputFiles.Where(File.Exists).ToList();

                for (int i = 0; i < existingFiles.Count; i++)
                {
                    if (!_Parameters.OverwriteFile)
                    {
                        writer.WriteLine();
                    }

                    using (var reader = new StreamReader(existingFiles[i]))
                    {
                        ReadFile(writer, reader);
                    }

                    if (i < existingFiles.Count - 1)
                    {
                        writer.WriteLine();
                    }
                }
            }
        }

        private void ReadFile(StreamWriter writer, StreamReader reader)
        {
            StringBuilder currentWord = new StringBuilder();
            char letter;
            int code;

            while ((code = reader.Read()) != -1)
            {
                letter = (char)code;

                if (char.IsWhiteSpace(letter) || char.IsPunctuation(letter))
                {
                    WriteSigns(writer, currentWord, letter);
                    currentWord.Clear();
                }
                else
                {
                    currentWord.Append(letter);
                }
            }
            WriteSigns(writer, currentWord, new char());
        }

        private void WriteSigns(StreamWriter writer, StringBuilder currentWord, char letter)
        {
            if (!_Parameters.RemoveShortWords || currentWord.Length >= _Parameters.WordMinLength)
            {
                writer.Write(currentWord);
            }

            if (char.IsWhiteSpace(letter) || (char.IsPunctuation(letter) && !_Parameters.RemovePunctuation))
            {
                writer.Write(letter);
            }
        }
    }

    public class RedactorParameters
    {
        public string OutputFile { get; set; }
        public List<string> InputFiles { get; set; }
        public bool RemoveShortWords { get; set; }
        public bool RemovePunctuation { get; set; }
        public bool OverwriteFile { get; set; }
        public int WordMinLength { get; set; }

        
    }
}
