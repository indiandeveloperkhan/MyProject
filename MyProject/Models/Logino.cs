using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace MyProject.Models
{
    
    public class Logino
    {

        
        public string UserName { get; set; }

        
        public string Password { get; set; }


    }
}
