﻿using FractalzFrontend.Cache;
using FractalzFrontend.Client;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Models
{
    public static class NinjectCollection
    {
        public static NinjectModuleCacheCollection Cache = new NinjectModuleCacheCollection();
        public static NinjectModuleClientCollection Integration = new NinjectModuleClientCollection();
    }
}