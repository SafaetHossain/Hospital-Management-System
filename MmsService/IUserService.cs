﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmsEntity;

namespace MmsService
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetByContact(string contact);
        int Insert(User user);
        int UpdatePassword(User user);
        int Delete(int id);
    }
}