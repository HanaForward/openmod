﻿using OpenMod.API.Eventing;
using OpenMod.Rust.Players.Events;

namespace OpenMod.Rust.Players.Spectating.Events
{
    public class RustPlayerSpectateEndingEvent : RustPlayerEvent, ICancellableEvent
    {
        public string SpectateFilter { get; }
        public bool IsCancelled { get; set; }
        
        public RustPlayerSpectateEndingEvent(
            RustPlayer player,
            string spectateFilter) : base(player)
        {
            SpectateFilter = spectateFilter;
        }
    }
}