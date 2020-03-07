using System.Runtime.Serialization;

namespace Models
{
 public abstract class Routes
 {
            /// <summary>
        /// Platform identifier for a platform stop (a stop belonging to a station). This should be just the platform identifier (eg. "G" or "3"). Words like “platform” or "track" (or the feed’s language-specific equivalent) should not be included. This allows feed consumers to more easily internationalize and localize the platform identifier into other languages.
        /// </summary>
        [DataMember(Name = "platform_code", IsRequired = false)]
        public string PlatformCode { get; set; }
        /// <summary>
        /// Identifies a route.
        /// </summary>
        [DataMember(Name = "route_id", IsRequired = true)]
        public string RouteId { get; set; }
        /// <summary>
        /// Agency for the specified route. This field is required when the dataset provides data for routes from more than one agency in agency.txt, otherwise it is optional.
        /// </summary>
        [DataMember(Name = "agency_id", IsRequired = false)]
        public string AgencyId { get; set; }
        /// <summary>
        /// Short name of a route. This will often be a short, abstract identifier like "32", "100X", or "Green" that riders use to identify a route, but which doesn't give any indication of what places the route serves. Either route_short_name or route_long_name must be specified, or potentially both if appropriate.
        /// </summary>
        [DataMember(Name = "route_short_name", IsRequired = false)]
        public string RouteShortName { get; set; }
        /// <summary>
        /// Full name of a route. This name is generally more descriptive than the route_short_name and often includes the route's destination or stop. Either route_short_name or route_long_name must be specified, or potentially both if appropriate.
        /// </summary>
        [DataMember(Name = "route_long_name", IsRequired = false)]
        public string RouteLongName { get; set; }
        /// <summary>
        /// Description of a route that provides useful, quality information. Do not simply duplicate the name of the route.Example: "A" trains operate between Inwood-207 St, Manhattan and Far Rockaway-Mott Avenue, Queens at all times. Also from about 6AM until about midnight, additional "A" trains operate between Inwood-207 St and Lefferts Boulevard (trains typically alternate between Lefferts Blvd and Far Rockaway).
        /// </summary>
        [DataMember(Name = "route_desc", IsRequired = false)]
        public string RouteDesc { get; set; }
        /// <summary>
        /// Indicates the type of transportation used on a route. Valid options are:0 - Tram, Streetcar, Light rail. Any light rail or street level system within a metropolitan area.1 - Subway, Metro. Any underground rail system within a metropolitan area.2 - Rail. Used for intercity or long-distance travel.3 - Bus. Used for short- and long-distance bus routes.4 - Ferry. Used for short- and long-distance boat service.5 - Cable tram. Used for street-level rail cars where the cable runs beneath the vehicle, e.g., cable car in San Francisco.6 - Aerial lift, suspended cable car (e.g., gondola lift, aerial tramway). Cable transport where cabins, cars, gondolas or open chairs are suspended by means of one or more cables.7 - Funicular. Any rail system designed for steep inclines.11 - Trolleybus. Electric buses that draw power from overhead wires using poles.12 - Monorail. Railway in which the track consists of a single rail or a beam.
        /// </summary>
        [DataMember(Name = "route_type", IsRequired = true)]
        public string RouteType { get; set; }
        /// <summary>
        /// URL of a web page about the particular route. Should be different from the agency.agency_url value.
        /// </summary>
        [DataMember(Name = "route_url", IsRequired = false)]
        public string RouteUrl { get; set; }
        /// <summary>
        /// Route color designation that matches public facing material. Defaults to white (FFFFFF) when omitted or left empty. The color difference between route_color and route_text_color should provide sufficient contrast when viewed on a black and white screen.
        /// </summary>
        [DataMember(Name = "route_color", IsRequired = false)]
        public string RouteColor { get; set; }
        /// <summary>
        /// Legible color to use for text drawn against a background of route_color. Defaults to black (000000) when omitted or left empty. The color difference between route_color and route_text_color should provide sufficient contrast when viewed on a black and white screen.
        /// </summary>
        [DataMember(Name = "route_text_color", IsRequired = false)]
        public string RouteTextColor { get; set; }
        /// <summary>
        /// Orders the routes in a way which is ideal for presentation to customers. Routes with smaller route_sort_order values should be displayed first.
        /// </summary>
        [DataMember(Name = "route_sort_order", IsRequired = false)]
        public string RouteSortOrder { get; set; }

 }
}