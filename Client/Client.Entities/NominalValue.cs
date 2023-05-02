using System;

namespace Client.Entities
{
   [DataLayer.Table("dbo","NominalValue")]
      public class NominalValue
     {
       public int TypeId {get;set;}
       public int NominalId {get;set;}
       public float Value {get;set;}
     }
}
