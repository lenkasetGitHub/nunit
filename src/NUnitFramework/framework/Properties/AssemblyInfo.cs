// ***********************************************************************
// Copyright (c) 2007 Charlie Poole, Rob Prouse
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: InternalsVisibleTo("nunit.framework.tests, PublicKey=002400000480000094" +
                              "000000060200000024000052534131000400000100010031eea" +
                              "370b1984bfa6d1ea760e1ca6065cee41a1a279ca234933fe977" +
                              "a096222c0e14f9e5a17d5689305c6d7f1206a85a53c48ca0100" +
                              "80799d6eeef61c98abd18767827dc05daea6b6fbd2e868410d9" +
                              "bee5e972a004ddd692dec8fa404ba4591e847a8cf35de21c2d3" +
                              "723bc8d775a66b594adeb967537729fe2a446b548cd57a6")]

#if NET_4_5
[assembly: AssemblyTitle("NUnit Framework .NET 4.5")]
#elif NET_4_0
[assembly: AssemblyTitle("NUnit Framework .NET 4.0")]
#elif NET_3_5
[assembly: AssemblyTitle("NUnit Framework .NET 4.0")]
#elif NET_2_0
[assembly: AssemblyTitle("NUnit Framework .NET 2.0")]
#elif NETSTANDARD1_3
[assembly: AssemblyTitle("NUnit Framework .NET Standard 1.3")]
#elif NETSTANDARD1_6
[assembly: AssemblyTitle("NUnit Framework .NET Standard 1.6")]
#else
[assembly: AssemblyTitle("NUnit Framework")]
#endif

[assembly: AssemblyDescription("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]

#if !NETSTANDARD1_3
[assembly: AllowPartiallyTrustedCallers]
#endif