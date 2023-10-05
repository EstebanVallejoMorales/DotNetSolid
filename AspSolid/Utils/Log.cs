namespace AspSolid.Utils
{
    public class Log
    {
        private string _fileName = "log.txt";

        public async void Save(string content)
        {
            await File.WriteAllTextAsync(_fileName, content);
        }
    }
}
