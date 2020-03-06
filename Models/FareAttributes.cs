using System.Runtime.Serialization;

namespace Models
{
    public class FareAttributes
    {
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
        /// Indicates when the fare must be paid. Valid options are:
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true)]
        public string PaymentMethod { get; set; }
    }
}