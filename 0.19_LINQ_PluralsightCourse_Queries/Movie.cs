﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19_LINQ_PluralsightCourse_Queries
{
    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

    }
}
