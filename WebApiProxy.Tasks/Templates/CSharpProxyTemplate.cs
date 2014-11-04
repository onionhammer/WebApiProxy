﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace WebApiProxy.Tasks.Templates
{
    using System.Linq;
    using System.Text;
    using WebApiProxy.Core.Models;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class CSharpProxyTemplate : CSharpProxyTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Net.Http;\r\nusi" +
                    "ng System.Net.Http.Headers;\r\nusing System.Threading.Tasks;\r\nusing System.Net.Htt" +
                    "p.Formatting;\r\nusing System.Linq;\r\nusing System.Net;\r\nusing System.Web;\r\nusing ");
            
            #line 18 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Namespace));
            
            #line default
            #line hidden
            this.Write(".Models;\r\n\r\n// Proxies\r\nnamespace ");
            
            #line 21 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\t/// <summary>\r\n    /// Client configuration.\r\n    /// </summary>\r\n    publi" +
                    "c partial class Configuration\r\n\t{\r\n\t\t/// <summary>\r\n        /// Web Api Base Add" +
                    "ress.\r\n        /// </summary>\r\n\t\tpublic static string ");
            
            #line 31 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Name));
            
            #line default
            #line hidden
            this.Write("BaseAddress = \"");
            
            #line 31 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Metadata.Host));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\r\n\t}\r\n}\r\n\r\nnamespace ");
            
            #line 36 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Namespace));
            
            #line default
            #line hidden
            this.Write(".Models\r\n{\r\n#region Models\r\n");
            
            #line 39 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var model in Configuration.Metadata.Models.Where(m => m.Type.Equals("class"))) { 
            
            #line default
            #line hidden
            this.Write("\t\r\n\t/// <summary>\r\n    /// ");
            
            #line 41 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n    /// </summary>\r\n\tpublic partial class ");
            
            #line 43 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\t#region Constants\r\n");
            
            #line 46 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var constantItem in model.Constants) { 
            
            #line default
            #line hidden
            this.Write("\t\t/// <summary>\r\n        /// ");
            
            #line 48 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n\t\tpublic const ");
            
            #line 50 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 50 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 50 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Value));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 51 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t#endregion\r\n\r\n\t\t#region Properties\r\n");
            
            #line 55 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var propertyItem in model.Properties) { 
            
            #line default
            #line hidden
            this.Write("\t\t/// <summary>\r\n        /// ");
            
            #line 57 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyItem.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n\t\tpublic virtual ");
            
            #line 59 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyItem.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 59 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyItem.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n");
            
            #line 60 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t#endregion\r\n\t}\t\r\n");
            
            #line 63 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 65 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var model in Configuration.Metadata.Models.Where(m => m.Type.Equals("enum"))) { 
            
            #line default
            #line hidden
            this.Write("\t\r\n\t/// <summary>\r\n    /// ");
            
            #line 67 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n    /// </summary>\r\n\tpublic enum ");
            
            #line 69 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 71 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var constantItem in model.Constants) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// <summary>\r\n\t\t/// ");
            
            #line 74 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// </summary>\r\n\t\t");
            
            #line 76 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 76 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(constantItem.Value));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 77 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t}\r\n");
            
            #line 79 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\r\n}\r\n#endregion\r\n \r\nnamespace ");
            
            #line 84 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Namespace));
            
            #line default
            #line hidden
            this.Write(@".Clients
{
/// <summary>
    /// Client base class.
    /// </summary>
	public abstract partial class ClientBase : IDisposable
	{
	    /// <summary>
		/// Gests the HttpClient.
		/// </summary>
		public HttpClient HttpClient { get; private set; }

		/// <summary>
        /// Initializes a new instance of the <see cref=""ClientBase""/> class.
        /// </summary>
		protected ClientBase()
		{
			HttpClient = new HttpClient()
			{
				BaseAddress = new Uri(Configuration.");
            
            #line 103 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Name));
            
            #line default
            #line hidden
            this.Write(@"BaseAddress)
			};

			OnCreated();
		}

		/// <summary>
        /// Initializes a new instance of the <see cref=""ClientBase""/> class.
        /// </summary>
        /// <param name=""handler"">The handler.</param>
        /// <param name=""disposeHandler"">if set to <c>true</c> [dispose handler].</param>
		protected ClientBase(HttpMessageHandler handler, bool disposeHandler = true)
		{
			HttpClient = new HttpClient(handler, disposeHandler)
			{
				BaseAddress = new Uri(Configuration.");
            
            #line 118 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.Name));
            
            #line default
            #line hidden
            this.Write(@"BaseAddress)
			};

			OnCreated();
		}

		/// <summary>
		/// Called when client is created.
		/// </summary>
		partial void OnCreated();

		/// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources.       
        /// </summary>
		public void Dispose()
        {
            HttpClient.Dispose();
        }
	}
");
            
            #line 137 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var definition in Configuration.Metadata.Definitions) { 
            
            #line default
            #line hidden
            this.Write("\t/// <summary>\r\n    /// ");
            
            #line 139 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n    /// </summary>\r\n\tpublic partial class ");
            
            #line 141 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Name));
            
            #line default
            #line hidden
            
            #line 141 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.ClientSuffix));
            
            #line default
            #line hidden
            this.Write(" : ClientBase\r\n\t{\t\t\r\n\r\n\t\t/// <summary>\r\n        /// ");
            
            #line 145 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n\t\tpublic ");
            
            #line 147 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Name));
            
            #line default
            #line hidden
            
            #line 147 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.ClientSuffix));
            
            #line default
            #line hidden
            this.Write("() : base()\r\n\t\t{\r\n\t\t}\r\n\r\n\t\t/// <summary>\r\n        /// ");
            
            #line 152 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n\t\tpublic ");
            
            #line 154 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Name));
            
            #line default
            #line hidden
            
            #line 154 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Configuration.ClientSuffix));
            
            #line default
            #line hidden
            this.Write("(HttpMessageHandler handler, bool disposeHandler = true) : base(handler, disposeH" +
                    "andler)\r\n\t\t{\r\n\t\t}\r\n\r\n\t\t#region Methods\r\n");
            
            #line 159 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var method in definition.ActionMethods) { 
		var allParameters = method.UrlParameters.AsEnumerable().Where(m => m != null);
		
		var queryParameterString = "\"";
		var bodyParameterString = "";


		if (method.BodyParameter != null) {
			allParameters = allParameters.Concat(new [] { method.BodyParameter });
			bodyParameterString = ", " + method.BodyParameter.Name;
		}
	
		var parameterList = "";
		var parameterNameList = "";
		var parametersEncodeList = "";

		if (allParameters.Any())
		{
		var q = allParameters.Select(m => m.Type + " " + m.Name);

		if (q != null)
			parameterList = string.Join(",", q.ToArray());

			parameterNameList =  string.Join(", ", allParameters.Select(m => m.Name));
		}

		var stringParameters = allParameters.Where(t => t.Type.Equals("String", StringComparison.OrdinalIgnoreCase));
		parametersEncodeList = string.Join("\n", stringParameters.Select(t => t.Name + " = HttpUtility.UrlEncode(" + t.Name + ");"));
		
		var postOrPut =  method.Type.ToTitle() == "Post" || method.Type.ToTitle() == "Put";
		var url = method.Url;
		
		if(!String.IsNullOrEmpty(Configuration.RemoveFromUrl)) {
			url = url.Replace(Configuration.RemoveFromUrl, "");
		}
		
		url = ("\"" + url.Replace("{", "\" + ").Replace("}", " + \"") + "\"").Replace(" + \"\"","");
		

            
            #line default
            #line hidden
            this.Write("        /// <summary>\r\n        /// ");
            
            #line 199 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n");
            
            #line 201 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var p in method.UrlParameters) { 
            
            #line default
            #line hidden
            this.Write("\t\t/// <param name=\"");
            
            #line 202 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 202 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Description));
            
            #line default
            #line hidden
            this.Write("</param>\r\n");
            
            #line 203 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        /// <returns></returns>\r\n\t\tpublic virtual async Task<HttpResponseMessage>" +
                    " ");
            
            #line 205 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 205 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterList));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\t");
            
            #line 207 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parametersEncodeList));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn await HttpClient.");
            
            #line 208 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Type.ToTitle()));
            
            #line default
            #line hidden
            
            #line 208 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(postOrPut ? "AsJson" : ""));
            
            #line default
            #line hidden
            this.Write("Async");
            
            #line 208 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(postOrPut && method.BodyParameter != null ? "<" + method.BodyParameter.Type + ">" : ""));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 208 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(url));
            
            #line default
            #line hidden
            
            #line 208 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(bodyParameterString));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\r\n\t\t/// <summary>\r\n        /// ");
            
            #line 212 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Description.ToSummary()));
            
            #line default
            #line hidden
            this.Write("\r\n        /// </summary>\r\n");
            
            #line 214 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 foreach(var p in method.UrlParameters) {
            
            #line default
            #line hidden
            this.Write("\t\t/// <param name=\"");
            
            #line 215 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 215 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Description));
            
            #line default
            #line hidden
            this.Write("</param>\r\n");
            
            #line 216 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        /// <returns></returns>\r\n\t\tpublic virtual ");
            
            #line 218 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(String.IsNullOrEmpty(method.ReturnType) ? "void" : method.ReturnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 218 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 218 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterList));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\t");
            
            #line 220 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"

			var parametersValues = String.IsNullOrEmpty(bodyParameterString) ? (url.IndexOf("+") > -1 ? url.Substring(url.IndexOf("+") + 1) : "") : bodyParameterString.Substring(2);
			
            
            #line default
            #line hidden
            this.Write("\t\t\t var result = Task.Run(() => ");
            
            #line 223 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 223 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterNameList));
            
            #line default
            #line hidden
            this.Write(")).Result;\r\n\t\t\t EnsureSuccess(result);\t\t\t \r\n\t\t\t ");
            
            #line 225 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 if(!String.IsNullOrEmpty(method.ReturnType)) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t \t\t\t \r\n             return result.Content.ReadAsAsync<");
            
            #line 226 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ReturnType));
            
            #line default
            #line hidden
            this.Write(">().Result;\r\n\t\t\t ");
            
            #line 227 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 230 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(@"	    
		#endregion

		#region Private methods
		private void EnsureSuccess(HttpResponseMessage result)
		{
			if (!result.IsSuccessStatusCode)
            {
				throw result.Content.ReadAsAsync<ApiException>().Result;
            }
		}
		#endregion
				
	}
");
            
            #line 244 "C:\Users\giacomelli\Documents\WebApiProxy\WebApiProxy.Tasks\Templates\CSharpProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class CSharpProxyTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}