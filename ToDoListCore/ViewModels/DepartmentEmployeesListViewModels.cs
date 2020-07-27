﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDoListCore.Models;

namespace ToDoListCore.ViewModels
{
    public class DepartmentEmployeesListViewModels
    {
        //Department
        [Required]
        public int DepartmentID { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwę działu.")]
        public string Name { get; set; }
        public string Description { get; set; }

        // Lista pracowników przypisanych do działu firmy
        public List<Employee> EmployeesList { get; set; }
    }
}
