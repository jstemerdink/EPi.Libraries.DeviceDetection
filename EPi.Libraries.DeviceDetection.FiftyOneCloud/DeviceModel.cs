// Copyright © 2017 Jeroen Stemerdink.
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
namespace EPi.Libraries.DeviceDetection.FiftyOneCloud
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// Class DeviceModel.
    /// </summary>
    public class DeviceModel
    {
        /// <summary>
        /// Gets or sets the name of the data set.
        /// </summary>
        /// <value>The name of the data set.</value>
        public string DataSetName { get; set; }

        /// <summary>
        /// Gets or sets the detection time.
        /// </summary>
        /// <value>The detection time.</value>
        public float DetectionTime { get; set; }

        /// <summary>
        /// Gets or sets the difference.
        /// </summary>
        /// <value>The difference.</value>
        public int Difference { get; set; }

        /// <summary>
        /// Gets or sets the match method.
        /// </summary>
        /// <value>The match method.</value>
        public string MatchMethod { get; set; }

        /// <summary>
        /// Gets or sets the profile ids.
        /// </summary>
        /// <value>The profile ids.</value>
        [JsonProperty(PropertyName = "ProfileIds")]
        public DeviceProfileids ProfileIds { get; set; }

        /// <summary>
        /// Gets or sets the published.
        /// </summary>
        /// <value>The published.</value>
        public DateTime Published { get; set; }

        /// <summary>
        /// Gets or sets the signatures compared.
        /// </summary>
        /// <value>The signatures compared.</value>
        public int SignaturesCompared { get; set; }

        /// <summary>
        /// Gets or sets the target useragent.
        /// </summary>
        /// <value>The target useragent.</value>
        public string TargetUseragent { get; set; }

        /// <summary>
        /// Gets or sets the useragent.
        /// </summary>
        /// <value>The useragent.</value>
        public string Useragent { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>The values.</value>
        [JsonProperty(PropertyName = "Values")]
        public DeviceProperties Values { get; set; }
    }
}