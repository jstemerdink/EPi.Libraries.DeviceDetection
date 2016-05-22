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
namespace EPi.Libraries.DeviceDetection.RegEx
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    ///     Adapts the DeviceInfo class to the DeviceBase class.
    /// </summary>
    public class RegExAdapter : DeviceInfo
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RegExAdapter" /> class.
        /// </summary>
        /// <param name="userAgent">The user agent</param>
        /// <exception cref="RegexMatchTimeoutException">A time-out occurred.</exception>
        /// <exception cref="ArgumentException">A regular expression parsing error occurred.</exception>
        /// <exception cref="ArgumentNullException">Input or pattern for the regex match is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The provided regex options is not a valid <see cref="T:System.Text.RegularExpressions.RegexOptions" /> value.</exception>
        public RegExAdapter(string userAgent)
        {
                // Regex b = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                // Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                // Regex t = new Regex(@"(android|ipad|playbook|silk)", RegexOptions.IgnoreCase | RegexOptions.Multiline);

                // Regex OS = new Regex(@"(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                // Regex device = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);
                // string device_info = string.Empty;

                // if (OS.IsMatch(userAgent))
                // {
                // device_info = OS.Match(userAgent).Groups[0].Value;
                // }
                // if (device.IsMatch(userAgent.Substring(0, 4)))
                // {
                // device_info += device.Match(userAgent).Groups[0].Value;
                // }

                // if ((b.IsMatch(userAgent) || v.IsMatch(userAgent.Substring(0, 4))))
                // {
                // Response.Redirect("http://detectmobilebrowser.com/mobile");
                // }
                this.DeviceType = string.Empty;

                // Check if user agent is a smart TV - http://goo.gl/FocDk
                if (Regex.IsMatch(
                    userAgent,
                    @"GoogleTV|SmartTV|Internet.TV|NetCast|NETTV|AppleTV|boxee|Kylo|Roku|DLNADOC|CE\-HTML",
                    RegexOptions.IgnoreCase))
                {
                    this.IsTv = true;
                }

                // Check if user agent is a TV Based Gaming Console
                else if (Regex.IsMatch(userAgent, "Xbox|PLAYSTATION.3|Wii", RegexOptions.IgnoreCase))
                {
                    this.IsConsole = true;
                }

                // Check if user agent is a Tablet
                else if ((Regex.IsMatch(userAgent, "iP(a|ro)d", RegexOptions.IgnoreCase)
                          || Regex.IsMatch(userAgent, "tablet", RegexOptions.IgnoreCase))
                         && (!Regex.IsMatch(userAgent, "RX-34", RegexOptions.IgnoreCase)
                             || Regex.IsMatch(userAgent, "FOLIO", RegexOptions.IgnoreCase)))
                {
                    this.IsTablet = true;
                }

                // Check if user agent is an Android Tablet
                else if (Regex.IsMatch(userAgent, "Linux", RegexOptions.IgnoreCase)
                         && Regex.IsMatch(userAgent, "Android", RegexOptions.IgnoreCase)
                         && !Regex.IsMatch(
                             userAgent,
                             "Fennec|mobi|HTC.Magic|HTCX06HT|Nexus.One|SC-02B|fone.945",
                             RegexOptions.IgnoreCase))
                {
                    this.IsTablet = true;
                }

                // Check if user agent is a Kindle or Kindle Fire
                else if (Regex.IsMatch(userAgent, "Kindle", RegexOptions.IgnoreCase)
                         || (Regex.IsMatch(userAgent, "Mac.OS", RegexOptions.IgnoreCase)
                             && Regex.IsMatch(userAgent, "Silk", RegexOptions.IgnoreCase)))
                {
                    this.IsEReader = true;
                }

                // Check if user agent is a pre Android 3.0 Tablet
                else if (Regex.IsMatch(
                    userAgent,
                    @"GT-P10|SC-01C|SHW-M180S|SGH-T849|SCH-I800|SHW-M180L|SPH-P100|SGH-I987|zt180|HTC(.Flyer|\\_Flyer)|Sprint.ATP51|ViewPad7|pandigital(sprnova|nova)|Ideos.S7|Dell.Streak.7|Advent.Vega|A101IT|A70BHT|MID7015|Next2|nook",
                    RegexOptions.IgnoreCase)
                         || (Regex.IsMatch(userAgent, "MB511", RegexOptions.IgnoreCase)
                             && Regex.IsMatch(userAgent, "RUTEM", RegexOptions.IgnoreCase)))
                {
                    this.IsTablet = true;
                }

                // Check if user agent is unique Mobile User Agent
                else if (Regex.IsMatch(
                    userAgent,
                    "BOLT|Fennec|Iris|Maemo|Minimo|Mobi|mowser|NetFront|Novarra|Prism|RX-34|Skyfire|Tear|XV6875|XV6975|Google.Wireless.Transcoder",
                    RegexOptions.IgnoreCase))
                {
                    this.IsMobile = true;
                }

                // Check if user agent is an odd Opera User Agent - http://goo.gl/nK90K
                else if (Regex.IsMatch(userAgent, "Opera", RegexOptions.IgnoreCase)
                         && Regex.IsMatch(userAgent, "Windows.NT.5", RegexOptions.IgnoreCase)
                         && Regex.IsMatch(
                             userAgent,
                             @"HTC|Xda|Mini|Vario|SAMSUNG\-GT\-i8000|SAMSUNG\-SGH\-i9",
                             RegexOptions.IgnoreCase))
                {
                    this.IsMobile = true;
                }

                // Check if user agent is Windows Desktop
                else if ((Regex.IsMatch(userAgent, "Windows.(NT|XP|ME|9)")
                          && !Regex.IsMatch(userAgent, "Phone", RegexOptions.IgnoreCase))
                         || Regex.IsMatch(userAgent, "Win(9|.9|NT)", RegexOptions.IgnoreCase))
                {
                }

                // Check if agent is Mac Desktop
                else if (Regex.IsMatch(userAgent, "Macintosh|PowerPC", RegexOptions.IgnoreCase)
                         && !Regex.IsMatch(userAgent, "Silk", RegexOptions.IgnoreCase))
                {
                }

                // Check if user agent is a Linux Desktop
                else if (Regex.IsMatch(userAgent, "Linux", RegexOptions.IgnoreCase)
                         && Regex.IsMatch(userAgent, "X11", RegexOptions.IgnoreCase))
                {
                }

                // Check if user agent is a Solaris, SunOS, BSD Desktop
                else if (Regex.IsMatch(userAgent, "Solaris|SunOS|BSD", RegexOptions.IgnoreCase))
                {
                }

                // Check if user agent is a Desktop BOT/Crawler/Spider
                else if (Regex.IsMatch(
                    userAgent,
                    "Bot|Crawler|Spider|Yahoo|ia_archiver|Covario-IDS|findlinks|DataparkSearch|larbin|Mediapartners-Google|NG-Search|Snappy|Teoma|Jeeves|TinEye",
                    RegexOptions.IgnoreCase)
                         && !Regex.IsMatch(userAgent, "Mobile", RegexOptions.IgnoreCase))
                {
                }

                // Otherwise assume it is a Mobile DeviceInfo
                else
                {
                    this.IsSmartPhone = true;
                }

                this.ScreenPixelsWidth = 0;

                this.ScreenPixelsHeight = 0;
        }
    }
}