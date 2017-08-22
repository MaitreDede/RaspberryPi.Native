﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RaspberryPi
{
    [Flags]
    public enum DISPMANX_FLAGS_ALPHA_T
    {
        /* Bottom 2 bits sets the alpha mode */
        DISPMANX_FLAGS_ALPHA_FROM_SOURCE = 0,
        DISPMANX_FLAGS_ALPHA_FIXED_ALL_PIXELS = 1,
        DISPMANX_FLAGS_ALPHA_FIXED_NON_ZERO = 2,
        DISPMANX_FLAGS_ALPHA_FIXED_EXCEED_0X07 = 3,

        DISPMANX_FLAGS_ALPHA_PREMULT = 1 << 16,
        DISPMANX_FLAGS_ALPHA_MIX = 1 << 17
    }
}
