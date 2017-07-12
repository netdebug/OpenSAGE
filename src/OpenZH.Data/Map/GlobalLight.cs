﻿using System.IO;

namespace OpenZH.Data.Map
{
    public sealed class GlobalLight
    {
        public MapVector3 Ambient { get; private set; }
        public MapVector3 Color { get; private set; }
        public MapVector3 EulerAngles { get; private set; }

        public static GlobalLight Parse(BinaryReader reader)
        {
            return new GlobalLight
            {
                Ambient = MapVector3.Parse(reader),
                Color = MapVector3.Parse(reader),
                EulerAngles = MapVector3.Parse(reader)
            };
        }

        public void WriteTo(BinaryWriter writer)
        {
            Ambient.WriteTo(writer);
            Color.WriteTo(writer);
            EulerAngles.WriteTo(writer);
        }
    }
}