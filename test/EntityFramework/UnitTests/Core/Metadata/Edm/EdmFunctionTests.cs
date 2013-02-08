﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.Core.Metadata.Edm
{
    using Xunit;

    public class EdmFunctionTests
    {
        [Fact]
        public void Can_get_and_set_schema()
        {
            var function
                = new EdmFunction
                      {
                          Schema = "Foo"
                      };

            Assert.Equal("Foo", function.Schema);
        }
    }
}
