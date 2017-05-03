using LearningDDD.Aplication.Interface;
using LearningDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearningDDD.Apresentation.WebAPI.Controllers
{
    [RoutePrefix("Api/v1/Funcionario")]
    public class FuncionarioController : ApiController
    {
        private readonly IAplicationFuncionario _funcionario;
        public FuncionarioController(IAplicationFuncionario funcionario)
        {
            _funcionario = funcionario;
        }

        [HttpGet]
        [Route("Funcionario")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var result = _funcionario.GetAll();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("Funcionario/{id}")]
        public IHttpActionResult GetById([FromUri]int id)
        {
            try
            {
                var result = _funcionario.GetById(id);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("Funcionario")]
        public IHttpActionResult Inserir([FromBody]Funcionario obj)
        {
            try
            {
                var result = _funcionario.Insert(obj);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("Funcionario")]
        public IHttpActionResult Update([FromBody]Funcionario obj)
        {
            try
            {
                var result = _funcionario.Update(obj);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("Funcionario/{id}")]
        public IHttpActionResult Delete([FromUri]int id)
        {
            try
            {
                var result = _funcionario.GetById(id);
                _funcionario.Delete(result);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
