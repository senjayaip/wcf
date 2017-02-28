using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.data
{
    [DataContract]
    public class DataClass1
    {
        //[DataMember]
        //public string text1 { get; set; }

        [DataMember]
        public Dictionary<int, Reportrec> Reportsrc{ get; set; }

        //[DataMember]
        //public Reportsrc2 Reportsrc2 { get; set; }
        [DataMember]
        public List<Reportrec> Reportsrc2 { get; set; }

    }

    public class Reportsrc2:List<Reportrec>
    {
    }

    [DataContract]
    public class Reportrec
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string message { get; set; }
    }

}