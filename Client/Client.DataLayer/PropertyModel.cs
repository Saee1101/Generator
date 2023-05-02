using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataLayer
{
    class PropertyModel
    {
        public string  PropertyName { get; set; }
        public string ColumnName { get; set; }
        public bool IsPrimerykey { get; set; }
        public bool IsComputed { get; set; }
        public PropertyInfo PropertyInfo { get; set; }

    }
}
