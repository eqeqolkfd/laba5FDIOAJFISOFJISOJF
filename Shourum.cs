//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practa5laba5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shourum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shourum()
        {
            this.ShourumContent = new HashSet<ShourumContent>();
        }
    
        public int ID_Shourum { get; set; }
        public string NameShourum { get; set; }
        public string AddressS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShourumContent> ShourumContent { get; set; }
    }
}
