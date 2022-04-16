using Microsoft.EntityFrameworkCore;

namespace Satistic.Models
{
    public class IsfDashbord_DbContext:DbContext
    {
        public IsfDashbord_DbContext(DbContextOptions options):base(options)
        {

        }
    }
}
