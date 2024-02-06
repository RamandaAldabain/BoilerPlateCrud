using System.Collections.Generic;
using StudentsCrud.Roles.Dto;

namespace StudentsCrud.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}