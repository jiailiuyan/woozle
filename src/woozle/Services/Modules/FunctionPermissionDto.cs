//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Woozle.Services.Modules
{
    [Serializable]
    public partial class FunctionPermissionDto : WoozleDto
    {
        public int FunctionId { get; set; }
        public int PermissionId { get; set; }
    
        public FunctionDto FunctionDto { get; set; }
        public PermissionDto PermissionDto { get; set; }
    }
    
}