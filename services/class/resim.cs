using Microsoft.AspNetCore.Http;
using System.IO;

namespace Services.@class
{
    public static class Resim
    {
        public static string UploadImage(IFormFile file)
        {
            var localImageDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Resimler");
            var localImagePath = Path.Combine(localImageDir, file.FileName);

            if (!Directory.Exists(localImageDir))
            {
                Directory.CreateDirectory(localImageDir);
            }

            using (var fileStream = new FileStream(localImagePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            string modelsImagePath = Path.GetFileName(file.FileName);
            return modelsImagePath;
        }
       

    }
}
