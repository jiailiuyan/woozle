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
    
    
    	 public override Person Synchronize(Person entity, SessionData sessionData) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			var attachedObj = Context.SynchronizeObject(entity, sessionData);
    			
    			attachedObj.City = Context.SynchronizeObject(entity.City, sessionData); 
    
    			attachedObj.SalutationStatus = Context.SynchronizeObject(entity.SalutationStatus, sessionData); 
    
    			attachedObj.Mandator = Context.SynchronizeObject(entity.Mandator, sessionData); 
    
    			
    			//Navigation Property 'Customers'
    			stopwatch.Start();
    			foreach(var n in entity.Customers.Where(n => n.PersistanceState == PState.Added))
    			{ 
    				if (!attachedObj.Customers.Contains(n)) attachedObj.Customers.Add(n);
    				if (n is IMandatorCapable)
    				{
    					n.MandatorId = sessionData.Mandator.Id;
    				}
    			} 
    			foreach(var n in entity.Customers.Where(n => n.PersistanceState == PState.Modified || n.PersistanceState == PState.Deleted))
    			{ 
    					Context.SynchronizeObject(n, sessionData); 
    			} 
    			stopwatch.Stop();
    			Trace.TraceInformation(string.Format("Synchronize state of '{0}', took {1} ms", "Customers", stopwatch.ElapsedMilliseconds));
    			return attachedObj; 
    		}
    		catch (Exception e)
    		{
    			Trace.TraceError(e.Message); 
    			throw new PersistenceException(PersistenceOperation.SYNCHRONIZE, e); 
    		} 
         } 
    
    }
    
}
