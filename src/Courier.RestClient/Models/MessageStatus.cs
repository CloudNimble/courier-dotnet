namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
    public enum MessageStatus
    {

        /// <summary>
        /// The recipient has clicked on any link in the message at least one time.
        /// </summary>
        Clicked,

        /// <summary>
        /// The provider successfully delivered the message to the recipient.
        /// </summary>
        Delivered,

        /// <summary>
        /// The request has been received to send a message, is waiting in the work queue
        /// </summary>
        Enqueued,

        /// <summary>
        /// The message has been accepted by the provider.
        /// </summary>
        Sent,

        /// <summary>
        /// The message could not be delivered to at least one provider, or the provider could not deliver the message 
        /// to the recipient. This can happen for multiple reasons: an error, insufficient profile data, invalid 
        /// notification setup, invalid integration configuration, etc.
        /// </summary>
        Undeliverable,

        /// <summary>
        /// Could not find a corresponding notification or event mapping for the messages.
        /// </summary>
        Unmapped

    }

}
