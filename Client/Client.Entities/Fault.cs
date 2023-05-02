using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","Faults")]
      public class Fault
     {
         [DataLayer.PrimaryKey]
         [DataLayer.ComputedColumn]
       public int Id {get;set;}
       public int TypeId {get;set;}
       public int ModeId {get;set;}
       public int NominalId {get;set;}
       public DateTime Date {get;set;}
       public float Value {get;set;}
     }
}
