using Newtonsoft.Json;
using System.IO;

namespace WebAutomationSeleniumTests.SeleniumEasy.Common
{
    sealed class XpathReader : IXpathReader
    {
        private string FilePath { get; set; }
        public XpathReader(string filePath) => FilePath = filePath;
        public T GetValue<T>()
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(FilePath));
        }
    }
}