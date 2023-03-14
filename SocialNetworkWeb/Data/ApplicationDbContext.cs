using System;
using System.Collections.Generic;
using System.Text;
using SocialNetworkWeb.Configs;
using SocialNetworkWeb.Models.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SocialNetworkWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
                Database.EnsureCreated();
            }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FriendConfiguration());
            builder.ApplyConfiguration(new MessageConfuiguration());
        }
    }
}
