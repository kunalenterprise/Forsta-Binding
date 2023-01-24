using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ConfirmitServer", DoNotGenerateAcw=true)]
	public sealed partial class ConfirmitServer : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Confirmit.Mobilesdk.ConfirmitServer Instance {
			get {
				const string __id = "INSTANCE.Lcom/confirmit/mobilesdk/ConfirmitServer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.ConfirmitServer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ConfirmitServer", typeof (ConfirmitServer));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal ConfirmitServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server AUSTRALIA {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getAUSTRALIA' and count(parameter)=0]"
			[Register ("getAUSTRALIA", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getAUSTRALIA.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server CANADA {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getCANADA' and count(parameter)=0]"
			[Register ("getCANADA", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getCANADA.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server GERMANY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getGERMANY' and count(parameter)=0]"
			[Register ("getGERMANY", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getGERMANY.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server HX_PLATFORM {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getHX_PLATFORM' and count(parameter)=0]"
			[Register ("getHX_PLATFORM", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getHX_PLATFORM.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server INSIGHTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getINSIGHTS' and count(parameter)=0]"
			[Register ("getINSIGHTS", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getINSIGHTS.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server NORDIC {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getNORDIC' and count(parameter)=0]"
			[Register ("getNORDIC", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getNORDIC.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> Servers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getServers' and count(parameter)=0]"
			[Register ("getServers", "()Ljava/util/List;", "")]
			get {
				const string __id = "getServers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Server>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server UK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getUK' and count(parameter)=0]"
			[Register ("getUK", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getUK.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server US {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getUS' and count(parameter)=0]"
			[Register ("getUS", "()Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
			get {
				const string __id = "getUS.()Lcom/confirmit/mobilesdk/database/externals/Server;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configure' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("configure", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server Configure (string name, string host, string clientId, string clientSecret)
		{
			const string __id = "configure.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;";
			IntPtr native_name = JNIEnv.NewString ((string)name);
			IntPtr native_host = JNIEnv.NewString ((string)host);
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_host);
				__args [2] = new JniArgumentValue (native_clientId);
				__args [3] = new JniArgumentValue (native_clientSecret);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_host);
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureAustralia' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureAustralia", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureAustralia (string clientId, string clientSecret)
		{
			const string __id = "configureAustralia.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureCanada' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureCanada", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureCanada (string clientId, string clientSecret)
		{
			const string __id = "configureCanada.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureGermany' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureGermany", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureGermany (string clientId, string clientSecret)
		{
			const string __id = "configureGermany.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureHxPlatform' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureHxPlatform", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureHxPlatform (string clientId, string clientSecret)
		{
			const string __id = "configureHxPlatform.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureInsights' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureInsights", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureInsights (string clientId, string clientSecret)
		{
			const string __id = "configureInsights.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureNordic' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureNordic", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureNordic (string clientId, string clientSecret)
		{
			const string __id = "configureNordic.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureUK' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureUK", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureUK (string clientId, string clientSecret)
		{
			const string __id = "configureUK.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='configureUS' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("configureUS", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void ConfigureUS (string clientId, string clientSecret)
		{
			const string __id = "configureUS.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_clientId = JNIEnv.NewString ((string)clientId);
			IntPtr native_clientSecret = JNIEnv.NewString ((string)clientSecret);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_clientId);
				__args [1] = new JniArgumentValue (native_clientSecret);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_clientId);
				JNIEnv.DeleteLocalRef (native_clientSecret);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk']/class[@name='ConfirmitServer']/method[@name='getServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getServer", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Server GetServer (string serverId)
		{
			const string __id = "getServer.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Server;";
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_serverId);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Server> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverId);
			}
		}

	}
}
