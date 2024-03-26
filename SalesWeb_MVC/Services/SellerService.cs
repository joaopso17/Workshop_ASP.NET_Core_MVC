using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;

namespace SalesWeb_MVC.Services
{
    public class SellerService
    {
        private readonly DepartmentsContext _context;

        public SellerService (DepartmentsContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
