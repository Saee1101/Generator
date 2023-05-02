using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Type_Units")]
      public class Type_Unit
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public string Title {get;set;}
       public string DESCRIPTION {get;set;}
     }
}
