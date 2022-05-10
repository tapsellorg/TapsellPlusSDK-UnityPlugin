## Tapsell plus Unity Changelog

## 2.1.8-alpha01
* refactor release process

### v2.1.7 - 2022/04/04
* [Using Tapsell Plus version 2.1.7](/plus-sdk/android/main/#v217---20220328)
* Update AdMob to `20.6.0` and AppSetId to 16.0.2 which fixes [#41](https://github.com/tapsellorg/TapsellPlusSDK-AndroidSample/issues/41)
* Fix `SSL Exception` prior to Android 4.4
* Minor bug fixes

### v2.1.6 - 2022/01/12
* Using the Tapsell version 4.7.4
* Fixed native banner issue
* Updated TargetSDK to 31
* Improve ad request error
  To use this feature, invoke
  `TapsellPlus.setDebugMode (Log.DEBUG)`
  after initialize method

* Added support for Mintegral ** 15.6.11 **
    - You can refer to [Advertising Networks](/plus-sdk/android/add-adnetworks/index.html) for more information
    * Added Ability to display GDPR dialog at any time by Developer
    - Added the method `TapsellPlus.showGDPRDialog(activity)` to display the dialog
* AppLovin support ** 10.3.4 **
* Support for UnityAds ** 3.7.5 **
* AdMob support ** 20.4.0 **
* AdColony support ** 4.6.5 **

### v2.1.3 - 2021/07/21
* [Using Tapsell Plus version 2.1.3](/plus-sdk/android/main/#v213---20210721)
* Added native banner to AdColony
* Added Interstitial banner to AdColony
* Added support for AdMob version of 20.2.0

> The Adobe Update requires changes to the implementation. See [Add Ad Networks](/plus-sdk/unity/add-adnetworks/index.html) for more information.

* Chartboost support ** 8.2.1 **
* AppLovin support ** 10.3.1 **
* UnityAds support ** 3.7.4 **


### v2.1.2 - 2021/06/08
> ** NOTE ** From this version onwards, the version number of TapsellPlus Unity Plugin will be in accordance with the version number of TapsellPlus Android SDK. Therefore, the current version 2.1.2 is newer than the previous version 2.5


* [Using TepselPlus version 2.1.2](https://docs.tapsell.ir/plus-sdk/android/main/#v212---20210607)
* Added AdMob AdIcon in native banner ads.
* Added support for the Android 11
* Added support for Standard and Interstitial ads
* Fixed pressing on native ads

### v2.5 - 2020/12/07
* Using the Tapsell Plus version 1.2.2

### v2.4 - 2020/9/22
* Using the Tapsell Plus version 1.2.1
* Added the ability to display AdMob native ads
* Change in the implementation of receiving clicks in native ads

### v2.3 - 2020/8/31
* Using the Tapsell Plus version 1.1.3

### v1.1.1 - 2020/1/21
* Fixed user-agent issue
* Using the Tapsell version 4.4.1
* Fixed error callback issue
* Added GDPR Configuration

### v1.1.0 - 2020/1/12
* Improvements in working with threads
* Using the Tapsell version 4.4.0
* Using the consumer proguard file

### v1.0.12 - 2019/12/02
* Fixed ConsentDialog issue
* Fixed reported issues
