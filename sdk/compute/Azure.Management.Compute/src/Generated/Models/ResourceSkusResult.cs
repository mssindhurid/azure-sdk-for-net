// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Management.Compute.Models
{
    /// <summary> The List Resource Skus operation response. </summary>
    public partial class ResourceSkusResult
    {
        /// <summary> Initializes a new instance of ResourceSkusResult. </summary>
        /// <param name="value"> The list of skus available for the subscription. </param>
        internal ResourceSkusResult(IEnumerable<ResourceSku> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of ResourceSkusResult. </summary>
        /// <param name="value"> The list of skus available for the subscription. </param>
        /// <param name="nextLink"> The URI to fetch the next page of Resource Skus. Call ListNext() with this URI to fetch the next page of Resource Skus. </param>
        internal ResourceSkusResult(IReadOnlyList<ResourceSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of skus available for the subscription. </summary>
        public IReadOnlyList<ResourceSku> Value { get; }
        /// <summary> The URI to fetch the next page of Resource Skus. Call ListNext() with this URI to fetch the next page of Resource Skus. </summary>
        public string NextLink { get; }
    }
}