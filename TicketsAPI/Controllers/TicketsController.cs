using Microsoft.AspNetCore.Mvc;
using TicketsAPI.Models;

namespace TicketsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTickets()
        {
            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    ShortDescription = "Login Issue",
                    Description = "User unable to login",
                    CreatedDate = DateTime.Now.AddDays(-2),
                    Severity = "High",
                    TargetDate = DateTime.Now.AddDays(3),
                    Status = "Open"
                },
                new Ticket
                {
                    Id = 2,
                    ShortDescription = "UI Bug",
                    Description = "Alignment issue on dashboard",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    Severity = "Medium",
                    TargetDate = DateTime.Now.AddDays(5),
                    Status = "In Progress"
                }
            };

            // Async best practice
            return await Task.FromResult(Ok(tickets));
        }
    }
}
