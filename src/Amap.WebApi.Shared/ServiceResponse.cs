﻿using System.Runtime.Serialization;

namespace Amap.WebApi.Shared
{
    [DataContract]
    public class ServiceResponse
    {
        [DataMember(Name = "status")]
        public int Status { get; set; }

        [DataMember(Name = "info")]
        public string Info { get; set; }

        [DataMember(Name = "errcode")]
        public int ErrorCode { get; set; }
    }
}
