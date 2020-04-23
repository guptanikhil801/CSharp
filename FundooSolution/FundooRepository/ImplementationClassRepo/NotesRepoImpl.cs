namespace FundooRepository.ImplementationClassRepo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using InterfaceRepo;
    using Microsoft.AspNetCore.Http;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;

    public class NotesRepoImpl : INotesRepository
    {
        public string CloudImage(IFormFile file)
        {
            if(file == null)
            {
                return null;
            }
            var filepath = file.OpenReadStream();
            string uniquename = Guid.NewGuid().ToString() + "_" + file.FileName;
            Account account = new Account("nikhilcloud007", "857761978269428", "Dp0h4mHl84o2zDL8HwINokEe6hM");
            Cloudinary cloud = new Cloudinary(account);
            var uploadparam = new ImageUploadParams()
            {
                File = new FileDescription(uniquename, filepath)
            };
            var uploadresult = cloud.Upload(uploadparam);
            return uploadresult.Uri.ToString();
        }
    }
}
