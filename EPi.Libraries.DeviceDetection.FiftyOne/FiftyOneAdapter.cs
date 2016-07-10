// Copyright © 2016 Jeroen Stemerdink.
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
namespace EPi.Libraries.DeviceDetection.FiftyOne
{
    using System.Linq;
    using System.Reflection;
    using System.Web;

    using global::FiftyOne.Foundation.Mobile.Detection;
    using global::FiftyOne.Foundation.Mobile.Detection.Entities;

    /// <summary>
    ///     Adapts the DeviceInfo class to the DeviceBase class.
    /// </summary>
    public class FiftyOneAdapter : DeviceInfo
    {
        /// <summary>
        ///     HTML used if the property has no value.
        /// </summary>
        private const string SwitchHtml =
            "<a href=\"" + "https://51degrees.com/compare-data-options\">" + "Switch Data Set</a>";

        /// <summary>
        ///     Initializes a new instance of the <see cref="FiftyOneAdapter" /> class.
        /// </summary>
        /// <param name="httpContextBase">The HTTP context base.</param>
        public FiftyOneAdapter(HttpContextBase httpContextBase)
        {
            if (WebProvider.ActiveProvider == null)
            {
                return;
            }

            if (httpContextBase == null)
            {
                return;
            }

            // Perform device detection on the headers provided in the request.
            Match match = WebProvider.ActiveProvider.Match(httpContextBase.Request.Headers);

            foreach (PropertyInfo classProperty in
                this.GetType().GetProperties().Where(p => p.PropertyType == typeof(string)))
            {
                Values values = match[classProperty.Name];

                if ((values != null) && (values.Count > 0))
                {
                    // There is a value for the property. Set the value
                    // now.
                    classProperty.SetValue(this, values.ToString());
                }
                else
                {
                    // Property is not contained in the active 51Degrees
                    // data set. Display a link to switch the data set
                    // and re-run the example.
                    classProperty.SetValue(this, SwitchHtml);
                }
            }

            this.DeviceType = match["DeviceType"] != null ? match["DeviceType"].ToString() : string.Empty;

            this.ScreenPixelsWidth = match["ScreenPixelsWidth"] != null ? (int)match["ScreenPixelsWidth"].ToDouble() : 0;

            this.ScreenPixelsHeight = match["ScreenPixelsHeight"] != null
                                          ? (int)match["ScreenPixelsHeight"].ToDouble()
                                          : 0;

            this.IsTv = match["IsTv"] != null ? match["IsTv"].ToBool() : false;

            this.IsSmartWatch = match["IsSmartWatch"] != null ? match["IsSmartWatch"].ToBool() : false;

            this.IsSmartPhone = match["IsSmartPhone"] != null ? match["IsSmartPhone"].ToBool() : false;

            this.IsSmallScreen = match["IsSmallScreen"] != null ? match["IsSmallScreen"].ToBool() : false;

            this.IsMediaHub = match["IsMediaHub"] != null ? match["IsMediaHub"].ToBool() : false;

            this.IsEReader = match["IsEReader"] != null ? match["IsEReader"].ToBool() : false;

            this.IsConsole = match["IsConsole"] != null ? match["IsConsole"].ToBool() : false;

            this.IsTablet = match["IsTablet"] != null ? match["IsTablet"].ToBool() : false;

            this.IsMobile = match["IsMobile"] != null ? match["IsMobile"].ToBool() : false;
        }
    }
}