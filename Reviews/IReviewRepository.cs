﻿using Reviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews
{
    public interface IReviewRepository
    {
        List<Review> GetAll();
        Review FindById(int id);
    }
}
