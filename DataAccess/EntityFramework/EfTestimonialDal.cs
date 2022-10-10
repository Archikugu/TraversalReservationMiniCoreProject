﻿using DataAccess.Abstract;
using DataAccess.Repository;
using Entity.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
    }
}
