using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace SeguesAndViewModels
{
	public static class Reflection
	{
		public static PropertyInfo GetPropertyInfo(LambdaExpression property)
		{
			var propertyInfo = (property.Body as MemberExpression).Member as PropertyInfo;
			if (propertyInfo == null)
				throw new ArgumentException("The lambda expression 'property' should point to a valid Property");
			return propertyInfo;
		}

		public static string GetPropertyName(LambdaExpression property)
		{
			var propertyInfo = GetPropertyInfo(property);
			return propertyInfo.Name;
		}

		public static string GetPropertyName<T>(Expression<Func<T>> property)
		{
			return GetPropertyName((LambdaExpression)property);
		}
	}
}
