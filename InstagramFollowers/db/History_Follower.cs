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
    
    public partial class History_Follower
    {
        public int ID_History_Follower { get; set; }
        public Nullable<System.DateTime> History_Follower_date { get; set; }
        public string History_Follower_text { get; set; }
        public Nullable<int> ID_Follower { get; set; }
    
        public virtual Follower Follower { get; set; }
    }
}
