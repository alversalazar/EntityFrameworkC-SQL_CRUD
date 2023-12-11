using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetC__CRUD.Models
{
    [Table("employee")]

    public class Employee
    {


        [Key]

        public Int32 idEmployee
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public string lastname
        {
            get; set;
        }
        public string mothersLastName
        {
            get; set;
        }
        public string gender
        {
            get; set;
        }
        public string phone
        {
            get; set;
        }
        public string email
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public string socialSecurity
        {
            get; set;
        }
        public DateTime dateOfHire
        {
            get; set;
        }
        public Int32 idSubject
        {
            get; set;
        }
        public bool status
        {
            get; set;
        }
    }
}