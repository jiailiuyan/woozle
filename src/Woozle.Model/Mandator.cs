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
    public partial class Mandator : WoozleObject, IManagedConcurrency
    {
        public Mandator()
        {
            this.Modules = new ObservableCollection<Module>();
            this.Locations = new ObservableCollection<Location>();
            this.MandatorRoles = new ObservableCollection<MandatorRole>();
            this.People = new ObservableCollection<Person>();
            this.Settings = new ObservableCollection<Setting>();
        }
    
        private string name;
        private string street;
        private string phone;
        private Nullable<int> cityid;
        private byte[] changecounter;
        private string email;
        private byte[] picture;
        private Nullable<int> mandatorgroupid;
    
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
        public string Street 
    	{ 
    		get { return this.street;} 
    		set { 
    			if(this.street != value)
    			{
    				this.street = value;
    			}
    		}
    	}
        public string Phone 
    	{ 
    		get { return this.phone;} 
    		set { 
    			if(this.phone != value)
    			{
    				this.phone = value;
    			}
    		}
    	}
        public Nullable<int> CityId 
    	{ 
    		get { return this.cityid;} 
    		set { 
    			if(this.cityid != value)
    			{
    				this.cityid = value;
    			}
    		}
    	}
        public byte[] ChangeCounter 
    	{ 
    		get { return this.changecounter;} 
    		set { 
    			if(this.changecounter != value)
    			{
    				this.changecounter = value;
    			}
    		}
    	}
        public string Email 
    	{ 
    		get { return this.email;} 
    		set { 
    			if(this.email != value)
    			{
    				this.email = value;
    			}
    		}
    	}
        public byte[] Picture 
    	{ 
    		get { return this.picture;} 
    		set { 
    			if(this.picture != value)
    			{
    				this.picture = value;
    			}
    		}
    	}
        public Nullable<int> MandatorGroupId 
    	{ 
    		get { return this.mandatorgroupid;} 
    		set { 
    			if(this.mandatorgroupid != value)
    			{
    				this.mandatorgroupid = value;
    			}
    		}
    	}
    
    
    private ObservableCollection<Module> modules;
    
    public virtual ObservableCollection<Module> Modules 
    { 
    	get { return modules; } 
    	set
    	{
    		modules = value;
    	}
    }
    
    
    private ObservableCollection<Location> locations;
    
    public virtual ObservableCollection<Location> Locations 
    { 
    	get { return locations; } 
    	set
    	{
    		locations = value;
    	}
    }
    
    
    public virtual City City { get; set; }
    
    
    private ObservableCollection<MandatorRole> mandatorroles;
    
    public virtual ObservableCollection<MandatorRole> MandatorRoles 
    { 
    	get { return mandatorroles; } 
    	set
    	{
    		mandatorroles = value;
    	}
    }
    
    
    private ObservableCollection<Person> people;
    
    public virtual ObservableCollection<Person> People 
    { 
    	get { return people; } 
    	set
    	{
    		people = value;
    	}
    }
    
    
    private ObservableCollection<Setting> settings;
    
    public virtual ObservableCollection<Setting> Settings 
    { 
    	get { return settings; } 
    	set
    	{
    		settings = value;
    	}
    }
    
    
    public virtual MandatorGroup MandatorGroup { get; set; }
    
    
    
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