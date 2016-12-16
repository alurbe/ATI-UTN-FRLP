using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibliotecaWeb.Models
{
    public class EmpModel
    {
        [Display(Name="Birth name")]
        [DataType(DataType.Date)]

        public DateTime? DOB { get; set; }
    }
}