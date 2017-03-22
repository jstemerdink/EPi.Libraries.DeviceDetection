# EPi.Libraries.DeviceDetection

By Jeroen Stemerdink

[![Build status](https://ci.appveyor.com/api/projects/status/60vg1xeix98n9w3o/branch/master?svg=true)](https://ci.appveyor.com/project/jstemerdink/epi-libraries-devicedetection/branch/master)
[![GitHub version](https://badge.fury.io/gh/jstemerdink%2FEPi.Libraries.DeviceDetection.svg)](http://badge.fury.io/gh/jstemerdink%2FEPi.Libraries.DeviceDetection)
[![Semver](http://img.shields.io/SemVer/2.0.0.png)](http://semver.org/spec/v2.0.0.html)
[![Platform](https://img.shields.io/badge/platform-.NET%204.5.2-blue.svg?style=flat)](https://msdn.microsoft.com/en-us/library/w0x726c2%28v=vs.110%29.aspx)
[![Platform](https://img.shields.io/badge/EPiServer-%2010.0.0-orange.svg?style=flat)](http://world.episerver.com/cms/)  
[![Issue Count](https://codeclimate.com/github/jstemerdink/EPi.Libraries.DeviceDetection/badges/issue_count.svg)](https://codeclimate.com/github/jstemerdink/EPi.Libraries.DeviceDetection)
[![Dependency Status](https://www.versioneye.com/user/projects/57aad478c75d64003af415b5/badge.svg?style=flat-square)](https://www.versioneye.com/user/projects/57aad478c75d64003af415b5)
[![Stories in Backlog](https://badge.waffle.io/jstemerdink/EPi.Libraries.DeviceDetection.svg?label=enhancement&title=Backlog)](http://waffle.io/jstemerdink/EPi.Libraries.DeviceDetection)

## About
Get some basic info about the device that's browsing your website. Use wurfl or 51degrees to get the information. 
Or create use your own by creating a provider for it by implementing ```IDeviceDetectionService```. It will be picked up automatically.

## Parts

[Base for detection services](EPi.Libraries.DeviceDetection/README.md)

[51 degrees cloud detection service](EPi.Libraries.DeviceDetection.FiftyOneCloud/README.md)

[51 degrees on premise detection service](EPi.Libraries.DeviceDetection.FiftyOne/README.md)

[Wurfl on premise detection service](EPi.Libraries.DeviceDetection.Wurfl/README.md)

[Wurflcloud detection service](EPi.Libraries.DeviceDetection.WurflCloud/README.md)


> *Powered by ReSharper*

> [![image](http://resources.jetbrains.com/assets/media/open-graph/jetbrains_250x250.png)](http://jetbrains.com)

