﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace Thinktecture.IdentityServer.Core.Events
{
    /// <summary>
    /// Base class for local authentication events
    /// </summary>
    public class LocalAuthenticationEvent : AuthenticationEventBase
    {
        public LocalAuthenticationEvent(EventType type)
            : base(EventConstants.Ids.LocalLogin, type)
        {
            Message = "Local authentication event";
        }

        /// <summary>
        /// Gets or sets the name of the login user.
        /// </summary>
        /// <value>
        /// The name of the login user.
        /// </value>
        public string LoginUserName { get; set; }
    }
}