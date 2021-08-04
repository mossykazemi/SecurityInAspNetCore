using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.DataProtection;

namespace SecurityInAspNet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [DisableCors]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IDataProtector _protector;

        public ValuesController(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("SecurityInAspNet.WebApi.Controllers.ValuesController",
                new string[]{"Tenant1"});
        }



        [HttpGet]
        [Route("UserIds")]
        public IEnumerable<string> GetUserIds()
        {
            var sec1 = _protector.Protect("Mostafa Kazemi");
            var sec2 = _protector.Protect("Ali Rezaei");

            return new string[] {sec1, sec2};
        }


        [HttpGet]
        [Route("PlainTextId")]
        public string GetPlainTextId(string encryptedId)
        {

            return _protector.Unprotect(encryptedId);
        }
    }
}
