// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal static partial class Interop
{
    private static partial class Libraries
    {
        internal const string GlobalizationInterop = "System.Globalization.Native"; // CoreFX wrappers for ICU
        // Shims
        internal const string SystemNative = "System.Native";
        internal const string HttpNative = "System.Net.Http.Native";
        internal const string NetSecurityNative = "System.Net.Security.Native";
        internal const string CryptoNative = "System.Security.Cryptography.Native.OpenSsl";
        internal const string GlobalizationNative = "System.Globalization.Native";
        internal const string CompressionNative = "System.IO.Compression.Native";
    }
}
