# GoogleAnalyticsDemo

## Intro

This project illustrates how to incorporate Google Analytics with a Unity project that will be built for iOS on Unity Cloud Build.

[Google Analytics Plugin for Unity](https://developers.google.com/analytics/devguides/collection/unity/v4/devguide#before_begin)

While the plugin includes a post-build script that registers the required frameworks to use Google Analytics, this project uses the [XCode Manipulation API](https://bitbucket.org/Unity-Technologies/xcodeapi) to make those modifications both while building locally, as well as in the cloud.

## Unity Cloud Build Setup

When adding this as a new Cloud Build build target, go to the 'Config' tab of your project and find 'Advanced Options' for your build target. Set 'Post-Export Method' to `PostBuildProcessor.OnPostprocessBuildiOS` and click Save.