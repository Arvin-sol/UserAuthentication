
using Microsoft.AspNetCore.Http;

namespace UserAuthentication.Application.Common;
public static class UploadImageExtention
{
    public static bool AddImageToServer(this IFormFile image , string ImageName, string orginalPath)
    {
        if(image != null)
        {
            if (!Directory.Exists(orginalPath))
                Directory.CreateDirectory(orginalPath);

            string OriginPath = orginalPath + ImageName;

            using (var stream = new FileStream(OriginPath, FileMode.Create))
            {
                if (!Directory.Exists(OriginPath)) image.CopyTo(stream);
            }
            return true;
        }
        return false;
    }
}
