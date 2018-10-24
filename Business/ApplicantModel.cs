using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Business
{
    [Table("Bank.dbo.Applicant")]
    public class ApplicantModel

    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get => FirstName + LastName; }

        public string NationalityName { get; set; }

        public string GenderName { get; set; }

        public int PhoneNumber { get; set; }

        public int Adhar { get; set; }

        public int PinCode { get; set; }
        public string Village { get; set; }
        public string Mandal { get; set; }
        public string District { get; set; }
        public string State { get; set; }
    }
}
