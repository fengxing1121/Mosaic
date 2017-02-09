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
using System.Runtime.InteropServices;

namespace VP.FF.PT.Common.PlcEssentials
{
    public static class ConstantsController
    {
        public const int MaxCommandsPerController = 15;
        public const int MaxChilds = 30;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public class CtrlCommonInterface
    {
        public CtrlJob Job;
        public CtrlInfo Info;
        public CtrlSoftwareConfig SoftwareConfig;

        public override string ToString()
        {
            return Info.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public class Command
    {
        public short CommandId;

        [MarshalAs(UnmanagedType.I1)]
        public bool Available;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string Name = "";
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public class CtrlJob
    {
        public short Mode;
        public short AutomaticCommand;
        public short ManualCommand;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ActiveCommand = "";

        public short State;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StateName = "";

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string SubStateName = "";

        public short Event;

        [MarshalAs(UnmanagedType.I1)]
        public bool ResetAlarm;

        [MarshalAs(UnmanagedType.I1)]
        public bool EnableForcing;

        [MarshalAs(UnmanagedType.I1)]
        public bool OverwriteInterlocks;

        public short AlarmOfParent;

        public short Alarm;

        // TODO: fix this workaround, use dynamic marshal array
        public Command command0;
        public Command command1;
        public Command command2;
        public Command command3;
        public Command command4;
        public Command command5;
        public Command command6;
        public Command command7;
        public Command command8;
        public Command command9;
        public Command command10;
        public Command command11;
        public Command command12;
        public Command command13;
        public Command command14;
        public Command command15;

        //[MarshalAs(UnmanagedType.SafeArray, SafeArrayUserDefinedSubType = typeof(Command))]
 //       [MarshalAs(UnmanagedType.ByValArray, SizeConst = ConstantsController.MaxCommandsPerController + 1)]
 //       public Command[] commands = new Command[ConstantsController.MaxCommandsPerController + 1];
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public class CtrlInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string Name = "";

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string FullName = "";

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string Type = "";

        public short CtrlId;

        public short CtrlIdOfParent;

        [MarshalAs(UnmanagedType.I1)]
        public bool InitDone;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = ConstantsController.MaxChilds + 1)]
        public Int32[] pChilds = new Int32[ConstantsController.MaxChilds + 1];

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = ConstantsController.MaxChilds + 1)]
        public Int32[] pChildCIf = new Int32[ConstantsController.MaxChilds + 1];

        public UInt16 ChildCount;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InstancePath = "";
    }

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public class CtrlSoftwareConfig
    {
        [MarshalAs(UnmanagedType.I1)]
        public bool Exist;

        [MarshalAs(UnmanagedType.I1)]
        public bool Enable;

        [MarshalAs(UnmanagedType.I1)]
        public bool Simulation;

        [MarshalAs(UnmanagedType.I1)]
        public bool SimulateAll;

        [MarshalAs(UnmanagedType.I1)]
        public bool EnStateLogger;
    }
}
