﻿using System;

namespace Magma.DomainModels
{
    public class UserLog
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public DateTime? User_LoginTime { get; set; }
        public DateTime? User_LogoutTime { get; set; }
        public string User_LoginFrom { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}