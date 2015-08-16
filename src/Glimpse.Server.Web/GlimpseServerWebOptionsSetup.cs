﻿using Microsoft.Framework.OptionsModel;

namespace Glimpse.Server.Web
{
    public class GlimpseServerWebOptionsSetup : ConfigureOptions<GlimpseServerWebOptions>
    {
        public GlimpseServerWebOptionsSetup() : base(ConfigureGlimpseServerWebOptions)
        {
            Order = -1000;
        }

        public static void ConfigureGlimpseServerWebOptions(GlimpseServerWebOptions options)
        {
            // TODO: Setup different settings here
        }
    }
}