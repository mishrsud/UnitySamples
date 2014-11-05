using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Microsoft.Practices.Unity;

namespace UnitySamplesRunner
{
	class Program
	{
		private static UnityContainer _container;

		static void Main(string[] args)
		{
			Bootstrap();
			var configProvider = _container.Resolve<IConfigProvider>();
			Console.WriteLine(configProvider != null ? "Resolved" : "Coudn't resolve");

			Console.ReadLine();
		}

		private static void Bootstrap()
		{
			_container = new UnityContainer();

			_container.RegisterTypes(
				AllClasses.FromLoadedAssemblies(),
				WithMappings.FromAllInterfacesInSameAssembly,
				WithName.Default,
				WithLifetime.ContainerControlled);
		}
	}
}
