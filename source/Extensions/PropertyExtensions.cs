using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Netina.Core.Extensions
{
    public static class PropertyExtensions
    {

        public static string GetPropertyDisplayName(this MemberInfo propertyExpression)
        {
            var memberInfo = propertyExpression;
            var attr = memberInfo.GetCustomAttributes<DisplayAttribute>().FirstOrDefault();
            if (attr == null)
            {
                return memberInfo.Name;
            }

            return attr.Name;
        }

    }
}
