# TechShop current architecture image

Generated with the built-in image_gen tool. Based on source inspection, not a runtime deployment verification.

BusinessLayer and DataAccessLayer boxes represent shared code. The API and WinForms instantiate and run that code in separate processes.

## Generation prompt

Use case: infographic-diagram.
Create a precise educational architecture infographic for the EXISTING TechShop C# repository, in simplified Chinese with exact English code names. Landscape, high resolution, crisp readable text, white background, restrained blue/teal/orange palette, flat professional diagram, generous spacing, clean orthogonal arrows. Title "TechShop 当前项目架构". Subtitle "从入口到数据库，理解现有代码". This is a source-code architecture overview, not a verified deployment diagram.

Layout: main flow occupies left 75%, explanatory sidebar right 25%. Main flow runs top to bottom. Top blue group "应用入口" with three small boxes: "ClientApp / ASP.NET Core MVC", "BlazorClientApp / Blazor WebAssembly", "ConsoleApp2 / 控制台调用示例". All three point down to one box "RestApi.Client / HTTP 客户端封装". That box points DOWN with clearly labeled "HTTP / JSON" arrow to "RestApi / ASP.NET Core Web API · .NET 8" containing "ProductController · BrandController · OrderController". Next arrow to teal box "BusinessLayer / ProductService · BrandService · OrderService", secondary text "业务规则 · AutoMapper 映射". Next arrow to teal box "DataAccessLayer", with internal sequence "UnitOfWork → Repository<T> → ModelContext", secondary text "EF Core 9 · 实体与表映射". Final downward arrow labeled "SQL" to database cylinder "SQL Server LocalDB / ComputerStoreDB", secondary "Brands · Products · Orders".

Place orange box "WinFormsApp / 桌面管理端" alongside API and business layers, with ONE clear orange arrow DIRECTLY to BusinessLayer, labeled "进程内调用". Do NOT connect WinForms to RestApi or RestApi.Client. Label nearby "自行创建数据库上下文". Note that shared BusinessLayer and DataAccessLayer represent reused code, not a shared running server instance.

Right sidebar separated from main flow with no accidental flow arrows:
1. pale purple box "Models / 层间数据模型" and small text "ProductModel · OrderModel · BrandModel" then "与数据库实体通过 AutoMapper 转换". This is shared code, not another sequential request hop.
2. gray box "BlazorApp / 独立界面原型" with "当前商品与结账页面使用示例数据" and "未接入上述 API 主链路". NO arrows from this box.
3. reading guide "建议阅读顺序" with "① ProductController.Get" / "② ProductService.Get" / "③ Repository.Get" / "④ ModelContext".
Footer small text "箭头表示调用方向；响应沿原路返回。辅助 Tester 与旧界面项目省略。" and "当前架构，不包含计划中的 React、Azure 或 AI 功能。"
Accuracy paramount. No future stack components, no invented authentication, no clouds, no decorative circuit lines. Ensure arrows terminate at intended boxes and do not cross text.
