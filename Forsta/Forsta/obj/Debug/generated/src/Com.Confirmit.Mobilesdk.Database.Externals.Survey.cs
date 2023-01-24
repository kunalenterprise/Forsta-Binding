using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Externals {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/externals/Survey", DoNotGenerateAcw=true)]
	public sealed partial class Survey : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/externals/Survey", typeof (Survey));

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

		internal Survey (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe int CompanyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getCompanyId' and count(parameter)=0]"
			[Register ("getCompanyId", "()I", "")]
			get {
				const string __id = "getCompanyId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyLanguage DefaultLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getDefaultLanguage' and count(parameter)=0]"
			[Register ("getDefaultLanguage", "()Lcom/confirmit/mobilesdk/database/externals/SurveyLanguage;", "")]
			get {
				const string __id = "getDefaultLanguage.()Lcom/confirmit/mobilesdk/database/externals/SurveyLanguage;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyLanguage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyLanguage> Languages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getLanguages' and count(parameter)=0]"
			[Register ("getLanguages", "()Ljava/util/List;", "")]
			get {
				const string __id = "getLanguages.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Confirmit.Mobilesdk.Database.Externals.SurveyLanguage>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getName' and count(parameter)=0]"
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

		public unsafe int PackageVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getPackageVersion' and count(parameter)=0]"
			[Register ("getPackageVersion", "()I", "")]
			get {
				const string __id = "getPackageVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string ServerId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getServerId' and count(parameter)=0]"
			[Register ("getServerId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getServerId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string SurveyId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.externals']/class[@name='Survey']/method[@name='getSurveyId' and count(parameter)=0]"
			[Register ("getSurveyId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSurveyId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
