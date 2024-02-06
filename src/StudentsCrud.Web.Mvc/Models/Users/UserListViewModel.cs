using System.Collections.Generic;
using StudentsCrud.Roles.Dto;

namespace StudentsCrud.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
