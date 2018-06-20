﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSVpnClientIPsecParameters
    {
        /// <summary>
        /// Quick Mode / Phase 2 SA life time in seconds
        /// </summary>
        public int SaLifeTimeSeconds { get; set; }

        /// <summary>
        /// Quick Mode / Phase 2 SA payload size in kilobytes
        /// </summary>
        public int SaDataSizeKilobytes { get; set; }

        /// <summary>
        /// IKE phase 1 IPSec encryption algorithm
        /// </summary>
        public string IpsecEncryption { get; set; }

        /// <summary>
        /// IKE phase 1 IPSec integrity algorithm
        /// </summary>
        public string IpsecIntegrity { get; set; }

        /// <summary>
        /// IKE phase 2 IKE encryption algorithm
        /// </summary>
        public string IkeEncryption { get; set; }

        /// <summary>
        /// IKE phase 2 IKE integrity algorithm
        /// </summary>
        public string IkeIntegrity { get; set; }

        /// <summary>
        /// IKE phase 1 DH group for initial SA
        /// </summary>
        public string DhGroup { get; set; }

        /// <summary>
        /// IKE phase 2 Pfs Group for new child SA
        /// </summary>
        public string PfsGroup { get; set; }
    }
}