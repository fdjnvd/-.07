﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Автобус> Автобус { get; set; }
        public virtual DbSet<Билет> Билет { get; set; }
        public virtual DbSet<Водители> Водители { get; set; }
        public virtual DbSet<Диспетчер> Диспетчер { get; set; }
        public virtual DbSet<Маршрут> Маршрут { get; set; }
        public virtual DbSet<Пассажир> Пассажир { get; set; }
        public virtual DbSet<Пассажировместимость> Пассажировместимость { get; set; }
        public virtual DbSet<Расписание_рейсов> Расписание_рейсов { get; set; }
    }
}
