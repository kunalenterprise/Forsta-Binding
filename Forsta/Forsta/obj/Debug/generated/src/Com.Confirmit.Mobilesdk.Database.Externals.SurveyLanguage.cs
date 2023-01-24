using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Externals {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyLanguage']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/externals/SurveyLanguage", DoNotGenerateAcw=true)]
	public sealed partial class SurveyLanguage : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/externals/SurveyLanguage", typeof (SurveyLanguage));

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

		internal SurveyLanguage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyLanguage']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyLanguage']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "")]
			get {
				const string __id = "getId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsDefault {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyLanguage']/method[@name='isDefault' and count(parameter)=0]"
			[Register ("isDefault", "()Z", "")]
			get {
				const string __id = "isDefault.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyLanguage']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string NativeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='SurveyLanguage']/method[@name='getNativeName' and count(parameter)=0]"
			[Register ("getNativeName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getNativeName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
