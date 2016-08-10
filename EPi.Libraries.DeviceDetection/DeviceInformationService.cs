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
namespace EPi.Libraries.DeviceDetection
{
    using System;
    using System.Collections.Concurrent;
    using System.Web;

    using EPiServer.Logging;
    using EPiServer.ServiceLocation;

    /// <summary>
    /// Class DeviceInformationService.
    /// </summary>
    /// <seealso cref="EPi.Libraries.DeviceDetection.IDeviceInformationService" />
    /// <author>Jeroen Stemerdink</author>
    [ServiceConfiguration(typeof(IDeviceInformationService), Lifecycle = ServiceInstanceScope.Singleton)]
    public class DeviceInformationService : IDeviceInformationService
    {
        /// <summary>
        /// The <see cref="ILogger"/> instance
        /// </summary>
        private static readonly ILogger Log = LogManager.GetLogger();

        /// <summary>
        /// The thread safe device information cache
        /// </summary>
        private static readonly ConcurrentDictionary<string, IDeviceInfo> DeviceInfoCache =
            new ConcurrentDictionary<string, IDeviceInfo>();

        /// <summary>
        /// The device detection service
        /// </summary>
        private readonly IDeviceDetectionService deviceDetectionService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInformationService"/> class.
        /// </summary>
        /// <param name="deviceDetectionService">The device detection service.</param>
        public DeviceInformationService(IDeviceDetectionService deviceDetectionService)
        {
            this.deviceDetectionService = deviceDetectionService;
        }

        /// <summary>
        /// Gets the device information.
        /// </summary>
        /// <returns>DeviceInfo.</returns>
        public IDeviceInfo GetDeviceInfo()
        {
            try
            {
                return this.GetDeviceInfo(HttpContext.Current);
            }
            catch (ArgumentNullException argumentNullException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", argumentNullException.Message, argumentNullException);
            }

            return new DeviceInfo();
        }

        /// <summary>
        /// Gets the device information.
        /// </summary>
        /// <param name="httpContext">The HTTP context.</param>
        /// <returns>DeviceInfo.</returns>
        public IDeviceInfo GetDeviceInfo(HttpContext httpContext)
        {
            try
            {
                HttpContextWrapper contextWrapper = new HttpContextWrapper(httpContext);
                return this.GetDeviceInfo(contextWrapper);
            }
            catch (ArgumentNullException argumentNullException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", argumentNullException.Message, argumentNullException);
            }

            return new DeviceInfo();
        }

        /// <summary>
        /// Gets the device information.
        /// </summary>
        /// <param name="httpContextBase">The HTTP context base.</param>
        /// <returns>DeviceInfo.</returns>
        public IDeviceInfo GetDeviceInfo(HttpContextBase httpContextBase)
        {
            IDeviceInfo deviceInfo = new DeviceInfo();

            if (httpContextBase == null)
            {
                return deviceInfo;
            }

            try
            {
                string userAgent = httpContextBase.Request.ServerVariables["HTTP_USER_AGENT"];

                if (DeviceInfoCache.TryGetValue(userAgent, out deviceInfo))
                {
                    return deviceInfo;
                }

                deviceInfo = this.deviceDetectionService.GetDevice(httpContextBase);
                DeviceInfoCache.TryAdd(userAgent, deviceInfo);
            }
            catch (NotImplementedException notImplementedException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", notImplementedException.Message, notImplementedException);
            }
            catch (NotSupportedException notSupportedException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", notSupportedException.Message, notSupportedException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", argumentNullException.Message, argumentNullException);
            }
            catch (OverflowException overflowException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", overflowException.Message, overflowException);
            }

            return deviceInfo;
        }
    }
}