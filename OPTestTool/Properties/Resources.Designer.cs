﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace OPTestTool.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OPTestTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Cursor {
            get {
                object obj = ResourceManager.GetObject("Cursor", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap CursorAll {
            get {
                object obj = ResourceManager.GetObject("CursorAll", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap CursorAll1 {
            get {
                object obj = ResourceManager.GetObject("CursorAll1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap CursorNotAll {
            get {
                object obj = ResourceManager.GetObject("CursorNotAll", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Desktop {
            get {
                object obj = ResourceManager.GetObject("Desktop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap exefalse {
            get {
                object obj = ResourceManager.GetObject("exefalse", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap exetrue {
            get {
                object obj = ResourceManager.GetObject("exetrue", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap HiddenWindow {
            get {
                object obj = ResourceManager.GetObject("HiddenWindow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 // libop的声明
        ////*
        ///所有op的开放接口都从此cpp类衍生而出
        ///*/
        ///#pragma once
        ///#include &lt;string&gt;
        /////forward declare
        /////class WinApi;
        /////class opBackground;
        /////class ImageProc;
        ///struct op_context;
        ///
        ///#ifdef U_STATIC_IMPLEMENTATION
        ///#define OP_API
        ///#else
        ///#ifndef OP_API 
        ///#if defined(OP_EXPORTS)
        ///#define OP_API __declspec(dllexport)
        ///#else
        ///#define OP_API __declspec(dllimport)
        ///#endif
        ///#endif
        ///#endif
        ///// libop
        ///#undef FindWindow
        ///#undef FindWindowEx
        ///#undef SetWindowText
        ///
        ///class OP_API libop{
        ///	
        ///public:
        ///	
        ///	libop();
        ///	~libop(); [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string libop {
            get {
                return ResourceManager.GetString("libop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 // op.idl: op 的 IDL 源
        /////
        ///
        ///// 此文件将由 MIDL 工具处理以
        ///// 生成类型库(op.tlb)和封送处理代码。
        ///
        ///import &quot;oaidl.idl&quot;;
        ///import &quot;ocidl.idl&quot;;
        /////
        /////[
        /////	object,
        /////	uuid(a817e7a2-43fa-11d0-9e44-00aa00b6770a),
        /////	dual,
        /////	pointer_default(unique)
        /////]
        /////interface IComponentRegistrar : IDispatch
        /////{
        /////	[id(1)]	HRESULT Attach([in] BSTR bstrPath);
        /////	[id(2)]	HRESULT RegisterAll();
        /////	[id(3)]	HRESULT UnregisterAll();
        /////	[id(4)]	HRESULT GetComponents([out] SAFEARRAY(BSTR)* pbstrCLSIDs, [out] SAFEARRAY(BSTR)* pbstrDescriptions) [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string op {
            get {
                return ResourceManager.GetString("op", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap Window {
            get {
                object obj = ResourceManager.GetObject("Window", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
