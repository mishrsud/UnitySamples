namespace BusinessLogic
{
	/// <summary>
	/// A mockk implementation of the <see cref="IConfigProvider"/>
	/// </summary>
	public class MockConfigProvider : IConfigProvider
	{
		/// <summary>
		/// Gets the name of the provider.
		/// </summary>
		public string ProviderName
		{
			get { return "MockProvider"; }
		}

		/// <summary>
		/// Gets the name of the server.
		/// </summary>
		public string ServerName
		{
			get { return "DummyServer"; }
		}

		/// <summary>
		/// Gets the name of the database.
		/// </summary>
		public string DatabaseName
		{
			get { return "MockDatabase"; }
		}

		/// <summary>
		/// Gets the port.
		/// </summary>
		public int Port
		{
			get { return 0; }
		}
	}
}