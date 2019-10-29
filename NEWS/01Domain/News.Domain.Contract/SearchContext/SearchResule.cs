﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Contract.SearchContext
{
    public class SearchResule<T> where T:new()
    {
        public SearchResule()
        {
            Result = new List<T>();
        }

        public List<T> Result { get; set; }
        public int TotalCount { get; set; }
        public bool hasvalue => Result.Any();


    }
}
