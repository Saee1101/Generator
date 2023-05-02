using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Users")]
      public class User
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public string Username {get;set;}
       public object Date {get;set;}
     }
}
