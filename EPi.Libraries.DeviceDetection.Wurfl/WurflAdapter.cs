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
namespace EPi.Libraries.DeviceDetection.Wurfl
{
    using WURFL;

    /// <summary>
    ///     Adapts the DeviceInfo class to the DeviceBase class.
    /// </summary>
    public class WurflAdapter : DeviceInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WurflAdapter" /> class.
        /// </summary>
        /// <param name="deviceInfo">The <see cref="WURFL.IDevice" /> for the visitor.</param>
        public WurflAdapter(IDevice deviceInfo)
        {
            // Desktop, App, Tablet, Smartphone, Feature Phone, Smart-TV, Robot, Other non-Mobile, Other Mobile
            this.DeviceType = deviceInfo.GetVirtualCapability("form_factor");

            bool isMobile;
            bool.TryParse(deviceInfo.GetVirtualCapability("is_mobile"), out isMobile);
            this.IsMobile = isMobile;

            int screenPixelsWidth;
            int.TryParse(deviceInfo.GetCapability("resolution_width"), out screenPixelsWidth);
            this.ScreenPixelsWidth = screenPixelsWidth;

            int screenPixelsHeight;
            int.TryParse(deviceInfo.GetCapability(" resolution_height"), out screenPixelsHeight);
            this.ScreenPixelsHeight = screenPixelsHeight;

            bool isTv;
            bool.TryParse(deviceInfo.GetCapability("is_smarttv"), out isTv);
            this.IsTv = isTv;

            bool isSmartWatch;
            bool.TryParse(deviceInfo.GetCapability("is_smartwatch"), out isSmartWatch); // Not available in wurfl
            this.IsSmartWatch = isSmartWatch;

            bool isSmartPhone;
            bool.TryParse(deviceInfo.GetVirtualCapability("is_smartphone"), out isSmartPhone);
            this.IsSmartPhone = isSmartPhone;

            bool isLargeScreen;
            bool.TryParse(deviceInfo.GetVirtualCapability("is_largescreen"), out isLargeScreen);
            this.IsSmallScreen = !isLargeScreen;

            bool isMediaHub;
            bool.TryParse(deviceInfo.GetCapability("is_mediahub"), out isMediaHub); // Not available in wurfl
            this.IsMediaHub = isMediaHub;

            bool isEReader;
            bool.TryParse(deviceInfo.GetCapability("is_ereader"), out isEReader); // Not available in wurfl
            this.IsEReader = isEReader;

            bool isConsole;
            bool.TryParse(deviceInfo.GetCapability("is_console"), out isConsole);
            this.IsConsole = isConsole;

            bool isTablet;
            bool.TryParse(deviceInfo.GetCapability("is_tablet"), out isTablet);
            this.IsTablet = isTablet;
        }
    }
}