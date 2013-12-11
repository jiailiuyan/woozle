//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace Woozle.Services.Modules.Settings
{
    [Serializable]
    [Route("/settings", "GET,POST,PUT")]
    public partial class SettingDto : WoozleDto, IReturn<SettingDto>, IReturn<SaveResultDto<SettingDto>>
    {
        public string EventManagementPlanningEMail { get; set; }
        public string EventManagementPlanningMobile { get; set; }
        public byte[] ChangeCounter { get; set; }
    
        public Mandator.MandatorDto MandatorDto { get; set; }
    
    }
    
}