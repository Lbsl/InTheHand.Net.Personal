//#define NO_SIGNING
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("InTheHand.Net.Personal")]
[assembly: AssemblyDescription("Personal Area Networking for .NET\r\n(" +
#if WinXP
 ".NET Framework"
#elif WinCE
".NET Compact Framework"
#elif ANDROID
"Android"
#else
"unknown!"
#error Unknown platform!
#endif
 + " " +
#if FX4
 "v4.0"
#elif FX3_5
 "v3.5"
#elif V2
 "v2.0"
#elif V1
"v1.0"
#else
"unknown!"
#error Unknown version!
#endif
 + ")")]

[assembly: AssemblyCompany("In The Hand Ltd")]
[assembly: AssemblyProduct("32feet.NET")]
[assembly: AssemblyCopyright("Copyright © In The Hand Ltd 2003-2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: Guid("bdfcb667-1231-4014-82e9-Bf008ee5c687")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("3.7.1102.0")]
[assembly: AssemblyInformationalVersion("3.7.1102.0")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]

#if WinXP
[assembly: ComVisible(false)]
#endif

//only sign on non-debug builds
#if !DEBUG && !CODE_ANALYSIS && !NO_SIGNING
[assembly: AssemblyDelaySign(false)]
#pragma warning disable 1699
[assembly: AssemblyKeyFile(@"..\..\..\InTheHand.Net.Personal\d-m-wilson.ITH.snk")]
#pragma warning restore 1699
[assembly: AssemblyKeyName("")]
#endif

#if DEBUG // for unit-tests
#if ! V1
[assembly: InternalsVisibleTo("ITH.Net.Personal.FX2.Tests"
    //+ ", PublicKey=" + "002400000480000094000000060200000024000052534131000400000100010057ba3491d0a5f7335b762468963a1e2dc49a9d23eade3bbe9fd4637dde5c9b632eddbae9ea0dbcf260c0f573b8cea5a0b842f7421db0a2e3c9c175151eb422a573bc0dc5c379c032b9462624813f50988fb6a48b39da8a3c2eb6153c77899506ca2f8fe541c88cca1cdb5b38226f442494c1bf85a015e3c96ce39b5f77dbebc0"
    )]
[assembly: InternalsVisibleTo("ITH.Net.Personal.FX4.Tests")]
[assembly: InternalsVisibleTo("ITH.Net.CE2.Tests")]
[assembly: InternalsVisibleTo("BlueSoleilTests")]
[assembly: InternalsVisibleTo("Mocks")]
[assembly: InternalsVisibleTo("MockObjects")]
[assembly: InternalsVisibleTo("BluetopiaTests")]
#endif
#endif
