using PayrollApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PayrollApi.Controllers
{
    public class PayrollApiController : ApiController
    {
        private readonly IPayrollRepository _iPayrollRepository = new PayrollRepository();

        [HttpGet]
        [Route("api/Payroll/Get")]
        public async Task<IEnumerable<Payroll>> Get()
        {
            return await _iPayrollRepository.GetPayrolls();
        }

        [HttpPost]
        [Route("api/Payroll/Create")]
        public async Task CreateAsync([FromBody]Payroll employee)
        {
            if (ModelState.IsValid)
            {
                await _iPayrollRepository.Add(employee);
            }
        }

        [HttpGet]
        [Route("api/Payroll/Details/{id}")]
        public async Task<Payroll> Details(string id)
        {
            var result = await _iPayrollRepository.GetPayroll(id);
            return result;
        }

        [HttpPut]
        [Route("api/Payroll/Edit")]
        public async Task EditAsync([FromBody]Payroll employee)
        {
            if (ModelState.IsValid)
            {
                await _iPayrollRepository.Update(employee);
            }
        }

        [HttpDelete]
        [Route("api/Payroll/Delete/{id}")]
        public async Task DeleteConfirmedAsync(string id)
        {
            await _iPayrollRepository.Delete(id);
        }

    }

}
