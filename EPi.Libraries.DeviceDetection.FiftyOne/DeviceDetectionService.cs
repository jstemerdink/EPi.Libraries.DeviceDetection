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
    using System.Web;

    using EPiServer.ServiceLocation;

    /// <summary>
    /// Class DeviceDetectionService.
    /// </summary>
    /// <seealso cref="EPi.Libraries.DeviceDetection.IDeviceDetectionService" />
    [ServiceConfiguration(typeof(IDeviceDetectionService), Lifecycle = ServiceInstanceScope.Singleton)]
    public class DeviceDetectionService : IDeviceDetectionService
    {
        /// <summary>
        /// Gets the device for the user.
        /// </summary>
        /// <param name="httpContextBase">The HTTP context base.</param>
        /// <returns>DeviceTypes.</returns>
        public IDeviceInfo GetDevice(HttpContextBase httpContextBase)
        {
            return httpContextBase == null ? new DeviceInfo() : new FiftyOneAdapter(httpContextBase);
        }
    }
}