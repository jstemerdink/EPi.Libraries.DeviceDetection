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
    using System.Configuration;
    using System.Globalization;
    using System.Net;
    using System.Web;

    using EPiServer.Logging;
    using EPiServer.ServiceLocation;

    using Newtonsoft.Json;

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
        /// The 51degrees license key
        /// </summary>
        private static readonly string LicenseKey = ConfigurationManager.AppSettings["51degrees:licensekey"];

        /// <summary>
        /// Gets the device for the user.
        /// </summary>
        /// <param name="httpContextBase">The HTTP context base.</param>
        /// <returns>DeviceTypes.</returns>
        /// <exception cref="InvalidOperationException">[DeviceInfo detection] No license key found. Add an appsetting called "51degrees:licensekey" with your cloud service key.</exception>
        public IDeviceInfo GetDevice(HttpContextBase httpContextBase)
        {
            if (string.IsNullOrWhiteSpace(LicenseKey))
            {
                throw new InvalidOperationException(
                    "[Device detection] No license key found. Add an appsetting called \"51degrees:licensekey\" with your cloud service key.");
            }

            IDeviceInfo deviceInfo = new DeviceInfo();

            if (httpContextBase == null)
            {
                return deviceInfo;
            }

            try
            {
                string userAgent = httpContextBase.Request.ServerVariables["HTTP_USER_AGENT"];

                using (WebClient webClient = new WebClient())
                {
                    string address = string.Format(
                        CultureInfo.InvariantCulture,
                        "https://cloud.51degrees.com/api/v1/{0}/match?user-agent={1}",
                        LicenseKey,
                        userAgent);

                    string json = webClient.DownloadString(address);

                    DeviceModel model = JsonConvert.DeserializeObject<DeviceModel>(json);

                    return new FiftyOneCloudAdapter(model);
                }
            }
            catch (NotImplementedException notImplementedException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", notImplementedException.Message, notImplementedException);
            }
            catch (NotSupportedException notSupportedException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", notSupportedException.Message, notSupportedException);
            }
            catch (WebException webException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", webException.Message, webException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", argumentNullException.Message, argumentNullException);
            }
            catch (FormatException formatException)
            {
                Log.Error("[Device detection] {0}.\r\n {1}", formatException.Message, formatException);
            }

            return deviceInfo;
        }
    }
}