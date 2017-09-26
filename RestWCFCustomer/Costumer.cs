using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace RestWCFCustomer
{
    [DataContract]
    public class Costumer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int MyProperty { get; set; }

        [DataMember]
        public int Year { get; set; }

    }
}