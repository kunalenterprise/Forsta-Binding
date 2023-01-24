using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/domain/j", DoNotGenerateAcw=true)]
	public sealed partial class ProvidersRoomDomainJ : global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainD, global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/domain/j", typeof (ProvidersRoomDomainJ));

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

		internal ProvidersRoomDomainJ (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']/constructor[@name='j' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.b']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/database/providers/room/b;)V", "")]
		public unsafe ProvidersRoomDomainJ (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.ProvidersRoomB p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/confirmit/mobilesdk/database/providers/room/b;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']/method[@name='createOrUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "")]
		public unsafe void CreateOrUpdate (string p0, string p1, long p2, string p3)
		{
			const string __id = "createOrUpdate.(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']/method[@name='createOrUpdateCounter' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
		[Register ("createOrUpdateCounter", "(Ljava/lang/String;JLjava/lang/String;JJJJ)V", "")]
		public unsafe void CreateOrUpdateCounter (string p0, long p1, string p2, long p3, long p4, long p5, long p6)
		{
			const string __id = "createOrUpdateCounter.(Ljava/lang/String;JLjava/lang/String;JJJJ)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']/method[@name='deleteScenarios' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteScenarios", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void DeleteScenarios (string p0, string p1)
		{
			const string __id = "deleteScenarios.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']/method[@name='getCounters' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("getCounters", "(Ljava/lang/String;JLjava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/ScenarioCounter;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.ScenarioCounter GetCounters (string p0, long p1, string p2)
		{
			const string __id = "getCounters.(Ljava/lang/String;JLjava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/ScenarioCounter;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.ScenarioCounter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='j']/method[@name='getScenarios' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getScenarios", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Scenario> GetScenarios (string p0, string p1)
		{
			const string __id = "getScenarios.(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Scenario>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
