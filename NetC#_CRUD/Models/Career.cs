using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NetC__CRUD.Models
{
    [Table("career")]
    public class Career
    {
        [Key]

        public Int32 idCareer
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public string duration
        {
            get; set;
        }
        public string description
        {
            get; set;
        }
        public bool status
        {
            get; set;
        }
    }
}