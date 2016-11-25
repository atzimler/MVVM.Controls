using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ATZ.MVVM.Controls")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Attila Tamas Zimler")]
[assembly: AssemblyProduct("ATZ.MVVM.Controls")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("21308096-bd31-4af2-b23c-0b2c0d2fdf09")]

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

// Allow Wpf controls to access the information necessary to bind the component view models to the component views.
// While these need to be access by the appropriate views, they should not be part of the public API and as a result,
// they are marked as being internal. The reason why Wpf is not in the same DLL is that this will allow us to
// implement different UI control sets with reusing the Model and ViewModel codes.
[assembly: InternalsVisibleTo("ATZ.MVVM.Controls.Wpf")]

// Semantic versioning - from http://semver.org
// Summary
//Given a version number MAJOR.MINOR.PATCH, increment the:
//MAJOR version when you make incompatible API changes,
//MINOR version when you add functionality in a backwards-compatible manner, and
//PATCH version when you make backwards-compatible fixes.
//Additional labels for pre-release and build metadata are available as extensions to the MAJOR.MINOR.PATCH format.
[assembly: AssemblyVersion("1.0.0.*")]
