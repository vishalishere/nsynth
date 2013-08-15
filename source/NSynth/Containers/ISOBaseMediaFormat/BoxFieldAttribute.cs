﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSynth.Containers.ISOBaseMediaFormat
{
    public sealed class BoxFieldAttribute : Attribute
    {
        public BoxFieldAttribute()
        {

        }

        /// <summary>
        /// Gets or sets the version of the box that the field applies to.
        /// </summary>
        public byte Version { get; set; }



    }
}
