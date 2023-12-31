﻿using CRUDAPI.Data;
using CRUDAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Services
{
    public class EmployeeService
    {
        private readonly Context _context;

        public EmployeeService(Context context)
        {
            _context = context;
        }

        public bool CreateEmployeer(Employee employee)
        {

            if (CPFExists(employee.Person.CPF))
            {
                throw new InvalidOperationException("CPF já cadastrado.");
                

            }
            else if (RGExists(employee.Person.RG))
            {
                throw new InvalidOperationException("RG já cadastrado.");
            }

            if (employee.Id == 0)
            {
                _context.Employees.Add(employee);
            }
             
             
            _context.SaveChanges();

            return true;

        }

        public bool CPFExists(string cpf)
        {
            return _context.Persons.Any(p => p.CPF == cpf);
        }
        public bool RGExists(string rg)
        {
            return _context.Persons.Any(p => p.RG == rg);
        }
    }
}
