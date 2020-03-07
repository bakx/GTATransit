using System.Runtime.Serialization;

namespace Models
{
 public abstract class FareAttributes
 {
            /// <summary>
        /// Indicates whether service is available on the date specified in the date field. Valid options are:1 - Service has been added for the specified date.2 - Service has been removed for the specified date.Example: Suppose a route has one set of trips available on holidays and another set of trips available on all other days. One service_id could correspond to the regular service schedule and another service_id could correspond to the holiday schedule. For a particular holiday, the calendar_dates.txt file could be used to add the holiday to the holiday service_id and to remove the holiday from the regular service_id schedule.
        /// </summary>
        [DataMember(Name = "exception_type", IsRequired = true)]
        public string ExceptionType { get; set; }
        /// <summary>
        /// Identifies a fare class.
        /// </summary>
        [DataMember(Name = "fare_id", IsRequired = true)]
        public string FareId { get; set; }
        /// <summary>
        /// Fare price, in the unit specified by currency_type.
        /// </summary>
        [DataMember(Name = "price", IsRequired = true)]
        public string Price { get; set; }
        /// <summary>
        /// Currency used to pay the fare.
        /// </summary>
        [DataMember(Name = "currency_type", IsRequired = true)]
        public string CurrencyType { get; set; }
        /// <summary>
        /// Indicates when the fare must be paid. Valid options are:0 - Fare is paid on board.1 - Fare must be paid before boarding.
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Indicates the number of transfers permitted on this fare. The fact that this field can be left empty is an exception to the requirement that a Required field must not be empty. Valid options are:0 - No transfers permitted on this fare.1 - Riders may transfer once.2 - Riders may transfer twice.empty - Unlimited transfers are permitted.
        /// </summary>
        [DataMember(Name = "transfers", IsRequired = true)]
        public string Transfers { get; set; }
        /// <summary>
        /// Identifies the relevant agency for a fare. This field is required for datasets with multiple agencies defined in agency.txt, otherwise it is optional.
        /// </summary>
        [DataMember(Name = "agency_id", IsRequired = false)]
        public string AgencyId { get; set; }
        /// <summary>
        /// Length of time in seconds before a transfer expires. When transfers=0 this field can be used to indicate how long a ticket is valid for or it can can be left empty.
        /// </summary>
        [DataMember(Name = "transfer_duration", IsRequired = false)]
        public string TransferDuration { get; set; }

 }
}