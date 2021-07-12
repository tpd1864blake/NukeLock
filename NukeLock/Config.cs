using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Scp914;

namespace NukeLock
{
    public class Config : IConfig
    {
        [Description("Whether the Plugin is enabled or not")]
        public bool IsEnabled { get; set; } = true;
        [Description("Amount of time in seconds until the nuke is unlocked. Default is 6 minutes")]
        public int LockTime { get; set; } = 360;
        [Description("If true, prevents the nuke lever from being flipped on while it is locked")]
        public bool PreventEnabling { get; set; } = true;
    }
}
