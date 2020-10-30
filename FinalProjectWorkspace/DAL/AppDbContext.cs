using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using FinalProjectWorkspace.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinalProjectWorkspace.DAL

{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
    }
}
