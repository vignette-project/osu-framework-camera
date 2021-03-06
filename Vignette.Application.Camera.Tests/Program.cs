﻿// Copyright 2020 - 2021 Vignette Project
// Licensed under MIT. See LICENSE for details.

using osu.Framework;
using osu.Framework.Platform;

namespace Vignette.Application.Camera.Tests
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using GameHost host = Host.GetSuitableHost(@"visual-tests");
            host.Run(new VisualTestGame());
        }
    }
}
