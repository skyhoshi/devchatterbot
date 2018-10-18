﻿// <auto-generated />
using System;
using DevChatter.Bot.Infra.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevChatter.Bot.Infra.Ef.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20181013180243_AddingWeightColumnToIntervalMessages")]
    partial class AddingWeightColumnToIntervalMessages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevChatter.Bot.Core.Commands.SimpleCommand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommandText");

                    b.Property<string>("HelpText");

                    b.Property<int>("RoleRequired");

                    b.Property<string>("StaticResponse");

                    b.HasKey("Id");

                    b.ToTable("SimpleCommands");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.AliasArgumentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AliasId");

                    b.Property<string>("Argument");

                    b.Property<int>("Index");

                    b.HasKey("Id");

                    b.HasIndex("AliasId");

                    b.ToTable("AliasArgumentEntity");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.AliasEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CommandId");

                    b.Property<string>("Word");

                    b.HasKey("Id");

                    b.HasIndex("CommandId");

                    b.HasIndex("Word")
                        .IsUnique()
                        .HasFilter("[Word] IS NOT NULL");

                    b.ToTable("AliasEntity");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.BlastTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImagePath");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("BlastTypes");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.CanvasProperties", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CanvasId");

                    b.Property<int>("Height");

                    b.Property<int>("LeftX");

                    b.Property<int>("TopY");

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.HasIndex("CanvasId")
                        .IsUnique()
                        .HasFilter("[CanvasId] IS NOT NULL");

                    b.ToTable("CanvasProperties");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.ChatUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<int?>("Role");

                    b.Property<int>("Tokens");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("ChatUsers");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.CommandEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommandWord");

                    b.Property<TimeSpan>("Cooldown");

                    b.Property<string>("FullTypeName");

                    b.Property<string>("HelpText");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("RequiredRole");

                    b.HasKey("Id");

                    b.HasIndex("CommandWord")
                        .IsUnique()
                        .HasFilter("[CommandWord] IS NOT NULL");

                    b.ToTable("CommandWords");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.CommandSettingsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key");

                    b.Property<string>("SettingsTypeName");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("CommandSettings");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.CommandUsageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChatClientUsed");

                    b.Property<string>("CommandWord");

                    b.Property<DateTimeOffset>("DateTimeUsed");

                    b.Property<string>("FullTypeName");

                    b.Property<string>("UserDisplayName");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("CommandUsages");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.HangmanWord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Word");

                    b.HasKey("Id");

                    b.ToTable("HangmanWords");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.IntervalMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DelayInMinutes");

                    b.Property<DateTime>("LastSent");

                    b.Property<string>("MessageText");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("IntervalMessages");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.QuizQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorrectAnswer");

                    b.Property<string>("Hint1");

                    b.Property<string>("Hint2");

                    b.Property<string>("MainQuestion");

                    b.Property<string>("WrongAnswer1");

                    b.Property<string>("WrongAnswer2");

                    b.Property<string>("WrongAnswer3");

                    b.HasKey("Id");

                    b.ToTable("QuizQuestions");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.QuoteEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<string>("Author");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("QuoteId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("QuoteEntities");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.ScheduleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("ExampleDateTime");

                    b.HasKey("Id");

                    b.ToTable("ScheduleEntities");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.StreamerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelName");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("TimesShoutedOut");

                    b.HasKey("Id");

                    b.ToTable("Streamers");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.TimezoneEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateUpdated");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<string>("LookupString");

                    b.Property<int>("Offset");

                    b.Property<string>("TimezoneName");

                    b.HasKey("Id");

                    b.ToTable("Timezones");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.AliasArgumentEntity", b =>
                {
                    b.HasOne("DevChatter.Bot.Core.Data.Model.AliasEntity", "Alias")
                        .WithMany("Arguments")
                        .HasForeignKey("AliasId");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Data.Model.AliasEntity", b =>
                {
                    b.HasOne("DevChatter.Bot.Core.Data.Model.CommandEntity", "Command")
                        .WithMany("Aliases")
                        .HasForeignKey("CommandId");
                });
#pragma warning restore 612, 618
        }
    }
}