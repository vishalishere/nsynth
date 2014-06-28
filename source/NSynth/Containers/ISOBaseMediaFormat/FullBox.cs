﻿/******************************************************************************
 * NSynth - A Managed Multimedia API - http://nsynth.gearedstudios.com/       *
 * Copyright © 2009-2013 William 'cathode' Shelley. All Rights Reserved.      *
 * This software is released under the terms and conditions of the MIT/X11    *
 * license; see the included 'license.txt' file for the full text.            *
 *****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSynth.Containers.ISOBaseMediaFormat
{
    public class FullBox : Box
    {
        public FullBox(uint boxType, byte version, int flags = 0)
            : base(boxType)
        {
            this.Version = version;
            this.Flags = flags;
        }

        public byte Version
        {
            get;
            set;
        }

        public int Flags
        {
            get;
            set;
        }
    }
}