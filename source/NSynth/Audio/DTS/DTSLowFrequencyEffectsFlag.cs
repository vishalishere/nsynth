﻿/******************************************************************************
 * NSynth - A Managed Multimedia API - http://nsynth.gearedstudios.com/       *
 * Copyright © 2009-2011 William 'cathode' Shelley. All Rights Reserved.      *
 * This software is released under the terms and conditions of the MIT/X11    *
 * license; see the included 'license.txt' file for the full text.            *
 *****************************************************************************/
using System.Collections.Generic;
using System.Text;

namespace NSynth.Audio.DTS
{
    public enum DTSLowFrequencyEffectsFlag
    {
        NotPresent = 0,
        Present128InterpolationFactor = 1,
        Present64InterpolationFactor = 2,
    }
}
