using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/domain/l", DoNotGenerateAcw=true)]
	public sealed partial class ProvidersRoomDomainL : global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainA, global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/domain/l", typeof (ProvidersRoomDomainL));

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

		internal ProvidersRoomDomainL (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/constructor[@name='l' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.b']]"
		[Register (".ctor", "(Lcom/confirmit/mobilesdk/database/providers/room/b;)V", "")]
		public unsafe ProvidersRoomDomainL (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.ProvidersRoomB p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> DeletedSurveyList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='getDeletedSurveyList' and count(parameter)=0]"
			[Register ("getDeletedSurveyList", "()Ljava/util/List;", "")]
			get {
				const string __id = "getDeletedSurveyList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> SurveyList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='getSurveyList' and count(parameter)=0]"
			[Register ("getSurveyList", "()Ljava/util/List;", "")]
			get {
				const string __id = "getSurveyList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.database.providers.room.domain.l'] and parameter[2][@type='com.confirmit.mobilesdk.database.providers.room.model.l']]"
		[Register ("a", "(Lcom/confirmit/mobilesdk/database/providers/room/domain/l;Lcom/confirmit/mobilesdk/database/providers/room/model/l;)Lcom/confirmit/mobilesdk/database/externals/Survey;", "")]
		public static unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Survey ProvidersRoomDomainLFuncA (global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainL p0, global::Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys p1)
		{
			const string __id = "a.(Lcom/confirmit/mobilesdk/database/providers/room/domain/l;Lcom/confirmit/mobilesdk/database/providers/room/model/l;)Lcom/confirmit/mobilesdk/database/externals/Survey;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='cleanupSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("cleanupSurvey", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void CleanupSurvey (string p0, string p1)
		{
			const string __id = "cleanupSurvey.(Ljava/lang/String;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='createOrUpdate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='com.confirmit.mobilesdk.surveyengine.packages.a'] and parameter[5][@type='boolean']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;ILcom/confirmit/mobilesdk/surveyengine/packages/a;Z)V", "")]
		public unsafe void CreateOrUpdate (string p0, string p1, int p2, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA p3, bool p4)
		{
			const string __id = "createOrUpdate.(Ljava/lang/String;Ljava/lang/String;ILcom/confirmit/mobilesdk/surveyengine/packages/a;Z)V";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='deleteSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteSurvey", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void DeleteSurvey (string p0, string p1)
		{
			const string __id = "deleteSurvey.(Ljava/lang/String;Ljava/lang/String;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room.domain']/class[@name='l']/method[@name='getSurvey' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSurvey", "(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Survey;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.Survey GetSurvey (string p0, string p1)
		{
			const string __id = "getSurvey.(Ljava/lang/String;Ljava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/Survey;";
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.Survey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
