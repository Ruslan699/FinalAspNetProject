using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApplication.Models;
using MyApplication.Models.Brons;

namespace MyApplication.Models
{
    public class ToursDbContext : DbContext
    {
        public ToursDbContext(DbContextOptions<ToursDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Tour> Tours { get; set; }

        public DbSet<DemoStudent> Students { get; set; }

        public DbSet<Transfer> Transfers { get; set; }

        public DbSet<Transport> Transports { get; set; }

        public DbSet<GroupTour> GroupTours { get; set; }

        public DbSet <OnlinePayment> OnlinePayments { get; set; }

        public DbSet<Insuarance> Insuarances { get; set; }

        public DbSet<TitleAndSubTitle> TitleAndSubTitles { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Compliance> Compliances { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Vip> Vips { get; set; }

        public DbSet<WhyWe> WhyWe { get; set; }

        public DbSet<Advice> Advices { get; set; }

        public DbSet<Cruiz> Cruizs { get; set; }

        public DbSet<Emergency> Emergencies { get; set; }

        public DbSet<HotelList> HotelLists { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<AzeTitleSubtitle> AzeTitleSubTitles { get; set; }

        public DbSet<MyApplication.Models.Incoming> Incoming { get; set; }

        public DbSet<MyApplication.Models.Event> Events { get; set; }

        public DbSet<MyApplication.Models.Health> Healths { get; set; }

        public DbSet<MyApplication.Models.Azerbaijan> Azerbaijans { get; set; }

        public DbSet<MyApplication.Models.Contact> Contacts { get; set; }

        public DbSet<MainPage> MainPages { get; set; }

        public DbSet<MainPageTitleSubTitle> MainPageTitles { get; set; }

        public DbSet<NaftalanPage> NaftalanPages { get; set; }

        public DbSet<NaftalanDescription> NaftalanDescriptions { get; set; }

        public DbSet<GoyGolPage> GoyGolPages { get; set; }

        public DbSet<GoyGolDescription> GoyGolDescriptions { get; set; }

        public DbSet<FireMountainPage> FireMountainPages { get; set; }

        public DbSet<FireMountainDescription> FireMountainDescriptions { get; set; }

        public DbSet<ShakiPage> ShakiPages { get; set; }

        public DbSet<ShakiPageDescription> ShakiPageDescriptions { get; set; }

        public DbSet<BilgehDescription> BilgehDescriptions { get; set; }

        public DbSet<BilgehPage> BilgehPages { get; set; } 

        public DbSet<FormulaPage> FormulaPages { get; set; }

        public DbSet<Festival> Festivals { get; set; }

        public DbSet<BakuJara> BakuJaras { get; set; }

        public DbSet<TransportDescription> TransportDescriptions { get; set; }

        public DbSet<InsuaranceDescription> InsuaranceDescriptions { get; set; }

        public DbSet<HotelListDescription> HotelListDescriptions { get; set; }

        public DbSet<MyApplication.Models.QubaPage> QubaPages { get; set; }

        public DbSet<MyApplication.Models.QubaPageDescription> QubaPageDescriptions { get; set; }

        public DbSet<MyApplication.Models.QakhPage> QakhPages { get; set; }

        public DbSet<MyApplication.Models.QakhDescriptions> QakhDescriptions { get; set; }

        public DbSet<MyApplication.Models.VulkanPage> VulkanPages { get; set; }

        public DbSet<MyApplication.Models.VulkanDescription> VulkanDescriptions { get; set; }

        public DbSet<MyApplication.Models.QabalaPage> QabalaPages { get; set; }

        public DbSet<MyApplication.Models.QabalaDescriptions> QabalaDescriptions { get; set; }

        public DbSet<MyApplication.Models.LankaranPage> LankaranPages { get; set; }

        public DbSet<MyApplication.Models.LankaranDescription> LankaranDescriptions { get; set; }

        public DbSet<MyApplication.Models.Brons.PersonalInformation> PersonalInfos { get; set; }

        public DbSet<MyApplication.Models.Message> Messages { get; set; }

        public DbSet<MyApplication.Models.BronTitle> BronTitles { get; set; }

        public DbSet<MyApplication.Models.BronNaftalan> BronNaftalans { get; set; }

        public DbSet<MyApplication.Models.BronBilgeh> BronBilgehs { get; set; }

        public DbSet<MyApplication.Models.BronHotel> BronHotels { get; set; }

        public DbSet<MyApplication.Models.BronLankaran> BronLankarans { get; set; }

        public DbSet<MyApplication.Models.BronInfo> BronInfos { get; set; }

        public DbSet<MyApplication.Models.SimiliarTour> SimiliarTours { get; set; }

        public DbSet<MyApplication.Models.Brons.SimpleInformation> SimpleInformation { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalInformation>().HasIndex(x => x.BronHotelId).IsUnique(false);
            base.OnModelCreating(modelBuilder);
        }


    }





}
