namespace FundooRepository.InterfaceRepo
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface INotesRepository
    {
        string CloudImage(IFormFile file)
    }
}
