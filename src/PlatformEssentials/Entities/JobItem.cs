/* Copyright 2017 Cimpress

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License. */


using System;
using System.Collections.Generic;

namespace VP.FF.PT.Common.PlatformEssentials.Entities
{
    [Serializable]
    public class JobItem
    {
        public JobItem()
        {
            AssosiatedPlatformItems = new List<PlatformItem>();
        }

        // Used as primary key in database. Will be generated automatically by entity framework.
        public virtual long Id { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual JobItemState State { get; set; }

        /// <summary>
        /// Gets or sets the failed reason in case it's in Failed state.
        /// </summary>
        public virtual string FailedReason { get; set; }

        public virtual string ItemHostId { get; set; }

        public virtual ICollection<PlatformItem> AssosiatedPlatformItems { get; set; }
    }
}
