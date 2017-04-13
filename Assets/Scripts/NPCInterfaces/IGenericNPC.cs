using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.NPCInterfaces
{
    public interface IGenericNPC
    {
        int GenericNPCID { get; set; }
        String GenericNPCName { get; set; }
        Location.Type GenericNPCSpawnLocation { get; set; }
        String GenericNPCSprite { get; set; }
    }
}
