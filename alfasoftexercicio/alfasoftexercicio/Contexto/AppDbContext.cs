using System;
using alfasoftexercicio.Models;
using Microsoft.EntityFrameworkCore;

namespace alfasoftexercicio.Contexto
{
    public class AppDbContext : DbContext
    {
        DbSet<Contact> Contacts { get; set; }
    }
}

