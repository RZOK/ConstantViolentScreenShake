using Terraria.DataStructures;
using Terraria.ModLoader;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.IO;
using Terraria.GameContent;

namespace ConstantViolentScreenshake
{
    public class MPlayer : ModPlayer
    {
        public override void ModifyScreenPosition()
        {
            Main.screenPosition += new Vector2(Main.rand.Next(-99, 100), Main.rand.Next(-99, 100));
        }
    }
}