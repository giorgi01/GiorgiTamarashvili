using EduWiki.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace EduWiki.Services.Implementations
{
    public class ImageService : IFileService
    {
        public async Task<string> UploadAsync(IFormFile image)
        {
            {
                string FileName = Path.GetFileNameWithoutExtension(image.FileName);
                string FileExtension = Path.GetExtension(image.FileName);
                FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;
                var imagePath = "/UserData/Images/" + FileName;
                using Stream fileStream = new FileStream("wwwroot/" + imagePath, FileMode.Create);
                await image.CopyToAsync(fileStream);
                return imagePath;
            }
        }
    }
}
