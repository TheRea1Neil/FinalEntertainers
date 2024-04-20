using SQLitePCL;

namespace FinalEntertainers.Models
{
    public class EFEntertainmentAgancyRepository : IEntertainmentAgnecyRepository
    
    {
        private EntertainmentAgencyExampleContext _context;

        public EFEntertainmentAgancyRepository(EntertainmentAgencyExampleContext context)
        {
            _context = context;
        }
    }
}
