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
namespace EPi.Libraries.DeviceDetection
{
    /// <summary>
    /// Interface IDeviceInfo
    /// </summary>
    public interface IDeviceInfo
    {
        /// <summary>
        /// Gets or sets the type of the device.
        /// </summary>
        /// <value>The type of the device.</value>
        string DeviceType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a console.
        /// </summary>
        /// <value><c>true</c> if this instance is a console; otherwise, <c>false</c>.</value>
        /// <remarks>Not available in wurfl</remarks>
        bool IsConsole { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is an e-reader.
        /// </summary>
        /// <value><c>true</c> if this instance is an e-reader; otherwise, <c>false</c>.</value>
        /// <remarks>Not available in wurfl, wurfl full version</remarks>
        bool IsEReader { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a media hub.
        /// </summary>
        /// <value><c>true</c> if this instance is a media hub; otherwise, <c>false</c>.</value>
        /// <remarks>Not available in wurfl, wurfl full version</remarks>
        bool IsMediaHub { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a mobile device.
        /// </summary>
        /// <value><c>true</c> if this instance is a mobile device; otherwise, <c>false</c>.</value>
        /// <remarks>Not available in wurfl</remarks>
        bool IsMobile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has a small screen.
        /// </summary>
        /// <value><c>true</c> if this instance has a small screen; otherwise, <c>false</c>.</value>
        /// <remarks>Not available in wurfl</remarks>
        bool IsSmallScreen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a smartphone.
        /// </summary>
        /// <value><c>true</c> if this instance is a smartphone; otherwise, <c>false</c>.</value>
        bool IsSmartPhone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a smartwatch.
        /// </summary>
        /// <value><c>true</c> if this instance is a smartwatch; otherwise, <c>false</c>.</value>
        /// <remarks>Not available in wurfl, wurfl full version</remarks>
        bool IsSmartWatch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a tablet.
        /// </summary>
        /// <value><c>true</c> if this instance is a tablet; otherwise, <c>false</c>.</value>
        bool IsTablet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a TV.
        /// </summary>
        /// <value><c>true</c> if this instance is a TV; otherwise, <c>false</c>.</value>
        bool IsTv { get; set; }

        /// <summary>
        /// Gets or sets the height of the screen in pixels.
        /// </summary>
        /// <value>The height of the screen in pixels.</value>
        /// <remarks>Not available in wurfl</remarks>
        int ScreenPixelsHeight { get; set; }

        /// <summary>
        /// Gets or sets the width of the screen in pixels.
        /// </summary>
        /// <value>The width of the screen in pixels.</value>
        /// <remarks>Not available in wurfl</remarks>
        int ScreenPixelsWidth { get; set; }
    }
}