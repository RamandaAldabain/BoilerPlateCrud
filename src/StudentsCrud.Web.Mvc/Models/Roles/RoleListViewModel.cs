using System.Collections.Generic;
using StudentsCrud.Roles.Dto;

namespace StudentsCrud.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
