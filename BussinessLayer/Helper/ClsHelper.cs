using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Helper
{
    public static class ImageHelper
    {
        /// <summary>
        /// يحفظ الصورة ويرجع المسار النسبي
        /// </summary>
        /// <param name="imageFile">ملف الصورة من IFormFile</param>
        /// <param name="folderName">المجلد داخل wwwroot</param>
        /// <returns>المسار النسبي للصورة (مثال: /images/customers/xxx.jpg)</returns>
        public static async Task<string?> SaveImageAsync(IFormFile imageFile, string folderName = "images/customers")
        {
            if (imageFile == null || imageFile.Length == 0)
                return null;

            // تحقق من نوع الملف
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
            var ext = Path.GetExtension(imageFile.FileName).ToLowerInvariant();

            if (!allowedExtensions.Contains(ext))
                throw new InvalidOperationException("Invalid image type");

            if (imageFile.Length > 5 * 1024 * 1024) // حد 5 ميغا
                throw new InvalidOperationException("File too large");

            // إنشاء اسم فريد
            var fileName = Guid.NewGuid().ToString() + ext;

            // استخدم Path.Combine مع CurrentDirectory لكن تحقق من وجود wwwroot
            var root = Path.Combine(AppContext.BaseDirectory, "..", "..", ".."); // مسار المشروع
            var folder = Path.Combine(root, "wwwroot", folderName);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var path = Path.Combine(folder, fileName);

            try
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving image: " + ex.Message);
                throw;
            }

            return "/" + folderName + "/" + fileName;
        }
    }
}
