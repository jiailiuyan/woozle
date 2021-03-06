﻿using System.Diagnostics;
using System.Linq;
using Woozle.Model;
using Woozle.Model.SessionHandling;
using Woozle.Persistence;

namespace Woozle.Domain.PersonManagement
{
    public class PersonLogic : IPersonLogic
    {
        private readonly IRepository<Person> personRepository;

        public PersonLogic(IRepository<Person> personRepository)
        {
            this.personRepository = personRepository;
        }

        public Person SearchForExistingPerson(Person personToCheck, SessionData sessionData)
        {
            Trace.TraceInformation("Search for existing person.");

            //Check only for existing persons if the person to check is new 
            if (personToCheck.Id == 0)
            {
                var persons = personRepository.CreateQueryable(sessionData);
                var query = from person in persons
                            where
                                ((string.IsNullOrEmpty(personToCheck.EnterpriseName) &&
                                  string.IsNullOrEmpty(person.EnterpriseName)) ||
                                 person.EnterpriseName == personToCheck.EnterpriseName) &&
                                ((string.IsNullOrEmpty(personToCheck.FirstName) &&
                                  string.IsNullOrEmpty(person.FirstName)) ||
                                 person.FirstName == personToCheck.FirstName) &&
                                ((string.IsNullOrEmpty(personToCheck.LastName) &&
                                  string.IsNullOrEmpty(person.LastName)) ||
                                 person.LastName == personToCheck.LastName) &&
                                ((string.IsNullOrEmpty(personToCheck.Street) &&
                                  string.IsNullOrEmpty(person.Street)) ||
                                 person.Street == personToCheck.Street) &&
                                person.CityId == personToCheck.CityId
                            select person;
                var personResult = query.FirstOrDefault();

                if (personResult != null)
                {
                    personResult.PersistanceState = PState.Modified;

                    if (!string.IsNullOrEmpty(personToCheck.EMail)) personResult.EMail = personToCheck.EMail;
                    if (!string.IsNullOrEmpty(personToCheck.Phone)) personResult.Phone = personToCheck.Phone;
                    if (!string.IsNullOrEmpty(personToCheck.Mobile)) personResult.Phone = personToCheck.Mobile;

                    return personResult;
                } else
                {
                    personToCheck.PersistanceState = PState.Added;
                }
            }
            return personToCheck;
        }
    }
}
