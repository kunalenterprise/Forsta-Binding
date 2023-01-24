using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/SurveyFrame", DoNotGenerateAcw=true)]
	public sealed partial class SurveyFrame : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/SurveyFrame$EngineManager", DoNotGenerateAcw=true)]
		public sealed partial class EngineManager : global::Java.Lang.Object, global::Com.Confirmit.Mobilesdk.Surveyengine.IEngineLifeCycleListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/SurveyFrame$EngineManager", typeof (EngineManager));

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

			internal EngineManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/constructor[@name='SurveyFrame.EngineManager' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe EngineManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			public unsafe bool Ended {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='getEnded' and count(parameter)=0]"
				[Register ("getEnded", "()Z", "")]
				get {
					const string __id = "getEnded.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='setEnded' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setEnded", "(Z)V", "")]
				set {
					const string __id = "setEnded.(Z)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			public unsafe global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineK EngineRunner {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='getEngineRunner' and count(parameter)=0]"
				[Register ("getEngineRunner", "()Lcom/confirmit/mobilesdk/surveyengine/k;", "")]
				get {
					const string __id = "getEngineRunner.()Lcom/confirmit/mobilesdk/surveyengine/k;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineK> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::Com.Confirmit.Mobilesdk.UI.SurveyPage Page {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='getPage' and count(parameter)=0]"
				[Register ("getPage", "()Lcom/confirmit/mobilesdk/ui/SurveyPage;", "")]
				get {
					const string __id = "getPage.()Lcom/confirmit/mobilesdk/ui/SurveyPage;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyPage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='setPage' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyPage']]"
				[Register ("setPage", "(Lcom/confirmit/mobilesdk/ui/SurveyPage;)V", "")]
				set {
					const string __id = "setPage.(Lcom/confirmit/mobilesdk/ui/SurveyPage;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			public unsafe global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener SurveyFrameLifeCycleListener {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='getSurveyFrameLifeCycleListener' and count(parameter)=0]"
				[Register ("getSurveyFrameLifeCycleListener", "()Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;", "")]
				get {
					const string __id = "getSurveyFrameLifeCycleListener.()Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='setSurveyFrameLifeCycleListener' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener']]"
				[Register ("setSurveyFrameLifeCycleListener", "(Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;)V", "")]
				set {
					const string __id = "setSurveyFrameLifeCycleListener.(Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='load' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyFrameConfig']]"
			[Register ("load", "(Lcom/confirmit/mobilesdk/ui/SurveyFrameConfig;)V", "")]
			public unsafe void Load (global::Com.Confirmit.Mobilesdk.UI.SurveyFrameConfig p0)
			{
				const string __id = "load.(Lcom/confirmit/mobilesdk/ui/SurveyFrameConfig;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='onSurveyErrored' and count(parameter)=3 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.m'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.Exception']]"
			[Register ("onSurveyErrored", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;Ljava/lang/Exception;)V", "")]
			public unsafe void OnSurveyErrored (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Java.Lang.Exception p2)
			{
				const string __id = "onSurveyErrored.(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;Ljava/lang/Exception;)V";
				IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p2).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='onSurveyFinished' and count(parameter)=2 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.m'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("onSurveyFinished", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;)V", "")]
			public unsafe void OnSurveyFinished (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM p0, global::System.Collections.Generic.IDictionary<string, string> p1)
			{
				const string __id = "onSurveyFinished.(Lcom/confirmit/mobilesdk/surveyengine/packages/question/m;Ljava/util/Map;)V";
				IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='onSurveyPageReady' and count(parameter)=5 and parameter[1][@type='com.confirmit.mobilesdk.surveyengine.packages.question.k'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends com.confirmit.mobilesdk.surveyengine.packages.question.j&gt;'] and parameter[4][@type='com.confirmit.mobilesdk.surveyengine.o'] and parameter[5][@type='java.util.Map&lt;java.lang.String, ? extends java.util.List&lt;com.confirmit.mobilesdk.surveyengine.managers.h&gt;&gt;']]"
			[Register ("onSurveyPageReady", "(Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V", "")]
			public unsafe void OnSurveyPageReady (global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ> p2, global::Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO p3, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>> p4)
			{
				const string __id = "onSurveyPageReady.(Lcom/confirmit/mobilesdk/surveyengine/packages/question/k;Ljava/util/List;Ljava/util/Map;Lcom/confirmit/mobilesdk/surveyengine/o;Ljava/util/Map;)V";
				IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
				IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ>.ToLocalJniHandle (p2);
				IntPtr native_p4 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH>>.ToLocalJniHandle (p4);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
					__args [4] = new JniArgumentValue (native_p4);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p4);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
					global::System.GC.KeepAlive (p3);
					global::System.GC.KeepAlive (p4);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.EngineManager']/method[@name='onSurveyQuit' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("onSurveyQuit", "(Ljava/util/Map;)V", "")]
			public unsafe void OnSurveyQuit (global::System.Collections.Generic.IDictionary<string, string> p0)
			{
				const string __id = "onSurveyQuit.(Ljava/util/Map;)V";
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

			#region "Event implementation for Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener"

			public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyErroredEventArgs> SurveyErrored {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					__CreateISurveyFrameLifecycleListenerImplementor,
					__v => SurveyFrameLifeCycleListener = __v,
					__h => __h.OnSurveyErroredHandler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
					__v => SurveyFrameLifeCycleListener = null,
					__h => __h.OnSurveyErroredHandler -= value);
				}
			}

			public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyFinishedEventArgs> SurveyFinished {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					__CreateISurveyFrameLifecycleListenerImplementor,
					__v => SurveyFrameLifeCycleListener = __v,
					__h => __h.OnSurveyFinishedHandler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
					__v => SurveyFrameLifeCycleListener = null,
					__h => __h.OnSurveyFinishedHandler -= value);
				}
			}

			public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyPageReadyEventArgs> SurveyPageReady {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					__CreateISurveyFrameLifecycleListenerImplementor,
					__v => SurveyFrameLifeCycleListener = __v,
					__h => __h.OnSurveyPageReadyHandler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
					__v => SurveyFrameLifeCycleListener = null,
					__h => __h.OnSurveyPageReadyHandler -= value);
				}
			}

			public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyQuitEventArgs> SurveyQuit {
				add {
					global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					__CreateISurveyFrameLifecycleListenerImplementor,
					__v => SurveyFrameLifeCycleListener = __v,
					__h => __h.OnSurveyQuitHandler += value);
				}
				remove {
					global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
					ref weak_implementor___SetSurveyFrameLifeCycleListener,
					global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
					__v => SurveyFrameLifeCycleListener = null,
					__h => __h.OnSurveyQuitHandler -= value);
				}
			}

			WeakReference weak_implementor___SetSurveyFrameLifeCycleListener;

			global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor __CreateISurveyFrameLifecycleListenerImplementor ()
			{
				return new global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor (this);
			}

			#endregion

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame.WhenMappings']"
		[global::Android.Runtime.Register ("com/confirmit/mobilesdk/ui/SurveyFrame$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/SurveyFrame$WhenMappings", typeof (WhenMappings));

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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/ui/SurveyFrame", typeof (SurveyFrame));

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

		internal SurveyFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/constructor[@name='SurveyFrame' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SurveyFrame () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Confirmit.Mobilesdk.UI.SurveyPage Page {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='getPage' and count(parameter)=0]"
			[Register ("getPage", "()Lcom/confirmit/mobilesdk/ui/SurveyPage;", "")]
			get {
				const string __id = "getPage.()Lcom/confirmit/mobilesdk/ui/SurveyPage;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyPage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener SurveyFrameLifeCycleListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='getSurveyFrameLifeCycleListener' and count(parameter)=0]"
			[Register ("getSurveyFrameLifeCycleListener", "()Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;", "")]
			get {
				const string __id = "getSurveyFrameLifeCycleListener.()Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='setSurveyFrameLifeCycleListener' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyFrameLifecycleListener']]"
			[Register ("setSurveyFrameLifeCycleListener", "(Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;)V", "")]
			set {
				const string __id = "setSurveyFrameLifeCycleListener.(Lcom/confirmit/mobilesdk/ui/SurveyFrameLifecycleListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='back' and count(parameter)=0]"
		[Register ("back", "()Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult Back ()
		{
			const string __id = "back.()Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='load' and count(parameter)=1 and parameter[1][@type='com.confirmit.mobilesdk.ui.SurveyFrameConfig']]"
		[Register ("load", "(Lcom/confirmit/mobilesdk/ui/SurveyFrameConfig;)V", "")]
		public unsafe void Load (global::Com.Confirmit.Mobilesdk.UI.SurveyFrameConfig p0)
		{
			const string __id = "load.(Lcom/confirmit/mobilesdk/ui/SurveyFrameConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult Next ()
		{
			const string __id = "next.()Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='quit' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("quit", "(Z)Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult Quit (bool p0)
		{
			const string __id = "quit.(Z)Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.ui']/class[@name='SurveyFrame']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;", "")]
		public unsafe global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult Start ()
		{
			const string __id = "start.()Lcom/confirmit/mobilesdk/ui/SurveyFrameActionResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.UI.SurveyFrameActionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		#region "Event implementation for Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener"

		public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyErroredEventArgs> SurveyErrored {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				__CreateISurveyFrameLifecycleListenerImplementor,
				__v => SurveyFrameLifeCycleListener = __v,
				__h => __h.OnSurveyErroredHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
				__v => SurveyFrameLifeCycleListener = null,
				__h => __h.OnSurveyErroredHandler -= value);
			}
		}

		public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyFinishedEventArgs> SurveyFinished {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				__CreateISurveyFrameLifecycleListenerImplementor,
				__v => SurveyFrameLifeCycleListener = __v,
				__h => __h.OnSurveyFinishedHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
				__v => SurveyFrameLifeCycleListener = null,
				__h => __h.OnSurveyFinishedHandler -= value);
			}
		}

		public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyPageReadyEventArgs> SurveyPageReady {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				__CreateISurveyFrameLifecycleListenerImplementor,
				__v => SurveyFrameLifeCycleListener = __v,
				__h => __h.OnSurveyPageReadyHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
				__v => SurveyFrameLifeCycleListener = null,
				__h => __h.OnSurveyPageReadyHandler -= value);
			}
		}

		public event EventHandler<global::Com.Confirmit.Mobilesdk.UI.SurveyQuitEventArgs> SurveyQuit {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				__CreateISurveyFrameLifecycleListenerImplementor,
				__v => SurveyFrameLifeCycleListener = __v,
				__h => __h.OnSurveyQuitHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListener, global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor>(
				ref weak_implementor___SetSurveyFrameLifeCycleListener,
				global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor.__IsEmpty,
				__v => SurveyFrameLifeCycleListener = null,
				__h => __h.OnSurveyQuitHandler -= value);
			}
		}

		WeakReference weak_implementor___SetSurveyFrameLifeCycleListener;

		global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor __CreateISurveyFrameLifecycleListenerImplementor ()
		{
			return new global::Com.Confirmit.Mobilesdk.UI.ISurveyFrameLifecycleListenerImplementor (this);
		}

		#endregion

	}
}
