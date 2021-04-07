using System;
using System.Collections.Generic;
using System.Text;

namespace AmeriTrade.API.Models
{
    /// <summary>
    /// Contains a list of services to which the user has a valid authorization.
    /// </summary>
    public class UserAuthorizations
    {
        /// <summary>
        /// Gets a value indicating whether the user has authorization to the Options360 service.
        /// </summary>
        public bool Options360 { get; internal set; }
    }
}
