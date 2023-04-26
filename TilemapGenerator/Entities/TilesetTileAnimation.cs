﻿using System.Xml.Serialization;

namespace TilemapGenerator.Entities
{
    public class TilesetTileAnimation
    {
        [XmlElement("frame")] 
        public List<TilesetTileAnimationFrame> Frames { get; set; }

        [XmlIgnore]
        public int Hash { get; set; }
    }
}