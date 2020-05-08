﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject_p1.Models;

namespace TeamProject_p1.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        { }
        public DbSet<DailyTask> Tasks { get; set; }
        public DbSet<Calender> TaskDates { get; set; }
    }
}