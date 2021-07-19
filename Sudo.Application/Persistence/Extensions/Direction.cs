using System.IO;

namespace Sudo.Application.Persistence.Extensions
{
    public static class Direction
    {
        public static string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public static void ValidateStorage(string storage = "wwwroot\\database\\_deleteMe.txt")
        {
            var storageLocation = Path.Combine(GetCurrentDirectory(), storage);
            if (!File.Exists(storageLocation))
            {
                File.Create(storageLocation);
            }
        }
    }
}
