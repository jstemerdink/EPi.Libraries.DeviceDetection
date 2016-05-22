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
    using System;
    using System.Web;

    using EPiServer.Logging;
    using EPiServer.ServiceLocation;

    using WURFL;

    /// <summary>
    /// Class DeviceDetectionService.
    /// </summary>
    /// <seealso cref="EPi.Libraries.DeviceDetection.IDeviceDetectionService" />
    [ServiceConfiguration(typeof(IDeviceDetectionService), Lifecycle = ServiceInstanceScope.Singleton)]
    public class DeviceDetectionService : IDeviceDetectionService
    {
        /// <summary>
        /// The <see cref="ILogger"/> instance
        /// </summary>
        private static readonly ILogger Log = LogManager.GetLogger();

        /// <summary>
        /// Gets the device for the user.
        /// </summary>
        /// <param name="httpContextBase">The HTTP context base.</param>
        /// <returns>DeviceTypes.</returns>
        public IDeviceInfo GetDevice(HttpContextBase httpContextBase)
        {
            IDeviceInfo deviceInfo = new DeviceInfo();

            if (httpContextBase == null)
            {
                return deviceInfo;
            }

            try
            {
                string userAgent = httpContextBase.Request.ServerVariables["HTTP_USER_AGENT"];

                IWURFLManager manager = WURFLManagerBuilder.Instance;
                IDevice device = WURFLManagerBuilder.Instance.GetDeviceForRequest(userAgent, manager.GetMatchMode());
                return new WurflAdapter(device);
            }
            catch (NotSupportedException notSupportedException)
            {
                Log.Error(notSupportedException.Message, notSupportedException);
            }
            catch (NotImplementedException notImplementedException)
            {
                Log.Error(notImplementedException.Message, notImplementedException);
            }

            return deviceInfo;
        }
    }
}