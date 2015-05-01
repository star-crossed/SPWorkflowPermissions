using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SharePoint Workflow Permissions")]
[assembly: AssemblyDescription("A custom set of workflow actions for SharePoint 2013 that manipulate permissions.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Paul Choquette")]
[assembly: AssemblyProduct("SharePoint Workflow Permissions")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("79E84497-48A9-451A-9C12-2DB14B589AFB")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: System.Windows.Markup.XmlnsDefinition("wf://workflow.windows.net/$Current/$Activities", "SPAdminMenu2013Sandbox")]
[assembly: System.Windows.Markup.XmlnsDefinition("wf://workflow.windows.net/$Current/$Activities", "Starcrossed.SPWorkflowPermissions")]
