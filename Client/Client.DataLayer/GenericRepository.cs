using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Client.DataLayer
{
   public class GenericRepository<TEntity> : IRepository<TEntity>
    {
      protected  string schema;
       protected string tableName;
        List<PropertyModel> propertymodels = new List<PropertyModel>();
        string connectionString;
        public GenericRepository()
        {
            var entityType = typeof(TEntity);
            var tableAttribute = entityType.GetCustomAttributes(typeof(TableAttribute), false).OfType<TableAttribute>().FirstOrDefault();
            if(tableAttribute!=null)
            {
                schema = tableAttribute.Schema;
                tableName = tableAttribute.Table;
            }
            else
            {
                schema = "dbo";
                tableName = entityType.Name;
            }
            foreach(var propertyInfo in entityType.GetProperties())
            {
                var propertymodel = new PropertyModel
                {
                    PropertyName = propertyInfo.Name,
                    ColumnName = propertyInfo.Name,
                    IsComputed = propertyInfo.GetCustomAttributes(typeof(ComputedColumnAttribute), false).Any(),
                    IsPrimerykey = propertyInfo.GetCustomAttributes(typeof(PrimaryKey), false).Any(),
                    PropertyInfo = propertyInfo
                };
                propertymodels.Add(propertymodel);
            }
        }
        public GenericRepository(string connectionString) :this()
        {
            if(connectionString.StartsWith("name="))
            {
                this.connectionString = ConfigurationManager.ConnectionStrings[connectionString.Substring(5)].ConnectionString;
            }
            else
            {
                this.connectionString = connectionString;
            }
       
        }
        
        public int Add(TEntity entity)
        {
            StringBuilder insertStatement =new StringBuilder("INSERT INTO [" + schema + "].[" + tableName + "]({columns}) VALUES({values})");

            List<string> columnsName = new List<string>();      
            List<string> sqlparameterNames = new List<string>();
            List<SqlParameter> sqlparameters = new List<SqlParameter>();

            var parameterCounter = 1; 
            foreach(var property in propertymodels)
            {
                if (property.IsComputed)
                    continue;
                columnsName.Add(property.ColumnName);
                var parameterName = "Column" + parameterCounter++;
                sqlparameterNames.Add(parameterName);
                var parameterValue = property.PropertyInfo.GetValue(entity);
                sqlparameters.Add(new SqlParameter(parameterName, parameterValue==null ? DBNull.Value : parameterValue));
                
            }
            insertStatement.Replace("{columns}", string.Join(",", columnsName.Select(col => "[" + col + "]")));
            insertStatement.Replace("{values}", string.Join(",", sqlparameterNames.Select(parampeter => "@" + parampeter )));
            using (var connection = new SqlConnection(connectionString ))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = insertStatement.ToString();
                foreach(var parameter in sqlparameters)
                {
                    command.Parameters.Add(parameter);
                }
                return command.ExecuteNonQuery();
            }
                
        }
     /// <summary>
        /// ***************** Remove *********************
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Remove(TEntity entity)
        {
            var primeryKeys = propertymodels.Where(property => property.IsPrimerykey);
            StringBuilder deleteStatement = new StringBuilder("DELETE FROM [" + schema + "].[" + tableName + "]");
            List<string> wherePart = new List<string>();
            List<SqlParameter> sqlparameters = new List<SqlParameter>();
            //List<string> sqlparameterNames = new List<string>();
            var parameterCounter = 1;
            foreach (var property in primeryKeys)
            {
              
               
                var parameterName = "Column" + parameterCounter++;
                wherePart.Add("["+ property.ColumnName +"]=@"+parameterName);
                var parameterValue = property.PropertyInfo.GetValue(entity);
                sqlparameters.Add(new SqlParameter(parameterName, parameterValue));

            }
            deleteStatement.Append(" WHERE " + string.Join(" AND ", wherePart));
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = deleteStatement.ToString();
                foreach (var parameter in sqlparameters)
                {
                    command.Parameters.Add(parameter);
                }
                return command.ExecuteNonQuery();
            }
            
        }
     /// <summary>
        ///  @@@@@@@@@@@@     Find Methode @@@@@@@@@@@@@
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        ///
        public TEntity Find(params object[] keys)
        {
            var primeryKeys = propertymodels.Where(property => property.IsPrimerykey);

            //var query = new StringBuilder("SELECT TOP(1) * FROM [" + schema + "].[" + tableName + "]");
            //////////////////////    select Type.Title,Model.Title,Nominal.Titel,faults.Value from Type inner join Nominal on Type.Id = Nominal.TypeId inner join Model 
            //////////////////////                on Model.Id = Nominal.ModelId
            //////////////////////inner join faults on faults.NominalId = Nominal.Id where Date = '2023-03-22'
            var query=new StringBuilder("SELECT ype.Title,Model.Title,Nominal.Titel,faults.Value from Type inner join Nominal on Type.Id = Nominal.TypeId inner join Model on Model.Id = Nominal.ModelId inner join faults on faults.NominalId = Nominal.Id ");
            //List<string> wherePart = new List<string>();
            List<SqlParameter> sqlparameters = new List<SqlParameter>();


            //var parameterCounter = 1;
            //foreach (var property in primeryKeys)
            //{


            //    var parameterName = "Column" + parameterCounter;
            //    wherePart.Add("[" + property.ColumnName + "]=@" + parameterName);
            //    var parameterValue = keys[parameterCounter++ - 1];
            //    sqlparameters.Add(new SqlParameter(parameterName, parameterValue));

            //}
            //query.Append(" WHERE " + string.Join(" AND ", wherePart));

            return Runquery(query.ToString(), sqlparameters.ToArray()).FirstOrDefault();
        }
        public List<TEntity> All()
        {
            var query = new StringBuilder("SELECT  * FROM [" + schema + "].[" + tableName + "]");
            return Runquery(query.ToString());
        }
        public int Count()
        {
            var query = new StringBuilder("SELECT COUNT(*) FROM [" + schema + "].[" + tableName + "]");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query.ToString(), connection);
                return (int)command.ExecuteScalar();
            }
        }
     /// <summary>
