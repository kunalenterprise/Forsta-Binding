using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ScenarioDb']"
	[Register ("com/confirmit/mobilesdk/database/domain/ScenarioDb", "", "Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDbInvoker")]
	public partial interface IScenarioDb : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ScenarioDb']/method[@name='createOrUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V", "GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDbInvoker, Forsta")]
		void CreateOrUpdate (string serverId, string programKey, long scenarioId, string script);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ScenarioDb']/method[@name='createOrUpdateCounter' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
		[Register ("createOrUpdateCounter", "(Ljava/lang/String;JLjava/lang/String;JJJJ)V", "GetCreateOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJHandler:Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDbInvoker, Forsta")]
		void CreateOrUpdateCounter (string serverId, long scenarioId, string surveyId, long currentHourCount, long currentDayCount, long currentWeekCount, long totalCount);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ScenarioDb']/method[@name='deleteScenarios' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteScenarios", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDeleteScenarios_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDbInvoker, Forsta")]
		void DeleteScenarios (string serverId, string programKey);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ScenarioDb']/method[@name='getCounters' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String']]"
		[Register ("getCounters", "(Ljava/lang/String;JLjava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/ScenarioCounter;", "GetGetCounters_Ljava_lang_String_JLjava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDbInvoker, Forsta")]
		global::Com.Confirmit.Mobilesdk.Database.Externals.ScenarioCounter GetCounters (string serverId, long scenarioId, string surveyId);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.domain']/interface[@name='ScenarioDb']/method[@name='getScenarios' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getScenarios", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;", "GetGetScenarios_Ljava_lang_String_Ljava_lang_String_Handler:Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDbInvoker, Forsta")]
		global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Scenario> GetScenarios (string serverId, string programKey);

	}

	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/domain/ScenarioDb", DoNotGenerateAcw=true)]
	internal partial class IScenarioDbInvoker : global::Java.Lang.Object, IScenarioDb {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/domain/ScenarioDb", typeof (IScenarioDbInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IScenarioDb GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScenarioDb> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.confirmit.mobilesdk.database.domain.ScenarioDb'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScenarioDbInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_Handler ()
		{
			if (cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == null)
				cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLJL_V) n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_);
			return cb_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		}

		static void n_CreateOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey, long scenarioId, IntPtr native_script)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			var script = JNIEnv.GetString (native_script, JniHandleOwnership.DoNotTransfer);
			__this.CreateOrUpdate (serverId, programKey, scenarioId, script);
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_;
		public unsafe void CreateOrUpdate (string serverId, string programKey, long scenarioId, string script)
		{
			if (id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createOrUpdate", "(Ljava/lang/String;Ljava/lang/String;JLjava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			IntPtr native_script = JNIEnv.NewString ((string)script);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			__args [2] = new JValue (scenarioId);
			__args [3] = new JValue (native_script);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdate_Ljava_lang_String_Ljava_lang_String_JLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
			JNIEnv.DeleteLocalRef (native_script);
		}

		static Delegate cb_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ;
#pragma warning disable 0169
		static Delegate GetCreateOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJHandler ()
		{
			if (cb_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ == null)
				cb_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJLJJJJ_V) n_CreateOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ);
			return cb_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ;
		}

		static void n_CreateOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, long scenarioId, IntPtr native_surveyId, long currentHourCount, long currentDayCount, long currentWeekCount, long totalCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			__this.CreateOrUpdateCounter (serverId, scenarioId, surveyId, currentHourCount, currentDayCount, currentWeekCount, totalCount);
		}
#pragma warning restore 0169

		IntPtr id_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ;
		public unsafe void CreateOrUpdateCounter (string serverId, long scenarioId, string surveyId, long currentHourCount, long currentDayCount, long currentWeekCount, long totalCount)
		{
			if (id_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ == IntPtr.Zero)
				id_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ = JNIEnv.GetMethodID (class_ref, "createOrUpdateCounter", "(Ljava/lang/String;JLjava/lang/String;JJJJ)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (scenarioId);
			__args [2] = new JValue (native_surveyId);
			__args [3] = new JValue (currentHourCount);
			__args [4] = new JValue (currentDayCount);
			__args [5] = new JValue (currentWeekCount);
			__args [6] = new JValue (totalCount);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createOrUpdateCounter_Ljava_lang_String_JLjava_lang_String_JJJJ, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
		}

		static Delegate cb_deleteScenarios_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteScenarios_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteScenarios_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteScenarios_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DeleteScenarios_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteScenarios_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeleteScenarios_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			__this.DeleteScenarios (serverId, programKey);
		}
#pragma warning restore 0169

		IntPtr id_deleteScenarios_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void DeleteScenarios (string serverId, string programKey)
		{
			if (id_deleteScenarios_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteScenarios_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteScenarios", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteScenarios_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
		}

		static Delegate cb_getCounters_Ljava_lang_String_JLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCounters_Ljava_lang_String_JLjava_lang_String_Handler ()
		{
			if (cb_getCounters_Ljava_lang_String_JLjava_lang_String_ == null)
				cb_getCounters_Ljava_lang_String_JLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJL_L) n_GetCounters_Ljava_lang_String_JLjava_lang_String_);
			return cb_getCounters_Ljava_lang_String_JLjava_lang_String_;
		}

		static IntPtr n_GetCounters_Ljava_lang_String_JLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, long scenarioId, IntPtr native_surveyId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var surveyId = JNIEnv.GetString (native_surveyId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCounters (serverId, scenarioId, surveyId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCounters_Ljava_lang_String_JLjava_lang_String_;
		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.ScenarioCounter GetCounters (string serverId, long scenarioId, string surveyId)
		{
			if (id_getCounters_Ljava_lang_String_JLjava_lang_String_ == IntPtr.Zero)
				id_getCounters_Ljava_lang_String_JLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCounters", "(Ljava/lang/String;JLjava/lang/String;)Lcom/confirmit/mobilesdk/database/externals/ScenarioCounter;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_surveyId = JNIEnv.NewString ((string)surveyId);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (scenarioId);
			__args [2] = new JValue (native_surveyId);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.ScenarioCounter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCounters_Ljava_lang_String_JLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_surveyId);
			return __ret;
		}

		static Delegate cb_getScenarios_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetScenarios_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getScenarios_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getScenarios_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetScenarios_Ljava_lang_String_Ljava_lang_String_);
			return cb_getScenarios_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetScenarios_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serverId, IntPtr native_programKey)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var serverId = JNIEnv.GetString (native_serverId, JniHandleOwnership.DoNotTransfer);
			var programKey = JNIEnv.GetString (native_programKey, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Scenario>.ToLocalJniHandle (__this.GetScenarios (serverId, programKey));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getScenarios_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.Scenario> GetScenarios (string serverId, string programKey)
		{
			if (id_getScenarios_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getScenarios_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getScenarios", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_serverId = JNIEnv.NewString ((string)serverId);
			IntPtr native_programKey = JNIEnv.NewString ((string)programKey);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_serverId);
			__args [1] = new JValue (native_programKey);
			var __ret = global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.Scenario>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScenarios_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_serverId);
			JNIEnv.DeleteLocalRef (native_programKey);
			return __ret;
		}

	}
}
