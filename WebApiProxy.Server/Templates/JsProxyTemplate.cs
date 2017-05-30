﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace WebApiProxy.Server.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class JsProxyTemplate : JsProxyTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n(function($) {\r\n\t\"use strict\";\r\n\r\n\tif (!$) {\r\n\t\tthrow \"jQuery is required\";\r\n\t}" +
                    "\r\n\r\n\t$.proxies = $.proxies || { \r\n\t\tbaseUrl: \"");
            
            #line 15 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Metadata.Host));
            
            #line default
            #line hidden
            this.Write("\"\r\n\t};\r\n\r\n\tfunction getQueryString(params, queryString) {\r\n\t\tqueryString = queryS" +
                    "tring || \"\";\r\n\t\tfor(var prop in params) {\r\n\t\t\tif (params.hasOwnProperty(prop)) {" +
                    "\r\n\t\t\t\tvar val = getArgValue(params[prop]);\r\n\t\t\t\tif (val === null) continue;\r\n\r\n\t" +
                    "\t\t\tif (\"\" + val === \"[object Object]\") {\r\n\t\t\t\t\tqueryString = getQueryString(para" +
                    "ms[prop], queryString);\r\n\t\t\t\t\tcontinue;\r\n\t\t\t\t}\r\n\r\n\t\t\t\tif (queryString.length) {\r" +
                    "\n\t\t\t\t\tqueryString += \"&\";\r\n\t\t\t\t} else {\r\n\t\t\t\t\tqueryString += \"?\";\r\n\t\t\t\t}\r\n\t\t\t\tqu" +
                    "eryString = queryString + prop + \"=\" +val;\r\n\t\t\t}\r\n\t\t}\r\n\t\treturn queryString;\r\n\t}" +
                    "\r\n\r\n\tfunction getArgValue(val) {\r\n\t\tif (val === undefined || val === null) retur" +
                    "n null;\r\n\t\treturn val;\r\n\t}\r\n\r\n\tfunction invoke(url, type, urlParams, body) {\r\n\t\t" +
                    "//url += getQueryString(urlParams);\r\n\r\n\t\tvar ajaxOptions = $.extend({}, this.def" +
                    "aultOptions, {\r\n\t\t\turl: $.proxies.baseUrl + url,\r\n\t\t\ttype: type,\r\n\t\t\tbeforeSend " +
                    ": function(xhr) {\r\n\t\t\t\tif (typeof(webApiAuthToken) != \"undefined\" && webApiAuthT" +
                    "oken.length > 0)\r\n\t\t\t\t\txhr.setRequestHeader(\"Authorization\", \"Bearer \" + webApiA" +
                    "uthToken);\r\n\t\t\t},\r\n\t\t});\r\n\r\n\t\tif (body) {\r\n\t\t\tajaxOptions.data = body;\r\n\t\t}\r\n\r\n\t" +
                    "\tif (this.antiForgeryToken) {\r\n\t\t\tvar token = $.isFunction(this.antiForgeryToken" +
                    ") ? this.antiForgeryToken() : this.antiForgeryToken;\r\n\t\t\tif (token) {\r\n\t\t\t\tajaxO" +
                    "ptions.headers = ajaxOptions.headers || {};\r\n\t\t\t}\r\n\t\t}\r\n\t\r\n\t\treturn $.ajax(ajaxO" +
                    "ptions);\r\n\t}\r\n\r\n\tfunction defaultAntiForgeryTokenAccessor() {\r\n\t\treturn $(\"input" +
                    "[name=__RequestVerificationToken]\").val();\r\n\t}\r\n\r\n\tfunction endsWith(str, suffix" +
                    ") {\r\n\t\treturn str.indexOf(suffix, str.length - suffix.length) !== -1;\r\n\t}\r\n\r\n\tfu" +
                    "nction appendPathDelimiter(url){\r\n\t\tif(!endsWith(url, \'/\')){\r\n\t\t\treturn url + \'/" +
                    "\';\r\n\t\t}\r\n\t\t\r\n\t\treturn url;\r\n\t}\r\n\r\n\t/* Proxies */\r\n\r\n\t");
            
            #line 90 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 foreach(var definition in this.Metadata.Definitions) { 
            
            #line default
            #line hidden
            this.Write("\t$.proxies.");
            
            #line 91 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(definition.Name.ToLower()));
            
            #line default
            #line hidden
            this.Write(" = {\r\n\t\tdefaultOptions: {},\r\n\t\tantiForgeryToken: defaultAntiForgeryTokenAccessor," +
                    "\r\n");
            
            #line 94 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 foreach(var method in definition.ActionMethods) { 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 96 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"

	var allParameters = method.UrlParameters.AsEnumerable();
	
	if (method.BodyParameter != null) {
		allParameters = allParameters.Concat(new [] { method.BodyParameter });
	}
	var selectedParameters = allParameters.Where(m => m != null).Select(m => m.Name).ToList();
	selectedParameters.Add("options");

	var parameterList = string.Join(",", selectedParameters);

	
	
	var url = ("\"" + method.Url.Replace("{", "\" + ").Replace("}", " + \"") + "\"").Replace(" + \"\"","");


            
            #line default
            #line hidden
            this.Write("\r\n\r\n\t");
            
            #line 114 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name.ToCamelCasing()));
            
            #line default
            #line hidden
            this.Write(": function(");
            
            #line 114 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterList));
            
            #line default
            #line hidden
            this.Write(") {\r\n\t\t var defaults = { fields: [] };\r\n         var settings = $.extend({}, defa" +
                    "ults, options || {});\r\n\t\t var url = ");
            
            #line 117 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(url));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\t\t if(settings.fields.length > 0) {\r\n\t\t    url +=  url.indexOf(\"?\") == -1 ? " +
                    "\"?\" : \"&\";\r\n\t\t\turl += \"fields=\" + settings.fields.join();\r\n\t\t }\r\n\r\n\t\treturn invo" +
                    "ke.call(this, url, \"");
            
            #line 124 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Type.ToString().ToLower()));
            
            #line default
            #line hidden
            this.Write("\", \r\n\t\t");
            
            #line 125 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 if (method.UrlParameters.Any()) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t{\r\n\t\t\t");
            
            #line 127 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 foreach (var parameter in method.UrlParameters) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t");
            
            #line 128 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 128 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(",\r\n\t\t\t");
            
            #line 129 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t}\r\n\t\t");
            
            #line 131 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t{}\r\n\t\t");
            
            #line 133 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 134 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 if (method.BodyParameter != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t, ");
            
            #line 135 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.BodyParameter.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t");
            
            #line 136 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t);\r\n\t\t");
            
            #line 138 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t},\r\n");
            
            #line 140 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n};\r\n\t");
            
            #line 142 "D:\Development\WebApiProxy\WebApiProxy.Server\Templates\JsProxyTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("}(jQuery));\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class JsProxyTemplateBase
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
