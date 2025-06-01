# img2base64


这是一个很简单的用于转换图片于base64的程序

~~是好久没写程序重回后的复健作，耗时1day~~

## 使用方法 & 二次修改

使用方法：选择一张图片后点击开始转换，base64结果便会出现在右方文本框

本程序使用MIT开源，你可以在遵守MIT协议的情况下进行修改和二次分发

推荐使用[Visual Studio](https://visualstudio.microsoft.com/zh-hans/vs)进行开发

- 工作负荷
	- Web 和云
		- ASP.NET 和 Web 开发
	- 桌面应用和移动应用
		- .NET 桌面开发

SDK：

[.NET SDK 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0)

本程序使用WPF进行开发，此为[微软官方文档](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/)

## 程序布局

程序分为三个区域

左侧为图片区域，右侧为base64区域，最下方为日志区域

在[MainWindow](img2base64/MainWindow.xaml)中使用了注释来划分三个区域

## TODO

- [x] 完成UI界面
- [x] 完成图片选择部分
- [x] 完成图片转base64逻辑
- [x] 将输出的base64放到Base64Result文本框内
- [x] 完成文本复制按钮逻辑
- [x] 完成日志记录逻辑
- [ ] base64转图片 