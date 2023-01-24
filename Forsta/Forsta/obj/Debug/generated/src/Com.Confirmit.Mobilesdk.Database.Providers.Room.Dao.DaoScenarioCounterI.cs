using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/dao/i", DoNotGenerateAcw=true)]
	public sealed partial class DaoScenarioCounterI : global::Java.Lang.Object, global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomServerDao {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/field[@name='a']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/field[@name='b']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/field[@name='c']"
		[Register ("c")]
		public global::AndroidX.Room.EntityDeletionOrUpdateAdapter C {
			get {
				const string __id = "c.Landroidx/room/EntityDeletionOrUpdateAdapter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.EntityDeletionOrUpdateAdapter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Landroidx/room/EntityDeletionOrUpdateAdapter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/field[@name='d']"
		[Register ("d")]
		public global::AndroidX.Room.SharedSQLiteStatement D {
			get {
				const string __id = "d.Landroidx/room/SharedSQLiteStatement;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.SharedSQLiteStatement> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Landroidx/room/SharedSQLiteStatement;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/dao/i", typeof (DaoScenarioCounterI));

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

		internal DaoScenarioCounterI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/constructor[@name='i' and count(parameter)=1 and parameter[1][@type='androidx.room.RoomDatabase']]"
		[Register (".ctor", "(Landroidx/room/RoomDatabase;)V", "")]
		public unsafe DaoScenarioCounterI (global::AndroidX.Room.RoomDatabase p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='_deleteAll' and count(parameter)=0]"
		[Register ("_deleteAll", "()V", "")]
		public unsafe void _deleteAll ()
		{
			const string __id = "_deleteAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers> Get ()
		{
			const string __id = "get.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/k;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers Get (string p0)
		{
			const string __id = "get.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/k;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='getByName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getByName", "(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/k;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers GetByName (string p0)
		{
			const string __id = "getByName.(Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/k;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='getBySecret' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getBySecret", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/k;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers GetBySecret (string p0, string p1, string p2)
		{
			const string __id = "getBySecret.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/providers/room/model/k;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.k']]"
		[Register ("insert", "(Lcom/confirmit/mobilesdk/database/providers/room/model/k;)V", "")]
		public unsafe void Insert (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers p0)
		{
			const string __id = "insert.(Lcom/confirmit/mobilesdk/database/providers/room/model/k;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.dao']/class[@name='i']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.model.k']]"
		[Register ("update", "(Lcom/confirmit/mobilesdk/database/providers/room/model/k;)V", "")]
		public unsafe void Update (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers p0)
		{
			const string __id = "update.(Lcom/confirmit/mobilesdk/database/providers/room/model/k;)V";
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
