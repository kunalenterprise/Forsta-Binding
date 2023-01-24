using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Confirmit.Mobilesdk.Database.Providers.Room {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']"
	[global::Android.Runtime.Register ("com/confirmit/mobilesdk/database/providers/room/RoomDataModule", DoNotGenerateAcw=true)]
	public sealed partial class RoomDataModule : global::Com.Confirmit.Mobilesdk.Utils.ServiceLocator, global::Com.Confirmit.Mobilesdk.Database.IDataModule {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/confirmit/mobilesdk/database/providers/room/RoomDataModule", typeof (RoomDataModule));

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

		internal RoomDataModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/constructor[@name='RoomDataModule' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RoomDataModule () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IPrefDb Pref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getPref' and count(parameter)=0]"
			[Register ("getPref", "()Lcom/confirmit/mobilesdk/database/domain/PrefDb;", "")]
			get {
				const string __id = "getPref.()Lcom/confirmit/mobilesdk/database/domain/PrefDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IPrefDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb Program {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getProgram' and count(parameter)=0]"
			[Register ("getProgram", "()Lcom/confirmit/mobilesdk/database/domain/ProgramDb;", "")]
			get {
				const string __id = "getProgram.()Lcom/confirmit/mobilesdk/database/domain/ProgramDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb ProgramPref {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getProgramPref' and count(parameter)=0]"
			[Register ("getProgramPref", "()Lcom/confirmit/mobilesdk/database/domain/ProgramPrefDb;", "")]
			get {
				const string __id = "getProgramPref.()Lcom/confirmit/mobilesdk/database/domain/ProgramPrefDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IProgramPrefDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb Respondent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getRespondent' and count(parameter)=0]"
			[Register ("getRespondent", "()Lcom/confirmit/mobilesdk/database/domain/RespondentDb;", "")]
			get {
				const string __id = "getRespondent.()Lcom/confirmit/mobilesdk/database/domain/RespondentDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IRespondentDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/confirmit/mobilesdk/database/domain/ResponseDb;", "")]
			get {
				const string __id = "getResponse.()Lcom/confirmit/mobilesdk/database/domain/ResponseDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IResponseDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb Scenario {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getScenario' and count(parameter)=0]"
			[Register ("getScenario", "()Lcom/confirmit/mobilesdk/database/domain/ScenarioDb;", "")]
			get {
				const string __id = "getScenario.()Lcom/confirmit/mobilesdk/database/domain/ScenarioDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IScenarioDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb Server {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getServer' and count(parameter)=0]"
			[Register ("getServer", "()Lcom/confirmit/mobilesdk/database/domain/ServerDb;", "")]
			get {
				const string __id = "getServer.()Lcom/confirmit/mobilesdk/database/domain/ServerDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.IServerDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb Survey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='getSurvey' and count(parameter)=0]"
			[Register ("getSurvey", "()Lcom/confirmit/mobilesdk/database/domain/SurveyDb;", "")]
			get {
				const string __id = "getSurvey.()Lcom/confirmit/mobilesdk/database/domain/SurveyDb;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Confirmit.Mobilesdk.Database.Domain.ISurveyDb> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.confirmit.mobilesdk.database.providers.room']/class[@name='RoomDataModule']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.confirmit.mobilesdk.ConfirmitSDK.Setup']]"
		[Register ("initialize", "(Landroid/app/Application;Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;)V", "")]
		public unsafe void Initialize (global::Android.App.Application p0, global::Com.Confirmit.Mobilesdk.ConfirmitSDK.Setup p1)
		{
			const string __id = "initialize.(Landroid/app/Application;Lcom/confirmit/mobilesdk/ConfirmitSDK$Setup;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
