using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Client.Framework
{
    class ExpressionHandler:ExpressionVisitor
    {
        List <string> visitedProperty=new List<string>();
        public string GetPropertyName(Expression expression)
        {
            Visit(expression);
            visitedProperty.Reverse();

            return string.Join(".",visitedProperty);
        }
        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Member is PropertyInfo)
                visitedProperty.Add(node.Member.Name);
            return base.VisitMember(node);
        }
    }
}
