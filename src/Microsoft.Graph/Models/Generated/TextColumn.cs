// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type TextColumn.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TextColumn
    {
    
        /// <summary>
        /// Gets or sets allowMultipleLines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowMultipleLines", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowMultipleLines { get; set; }
    
        /// <summary>
        /// Gets or sets appendChangesToExistingText.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appendChangesToExistingText", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppendChangesToExistingText { get; set; }
    
        /// <summary>
        /// Gets or sets linesForEditing.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "linesForEditing", Required = Newtonsoft.Json.Required.Default)]
        public Int32? LinesForEditing { get; set; }
    
        /// <summary>
        /// Gets or sets maxLength.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaxLength { get; set; }
    
        /// <summary>
        /// Gets or sets textType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "textType", Required = Newtonsoft.Json.Required.Default)]
        public string TextType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}