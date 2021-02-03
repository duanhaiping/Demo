action 是controller 中的public 方法，无关返回值

若是想在controller 中声明public 方法。，但不希望在web中调用，即不希望是action ，那么就添加注释[NonAction]

return view ()默认根据controller和action 的路径返回 对应文件夹中的视图，含参数就返回名称为参数名的文件

view() 的作用，创建ViewResult 对象，并且渲染成视图，然后返回视图给浏览器


controller 与view 的值传递

1. viewdata
2. viewbag

viewdata 通过view Data传递，cshtml 中增加服务端代码。然后解析

viewdata 实现了IDictionary<string, object> ，因此 键为string,值为object ，因此转换

ViewBag可以称为ViewData的一块关于语法的辅助的糖果，ViewBag使用C# 4.0的动态特征，使得ViewData也具有动态特性。

viewBag 和ViewData 的缺点：

controller 没法感知view 的变化，view 中值类型转换出错将抛出异常，无法捕获异常 

强类型

在 return view() 时候，将数据作为参数传递给engine,@using Demo.ViewModels
@model EmployeeViewModel 这样去使用，原理是什么？？？ 


MVC的过滤器

四种

  1. Authorization 授权过滤器 IAuthorizationFilter 默认实现为AuthorizeAttribute
  2. Exception 异常过滤器 IExceptionFilter  默认实现为HandleErrorAttribute
  3. Action 行为处理器 IActionFilter  默认实现为 ActionFilterAttribute
  4. Result IResultFilter  用于返回结果的之前或之后的处理

model 验证

1. 使用 ModelState 对Model对象的属性值自行判断合法性 ,要自己处理验证失败的情况
2. Model各属性上直接定义验证规则，然后DefaultModelBinder类会自动进行验证


