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
using System.Runtime.Serialization;
using System.ServiceModel;
using VP.FF.PT.Common.PlatformEssentials.Entities.DTOs;

namespace VP.FF.PT.Common.PlatformEssentials
{
    [DataContract]
    public enum ChangeType
    {
        [EnumMember]
        Detected,

        [EnumMember]
        Removed,

        [EnumMember]
        Changed
    }

    public interface IPlatformModuleServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void ModuleStateChanged(PlatformModuleDTO module);

        [OperationContract(IsOneWay = true)]
        void MetricsChanged(MetricsDTO metrics);

        [OperationContract(IsOneWay = true)]
        void SendUserNotification(MessageType type, string message, TimeSpan duration);
    }

    [ServiceContract(CallbackContract = typeof(IPlatformModuleServiceEvents))]
    public interface IPlatformModuleWcfService
    {
        // Empty  
    }
}