using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/f", DoNotGenerateAcw=true)]
	public sealed partial class DaoRespondentValuesF : global::Java.Lang.Object, global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/field[@name='a']"
		[Register ("a")]
		public global::AndroidX.Room.RoomDatabase A {
			get {
				const string __id = "a.Landroidx/room/RoomDatabase;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.RoomDatabase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Landroidx/room/RoomDatabase;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/field[@name='b']"
		[Register ("b")]
		public global::AndroidX.Room.EntityInsertionAdapter B {
			get {
				const string __id = "b.Landroidx/room/EntityInsertionAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.EntityInsertionAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Landroidx/room/EntityInsertionAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/field[@name='c']"
		[Register ("c")]
		public global::AndroidX.Room.EntityInsertionAdapter C {
			get {
				const string __id = "c.Landroidx/room/EntityInsertionAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.EntityInsertionAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Landroidx/room/EntityInsertionAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/field[@name='d']"
		[Register ("d")]
		public global::AndroidX.Room.EntityInsertionAdapter D {
			get {
				const string __id = "d.Landroidx/room/EntityInsertionAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.EntityInsertionAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Landroidx/room/EntityInsertionAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/f", typeof (DaoRespondentValuesF));

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

		internal DaoRespondentValuesF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/constructor[@name='f' and count(parameter)=1 and parameter[1][@type='androidx.room.RoomDatabase']]"
		[Register (".ctor", "(Landroidx/room/RoomDatabase;)V", "")]
		public unsafe DaoRespondentValuesF (global::AndroidX.Room.RoomDatabase p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroidx/room/RoomDatabase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues> RespondentValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='getRespondentValue' and count(parameter)=0]"
			[Register ("getRespondentValue", "()Ljava/util/List;", "")]
			get {
				const string __id = "getRespondentValue.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses> Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/util/List;", "")]
			get {
				const string __id = "getResponse.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls> ResponseControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='getResponseControl' and count(parameter)=0]"
			[Register ("getResponseControl", "()Ljava/util/List;", "")]
			get {
				const string __id = "getResponseControl.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='deleteRespondentValue' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("deleteRespondentValue", "(Ljava/util/List;)V", "")]
		public unsafe void DeleteRespondentValue (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "deleteRespondentValue.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='deleteResponseControls' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("deleteResponseControls", "(Ljava/util/List;)V", "")]
		public unsafe void DeleteResponseControls (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "deleteResponseControls.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='deleteResponses' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("deleteResponses", "(Ljava/util/List;)V", "")]
		public unsafe void DeleteResponses (global::System.Collections.Generic.IList<string> p0)
		{
			const string __id = "deleteResponses.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='insertRespondentValue' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.f']]"
		[Register ("insertRespondentValue", "(Lcom/confirmit/mobilesdk/database/providers/room/model/f;)V", "")]
		public unsafe void InsertRespondentValue (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues p0)
		{
			const string __id = "insertRespondentValue.(Lcom/confirmit/mobilesdk/database/providers/room/model/f;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='insertResponse' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.h']]"
		[Register ("insertResponse", "(Lcom/confirmit/mobilesdk/database/providers/room/model/h;)V", "")]
		public unsafe void InsertResponse (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses p0)
		{
			const string __id = "insertResponse.(Lcom/confirmit/mobilesdk/database/providers/room/model/h;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='f']/method[@name='insertResponseControl' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.g']]"
		[Register ("insertResponseControl", "(Lcom/confirmit/mobilesdk/database/providers/room/model/g;)V", "")]
		public unsafe void InsertResponseControl (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls p0)
		{
			const string __id = "insertResponseControl.(Lcom/confirmit/mobilesdk/database/providers/room/model/g;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
