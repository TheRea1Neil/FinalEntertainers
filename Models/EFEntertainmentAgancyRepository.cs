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

       public IQueryable<Entertainer> Entertainers => _context.Entertainers;

        public void AddEntertainer(Entertainer entertainer)
        {
            _context.Entertainers.Add(entertainer);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
