using NorthWind.Data.Contexts;
using NorthWind.Repositories;

namespace NorthWind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            var repo = new Repository(context);
            //repo.GetCustomersAndProducts();
            
            //repo.GetProductsBySuppliers();

            //repo.GetTopFiveCustomersByNumberOforeder();
        }
    }
}
