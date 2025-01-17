﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Robson_Totvs_Test.Domain.Entities
{
    public class Account : IdentityUser
    {
        public Account()
        {
            this.Profiles = new List<ProfileObject>();
        }

        public Account(string name, string email, List<ProfileObject> profiles)
            : this()
        {
            this.Name = name;
            this.Profiles = profiles;
            this.Created = DateTime.Now;
            this.UserName = this.Email = email;
        }

        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? LastLogin { get; set; }
        public List<ProfileObject> Profiles { get; set; }
    }
}
