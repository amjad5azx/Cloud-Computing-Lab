using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PayrollApi.Models
{
    public class PayrollRepository : IPayrollRepository
    {
        private readonly SqlDbContext db = new SqlDbContext();
        public async Task Add(Payroll payroll)
        {
            payroll.Id = Guid.NewGuid().ToString();

            db.Payroll.Add(payroll);
            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

        }

        public async Task Delete(string id)
        {
            try
            {
                Payroll payroll = await db.Payroll.FindAsync(id);
                db.Payroll.Remove(payroll);
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }

        }

        public async Task<Payroll> GetPayroll(string id)
        {
            try
            {
                Payroll payroll = await db.Payroll.FindAsync(id);
                if (payroll == null)
                {
                    return null;
                }
                return payroll;
            }
            catch
            {
                throw;
            }

        }

        public async Task<IEnumerable<Payroll>> GetPayrolls()
        {
            try
            {
                var employees = await db.Payroll.ToListAsync();
                return employees.AsQueryable();
            }
            catch
            {
                throw;
            }
        }

        public async Task Update(Payroll payroll)
        {
            try
            {
                db.Entry(payroll).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }
        private bool EmployeeExists(string id)
        {
            return db.Payroll.Count(e => e.Id == id) > 0;
        }
    }
}