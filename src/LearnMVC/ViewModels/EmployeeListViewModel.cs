using LearnMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnMVC.ViewModels
{
    public class EmployeeListViewModel
    {
      public List<EmployeeViewModel> Employee { get; set; }
      public string UserName { get; set; }
    }
}
