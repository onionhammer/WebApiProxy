//------------------------------------------------------------------------------
//<auto-generated>
// This file is auto-generated by WebApiProxy
// Project site: https://github.com/onionhammer/WebApiProxy/
//
// Any changes to this file will be overwritten
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using MyTest.API.Models;

#region Models

namespace MyTest.API.Models
{
	public class WebApiProxyResponseException : Exception
	{
		public HttpStatusCode StatusCode { get; }

		public string Content { get; }

		public WebApiProxyResponseException(HttpStatusCode statusCode, string content)
			: base($"A {statusCode} ({(int)statusCode} http exception occurred. See content for response body.")
		{
			StatusCode = statusCode;
			Content    = content;
		}
	} 	

	/// <summary>
	/// 
	/// </summary>
	public partial class ItemTestViewModel
	{
		#region Constants

		#endregion

		#region Properties

		/// <summary>
		/// 
		/// </summary>
		public virtual String Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public virtual ItemTestEnum Value { get; set; }

		#endregion
	}

	/// <summary>
	/// 
	/// </summary>
	public enum ItemTestEnum
	{
		
		/// <summary>
		/// 
		/// </summary>
		Zero = 0,
		
		/// <summary>
		/// 
		/// </summary>
		One = 1,
		
		/// <summary>
		/// 
		/// </summary>
		Two = 2,
		
		/// <summary>
		/// 
		/// </summary>
		Three = 3,
		
		/// <summary>
		/// 
		/// </summary>
		Four = 4,
		
	}
}

#endregion

#region Clients

namespace MyTest.API.Clients
{
	/// <summary>
	/// Client base class.
	/// </summary>
	public abstract partial class ClientBase : IDisposable
	{
		/// <summary>
		/// Gets the HttpClient.
		/// </summary>
		public HttpClient HttpClient { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientBase"/> class.
		/// </summary>
		protected ClientBase(string apiRoot)
		{
			HttpClient = new HttpClient()
			{
				BaseAddress = new Uri(apiRoot)
			};
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientBase"/> class.
		/// </summary>
		/// <param name="handler">The handler.</param>
		/// <param name="disposeHandler">if set to <c>true</c> [dispose handler].</param>
		protected ClientBase(HttpMessageHandler handler, bool disposeHandler = true, string apiRoot = null)
		{
			HttpClient = new HttpClient(handler, disposeHandler)
			{
				BaseAddress = new Uri(apiRoot)
			};
		}
		
		/// <summary>
		/// Ensures that response has a valid (200 - OK) status code
		/// </summary>
		public virtual async Task EnsureSuccessAsync(HttpResponseMessage response)
		{			
			if (response.IsSuccessStatusCode)
				return;

			var content = await response.Content.ReadAsStringAsync();
			throw new WebApiProxyResponseException(response.StatusCode, content);
		}

		/// <summary>
		/// Encode the input parameter as a string
		/// </summary>
		protected string EncodeParam<T>(T value) =>
			value == null
				 ? string.Empty
				 : System.Net.WebUtility.UrlEncode(value.ToString());
		
		/// <summary>
		/// Encode the input parameter as a string
		/// </summary>
		protected string EncodeParam(DateTime value) =>
			System.Net.WebUtility.UrlEncode(value.ToString("s"));
		
		/// <summary>
		/// Encode the input parameter as a string
		/// </summary>
		protected string EncodeParam(DateTimeOffset value) =>
			System.Net.WebUtility.UrlEncode(value.ToString("s"));
		
		/// <summary>
		/// Releases the unmanaged resources and disposes of the managed resources.       
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && HttpClient != null)
				HttpClient.Dispose();
		}
		
		/// <summary>
		/// Releases the unmanaged resources and disposes of the managed resources.       
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Destructor
		/// </summary>
		~ClientBase() 
		{
			Dispose(false);
		}
	}

	/// <summary>
	/// Helper class to access all clients at once
	/// </summary>
	public partial class WebApiClients
	{
		public ValuesClient Values { get; }
		
		public WebApiClients(Uri apiRootUri = null)
		{
			var apiRoot = apiRootUri?.AbsoluteUri
					   ?? "http://localhost:61048/";

			Values = new ValuesClient(apiRoot);
		}

		public void SetAuthentication(AuthenticationHeaderValue auth)
		{
			Values.HttpClient.DefaultRequestHeaders.Authorization = auth;
		}
		
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				Values.Dispose();
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~WebApiClients() 
		{
			Dispose(false);
		}
	}

	/// <summary>
	/// Values service
	/// </summary>
	public partial class ValuesClient : ClientBase
	{
		#region Constructors

		/// <summary>
		/// Values service
		/// </summary>
		public ValuesClient(string apiRoot = "http://localhost:61048/") 
			: base(apiRoot)
		{
		}

		/// <summary>
		/// Values service
		/// </summary>
		public ValuesClient(HttpMessageHandler handler, bool disposeHandler = true, string apiRoot = "http://localhost:61048/")
			: base(handler, disposeHandler, apiRoot)
		{
		}

		#endregion

		#region Methods

		/// <summary>
		/// Retrieve many values
		/// </summary>
		/// <returns></returns>
		public virtual async Task<List<ItemTestViewModel>> GetAsync()
		{
			var result = await HttpClient.GetAsync($"api/Values");
			 
			await EnsureSuccessAsync(result);
				 
			return await result.Content.ReadAsAsync<List<ItemTestViewModel>>();
		}

		/// <summary>
		/// Get specific Value
		/// </summary>
		/// <param name="id">id of the value</param>
		/// <returns></returns>
		public virtual async Task<ItemTestViewModel> GetAsync(ItemTestEnum id)
		{
			var result = await HttpClient.GetAsync($"api/Values/{EncodeParam(id)}");
			 
			await EnsureSuccessAsync(result);
				 
			return await result.Content.ReadAsAsync<ItemTestViewModel>();
		}

		/// <summary>
		/// Find by name
		/// </summary>
		/// <param name="name">Name of thing to find</param>
		/// <returns></returns>
		public virtual async Task<ItemTestViewModel> FindByNameAsync(String name)
		{
			var result = await HttpClient.GetAsync($"api/Values?name={EncodeParam(name)}");
			 
			await EnsureSuccessAsync(result);
				 
			return await result.Content.ReadAsAsync<ItemTestViewModel>();
		}

		/// <summary>
		/// Push new value
		/// </summary>
		/// <returns></returns>
		public virtual async Task PostAsync(ItemTestViewModel value)
		{
			var result = await HttpClient.PostAsJsonAsync<ItemTestViewModel>($"api/Values", value);
		
			await EnsureSuccessAsync(result);
		}

		#endregion
	}
}

#endregion