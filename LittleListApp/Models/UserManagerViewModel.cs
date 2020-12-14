using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LittleListApp.Models;

namespace LittleListApp.Models
{
    public class UserManagerViewModel
    {
       public ApplicationUser[] Administrators { get; set; }
       public ApplicationUser[] Everyone { get; set; }
    }
}
