﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCore.MediaFoundation;
using System.IO;

namespace CSCore.Codecs.MP2
{
    public class MP2Decoder : MediaFoundationDecoder
    {
        static bool? _issupported;
        public static bool IsSupported
        {
            get
            {
                if (_issupported == null)
                {
                    _issupported = MediaFoundationCore.IsTransformAvailable(MediaFoundationCore.EnumerateTransforms(MFTCategories.AudioDecoder, MFTEnumFlags.All),
                        CommonAudioDecoder.MPEGAudioDecoder);
                }
                return _issupported.Value;
            }
        }

        public MP2Decoder(string url)
            : base(url)
        {
        }

        public MP2Decoder(Stream stream)
            : base(stream)
        {
        }
    }
}