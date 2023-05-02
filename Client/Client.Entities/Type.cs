using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Type")]
      public class Type
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public int ParentTypeId {get;set;}
       public string Titel {get;set;}
     }
}
