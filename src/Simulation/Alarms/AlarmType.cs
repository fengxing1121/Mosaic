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


namespace VP.FF.PT.Common.Simulation.Alarms
{
    public enum AlarmType
    {
        /// <summary>
        /// This alarm type contains helpful informations.
        /// </summary>
        Debug,

        /// <summary>
        /// This alarm type indicates that something bad happened on the hardware side but the simulation is still able to run.
        /// </summary>
        Warning,

        /// <summary>
        /// This alarm type stops the simulation.
        /// </summary>
        Error
    }
}
