using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Model")]
      public class Model
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public int? TypeId {get;set;}
       public string Titel {get;set;}
       public string Code {get;set;}
     }
}
