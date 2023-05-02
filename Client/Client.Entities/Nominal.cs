using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Nominal")]
      public class Nominal
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public int ModelId {get;set;}
       public string Key {get;set;}
       public string Titel {get;set;}
       public float? Tel {get;set; }
       public float? Tel_ {get;set; }
     }
}
