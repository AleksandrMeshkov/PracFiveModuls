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
    
    public partial class Reports
    {
        public int IdReport { get; set; }
        public int IdObject { get; set; }
        public int IdPatrol { get; set; }
        public string Findings { get; set; }
        public System.DateTime IncidentTime { get; set; }
    
        public virtual Objects Objects { get; set; }
        public virtual Patrols Patrols { get; set; }
    }
}
