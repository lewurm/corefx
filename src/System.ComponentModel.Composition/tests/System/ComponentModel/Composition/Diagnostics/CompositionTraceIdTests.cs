// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.UnitTesting;
using Xunit;

namespace System.ComponentModel.Composition.Diagnostics
{
    public class CompositionTraceIdTests
    {
        [Fact]
        public void CompositionTraceIdsAreInSyncWithTraceIds()
        {
            ExtendedAssert.EnumsContainSameValues<CompositionTraceId, TraceId>();
        }
    }
}
