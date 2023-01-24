using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Core.Scheduler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.core.scheduler']/class[@name='c']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/core/scheduler/c", DoNotGenerateAcw=true)]
	public sealed partial class CoreSchedulerC : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/core/scheduler/c", typeof (CoreSchedulerC));

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

		internal CoreSchedulerC (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.core.scheduler']/class[@name='c']/constructor[@name='c' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoreSchedulerC () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core.scheduler']/class[@name='c']/method[@name='onAppMoveBackground' and count(parameter)=0]"
		[Register ("onAppMoveBackground", "()V", "")]
		public unsafe void OnAppMoveBackground ()
		{
			const string __id = "onAppMoveBackground.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core.scheduler']/class[@name='c']/method[@name='onAppMoveForeground' and count(parameter)=0]"
		[Register ("onAppMoveForeground", "()V", "")]
		public unsafe void OnAppMoveForeground ()
		{
			const string __id = "onAppMoveForeground.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core.scheduler']/class[@name='c']/method[@name='onAppStart' and count(parameter)=0]"
		[Register ("onAppStart", "()V", "")]
		public unsafe void OnAppStart ()
		{
			const string __id = "onAppStart.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.core.scheduler']/class[@name='c']/method[@name='onRun' and count(parameter)=0]"
		[Register ("onRun", "()V", "")]
		public unsafe void OnRun ()
		{
			const string __id = "onRun.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
