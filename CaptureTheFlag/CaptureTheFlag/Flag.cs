﻿using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureTheFlag
{
    public class Flag
    {
        public Player PlayerCaptured { get; set; } //el jugador que ha capturado la bandera.
        public bool IsPositionBase { get; set; } = true; 
        public Color ColorHex { get; set; }
        public int Model { get; set; }
        public Vector3 PositionBase { get; set; }

        public Flag(int modelid, Color color, Vector3 vector3)
        {
            ColorHex = color;
            Model = modelid;
            PositionBase = vector3;
            Create();
        }

        public void AttachedObject(Player player)
        {
            player.SetAttachedObject(0, Model, Bone.Spine, new Vector3(-0.099000, -0.156000, -0.194000), new Vector3(8.399998, 41.500011, 17.199983), new Vector3(0.486000, 1.295001, 0.571000), ColorHex, ColorHex);
        }

        public void Create()
        {
            Pickup.Create(Model, 1, PositionBase);
        }

        public void Create(Player player)
        {
            Pickup.Create(Model, 1, player.Position);
        }
    }

    public class FlagID
    {
        public static int Alpha { get; } = 19306;
        public static int Beta { get; } = 19307;
    }
}
