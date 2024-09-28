using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models.Account;
using ProductAPI.Models.Contact;
using ProductAPI.Models;

using ProductAPI.Data;

namespace ProductAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class Trial_BAT : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public Trial_BAT(ApplicationDbContext context) {

            _context = context;

        }

        [HttpPost]
        public async Task<IActionResult> SendData(AccountModel accountModel) {
            try
            {
                await _context.AccountData.AddAsync(accountModel);
                await _context.SaveChangesAsync();
                return Ok();

            }
            catch {
                throw new Exception() {

                };
            }
        }

        [HttpPost("SendData2")]
        public async Task<IActionResult> SendData2(ContactModel contactModel)
        {
            try
            {
                await _context.ContactData.AddAsync(contactModel);
                await _context.SaveChangesAsync();
                return Ok();

            }
            catch
            {
                throw new Exception()
                {

                };
            }
        }
        
    }   
}
