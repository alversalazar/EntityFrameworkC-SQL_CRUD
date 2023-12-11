using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetC__CRUD.Models
{
    [Table("studyplan")]
    public class StudyPlan
    {
        [Key]

        public Int32 idStudyPlan
        {
            get; set;
        }
        public string objetive
        {
            get; set;
        }
        public DateTime starDate
        {
            get; set;
        }
        public DateTime finalDate
        {
            get; set;
        }
        public string key1
        {
            get; set;
        }


        public bool status
        {
            get; set;
        }
        public Int32 idCareer
        {
            get; set;
        }
    }
}