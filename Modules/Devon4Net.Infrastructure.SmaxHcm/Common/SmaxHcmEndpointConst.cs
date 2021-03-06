﻿namespace Devon4Net.Infrastructure.SmaxHcm.Common
{
    public static class SmaxHcmEndpointConst
    {
        public const string AuthorizationHeaderTokenkey = "LWSSO_COOKIE_KEY";
        public const string Logon = "/auth/authentication-endpoint/authenticate/login";
        public const string Users = "/bo/rest/entities/user";
        public const string User = "/bo/rest/entities/user/{0}?timeStamp={1}"; //UserId, time stamp
        public const string UserTenants = "/bo/rest/entities/tenant?timeStamp={0}&filter=(user+eq+\"{1}\")";
        public const string Offerings = "/rest/{0}/ems/Offering"; //tenant Id
        public const string OfferingDetail = "/rest/{0}/ems/Offering/{1}"; //tenant ID, offering Id
    }
}
