﻿using System;

namespace TrueCraft.API.World
{
    // TODO: Entities
    /// <summary>
    /// An in-game world composed of chunks and blocks.
    /// </summary>
    public interface IWorld
    {
        string Name { get; set; }

        IChunk GetChunk(Coordinates2D coordinates);
        short GetBlockID(Coordinates3D coordinates);
        byte GetMetadata(Coordinates3D coordinates);
        byte GetSkyLight(Coordinates3D coordinates);
        void SetBlockID(Coordinates3D coordinates, short value);
        void SetMetadata(Coordinates3D coordinates, byte value);
        void SetSkyLight(Coordinates3D coordinates, byte value);
        void SetBlockLight(Coordinates3D coordinates, byte value);
        bool IsValidPosition(Coordinates3D position);
        void Save();
    }
}