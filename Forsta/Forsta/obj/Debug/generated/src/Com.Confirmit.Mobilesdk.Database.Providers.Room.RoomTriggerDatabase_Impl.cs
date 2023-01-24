using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/RoomTriggerDatabase_Impl", DoNotGenerateAcw=true)]
	public sealed partial class RoomTriggerDatabase_Impl : global::Com.Confirmit.Mobilesdk.Database.Providers.Room.RoomTriggerDatabase {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramDao RoomPrefDaoObjA {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramDao;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramDao> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramDao;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/field[@name='b']"
		[Register ("b")]
		public global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao RoomProgramPrefDaoObjB {
			get {
				const string __id = "b.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/field[@name='c']"
		[Register ("c")]
		public global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao RoomScenarioDaoObjC {
			get {
				const string __id = "c.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/field[@name='d']"
		[Register ("d")]
		public global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao RoomScenarioCounterDaoObjC {
			get {
				const string __id = "d.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/RoomTriggerDatabase_Impl", typeof (RoomTriggerDatabase_Impl));

		internal static new IntPtr class_ref {
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

		internal RoomTriggerDatabase_Impl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/constructor[@name='RoomTriggerDatabase_Impl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RoomTriggerDatabase_Impl () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		protected override unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>> RequiredTypeConverters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='getRequiredTypeConverters' and count(parameter)=0]"
			[Register ("getRequiredTypeConverters", "()Ljava/util/Map;", "")]
			get {
				const string __id = "getRequiredTypeConverters.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Java.Lang.Class, global::System.Collections.Generic.IList<global::Java.Lang.Class>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramDao;", "")]
		public override unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramDao A ()
		{
			const string __id = "a.()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramDao;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramDao> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao;", "")]
		public override unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao B ()
		{
			const string __id = "b.()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomProgramPrefDao;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomProgramPrefDao> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao;", "")]
		public override unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao C ()
		{
			const string __id = "c.()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioCounterDao;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioCounterDao> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='clearAllTables' and count(parameter)=0]"
		[Register ("clearAllTables", "()V", "")]
		public override unsafe void ClearAllTables ()
		{
			const string __id = "clearAllTables.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='createInvalidationTracker' and count(parameter)=0]"
		[Register ("createInvalidationTracker", "()Landroidx/room/InvalidationTracker;", "")]
		protected override unsafe global::AndroidX.Room.InvalidationTracker CreateInvalidationTracker ()
		{
			const string __id = "createInvalidationTracker.()Landroidx/room/InvalidationTracker;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.InvalidationTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='createOpenHelper' and count(parameter)=1 and parameter[1][@type='androidx.room.DatabaseConfiguration']]"
		[Register ("createOpenHelper", "(Landroidx/room/DatabaseConfiguration;)Landroidx/sqlite/db/SupportSQLiteOpenHelper;", "")]
		protected override unsafe global::AndroidX.Sqlite.Db.ISupportSQLiteOpenHelper CreateOpenHelper (global::AndroidX.Room.DatabaseConfiguration p0)
		{
			const string __id = "createOpenHelper.(Landroidx/room/DatabaseConfiguration;)Landroidx/sqlite/db/SupportSQLiteOpenHelper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Sqlite.Db.ISupportSQLiteOpenHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao;", "")]
		public override unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao D ()
		{
			const string __id = "d.()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomScenarioDao;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomScenarioDao> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomTriggerDatabase_Impl']/method[@name='getAutoMigrations' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Class&lt;? extends androidx.room.migration.AutoMigrationSpec&gt;, androidx.room.migration.AutoMigrationSpec&gt;']]"
		[Register ("getAutoMigrations", "(Ljava/util/Map;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::AndroidX.Room.Migration.Migration> RoomTriggerDatabaseImplGetAutoMigrations (global::System.Collections.Generic.IDictionary<global::Java.Lang.Class, global::AndroidX.Room.Migration.IAutoMigrationSpec> p0)
		{
			const string __id = "getAutoMigrations.(Ljava/util/Map;)Ljava/util/List;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Class, global::AndroidX.Room.Migration.IAutoMigrationSpec>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::AndroidX.Room.Migration.Migration>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
