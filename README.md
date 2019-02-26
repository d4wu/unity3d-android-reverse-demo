# unity3d-android-reverse-demo

该项目是[《简单Unity3D类安卓游戏逆向思路》](https://paper.seebug.org/828/)一文中使用的 demo。
Unity3D 版本： 

## 目录结构
```
.
|____demo           Unity3D项目文件夹
|____game.apk       编译出的APK文件
|____LICENSE        GPL证书
|____README.md      
```

## 使用方法
打开 `Unity3D` ，将 `demo` 文件夹作为项目打开即可。
如果仅仅是学习逆向，可以直接解压 `game.apk`。取出 `assets/bin/data/Managed/Assembly-CSarp.dll` 进行反编译，反编译结果可以和 `demo\Assets\Scenes\` 目录的源码进行对比。

## 安装参考链接
如果你想自行安装 Unity3D 和 android SDK 来进行编译，下列参考链接可能会对你有所帮助：
1. [Unity3D 下载地址](https://unity3d.com/cn/get-unity/download)
2. [Unity - Manual: Android environment setup](https://docs.unity3d.com/Manual/android-sdksetup.html)
