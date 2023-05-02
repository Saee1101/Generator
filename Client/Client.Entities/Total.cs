using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Total")]
      public class Total
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public int TypeId {get;set;}
       public int ModeId {get;set;}
       public DateTime OnDate {get;set;}
       public DateTime OffDate {get;set;}
       public long? Sum {get;set;}
     }
}
