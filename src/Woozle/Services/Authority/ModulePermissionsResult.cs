﻿namespace Woozle.Services.Authority
{
    public class ModulePermissionsResult
    {
        public int FunctionPermissionId { get; set; }

        public int ModuleId { get; set; }

        public string ModuleName { get; set; }

        public string FunctionName { get; set; }

        public string PermissionName { get; set; }

        public bool HasPermission { get; set; }
    }
}
