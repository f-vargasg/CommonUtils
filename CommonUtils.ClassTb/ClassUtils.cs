using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtils.ClassTb
{
    public class ClassUtils<T>
    {
        public static List<T> Filter(List<T> collection,
                      string property,
                      string filterValue)
        {
            var filteredCollection = new List<T>();
            foreach (var item in collection)
            {
                // To check multiple properties use,
                // item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)

                var propertyInfo =
                    item.GetType()
                        .GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
                if (propertyInfo == null)
                    throw new NotSupportedException("property given does not exists");

                object propertyValue = propertyInfo.GetValue(item, null);
                string propertyValueCmp = Convert.ToString(propertyValue);
                //if (propertyValueCmp == filterValue)
                if (propertyValueCmp.ToUpper().Contains(filterValue.ToUpper()))
                {
                    filteredCollection.Add(item);
                }
            }
            return filteredCollection;
        }
    }
}
