﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BO1O_1K_MATH.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KTP_Matematika_BarashenkovEntities : DbContext
    {
        private static KTP_Matematika_BarashenkovEntities _instance;
        public KTP_Matematika_BarashenkovEntities()
            : base("name=KTP_Matematika_BarashenkovEntities")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public static KTP_Matematika_BarashenkovEntities GetContext()
        {
            if (_instance == null) _instance = new KTP_Matematika_BarashenkovEntities();
            return _instance;
        }

        public virtual DbSet<Chapters> Chapters { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Themes> Themes { get; set; }
    }
}