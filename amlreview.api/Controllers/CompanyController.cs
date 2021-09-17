using amlreview.application;
using amlreview.dataaccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amlreview.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {        
        private ICompanyRepository _companyRepository;
        private IScheduleRepository _scheduleRepository;

        public CompanyController(ICompanyRepository companyRepository, IScheduleRepository scheduleRepository)
        {
            _companyRepository = companyRepository;
            _scheduleRepository = scheduleRepository;
        }

        [HttpGet]
        [Route("GetCompanySchedule/{companyid}/{market}/{companytype}")]
        public async Task<IActionResult> GetCompanySchedule(string companyid ,string market, int companytype)
        {
            try
            {
                Company company = await _companyRepository.GetById(Guid.Parse(companyid));

                IScheduleService scheduleService = ServiceResolver.GetNamedSceduleServiceByMarket(market);

                var scheduleDto = scheduleService.CreateNotification(company);

                await _scheduleRepository.SaveRange(scheduleDto);

                return Ok(scheduleDto);
            }
            catch (Exception)
            {                 
                return BadRequest();
            }
        }
    }
}
