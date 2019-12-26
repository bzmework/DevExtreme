using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;
using DevExtreme.AspNet.Mvc.Internals;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace DevExtreme.AspNet.Mvc
{
	internal static class New
	{
		private static ConcurrentDictionary<Type, object> _factories = new ConcurrentDictionary<Type, object>();

		public static T Options<T>(OptionsOwnerContext context) where T : OptionsOwnerBuilder
		{
			return GetFactory<OptionsOwnerContext, T>()(context);
		}

		public static F WidgetFactory<F>(OptionsOwnerBuilder owner, IHtmlHelperAdapter html) where F : AbstractWidgetFactory
		{
			return GetFactory<OptionsOwnerBuilder, IHtmlHelperAdapter, F>()(owner, html);
		}

		public static F CollectionFactory<F>(OptionsOwnerContext context) where F : AbstractCollectionFactory
		{
			return GetFactory<OptionsOwnerContext, F>()(context);
		}

		private static Func<A1, R> GetFactory<A1, R>()
		{
			return (Func<A1, R>)_factories.GetOrAdd(typeof(R), (Type t) => CreateFactory(typeof(R), typeof(A1)));
		}

		private static Func<A1, A2, R> GetFactory<A1, A2, R>()
		{
			return (Func<A1, A2, R>)_factories.GetOrAdd(typeof(R), (Type t) => CreateFactory(typeof(R), typeof(A1), typeof(A2)));
		}

		private static Delegate CreateFactory(Type objectType, params Type[] ctorArgumentTypes)
		{
			ParameterExpression[] array = ctorArgumentTypes.Select(Expression.Parameter).ToArray();
			ConstructorInfo constructor = objectType.GetConstructor(ctorArgumentTypes);
			Expression[] arguments = array;
			return Expression.Lambda(Expression.New(constructor, arguments), array).Compile();
		}
	}
}
