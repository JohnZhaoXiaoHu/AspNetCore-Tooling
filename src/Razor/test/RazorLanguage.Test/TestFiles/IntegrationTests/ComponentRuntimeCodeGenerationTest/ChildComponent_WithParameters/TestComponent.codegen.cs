// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "IntProperty", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                 123

#line default
#line hidden
#nullable disable
            ));
            builder.AddAttribute(2, "BoolProperty", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
                  true

#line default
#line hidden
#nullable disable
            ));
            builder.AddAttribute(3, "StringProperty", "My string");
            builder.AddAttribute(4, "ObjectProperty", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Test.SomeType>(
#nullable restore
#line 5 "x:\dir\subdir\Test\TestComponent.cshtml"
                    new SomeType()

#line default
#line hidden
#nullable disable
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
