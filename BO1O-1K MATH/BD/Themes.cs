//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Themes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Themes()
        {
            this.Chapters = new HashSet<Chapters>();
        }
    
        public int ID_Theme { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
        public string Numeration { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chapters> Chapters { get; set; }
    }
}
