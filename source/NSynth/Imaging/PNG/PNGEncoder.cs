﻿/******************************************************************************
 * NSynth - A Managed Multimedia API - http://nsynth.gearedstudios.com/       *
 * Copyright © 2009-2013 William 'cathode' Shelley. All Rights Reserved.      *
 * This software is released under the terms and conditions of the MIT/X11    *
 * license; see the included 'license.txt' file for the full text.            *
 *****************************************************************************/
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSynth.Imaging.PNG
{
    public sealed class PNGEncoder : ImageEncoder
    {
        public PNGEncoder(Stream bitstream)
            : base(bitstream)
        {
        }
        public override bool CanSuspend
        {
            get
            {
                return false;
            }
        }

        public override void EncodeFrame(Frame frame)
        {
            throw new NotImplementedException();
        }

        public override bool Close()
        {
            throw new NotImplementedException();
        }

        public override void EncodeImage(Image image)
        {
            throw new NotImplementedException();
        }

        public override Codec Codec
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool Open()
        {
            throw new NotImplementedException();
        }
    }
}
