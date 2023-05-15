using Identity.Bugeto.Models.Dto.Blog;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Bugeto.Helpers
{
    public class BlogRequirement: IAuthorizationRequirement
    {
    }

    public class IsBlogForUserAuthorizationHandler : AuthorizationHandler<BlogRequirement, BlogDto>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BlogRequirement requirement, BlogDto resource)
        {
           if(context.User.Identity?.Name == resource.UserName)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
