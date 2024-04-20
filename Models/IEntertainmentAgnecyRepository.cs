namespace FinalEntertainers.Models
{
    public interface IEntertainmentAgnecyRepository
    {
       IQueryable<Entertainer> Entertainers { get; }

        void AddEntertainer(Entertainer entertainer);
        void SaveChanges();

        Entertainer GetEntertainerById(int entertainerId);
        void UpdateEntertainer(Entertainer entertainer);
    }
}
