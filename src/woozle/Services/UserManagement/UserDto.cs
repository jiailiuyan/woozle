
using System;
using System.Collections.ObjectModel;
using ServiceStack;
using ServiceStack.ServiceHost;
using Woozle.Model;

namespace Woozle.Services.UserManagement
{
    [Serializable]
    [Route("/users", "POST,PUT,DELETE")]
    [Route("/users/{Id}")]
    public partial class UserDto : WoozleDto, IReturn<UserResponse>, IReturn<SaveResultDto<UserDto>>, IReturnVoid
    {
        public UserDto()
        {
            this.UserMandatorRoles = new ObservableCollection<UserMandatorRole>();
        }
    
        public string Username { get; set; }
        public string Password { get; set; }
        public bool FlagActive { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<System.DateTime> LastPasswordChange { get; set; }
        public int LanguageId { get; set; }
        public int FlagActiveStatusId { get; set; }
        public byte[] ChangeCounter { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public Language Language { get; set; }
        public Status Status { get; set; }
        public ObservableCollection<UserMandatorRole> UserMandatorRoles { get; set; }
    
    }

    public class UserResponse
    {
        public UserDto UserDto { get; set; }
    }
    
}
