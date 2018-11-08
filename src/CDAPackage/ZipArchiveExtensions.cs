using System.IO.Compression;

namespace CDAPackage
{
    static class ZipArchiveExtensions
    {
        public static void AddEntry(this ZipArchive zipArchive, string path, byte[] data)
        {
            var entry = zipArchive.CreateEntry(path);
            using (var s = entry.Open())
                s.Write(data, 0, data.Length);
        }
    }
}
