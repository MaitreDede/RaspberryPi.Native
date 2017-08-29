﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace RaspberryPi.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public sealed class DISPMANX_CLAMP_KEYS_T
    {
        public byte yy_red_upper;
        public byte yy_red_lower;
        public byte cr_blue_upper;
        public byte cr_blue_lower;
        public byte cb_green_upper;
        public byte cb_green_lower;
    }
}
