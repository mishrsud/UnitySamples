namespace BusinessLogic
{
	/// <summary>
	/// Provides Configuration information
	/// </summary>
	public interface IConfigProvider
	{
		/// <summary>
		/// Gets the name of the provider.
		/// </summary>
		string ProviderName { get; }

		/// <summary>
		/// Gets the name of the server.
		/// </summary>
		string ServerName { get; }

		/// <summary>
		/// Gets the name of the database.
		/// </summary>
		string DatabaseName { get; }

		/// <summary>
		/// Gets the port.
		/// </summary>
		int Port { get; }
	}
}
