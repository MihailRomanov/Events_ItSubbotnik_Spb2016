#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"EPAM")]
[assembly: AssemblyProduct(@"NHModelingLanguage")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

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

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"EPAM.NHModelingLanguage.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010041F86470C1C1ADAFF4A31D5DCA023E81C0041F10B302BAD108003E81BA21BEC3793C8DD6BBD63D37BB6FA786F9C0218561488D6ACAD45991EF2AF7A2A8E0A44FA798C4C33EF8569C591EA5CD209E5F625768D50412D90231E1A67D3603750A4B17F768CEFEDD9B4A6A7433400A97A2BC0D6865EAAB7080D3F95D4798F749B5CC")]