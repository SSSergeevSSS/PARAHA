//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Administration.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administration
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public int IDPopulation { get; set; }
        public int IDApplication { get; set; }
        public int IDStaff { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual Population Population { get; set; }
        public virtual Staff Staff { get; set; }
    }
}