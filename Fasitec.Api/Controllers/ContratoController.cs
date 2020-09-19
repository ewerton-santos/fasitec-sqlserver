using System.Collections.Generic;
using System.Threading.Tasks;
using Fasitec.Business.ApplicationServices;
using Fasitec.Business.Dto;
using Fasitec.Business.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fasitec.Api.Controllers
{
    [ApiController]
    [Route("v1/contratos")]
    public class ContratoController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<ContratoOutput>>> Get([FromServices] IContratoFacade contratoService)
        {
            return await contratoService.All().ToListAsync();
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<ContratoOutput> Get([FromServices] IContratoFacade contratoService, int id)
        {
            return contratoService.ById(id);
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ContratoOutput>Post([FromServices] IContratoFacade contratoService, [FromBody]ContratoInput contratoInput)
        {
            return contratoService.Create(contratoInput);
        }

        [HttpPut]
        [Route("")]
        public ActionResult<ContratoOutput>Put([FromServices] IContratoFacade contratoService, [FromBody]ContratoInput contratoInput)
        {
            return contratoService.Modify(contratoInput);
        }
        
        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult<ContratoOutput>Delete([FromServices] IContratoFacade contratoService, int id)
        {       
            contratoService.Remove(id);
            return Ok();
        }
    }
}