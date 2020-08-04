
<!-- TOC -->

- [逐浪文本大师 ZoomlaFileDS](#逐浪文本大师-zoomlafileds)
    - [主要功能](#主要功能)
    - [开发指引](#开发指引)
        - [提示资源引用错误](#提示资源引用错误)
        - [如何扩展新功能](#如何扩展新功能)
        - [一：Clone代码并使用Visual Studio 2019打开解决方案](#一clone代码并使用visual-studio-2019打开解决方案)
        - [二：添加主界面新功能导航的配置](#二添加主界面新功能导航的配置)
        - [三：添加新功能Winform窗体代码](#三添加新功能winform窗体代码)
        - [最后：运行【ZFDS_WinKits】项目](#最后运行zfds_winkits项目)

<!-- /TOC -->


<p align="center">
  <a href="http://www.z01.com/">
    <img src="https://code.z01.com/img/zoomla_logo.svg" width="600">
  </a>
</p>
<br>

# 逐浪文本大师 ZoomlaFileDS
> 原用名：逐浪数据精灵


一个实用的windows小工具集合，里面包含了多个常用的小软件。其中的批量修改文件名及文件内容功能，可以自定义修改规则，支持规则的导入与导出。不需要安装Office软件，支持Excel/Word/Txt等文件的文件名或文件内容的批量修改操作。另外还包括正则表达式测试小工具、字符串转js常量工具、加密与解密和日期时间差等，您也可以很方便地扩展相关功能。


## 主要功能

- 1.文件批量改名改内容
- 2.Zoomla!逐浪CMS数据库维护
- 3.Zoomla!逐浪CMS标签工具
- 4.Zoomla!逐浪截图
- 5.设计师网网页取色
- 6.自由导库-支持一切数据库表导出为excel
- 7.在线音乐
- 8.IP地址读取
- 9.逐浪CMS安装配置文件加解密
- 10.正则表达式测试
- 11.字符串转js常量工具
- 12.常见加密解密
- 13.日期时间差
- 14.其它功能自由增加


## 开发指引

组件基于Devexpress 20

###  提示资源引用错误
使用C++\CLI环境创建窗体程序，在控件中添加外部资源（比如图片、数据库文件、音频等）出现System.Resources.MissingManifestResourceException错误。

可能的解决办法：
保持namespace与解决方案名称相同；
保持窗体类名与创建的窗体文件名相同。


### 如何扩展新功能


### 一：Clone代码并使用Visual Studio 2019打开解决方案


### 二：添加主界面新功能导航的配置

在配置文件（ZFDS_WinKits\Config\Config.xml）中添加相应代码：

```
<Category Name="扩展新功能" Sort="0">
  <CategoryItemList>
    <CategoryItem Sort="0" Name="这是一个新功能" AssemblyName="NewTestFunction"></CategoryItem>
  </CategoryItemList>
</Category>
```

### 三：添加新功能Winform窗体代码

- 在解决方案中添加新的winform项目，命名为：**NewTestFunction**（与上述添加配置中的AssemblyName属性保持一致）
- 在该项目中添加一个Index.cs的窗体，并继承BaseForm.BaseFormClass，作为其入口
- 重写新窗体的标题
```
        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        } 
```

- 注意：NewTestFunction项目的输出类型需要更改为**类库**；NewTestFunction项目需要添加引用BaseForm项目；ZFDS_WinKits项目需要添加引用NewTestFunction项目

### 最后：运行【ZFDS_WinKits】项目