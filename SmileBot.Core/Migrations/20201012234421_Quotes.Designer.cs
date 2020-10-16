// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmileBot.Core.Database;

namespace SmileBot.Core.Migrations
{
    [DbContext(typeof(SmileContext))]
    [Migration("20201012234421_Quotes")]
    partial class Quotes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("SmileBot.Core.Database.Models.BotConfig", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTime?>("DateCreated")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("BotConfig");
            });

            modelBuilder.Entity("SmileBot.Core.Database.Models.Guild", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTime?>("DateCreated")
                    .HasColumnType("TEXT");

                b.Property<bool>("DeleteMessageOnCommand")
                    .HasColumnType("INTEGER");

                b.Property<int>("DeleteMessageOnCommandTimer")
                    .HasColumnType("INTEGER");

                b.Property<ulong>("GuildId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Prefix")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Guilds");
            });

            modelBuilder.Entity("SmileBot.Core.Database.Models.Quote", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Author")
                    .HasColumnType("TEXT");

                b.Property<ulong>("AuthorId")
                    .HasColumnType("INTEGER");

                b.Property<DateTime?>("DateCreated")
                    .HasColumnType("TEXT");

                b.Property<ulong>("GuildId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Keyword")
                    .HasColumnType("TEXT");

                b.Property<string>("Text")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Quotes");
            });

            modelBuilder.Entity("SmileBot.Core.Database.Models.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("AvatarId")
                    .HasColumnType("TEXT");

                b.Property<DateTime?>("DateCreated")
                    .HasColumnType("TEXT");

                b.Property<string>("Discriminator")
                    .HasColumnType("TEXT");

                b.Property<ulong>("UserId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Username")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Users");
            });
#pragma warning restore 612, 618
        }
    }
}