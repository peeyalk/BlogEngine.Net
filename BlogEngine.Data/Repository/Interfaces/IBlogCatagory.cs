﻿using BlogEngine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repository.Interfaces
{
    public interface IBlogCatagoryRepository : IRepository<BlogCatagory>
    {
        BlogCatagory GetBuyUrl(string url);
    }
}
