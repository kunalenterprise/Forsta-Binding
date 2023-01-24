using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Surveyengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/surveyengine/i", DoNotGenerateAcw=true)]
	public sealed partial class SurveyengineI : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='a']"
		[Register ("a")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineModule SurveyEngineIObjA {
			get {
				const string __id = "a.Lcom/confirmit/mobilesdk/surveyengine/EngineModule;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/confirmit/mobilesdk/surveyengine/EngineModule;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='b']"
		[Register ("b")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersO SurveyEngineIObjB {
			get {
				const string __id = "b.Lcom/confirmit/mobilesdk/surveyengine/managers/o;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersO> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/confirmit/mobilesdk/surveyengine/managers/o;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='c']"
		[Register ("c")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersM SurveyEngineIObjC {
			get {
				const string __id = "c.Lcom/confirmit/mobilesdk/surveyengine/managers/m;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersM> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/confirmit/mobilesdk/surveyengine/managers/m;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='d']"
		[Register ("d")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersN D {
			get {
				const string __id = "d.Lcom/confirmit/mobilesdk/surveyengine/managers/n;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersN> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Lcom/confirmit/mobilesdk/surveyengine/managers/n;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='e']"
		[Register ("e")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersK E {
			get {
				const string __id = "e.Lcom/confirmit/mobilesdk/surveyengine/managers/k;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersK> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Lcom/confirmit/mobilesdk/surveyengine/managers/k;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='f']"
		[Register ("f")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersB F {
			get {
				const string __id = "f.Lcom/confirmit/mobilesdk/surveyengine/managers/b;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersB> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Lcom/confirmit/mobilesdk/surveyengine/managers/b;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='g']"
		[Register ("g")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersQ G {
			get {
				const string __id = "g.Lcom/confirmit/mobilesdk/surveyengine/managers/q;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersQ> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g.Lcom/confirmit/mobilesdk/surveyengine/managers/q;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='h']"
		[Register ("h")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersG H {
			get {
				const string __id = "h.Lcom/confirmit/mobilesdk/surveyengine/managers/g;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersG> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "h.Lcom/confirmit/mobilesdk/surveyengine/managers/g;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='i']"
		[Register ("i")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersP I {
			get {
				const string __id = "i.Lcom/confirmit/mobilesdk/surveyengine/managers/p;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersP> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "i.Lcom/confirmit/mobilesdk/surveyengine/managers/p;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='j']"
		[Register ("j")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersI J {
			get {
				const string __id = "j.Lcom/confirmit/mobilesdk/surveyengine/managers/i;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersI> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "j.Lcom/confirmit/mobilesdk/surveyengine/managers/i;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='k']"
		[Register ("k")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersL K {
			get {
				const string __id = "k.Lcom/confirmit/mobilesdk/surveyengine/managers/l;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersL> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "k.Lcom/confirmit/mobilesdk/surveyengine/managers/l;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='l']"
		[Register ("l")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersA L {
			get {
				const string __id = "l.Lcom/confirmit/mobilesdk/surveyengine/managers/a;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersA> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "l.Lcom/confirmit/mobilesdk/surveyengine/managers/a;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='m']"
		[Register ("m")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersF M {
			get {
				const string __id = "m.Lcom/confirmit/mobilesdk/surveyengine/managers/f;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "m.Lcom/confirmit/mobilesdk/surveyengine/managers/f;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='n']"
		[Register ("n")]
		public string N {
			get {
				const string __id = "n.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "n.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='o']"
		[Register ("o")]
		public string O {
			get {
				const string __id = "o.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "o.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString ((string)value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='p']"
		[Register ("p")]
		public int P {
			get {
				const string __id = "p.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "p.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='q']"
		[Register ("q")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesG Q {
			get {
				const string __id = "q.Lcom/confirmit/mobilesdk/surveyengine/packages/g;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesG> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "q.Lcom/confirmit/mobilesdk/surveyengine/packages/g;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='r']"
		[Register ("r")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA R {
			get {
				const string __id = "r.Lcom/confirmit/mobilesdk/surveyengine/packages/a;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "r.Lcom/confirmit/mobilesdk/surveyengine/packages/a;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='s']"
		[Register ("s")]
		public int S {
			get {
				const string __id = "s.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "s.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='t']"
		[Register ("t")]
		public int T {
			get {
				const string __id = "t.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "t.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='u']"
		[Register ("u")]
		public bool U {
			get {
				const string __id = "u.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "u.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='v']"
		[Register ("v")]
		public bool V {
			get {
				const string __id = "v.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "v.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='w']"
		[Register ("w")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stacks.SurveyEngineRunnerStacksB W {
			get {
				const string __id = "w.Lcom/confirmit/mobilesdk/surveyengine/runner/stacks/b;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stacks.SurveyEngineRunnerStacksB> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "w.Lcom/confirmit/mobilesdk/surveyengine/runner/stacks/b;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/field[@name='x']"
		[Register ("x")]
		public global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stacks.SurveyEngineRunnerStacksA X {
			get {
				const string __id = "x.Lcom/confirmit/mobilesdk/surveyengine/runner/stacks/a;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stacks.SurveyEngineRunnerStacksA> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "x.Lcom/confirmit/mobilesdk/surveyengine/runner/stacks/a;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/surveyengine/i", typeof (SurveyengineI));

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

		internal SurveyengineI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "")]
		public unsafe int A ()
		{
			const string __id = "a.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Lcom/confirmit/mobilesdk/surveyengine/managers/o;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersO B ()
		{
			const string __id = "b.()Lcom/confirmit/mobilesdk/surveyengine/managers/o;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersO> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.surveyengine']/class[@name='i']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Lcom/confirmit/mobilesdk/surveyengine/managers/p;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersP C ()
		{
			const string __id = "c.()Lcom/confirmit/mobilesdk/surveyengine/managers/p;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersP> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
