using LandSoft.Infrastructure.Interfaces;

namespace LandSoft.Data.EF
{
	public class EFUnitOfWork : IUnitOfWork
	{
		private readonly LSDbContext _context;

        public EFUnitOfWork(LSDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
