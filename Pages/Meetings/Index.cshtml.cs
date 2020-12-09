using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamSacramentMeetingPlanner.Data;
using TeamSacramentMeetingPlanner.Models;

namespace TeamSacramentMeetingPlanner.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext _context;

        public IndexModel(TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; }

        public async Task OnGetAsync()
        {
            Meeting = await _context.Meeting.ToListAsync();
        }
    }
}
