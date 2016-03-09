using og.samples.aspnet.Demo.Models;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompanyController.cs" company="ozkary.com">
//   Copyright (c) under http://opensource.org/licenses/MIT
// </copyright>
// <summary>
//  contact api controller with AntiForgery support (CSRF)
// </summary>
// <remarks>
//  http://ozkary.com
// </remarks>
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace og.samples.aspnet.Demo.Controllers.Api
{
    /// <summary>
    /// contact api controller
    /// </summary>
    [RoutePrefix("api/contact")]
    [helper.ValidateHttpAntiForgeryToken]
    public class ContactApiController : ApiController
    {
        // POST: api/Contact        
        [HttpPost]
        [ResponseType(typeof(Contact))]
        [Route("send")]
        public async Task<IHttpActionResult> send(Contact contact)
        {
            IHttpActionResult result = null;

            if (!ModelState.IsValid)
            {
                result = BadRequest(ModelState);
            }
            else
            {
                //simulate delay for proceesing information
                await Task.Delay(1500);
                contact.Created = DateTime.Now;
                //TODO process contact information
                result = Ok(contact);                
            }

            return result;
        }
           
        /// <summary>
        /// gets a token for the contact operation
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("token")]
        public IHttpActionResult token()
        {
            IHttpActionResult result = null;
            result = Ok("test");

            return result;
        }
    }
}
