//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Sotrud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrud()
        {
            this.Bolnich = new HashSet<Bolnich>();
            this.Komandirovka = new HashSet<Komandirovka>();
            this.Uvolnenie = new HashSet<Uvolnenie>();
        }
    
        public int ID { get; set; }
        public string FIO { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Pasport { get; set; }
        public string INN { get; set; }
        public string Obrazov { get; set; }
        public Nullable<int> Dolg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bolnich> Bolnich { get; set; }
        public virtual Dolg Dolg1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Komandirovka> Komandirovka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uvolnenie> Uvolnenie { get; set; }
    }
}