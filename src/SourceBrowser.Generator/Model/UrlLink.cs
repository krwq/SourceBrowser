﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceBrowser.Generator.Model
{
    public class UrlLink : ILink
    {
        public string Url { get; set; }

        public string GetLink()
        {
            return Url;
        }
    }
}
