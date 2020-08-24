﻿using OpenMod.Unturned.Entities;
using SDG.Unturned;

namespace OpenMod.Unturned.Events.Players.Inventory
{
    public class UnturnedPlayerItemAddEvent : UnturnedPlayerEvent
    {
        public byte Page { get; }

        public byte Index { get; }

        public ItemJar ItemJar { get; }

        public UnturnedPlayerItemAddEvent(UnturnedPlayer player, byte page, byte index, ItemJar itemJar) : base(player)
        {
            Page = page;
            Index = index;
            ItemJar = itemJar;
        }
    }
}
