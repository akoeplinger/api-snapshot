// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.2.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Xamarin, Inc.")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright (c) 2016 Xamarin Inc. (http://www.xamarin.com)")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Text.Encoding.CodePages.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Text.Encoding.CodePages.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Text.Encoding.CodePages.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace System.Text
{
    public sealed partial class CodePagesEncodingProvider : System.Text.EncodingProvider
    {
        internal CodePagesEncodingProvider() { }
        public static System.Text.EncodingProvider Instance { get { throw null; } }
        public override System.Text.Encoding GetEncoding(int codepage) { throw null; }
        public override System.Text.Encoding GetEncoding(string name) { throw null; }
    }
}