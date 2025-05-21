using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AppMultas.Data
{
    public class AppMultasContext(DbContextOptions<AppMultasContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
