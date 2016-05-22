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
namespace EPi.Libraries.DeviceDetection.FiftyOneCloud
{
    using System.Globalization;

    /// <summary>
    ///     Adapts the DeviceModel class to the DeviceInfo class.
    /// </summary>
    public class FiftyOneCloudAdapter : DeviceInfo
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref=" FiftyOneCloudAdapter" /> class.
        /// </summary>
        /// <param name="deviceModel">The deviceModel.</param>
        public FiftyOneCloudAdapter(DeviceModel deviceModel)
        {
            if (deviceModel == null)
            {
                return;
            }

            this.DeviceType = deviceModel.Values.DeviceType[0];

            double screenPixelsWidth;
            double.TryParse(
                deviceModel.Values.ScreenPixelsWidth[0],
                NumberStyles.Any,
                CultureInfo.CreateSpecificCulture("en-US"),
                out screenPixelsWidth);
            this.ScreenPixelsWidth = (int)screenPixelsWidth;

            double screenPixelsHeight;
            double.TryParse(
                deviceModel.Values.ScreenPixelsHeight[0],
                NumberStyles.Any,
                CultureInfo.CreateSpecificCulture("en-US"),
                out screenPixelsHeight);
            this.ScreenPixelsHeight = (int)screenPixelsHeight;

            bool isTv;
            bool.TryParse(deviceModel.Values.IsTv[0], out isTv);
            this.IsTv = isTv;

            bool isSmartWatch;
            bool.TryParse(deviceModel.Values.IsSmartWatch[0], out isSmartWatch);
            this.IsSmartWatch = isSmartWatch;

            bool isSmartPhone;
            bool.TryParse(deviceModel.Values.IsSmartPhone[0], out isSmartPhone);
            this.IsSmartPhone = isSmartPhone;

            bool isSmallScreen;
            bool.TryParse(deviceModel.Values.IsSmallScreen[0], out isSmallScreen);
            this.IsSmallScreen = isSmallScreen;

            bool isMediaHub;
            bool.TryParse(deviceModel.Values.IsMediaHub[0], out isMediaHub);
            this.IsMediaHub = isMediaHub;

            bool isEReader;
            bool.TryParse(deviceModel.Values.IsEReader[0], out isEReader);
            this.IsEReader = isEReader;

            bool isConsole;
            bool.TryParse(deviceModel.Values.IsConsole[0], out isConsole);
            this.IsConsole = isConsole;

            bool isTablet;
            bool.TryParse(deviceModel.Values.IsTablet[0], out isTablet);
            this.IsTablet = isTablet;

            bool isMobile;
            bool.TryParse(deviceModel.Values.IsMobile[0], out isMobile);
            this.IsMobile = isMobile;
        }
    }
}