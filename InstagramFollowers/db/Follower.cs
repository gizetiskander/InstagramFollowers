//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstagramFollowers.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Follower
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Follower()
        {
            this.History_Follower = new HashSet<History_Follower>();
        }
    
        public int ID_Follower { get; set; }
        public string Follower_Name { get; set; }
        public Nullable<int> ID_User { get; set; }
        public byte[] Follower_Image { get; set; }
        public string Follower_text { get; set; }
        public Nullable<int> ID_Role { get; set; }
    
        public virtual C_User C_User { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History_Follower> History_Follower { get; set; }
    }
}
