namespace Courier.Models
{

    /// <summary>
    /// 
    /// </summary>
#pragma warning disable CA1707 // Identifiers should not contain underscores
    public enum ErrorReason
    {

        /// <summary>
        /// The recipient did not receive the notification because of a condition that passed.
        /// </summary>
        Filtered,

        /// <summary>
        /// The notification did not contain any valid channels.
        /// </summary>
        No_Channels,

        /// <summary>
        /// The notification did not contain a configured provider for a channel.
        /// </summary>
        No_Providers,

        /// <summary>
        /// The Integration provider had an error when sending a notification.
        /// </summary>
        Provider_Error,

        /// <summary>
        /// The recipient did not receive the notification because they chose to unsubscribe from it.
        /// </summary>
        Unsubscribed

    }
#pragma warning restore CA1707 // Identifiers should not contain underscores

}
