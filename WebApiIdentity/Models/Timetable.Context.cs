﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiIdentity.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimetableEntities : DbContext
    {
        public TimetableEntities()
            : base("name=TimetableEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Extracurricular> Extracurricular { get; set; }
        public virtual DbSet<Mark> Mark { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
    }
}
