using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EduWiki.Services.Abstractions
{
    public interface IFileService
    {
        Task<string> UploadAsync(IFormFile file);
    }
}