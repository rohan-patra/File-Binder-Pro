﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dream_AIO.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dream_AIO.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap about {
            get {
                object obj = ResourceManager.GetObject("about", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap accept_button {
            get {
                object obj = ResourceManager.GetObject("accept_button", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap arrow_refresh {
            get {
                object obj = ResourceManager.GetObject("arrow_refresh", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap edit_button {
            get {
                object obj = ResourceManager.GetObject("edit_button", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap file_manager {
            get {
                object obj = ResourceManager.GetObject("file_manager", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///using System.IO;
        ///using System.Reflection;
        ///using System.Resources;
        ///using System.Runtime.InteropServices;
        ///using System.Windows.Forms;
        ///
        ////*ASM_INFO*/
        ///
        ///namespace Loader
        ///{
        ///  
        ///    static class Program
        ///    {
        ///        /// &lt;summary&gt;
        ///        /// The main entry point for the application.
        ///        /// &lt;/summary&gt;
        ///        [STAThread]
        ///        static void Main()
        ///        {
        ///
        ///            byte[] dll = (byte[])GetResource(&quot;%RESNAME%&quot;,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Loader {
            get {
                return ResourceManager.GetString("Loader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap package_go {
            get {
                object obj = ResourceManager.GetObject("package_go", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pencil {
            get {
                object obj = ResourceManager.GetObject("pencil", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pencil_add {
            get {
                object obj = ResourceManager.GetObject("pencil_add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pencil_delete {
            get {
                object obj = ResourceManager.GetObject("pencil_delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap reading_view {
            get {
                object obj = ResourceManager.GetObject("reading_view", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //#define ENCRYPTION
        /////#define COMPRESSION
        /////#define BINDER
        /////#define DOWNLOADER
        ///using System;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///using System.Diagnostics;
        ///using System.IO;
        ///using System.Net;
        ///using System.Reflection;
        ///using System.Resources;
        ///using System.Security.Cryptography;
        ///using System.Text;
        ///
        ///namespace Worker
        ///{
        ///    public class Worker
        ///    {
        ///
        ///        //Downloads stored as base64
        ///
        ///        private Assembly Asm;
        ///
        ///        public Worker(Type t)
        ///        {
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Worker {
            get {
                return ResourceManager.GetString("Worker", resourceCulture);
            }
        }
    }
}
