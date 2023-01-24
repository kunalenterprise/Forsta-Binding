using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomResponseDatabase']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/RoomResponseDatabase", DoNotGenerateAcw=true)]
	public abstract partial class RoomResponseDatabase : global::AndroidX.Room.RoomDatabase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/RoomResponseDatabase", typeof (RoomResponseDatabase));

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

		protected RoomResponseDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomResponseDatabase']/constructor[@name='RoomResponseDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RoomResponseDatabase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.RoomResponseDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomResponseDatabase']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomCustomDataDao;", "GetAHandler")]
		public abstract global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomCustomDataDao A ();

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.RoomResponseDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.B ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomResponseDatabase']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomResponseDao;", "GetBHandler")]
		public abstract global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao B ();

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/RoomResponseDatabase", DoNotGenerateAcw=true)]
	internal partial class RoomResponseDatabaseInvoker : RoomResponseDatabase {
		public RoomResponseDatabaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/RoomResponseDatabase", typeof (RoomResponseDatabaseInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomResponseDatabase']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomCustomDataDao;", "GetAHandler")]
		public override unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomCustomDataDao A ()
		{
			const string __id = "a.()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomCustomDataDao;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomCustomDataDao> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomResponseDatabase']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomResponseDao;", "GetBHandler")]
		public override unsafe global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao B ()
		{
			const string __id = "b.()Lcom/confirmit/mobilesdk/database/providers/room/dao/RoomResponseDao;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.IRoomResponseDao> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		[Register ("clearAllTables", "()V", "GetClearAllTablesHandler")]
		public override unsafe void ClearAllTables ()
		{
			const string __id = "clearAllTables.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		[Register ("createInvalidationTracker", "()Landroidx/room/InvalidationTracker;", "GetCreateInvalidationTrackerHandler")]
		protected override unsafe global::AndroidX.Room.InvalidationTracker CreateInvalidationTracker ()
		{
			const string __id = "createInvalidationTracker.()Landroidx/room/InvalidationTracker;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Room.InvalidationTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		[Register ("createOpenHelper", "(Landroidx/room/DatabaseConfiguration;)Landroidx/sqlite/db/SupportSQLiteOpenHelper;", "GetCreateOpenHelper_Landroidx_room_DatabaseConfiguration_Handler")]
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

	}
}
