﻿// Copyright © 2016 Jeroen Stemerdink.
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
    /// Class DeviceInfo.
    /// </summary>
    /// <seealso cref="IDeviceInfo" />
    public class DeviceInfo : IDeviceInfo
    {
        /// <summary>
        /// Gets or sets the type of the device.
        /// </summary>
        /// <value>The type of the device.</value>
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a console.
        /// </summary>
        /// <value><c>true</c> if this instance is a console; otherwise, <c>false</c>.</value>
        public bool IsConsole { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is a desktop.
        /// </summary>
        /// <value><c>true</c> if this instance is a desktop; otherwise, <c>false</c>.</value>
        public bool IsDesktop
        {
            get
            {
                return
                    !(this.IsMobile || this.IsTablet || this.IsConsole || this.IsEReader || this.IsMediaHub
                      || this.IsSmallScreen || this.IsSmartPhone || this.IsSmartWatch || this.IsTv);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is an e-reader.
        /// </summary>
        /// <value><c>true</c> if this instance is an e-reader; otherwise, <c>false</c>.</value>
        public bool IsEReader { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a media hub.
        /// </summary>
        /// <value><c>true</c> if this instance is a media hub; otherwise, <c>false</c>.</value>
        public bool IsMediaHub { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a mobile device.
        /// </summary>
        /// <value><c>true</c> if this instance is a mobile device; otherwise, <c>false</c>.</value>
        public bool IsMobile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has a small screen.
        /// </summary>
        /// <value><c>true</c> if this instance has a small screen; otherwise, <c>false</c>.</value>
        public bool IsSmallScreen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a smartphone.
        /// </summary>
        /// <value><c>true</c> if this instance is a smartphone; otherwise, <c>false</c>.</value>
        public bool IsSmartPhone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a smartwatch.
        /// </summary>
        /// <value><c>true</c> if this instance is a smartwatch; otherwise, <c>false</c>.</value>
        public bool IsSmartWatch { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a tablet.
        /// </summary>
        /// <value><c>true</c> if this instance is a tablet; otherwise, <c>false</c>.</value>
        public bool IsTablet { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a TV.
        /// </summary>
        /// <value><c>true</c> if this instance is a TV; otherwise, <c>false</c>.</value>
        public bool IsTv { get; set; }

        /// <summary>
        /// Gets or sets the height of the screen in pixels.
        /// </summary>
        /// <value>The height of the screen in pixels.</value>
        public int ScreenPixelsHeight { get; set; }

        /// <summary>
        /// Gets or sets the width of the screen in pixels.
        /// </summary>
        /// <value>The width of the screen in pixels.</value>
        public int ScreenPixelsWidth { get; set; }
    }
}