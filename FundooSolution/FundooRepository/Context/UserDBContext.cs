﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Common.UserModel;

namespace FundooRepository.Context
{
   public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
