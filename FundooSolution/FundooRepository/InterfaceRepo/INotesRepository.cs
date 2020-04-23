﻿namespace FundooRepository.InterfaceRepo
{
    using Common.ModelsOfNotes;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface INotesRepository
    {
        string CloudImage(IFormFile file);
        bool AddNote(string email, NewNote notemodel, IFormFile file);
    }
}
