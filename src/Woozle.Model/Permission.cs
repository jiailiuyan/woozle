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
    public partial class Permission : WoozleObject
    {
        public Permission()
        {
            this.FunctionPermissions = new ObservableCollection<FunctionPermission>();
        }
    
        private string name;
        private string description;
        private string logicalid;
    
        public string Name 
    	{ 
    		get { return this.name;} 
    		set { 
    			if(this.name != value)
    			{
    				this.name = value;
    			}
    		}
    	}
        public string Description 
    	{ 
    		get { return this.description;} 
    		set { 
    			if(this.description != value)
    			{
    				this.description = value;
    			}
    		}
    	}
        public string LogicalId 
    	{ 
    		get { return this.logicalid;} 
    		set { 
    			if(this.logicalid != value)
    			{
    				this.logicalid = value;
    			}
    		}
    	}
    
    
    private ObservableCollection<FunctionPermission> functionpermissions;
    
    public virtual ObservableCollection<FunctionPermission> FunctionPermissions 
    { 
    	get { return functionpermissions; } 
    	set
    	{
    		functionpermissions = value;
    	}
    }
    
    
    
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