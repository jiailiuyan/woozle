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
using Woozle.Model;
using Woozle.Model.SessionHandling;

namespace Woozle.Persistence.Ef.Repository
{
    public partial class MandatorGroupRepository  : AbstractRepository<MandatorGroup>
    {
    
    	public MandatorGroupRepository(IEfUnitOfWork Context) : base(Context)
    	{
    	}
    
    
    	 public override MandatorGroup Synchronize(MandatorGroup entity, Session session) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			var attachedObj = Context.SynchronizeObject(entity, session);
    			
    			
    			//Navigation Property 'Mandators'
    			stopwatch.Start();
    			foreach(var n in entity.Mandators.Where(n => n.PersistanceState == PState.Added))
    			{ 
    				if (!attachedObj.Mandators.Contains(n)) attachedObj.Mandators.Add(n);
    				if (n is IMandatorCapable)
    				{
    					n.MandatorId = session.SessionObject.Mandator.Id;
    				}
    			} 
    			foreach(var n in entity.Mandators.Where(n => n.PersistanceState == PState.Modified || n.PersistanceState == PState.Deleted))
    			{ 
    					Context.SynchronizeObject(n, session); 
    			} 
    			stopwatch.Stop();
    			this.Logger.Info(string.Format("Synchronize state of '{0}', took {1} ms", "Mandators", stopwatch.ElapsedMilliseconds));
    			return attachedObj; 
    		}
    	catch (Exception e)
    	{
    		this.Logger.Error(e.Message); 
    		throw new PersistenceException(PersistenceOperation.SYNCHRONIZE, e); 
    	} 
      } 
    	 public override void Delete(MandatorGroup entity, Session session) 
    	 { 
    		try
    		{
    			var stopwatch = new Stopwatch();
    			entity.PersistanceState = PState.Unchanged;
    			var attachedObj = Context.SynchronizeObject(entity, session);
    			
    			
    
    			//Navigation Property 'Mandators'
    			stopwatch.Start();
    			Context.LoadCollection<MandatorGroup>(attachedObj.Id, "Mandators");
    			foreach (var n in attachedObj.Mandators.ToList())
    			{
    				n.PersistanceState = PState.Deleted;
    			    Context.SynchronizeObject(n, session);
    			} 
    			stopwatch.Stop();
    			this.Logger.Info(string.Format("Synchronize state of '{0}', took {1} ms", "Mandators", stopwatch.ElapsedMilliseconds));
    			attachedObj.PersistanceState = PState.Deleted;
    			attachedObj = Context.SynchronizeObject(attachedObj, session);
    			stopwatch.Start();
    			Context.Commit();
    			stopwatch.Stop();
    			this.Logger.Info(string.Format("Commit '{0}' Delete, took {1} ms", "MandatorGroup", stopwatch.ElapsedMilliseconds));
    		}
    	catch (Exception e)
    	{
    		this.Logger.Error(e.Message); 
    		throw new PersistenceException(PersistenceOperation.DELETE, e);  
    	} 
      } 
    
    }
    
}