using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetC__CRUD.Models
{

    [Table("viatic")]
    public class Viatic
    {
        [Key]

        public Int32 idViatic
        {
            get; set;
        }
        public string place
        {
            get; set;
        }
        public string description1
        {
            get; set;
        }
        public decimal amount
        {
            get; set;
        }
        public Int32 idEmployee
        {
            get; set;
        }

        public bool status
        {
            get; set;
        }
    }
}