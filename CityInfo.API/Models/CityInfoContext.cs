﻿using CityInfo.API.Enitities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Models
{
    public class CityInfoContext:DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterests { get; set; }
        
    }
}