using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NetC__CRUD.Models
{
    public class Vinculation : DbContext
    {
        public DbSet<Career> career
        {
            get; set;
        }
        public DbSet<Employee> employee
        {
            get; set;
        }
        public DbSet<StudyPlan> studyplan
        {
            get; set;
        }
        public DbSet<Subject> subject
        {
            get; set;
        }
        public DbSet<Viatic> viatic
        {
            get; set;
        }
    }
}