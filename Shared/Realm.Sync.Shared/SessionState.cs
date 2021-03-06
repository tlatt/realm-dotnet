﻿////////////////////////////////////////////////////////////////////////////
//
// Copyright 2016 Realm Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
////////////////////////////////////////////////////////////////////////////

namespace Realms.Sync
{
    /// <summary>
    /// The current state of a sync session object.
    /// </summary>
    public enum SessionState
    {
        /// <summary>
        /// The session is waiting for an access token.
        /// </summary>
        WaitingForAccessToken = 0,

        /// <summary>
        /// The session is connected to the Realm Object Server and is actively transferring data.
        /// </summary>
        Active,

        /// <summary>
        /// The session is performing clean-up work in preparation to be destroyed.
        /// </summary>
        Dying,

        /// <summary>
        /// The user owning this session has logged out and the sesion has disconnected from the Realm Object Server.
        /// </summary>
        Inactive,

        /// <summary>
        /// A non-recoverable error has occurred, and this session is semantically invalid. A new session should be created with a different configuration.
        /// </summary>
        Error,
    }
}