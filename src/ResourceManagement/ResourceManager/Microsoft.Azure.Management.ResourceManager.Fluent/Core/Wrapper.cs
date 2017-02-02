﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Resource.Fluent.Core
{
    public class Wrapper<InnerT> : IWrapper<InnerT>
    {
        public Wrapper(InnerT inner)
        {
            Inner = inner;
        }

        public virtual InnerT Inner
        {
            get; private set;
        }

        public void SetInner(InnerT inner)
        {
            this.Inner = inner;
        }
    }
}