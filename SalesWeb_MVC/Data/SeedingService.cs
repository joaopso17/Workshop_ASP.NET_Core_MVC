namespace SalesWeb_MVC.Data
{
    public class SeedingService
    {
        private DepartmentsContext _context;
        
        public SeedingService (DepartmentsContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any()|| _context.seller.Any()|| _context.SelesRecord.Any()) { return; }
            
        }
    }
}
