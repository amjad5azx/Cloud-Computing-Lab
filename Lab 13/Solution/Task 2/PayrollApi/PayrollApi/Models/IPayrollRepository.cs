using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PayrollApi.Models
{
    interface IPayrollRepository
    {
        Task Add(Payroll payroll);  
        Task Update(Payroll payroll);  
        Task Delete(string id);  
        Task<Payroll> GetPayroll(string id);  
        Task<IEnumerable<Payroll>> GetPayrolls();  
    }
}