using Microsoft.EntityFrameworkCore;
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

        public Entertainer GetEntertainerById(int entertainerId)
        {
            return _context.Entertainers.FirstOrDefault(e => e.EntertainerId == entertainerId);
        }

        public void UpdateEntertainer(Entertainer entertainer)
        {
            _context.Update(entertainer);  // Simplified update using DbContext.Update()
        }

        public void DeleteEntertainer(Entertainer entertainer)
        {
            _context.Entertainers.Remove(entertainer);
        }
    }
}
