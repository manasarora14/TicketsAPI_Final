using Microsoft.AspNetCore.Mvc;
using TicketsAPI.Models;

namespace TicketsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTickets()
        {
            var tickets = new List<Ticket>
            {
                new Ticket{
                    Id = 1,
                    ShortDescription = "Login Issue",
                    Description = "User unable to login",
                    CreatedDate = new DateTime(2025, 01, 05),
                    Severity = "High",
                    TargetDate = new DateTime(2025, 01, 15),
                    Status = "Open"
                },
                new Ticket{
                    Id = 2,
                    ShortDescription = "Payment Error",
                    Description = "Error while processing payment",
                    CreatedDate = new DateTime(2025, 01, 03),
                    Severity = "Medium",
                    TargetDate = new DateTime(2025, 01, 20),
                    Status = "In Progress"
                }
            };

            return Ok(tickets);
        }
    }
}
