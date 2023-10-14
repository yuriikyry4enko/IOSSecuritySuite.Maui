using System;
using Foundation;
using ObjCRuntime;
using System.Runtime.InteropServices;

namespace IOSSecuritySuite
{
    // @interface IOSSecuritySuite : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC16IOSSecuritySuite16IOSSecuritySuite")]
    interface IOSSecuritySuite
    {
        // +(BOOL)amIJailbroken __attribute__((warn_unused_result("")));
        [Static]
        [Export("amIJailbroken")]
        bool AmIJailbroken { get; }

        // +(BOOL)amIRunInEmulator __attribute__((warn_unused_result("")));
        [Static]
        [Export("amIRunInEmulator")]
        bool AmIRunInEmulator { get; }

        // +(BOOL)amIDebugged __attribute__((warn_unused_result("")));
        [Static]
        [Export("amIDebugged")]
        bool AmIDebugged { get; }

        // +(void)denyDebugger;
        [Static]
        [Export("denyDebugger")]
        void DenyDebugger();

        // +(BOOL)amIReverseEngineered __attribute__((warn_unused_result("")));
        [Static]
        [Export("amIReverseEngineered")]
        bool AmIReverseEngineered { get; }
    }

}


