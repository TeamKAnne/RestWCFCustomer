using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestWCFCustomer
{
    /// <summary>
    /// Denne klasse indeholder attributter for costumer.
    /// </summary>
    [DataContract]
    public class Costumer
    {
        /// <summary>
        /// Prop Id
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Prop FirstName
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }
        /// <summary>
        /// Prop LastName
        /// </summary>

        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// prop year
        /// </summary>
        [DataMember]
        public int Year { get; set; }

        /// <summary>
        /// Default konstruktor - REST afhænger af en default, måske???
        /// </summary>
        public Costumer()
        {

        }
        /// <summary>
        /// Overloaded konstruktør som initierer en instans costumer med 4 atributter. 
        /// </summary>
        public Costumer(int id, string firstname, string lastname, int year)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Year = year;
        }


    }
}