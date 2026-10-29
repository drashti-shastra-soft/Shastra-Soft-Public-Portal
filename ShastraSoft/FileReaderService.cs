using Microsoft.Extensions.Hosting.Internal;

namespace ShastraSoft
{
    public class FileReaderService : IFileReaderService
    {
        private readonly IWebHostEnvironment _env;

        public FileReaderService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public string ReadFileContent(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));

            string physicalPath = _env.ContentRootPath + filePath;

            if (!File.Exists(physicalPath))
                throw new FileNotFoundException($"File not found at path: {filePath}");

            return File.ReadAllText(physicalPath);
        }
    }
}
