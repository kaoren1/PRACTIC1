//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PRACTIC1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assigments
    {
        public int ID_Assigment { get; set; }
        public int Employee_ID { get; set; }
        public int Project_ID { get; set; }
    
        public virtual Employees Employees {private get; set; }
        public virtual Projects Projects {private get; set; }
    }
}