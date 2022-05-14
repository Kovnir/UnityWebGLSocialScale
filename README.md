# UnityWebGLSocialShare

<b>UnityWebGLSocialShare</b> is a small JS+C# library that allows you to share posts on `Facebook` and `Twitter` from WebGL build of your Unity application.

<a href="https://kovnir.github.io/webglshare" target="_blank">Web Example</a>

⚠️ The plugin works only in the WebGL. In the Unity Editor, you will only see the log with the text of the post in the Console.

<div align="center">
<img width=50% src="Doc/ShareExample.gif">
</div>
  
## Installation

To install the plugin to your project, choose any of options below.
### AssetStore
Coming soon...

### UPM
Coming soon...

### From Github
Open <a href="https://github.com/Kovnir/UnityWebGLSocialShare/releases" target="_blank">Release List</a>, find latest version, download `UnityWebGLSocialShare.unitypackage` from it. Drag to Unity and import all files.

## API

### Namespace

To use `UnityWebGLSocialShare` you need to add namespace in each class where you want to use it.
```c#
using Kovnir.WebGLSocialShare;
```
### Function Call

All API is in the WebGLSocialShare class.

```c#
WebGLSocialShare.Facebook("This is post text", "http://your-site.com");
WebGLSocialShare.Twitter("This is post text", "http://your-site.com", "hashtag");
```

## Example
To see the example of plugin usage, open the `SampleScene` scene and check `WebGLShareExample` script.

<div align="center">
<img width=80% src="Doc/Example.png">
</div>
