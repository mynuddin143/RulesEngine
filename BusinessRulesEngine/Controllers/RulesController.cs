using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessRulesEngine.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BusinessRulesEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private readonly ILogger<RulesController> _logger;
        private readonly IRulesRepository _iRulesRepository;
        public RulesController(ILogger<RulesController> logger, IRulesRepository iRulesRepository)
        {
            _logger = logger;
            _iRulesRepository = iRulesRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {

            string type = PaymentEnum.PaymentTypes.PhysicalProduct;
            return Ok(_iRulesRepository.GetRules(type));
        }
    }
}