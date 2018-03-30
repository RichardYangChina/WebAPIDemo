using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebAPIDemo.Models
{
    [DataContract]
    public partial class TUser
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool? Sex { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Passcode { get; set; }
        [DataMember]
        public string Mygift { get; set; }
    }
}
