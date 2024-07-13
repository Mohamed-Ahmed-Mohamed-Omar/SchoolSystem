using Microsoft.AspNetCore.Http;

namespace SchoolSystem.Services.Abstracts
{
    public interface IFileService
    {
        public Task<string> UploadImage(string Location, IFormFile file);
    }
}
