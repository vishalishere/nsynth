﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSynth.Containers.MKV
{
    public class MKVDecoder : ContainerDecoder
    {
        public override Codec Codec
        {
            get { throw new NotImplementedException(); }
        }
        public override Clip GetContents()
        {
            throw new NotImplementedException();
        }
    }
}