﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.18444
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Codeer.Friendly.Windows.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Codeer.Friendly.Windows.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] Codeer_Friendly_Windows_Step {
            get {
                object obj = ResourceManager.GetObject("Codeer_Friendly_Windows_Step", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] CodeerFriendlyWindows_x64 {
            get {
                object obj = ResourceManager.GetObject("CodeerFriendlyWindows_x64", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] CodeerFriendlyWindows_x86 {
            get {
                object obj = ResourceManager.GetObject("CodeerFriendlyWindows_x86", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Communication with the application failed.
        ///The target applcation may be unreachable or you may be trying to send
        ///data that cannot be serialized. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorAppCommunication {
            get {
                return ResourceManager.GetString("ErrorAppCommunication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to connect to application. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorAppConnection {
            get {
                return ResourceManager.GetString("ErrorAppConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [type: {0}][operation: {1} ({2})]
        ///The specified operation name was found but could not be carried out.
        ///The arguments could be incorrect.
        ///Note that numerical types and Enums are strictly differentiated.
        ///(For example, even when passing an int as an argument for a long parameter, they are treated as different types and the call fails.)
        ///When calling a method with a params argument, please pass the argument as an array value. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorArgumentInvokeFormat {
            get {
                return ResourceManager.GetString("ErrorArgumentInvokeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [type: {0}][operation: {1} ({2})]
        ///An operation with the specified name was found, but could not be performed.
        ///The specified arguments may be incorrect.
        ///When calling an option with a params argument, please pass the value as an array.
        ///When passing object[] as a parameter, this cannot be distinguished from params object[].
        ///Please pass it as an element of an object[] array in this case.
        ///object[] arg;        // object[] to pass as a single argument.
        ///object[] tmpArg = new object[0];
        ///tmpArg [0] = arg;// P [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorArgumentInvokeFormatForObjectArray {
            get {
                return ResourceManager.GetString("ErrorArgumentInvokeFormatForObjectArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   If you use AttachOtherDomains, .netframework4.0 must be installed. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorAttachOtherDomainsNeedNet4 {
            get {
                return ResourceManager.GetString("ErrorAttachOtherDomainsNeedNet4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The file in use is in an invalid state and could not be deleted. Please manually delete the following file. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorBinaryInstall {
            get {
                return ResourceManager.GetString("ErrorBinaryInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to connect to the specified process.
        ///Installation may have failed. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorDllLoad {
            get {
                return ResourceManager.GetString("ErrorDllLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Communication with the application failed.
        ///The indicated window in the target thread does not exist or has already been disposed.
        ///In applications that display a splash window, the main window may have become a splash window immediately after starting.
        ///Please specify the handle of the expected window of explicitly. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorExecuteThreadWindowHandle {
            get {
                return ResourceManager.GetString("ErrorExecuteThreadWindowHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Permission to write within the ProgramData folder appears to be denied. Codeer.Friendly creates a ProgramData/Codeer.Friendly and several files within that folder during initialization. Please give your test project write permission to this folder. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorFriendlySystem {
            get {
                return ResourceManager.GetString("ErrorFriendlySystem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   There was a call from an unexpected thread. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorInvalidThreadCall {
            get {
                return ResourceManager.GetString("ErrorInvalidThreadCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [new {0}({1})]
        ///More than one constructor matching the specified arguments was found.
        ///Please clarify the arguments&apos; types or use OperationTypeInfo. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorManyFoundConstractorFormat {
            get {
                return ResourceManager.GetString("ErrorManyFoundConstractorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [type: {0}][operation: {1} ({2})]
        ///More than one operation matching the specified arguments was found.
        ///Please clarify arguments&apos; types or use OperationTypeInfo. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorManyFoundInvokeFormat {
            get {
                return ResourceManager.GetString("ErrorManyFoundInvokeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [new {0}({1})]
        ///The constructor was not found.
        ///The arguments specified may be incorrect.
        ///Note that numerical types and Enums are strictly differentiated.
        ///(For example, even when passing an int as an argument for a long parameter, they are treated as different types and the call fails.)
        ///When calling a method with a params argument, please pass the argument as an array value. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorNotFoundConstractorFormat {
            get {
                return ResourceManager.GetString("ErrorNotFoundConstractorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [new {0}({1})]
        ///A constructor was not found.
        ///The arguments specified may be incorrect.
        ///When calling an option with a params argument, please pass the value as an array.
        ///When passing object[] as a parameter, this cannot be distinguished from params object[].
        ///Please pass it as an element of an object[] array in this case.
        ///object[] arg;       // object[] to pass as a singl argument
        ///object[] tmpArg = new object[0];
        ///tmpArg [0] = arf // please pass tmpArg after doing this に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorNotFoundConstractorFormatForObjectArray {
            get {
                return ResourceManager.GetString("ErrorNotFoundConstractorFormatForObjectArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [type : {0}][operation : {1} ({2})]
        ///The selected operation was not found. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorNotFoundInvokeFormat {
            get {
                return ResourceManager.GetString("ErrorNotFoundInvokeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [OperationTypeInfo.Arguments: ({0})][argument : ({1})]
        ///The specified arguments are incorrect. The number of arguments do not match the number expected by the type.
        ///When calling a method with a params parameter, please place the arguments in an array. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorOperationTypeArgInfoFormat {
            get {
                return ResourceManager.GetString("ErrorOperationTypeArgInfoFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [OperationTypeInfo.Arguments: ({0})] [argument : ({1})]
        ///The specified arguments are incorrect. The number of arguments do not match the number expected by the type.
        ///When calling a method with a params parameter, please place the arguments in an array.
        ///When passing object[] as a parameter, this cannot be distinguished from params object[].
        ///Please pass it as an element of an object[] array in this case.
        ///object[] arg;         // object[] to pass
        ///object[] tmpArg = new object[0];
        ///tmpArg [0] = arg; // plea [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorOperationTypeArgInfoForObjectArrayFormat {
            get {
                return ResourceManager.GetString("ErrorOperationTypeArgInfoForObjectArrayFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Attempt to manipulate the specified process failed. One of the following could be the cause: (1) The specified CLR version is incorrect. (2) Permissions to manipulate the target process are insufficient. (3) The target process terminated during connection. (4) The window for the specified window handle was disposed. 
        ///In applications that display a splash window, the main window may have become a splash window immediately after starting.
        ///Please specify the handle of the expected window of explicitly. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorProcessAcess {
            get {
                return ResourceManager.GetString("ErrorProcessAcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Permissions to manipulate the target process are insufficient. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorProcessOperation {
            get {
                return ResourceManager.GetString("ErrorProcessOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Platform targets differ between the test target and test process. Please ensure they are the same. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorTargetCpuDifference {
            get {
                return ResourceManager.GetString("ErrorTargetCpuDifference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Failed to detect the CLR version. Multiple CLRs may be loaded in the target application. Please explicitly specify the CLR version in the constructor. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ErrorUnpredicatableClrVersion {
            get {
                return ResourceManager.GetString("ErrorUnpredicatableClrVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The selected variable does not implement IEnumerable. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string HasNotEnumerable {
            get {
                return ResourceManager.GetString("HasNotEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   An operation was executed on an AppVar containing a null value. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string NullObjectOperation {
            get {
                return ResourceManager.GetString("NullObjectOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The CLR version string was replaced. The specified string is deprecated. Please use the post-replacement version string (official CLR version string) or the version of the constructor that does not take a CLR version. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ObsoleteClrOrder {
            get {
                return ResourceManager.GetString("ObsoleteClrOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The maximum of the number of concurrent transmissions has been exceeded. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string OutOfCommunicationNo {
            get {
                return ResourceManager.GetString("OutOfCommunicationNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   The available variable space in the application was exceeded. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string OutOfMemory {
            get {
                return ResourceManager.GetString("OutOfMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [{0}]
        ///The selected type was not found.
        ///The specified type&apos;s full name is incorrect or the module containing the type has not yet been loaded. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string UnknownTypeInfoFormat {
            get {
                return ResourceManager.GetString("UnknownTypeInfoFormat", resourceCulture);
            }
        }
    }
}
