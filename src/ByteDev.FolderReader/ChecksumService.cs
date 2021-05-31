using System.Collections.Generic;
using ByteDev.Crypto;
using ByteDev.Crypto.Hashing;
using ByteDev.Crypto.Hashing.Algorithms;

namespace ByteDev.FolderReader
{
    public static class ChecksumService
    {
        private static readonly IFileChecksumService Md5ChecksumService = new FileChecksumService(new Md5Algorithm(), EncodingType.Hex);

        public static string GetMd5(string filePath)
        {
            return Md5ChecksumService.Calculate(filePath);
        }

        public static IList<string> GetMd5Matches(string dirPath, string expectedChecksum)
        {
            return Md5ChecksumService.Matches(dirPath, expectedChecksum);
        }
    }
}