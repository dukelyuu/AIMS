# AIMS-
The smart archives information manager system.

2015-09-06
-------------------------------------------------------
Initial Commit
搭建框架：

1、采用ABP框架，MUtilweb/AngularJS/WPF UI

2、采用EF模式

3、没有集成ZERO权限模块

4、源码说明：

	a) AIMS.UI---前端UI层，里面包含三个工程：
		Mutil.UI:jquery+asp.net MVC5
		AngularJS.UI:angularjs+asp.net MVC5
		WPF.UI：MVVMLight+WPF
	b）AIMS.Api---API层
	c) AIMS.Application---应用领域层
	d) AIMS.Core---核心业务层
	e) AIMS.Entity---实体层
	f) AIMS.Common---公共库管理层
	g) AIMS.Docs---文档管理层
5、数据库生成
	

----------
1. 在VS2013底部的“程序包管理器控制台”窗口中，选择默认项目并执行命令“Add-Migration InitialCreate”
2. 在“程序包管理器控制台”执行“Update-Database”，会自动在数据库创建相应的数据表
3. 修改了实体，可以再次执行Add-Migration和Update-Database，就能很轻松的让数据库结构与实体类的同步