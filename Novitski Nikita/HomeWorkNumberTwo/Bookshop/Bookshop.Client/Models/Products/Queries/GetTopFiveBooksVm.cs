﻿using Bookshop.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookshop.Client.Models.Products.Queries
{
    public class GetTopFiveBooksVm
    {
        public List<Book> Books { get; set; }
    }
}