///   *************   UPdate  **************
/// </summary>
/// <param name="entity"></param>
/// <returns></returns>
        public int Update(TEntity entity)
        {
            var query = new StringBuilder("UPDATE [" + schema + "].[" + tableName + "]");

            var noncomputedcolumns = propertymodels.Where(p => !p.IsComputed);

            var primeryKeys = propertymodels.Where(property => property.IsPrimerykey);
           
            List<string> updatestatments = new List<string>();
            List<SqlParameter> sqlparameter = new List<SqlParameter>();

            var valuecounter = 1;
            foreach (var model in noncomputedcolumns)
            {
                updatestatments.Add("[" + model.ColumnName + "]=@value"+valuecounter);
                sqlparameter.Add(new SqlParameter("value" + valuecounter++, model.PropertyInfo.GetValue(entity)));
            }
            query.Append("SET" + string.Join(",", updatestatments));

            List<string> wherePart = new List<string>();

            var KeyCounter = 1;
            foreach (var property in primeryKeys)
            {


                var parameterName = "Column" + KeyCounter++;
                wherePart.Add("[" + property.ColumnName + "]=@" + parameterName);
                var parameterValue = property.PropertyInfo.GetValue(entity);
                sqlparameter.Add(new SqlParameter(parameterName, parameterValue));
            }
            query.Append(" WHERE " + string.Join(" AND ", wherePart));
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = query.ToString();
                foreach (var parameter in sqlparameter)
                {
                    command.Parameters.Add(parameter);
                }
                return command.ExecuteNonQuery();
            }

        }
        protected List<TEntity> Runquery(string query, params SqlParameter[] parametrs)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = query.ToString();
                foreach (var parameter in parametrs)
                {
                    command.Parameters.Add(parameter);
                }
                var reader = command.ExecuteReader();
                List<TEntity> entities = new List<TEntity>();
                while (reader.Read())
                {
                    TEntity entity = Activator.CreateInstance<TEntity>();
                    foreach (var model in propertymodels)
                    {
                        var value = reader[model.ColumnName];
                        if (value is DBNull)
                            model.PropertyInfo.SetValue(entity, null);
                        else
                        model.PropertyInfo.SetValue(entity, value);
                    }
                    entities.Add(entity);
                }

                return entities;
            }
        }
        public void report()
        {
            var query = new StringBuilder("select Type.Title,Model.Title,Nominal.Titel,faults.Value from Type inner join Nominal on Type.Id=Nominal.TypeId inner join Model on Model.Id=Nominal.ModelId inner join faults on faults.NominalId = Nominal.Id where Date = '2023-03-22'");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query.ToString(), connection);              
            }
        }
    }
}
