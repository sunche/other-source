using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Reflection;
using System.Resources;

// Additional assembly attributes are defined in GlobalAssemblyInfo.cs

[assembly: AssemblyTitleAttribute("Npgsql - .Net Data Provider for PostgreSQL")]
[assembly: AssemblyDescriptionAttribute(".Net Data Provider for PostgreSQL")]



// Contains assembly attributes shared by all Npgsql projects

[assembly: CLSCompliantAttribute(true)]
[assembly: AllowPartiallyTrustedCallersAttribute()]
#if NET40
[assembly: System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
#endif
[assembly: AssemblyCompanyAttribute("Npgsql Development Team")]
[assembly: AssemblyProductAttribute("Npgsql")]
[assembly: AssemblyCopyrightAttribute("Copyright © 2002 - 2014 Npgsql Development Team")]
[assembly: AssemblyTrademarkAttribute("")]
[assembly: AssemblyVersionAttribute("2.2.7")]
[assembly: AssemblyFileVersionAttribute("2.2.7")]
[assembly: AssemblyInformationalVersionAttribute("2.2.7")]
[assembly: NeutralResourcesLanguageAttribute("en", UltimateResourceFallbackLocation.MainAssembly)]
