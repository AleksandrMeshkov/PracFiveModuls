//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracFive.ModelsModifierDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patrols
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patrols()
        {
            this.Reports = new HashSet<Reports>();
        }
    
        public int IdPatrol { get; set; }
        public int IdEmploees { get; set; }
        public System.DateTime PatrolTime { get; set; }
        public bool IsFalseAlarm { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
