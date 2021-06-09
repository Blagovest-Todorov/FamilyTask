using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private readonly HashSet<Person> members; // readonly is immutalbe! 

        // Good Practice! 
        public Family()
        { // Good Practice! 
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member) 
        {
            this.members.Add(member);
        }

        public Person GetOldestMember()
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //{
        //Explicitely  typed
        //Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //return person;
        //}

        public HashSet<Person> GetPeopleAbove30()
            => this.members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToHashSet();
    }
}
