using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmileBot.Core.Database.Models;
using SmileBot.Core.Services.Impl;

namespace SmileBot.Core.Database
{
    public class SmileContextFactory : IDesignTimeDbContextFactory<SmileContext>
    {
        public SmileContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SmileContext>();
            IBotCredentials creds = new BotCredentials();
            var builder = new SqliteConnectionStringBuilder(creds.Db.ConnectionString);
            optionsBuilder.UseSqlite(builder.ToString());
            var ctx = new SmileContext(optionsBuilder.Options);
            ctx.Database.SetCommandTimeout(60);
            return ctx;
        }
    }

    public class SmileContext : DbContext
    {
        public DbSet<BotConfig> BotConfig { get; set; }
        public DbSet<GuildConfig> Guilds { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        public SmileContext(DbContextOptions<SmileContext> options) : base(options) { }
    }
}