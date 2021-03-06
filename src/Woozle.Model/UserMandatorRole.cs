//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Woozle.Model
{
    [Serializable]
    public partial class UserMandatorRole : WoozleObject
    {
        private int userid;
        private int mandatorroleid;
    
        public int UserId 
    	{ 
    		get { return this.userid;} 
    		set { 
    			if(this.userid != value)
    			{
    				this.userid = value;
    			}
    		}
    	}
        public int MandatorRoleId 
    	{ 
    		get { return this.mandatorroleid;} 
    		set { 
    			if(this.mandatorroleid != value)
    			{
    				this.mandatorroleid = value;
    			}
    		}
    	}
    
    
    public virtual MandatorRole MandatorRole { get; set; }
    
    
    public virtual User User { get; set; }
    
    
    
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (GetType() != obj.GetType())
            return false;
    	//objects are equal when they are not new (Id != 0) and the Ids are equal
        WoozleObject other = (WoozleObject)obj;
        if (Id == 0 || Id != other.Id)
            return false;
        return true;
    }
    
    public override int GetHashCode()
    {
        int prime = 31;
    	int result = 1;
    	result = prime * result + Id;
    	return result;
    }
    }
    
}
