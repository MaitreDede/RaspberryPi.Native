﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RaspberryPi.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public sealed class VC_DISPMANX_ALPHA_T
    {
        public DISPMANX_FLAGS_ALPHA_T flags;
        public uint opacity;
        public DISPMANX_RESOURCE_HANDLE_T mask;
    }
}
