//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics;
using System;
using System.Linq;
using System.Collections.Generic;
using Woozle.Model;
using Woozle.Model.SessionHandling;

namespace Woozle.Persistence.Ef.Repository
{
    public partial class PersonRepository  : AbstractRepository<Person>
    {
    
    	public PersonRepository(IEfUnitOfWork Context) : base(Context)
    	{
    	}
    
    
    	 public override Person Synchronize(Person entity, Session session) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			var attachedObj = Context.SynchronizeObject(entity, session);
    			
    			attachedObj.City = Context.SynchronizeObject(entity.City, session); 
    
    			attachedObj.SalutationStatus = Context.SynchronizeObject(entity.SalutationStatus, session); 
    
    			attachedObj.Mandator = Context.SynchronizeObject(entity.Mandator, session); 
    
    			
    			return attachedObj; 
    		}
    		catch (Exception e)
    		{
    			this.Logger.Error(e.Message); 
    			throw new PersistenceException(PersistenceOperation.SYNCHRONIZE, e); 
    		} 
         } 
    
    }
    
}
