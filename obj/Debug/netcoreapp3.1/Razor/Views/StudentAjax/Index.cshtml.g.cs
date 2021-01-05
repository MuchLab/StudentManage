#pragma checksum "D:\C#\AspNetCore\Homework07\Homework07\Views\StudentAjax\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9974bbd75afd252d0b091926fbcd57e9552ca4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentAjax_Index), @"mvc.1.0.view", @"/Views/StudentAjax/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\C#\AspNetCore\Homework07\Homework07\Views\_ViewImports.cshtml"
using Homework06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\AspNetCore\Homework07\Homework07\Views\_ViewImports.cshtml"
using Homework06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9974bbd75afd252d0b091926fbcd57e9552ca4b", @"/Views/StudentAjax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5d48fbe1390ab2814196e3ade04bcbb8526bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentAjax_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("IndexNav", async() => {
                WriteLiteral("\r\n    <li class=\"layui-nav-item layui-nav-itemed\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9974bbd75afd252d0b091926fbcd57e9552ca4b3471", async() => {
                    WriteLiteral("添加学生");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </li>\r\n");
            }
            );
            WriteLiteral("<table id=\"demo\" lay-filter=\"test\"></table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/html"" id=""barDemo"">
        <a class=""layui-btn layui-btn-xs"" lay-event=""edit"">编辑</a>
        <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del"">删除</a>
    </script>
    <script>
        getRemoteList();

        function getRemoteList() {
            const httpRequest = new XMLHttpRequest();
            httpRequest.onreadystatechange = alertContents;
            httpRequest.open('GET', 'https://localhost:5001/api/students');
            httpRequest.send();

            function alertContents() {
                if (httpRequest.readyState === XMLHttpRequest.DONE) {
                    if (httpRequest.status === 200) {
                        response = httpRequest.responseText;
                        console.log(response);
                    } else {
                        alert('There was a problem with the request.');
                    }
                }
            }
        }

        function deleteStudent(id) {
            const ht");
                WriteLiteral(@"tpRequest = new XMLHttpRequest();
            httpRequest.onreadystatechange = alertContents;
            httpRequest.open('DELETE', 'https://localhost:5001/api/students/' + id);
            httpRequest.send();

            function alertContents() {
                if (httpRequest.readyState === XMLHttpRequest.DONE) {
                    if (httpRequest.status === 204) {
                        alert('Student is deleted');
                    } else {
                        alert('There was a problem with the request.');
                    }
                }
            }
        }

        layui.use('table',
            function() {
                var table = layui.table;
                table.render({
                    elem: '#demo',
                    height: 420,
                    url: 'https://localhost:5001/api/students' ,//数据接口
                    title: '用户表',
                    toolbar: true, //开启工具栏，此处显示默认图标，可以自定义模板，详见文档,
                    totalRow: true //开启合计行");
                WriteLiteral(@"
                    ,
                    cols: [
                        [//表头
                            { edit: 'text', field: 'id', title: 'Id', width: '15%', sort: true, fixed: 'left' },
                            { edit: 'text', field: 'firstName', title: '用户名', width: '15%' },
                            { edit: 'text', field: 'lastName', title: '用户名', width: '15%' },
                            { edit: 'text', field: 'city', title: '城市', width: '15%' },
                            { edit: 'text', field: 'state', title: '国家', width: '15%' },
                            { edit: 'text', field: 'major', title: '专业', width: '15%' },
                            { edit: 'text', field: 'class', title: '班级', width: '15%' },
                            { edit: 'text', field: 'gpa', title: 'GPA', width: '15%' },
                            { edit: 'text', field: 'zipCode', title: 'ZipCode', width: '15%' },
                            { fixed: 'right', width: 120, align: 'center', toolbar: '#barDe");
                WriteLiteral(@"mo' }
                        ]
                    ]
                });

                //监听头工具栏事件
                table.on('toolbar(test)',
                    function(obj) {
                        var checkStatus = table.checkStatus(obj.config.id), data = checkStatus.data; //获取选中的数据
                        switch (obj.event) {
                        case 'add':
                            layer.prompt({
                                    formType: 2,
                                    value: '初始值',
                                    title: '请输入值',
                                    content: $('#innerForm')
                                },
                                function(value, index, elem) {
                                    alert(value); //得到value
                                    layer.close(index);
                                });
                            break;
                        case 'update':
                            if (data.length === 0) ");
                WriteLiteral(@"{
                                layer.msg('请选择一行');
                            } else if (data.length > 1) {
                                layer.msg('只能同时编辑一个');
                            } else {
                                layer.alert('编辑 [id]：' + checkStatus.data[0].id);
                            }
                            break;
                        case 'delete':
                            if (data.length === 0) {
                                layer.msg('请选择一行');
                            } else {
                                layer.msg('删除');
                            }
                            break;
                        };
                    });

                //监听行工具事件
                table.on('tool(test)',
                    function(obj) { //注：tool 是工具条事件名，test 是 table 原始容器的属性 lay-filter=""对应的值""
                        var data = obj.data //获得当前行数据
                            ,
                            layEvent = obj.event; //获得 lay-eve");
                WriteLiteral(@"nt 对应的值
                        if (layEvent === 'detail') {
                            layer.msg('查看操作');
                        } else if (layEvent === 'del') {
                            layer.confirm('真的删除行么',
                                function(index) {
                                    obj.del(); //删除对应行（tr）的DOM结构
                                    //向服务端发送删除指令
                                    deleteStudent(data.id);
                                    layer.close(index);

                                });
                        } else if (layEvent === 'edit') {
                            location.href = `/StudentAjax/Update/${data.id}`;
                        }
                    });
            });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591