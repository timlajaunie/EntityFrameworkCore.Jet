﻿// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace EFCore.Jet.Integration.Test.GearOfWar
{
    public class SquadMission
    {
        public Squad Squad { get; set; }
        public int MissionId { get; set; }

        public int SquadId { get; set; }
        public Mission Mission { get; set; }
    }
}
