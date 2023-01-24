using Android.App;
using Android.Runtime;
using System;
using Com.Confirmit.Mobilesdk;

namespace ForstaDemo
{
    [Application]
    public class ForstaApplication : Application
    {
        protected ForstaApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
        public override void OnCreate()
        {
            base.OnCreate();
            ConfirmitSDK.Setup setup = new ConfirmitSDK.Setup(this);
            setup.Configure();
            ConfirmitServer.Instance.ConfigureUK("", "");
        }
    }
}