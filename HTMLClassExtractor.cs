using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace CssScraper
{
    internal class HTMLClassExtractor
    {
        private string inputFile;
        private string outputFile;

        public HTMLClassExtractor()
        {
            this.inputFile = this.outputFile = "";
        }

        public HTMLClassExtractor(string inputFile, string outputFile)
        {
            this.inputFile = inputFile;
            this.outputFile = outputFile;
        }

        public string getInputFile()
        {
            return this.inputFile;
        }

        public string getOutputFile()
        {
            return this.outputFile;
        }

        public void setInputFile(string inputFile)
        {
            this.inputFile = inputFile;
        }

        public void setOutputFile(string outputFile)
        {
            this.outputFile = outputFile;
        }


        public List<string> ExtractClasses()
        {
            List<string> classNames = new List<string>();
            StreamReader reader = new StreamReader(inputFile);
            
            try
            {
                string htmlContent = reader.ReadToEnd();

                reader.Close();

                string pattern = @"class\s*=\s*""([^""]*)""";

                MatchCollection matches = Regex.Matches(htmlContent, pattern);

                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    if (groups.Count > 1)
                    {
                        string classValue = groups[1].Value;
                        string[] classes = classValue.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string className in classes)
                        {
                            classNames.Add(className);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error occur : {e.Message}");
            }

            return classNames;
        }
    }
}