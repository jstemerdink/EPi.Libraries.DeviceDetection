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
namespace EPi.Libraries.DeviceDetection.WurflCloud
{
    using System;
    using System.Configuration;
    using System.Web;

    using EPiServer.Logging;
    using EPiServer.ServiceLocation;

    using ScientiaMobile.WurflCloud;
    using ScientiaMobile.WurflCloud.Config;

    /// <summary>
    /// Class DeviceDetectionService.
    /// </summary>
    /// <seealso cref="EPi.Libraries.DeviceDetection.IDeviceDetectionService" />
    [ServiceConfiguration(typeof(IDeviceDetectionService), Lifecycle = ServiceInstanceScope.Singleton)]
    public class DeviceDetectionService : IDeviceDetectionService
    {
        /// <summary>
        /// The API key
        /// </summary>
        private static readonly string ApiKey = ConfigurationManager.AppSettings["wurfl:apikey"];

        /// <summary>
        /// The full version
        /// </summary>
        private static readonly string FullVersion = ConfigurationManager.AppSettings["wurfl:fullversion"];

        /// <summary>
        /// Gets the device for the user.
        /// </summary>
        /// <param name="httpContextBase">The HTTP context base.</param>
        /// <returns>DeviceTypes.</returns>
        /// <exception cref="System.ApplicationException">[DeviceInfo detection] No license key found. Add an appsetting called \wurfl: apikey\ with your cloud service key.</exception>
        public IDeviceInfo GetDevice(HttpContextBase httpContextBase)
        {
            IDeviceInfo deviceInfo = new DeviceInfo();

            if (httpContextBase == null)
            {
                return deviceInfo;
            }

            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                throw new ApplicationException(
                    "[DeviceInfo detection] No license key found. Add an appsetting called \"wurfl: apikey\" with your cloud service key.");
            }

            bool isFullVersion;
            bool.TryParse(FullVersion, out isFullVersion);

            DefaultCloudClientConfig config = new DefaultCloudClientConfig { ApiKey = ApiKey };

            CloudClientManager manager = new CloudClientManager(config);

            ScientiaMobile.WurflCloud.Device.DeviceInfo device = isFullVersion
                                                                         ? manager.GetDeviceInfo(httpContextBase)
                                                                         : manager.GetDeviceInfo(httpContextBase, new[] { "complete_device_name, form_factor, is_mobile" });

            return new WurflAdapter(device, isFullVersion);
        }
    }
}