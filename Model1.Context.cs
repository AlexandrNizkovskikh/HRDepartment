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
    
    public partial class Otdel_KadrovEntities1 : DbContext
    {

        private static Otdel_KadrovEntities1 _instace;

        public Otdel_KadrovEntities1()
            : base("name=Otdel_KadrovEntities1")
        {
        }

        public static Otdel_KadrovEntities1 GetContext()
        {
            if (_instace == null)
            {
                _instace = new Otdel_KadrovEntities1();
            }
            return _instace;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolnich> Bolnich { get; set; }
        public virtual DbSet<Dolg> Dolg { get; set; }
        public virtual DbSet<Komandirovka> Komandirovka { get; set; }
        public virtual DbSet<Kondidat> Kondidat { get; set; }
        public virtual DbSet<Sotrud> Sotrud { get; set; }
        public virtual DbSet<Uvolnenie> Uvolnenie { get; set; }
    }
}