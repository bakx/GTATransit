using System.Runtime.Serialization;

namespace Models
{
    public class Routes
    {
        /// <summary>
        /// Identifies a route.
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = true)]
        public string RouteId { get; set; }

        /// <summary>
        /// Agency for the specified route. This field is required when the dataset provides data for routes from more than one
        /// agency in agency.txt, otherwise it is optional.
        /// </summary>
        [DataMember(Name = "agency_id", IsRequired = false)]
        public string AgencyId { get; set; }

        /// <summary>
        /// Short name of a route. This will often be a short, abstract identifier like "32", "100X", or "Green" that riders use to
        /// identify a route, but which doesn't give any indication of what places the route serves. Either route_short_name or
        /// route_long_name must be specified, or potentially both if appropriate.
        /// </summary>
        [DataMember(Name = "route_short_name", IsRequired = false)]
        public string RouteShortName { get; set; }

        /// <summary>
        /// Full name of a route. This name is generally more descriptive than the route_short_name and often includes the route's
        /// destination or stop. Either route_short_name or route_long_name must be specified, or potentially both if appropriate.
        /// </summary>
        [DataMember(Name = "route_long_name", IsRequired = false)]
        public string RouteLongName { get; set; }

        /// <summary>
        /// Description of a route that provides useful, quality information. Do not simply duplicate the name of the route.
        /// </summary>
        [DataMember(Name = "route_desc", IsRequired = false)]
        public string RouteDesc { get; set; }
    }
}