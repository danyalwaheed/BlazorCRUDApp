using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDApp.Data
{
    public class EmployeeService
    {
        private readonly EmployeeDBContext _employeeDbContext;

        public EmployeeService(EmployeeDBContext applicationDbContext)
        {
            _employeeDbContext = applicationDbContext;
        }
        public async Task<List<TblEmployee>> GetAllEmployees()
        {
            return await _employeeDbContext.TblEmployees.ToListAsync();
        }
        public async Task<bool> InsertEmployee(TblEmployee employee)
        {
            await _employeeDbContext.TblEmployees.AddAsync(employee);
            await _employeeDbContext.SaveChangesAsync();
            return true;
        }
        public async Task<TblEmployee> GetEmployeeById(int id)
        {
            TblEmployee employee = await _employeeDbContext.TblEmployees.FirstOrDefaultAsync(c => c.EmployeeId.Equals(id)); ;
            return employee;
        }

        //Update Employee
        public async Task<bool> UpdateEmployee(TblEmployee employee)
        {
            _employeeDbContext.TblEmployees.Update(employee);
            await _employeeDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Employee
        public async Task<bool> DeleteEmployee(TblEmployee employee)
        {
            _employeeDbContext.TblEmployees.Remove(employee);
            await _employeeDbContext.SaveChangesAsync();
            return true;
        }

    }
}
