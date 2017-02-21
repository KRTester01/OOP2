namespace OBJECTANALYZE
{
    internal class fileReader
    {
        public fileReader();
        public string ReadInTheFile();        
        string code = System.IO.File.ReadAllText(c: FileName);
    }
}