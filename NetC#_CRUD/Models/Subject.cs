using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetC__CRUD.Models
{
    [Table("Subject")]
    public class Subject
    {

        [Key]

        public Int32 idSubject
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public string credit
        {
            get; set;
        }
        public string unit
        {
            get; set;
        }
        public string characteristic
        {
            get; set;
        }
        public string keyMatter
        {
            get; set;
        }
        public bool status
        {
            get; set;
        }
    }
}