using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using KSP;

namespace CrashDummies
{
    public class CrashDummy : PartModule

    {
        public override void OnStart(PartModule.StartState state)
        {
            if (HighLogic.LoadedSceneIsFlight == true)
            {
                RemoveDummy();
            }
            base.OnStart(state);
        }
        public void RemoveDummy()
        {
            foreach (PartResource res in part.Resources)
            {
                if (res.info.name == "CrashDummies")
                {
                    res.amount = res.amount - 1;
                }
            }
         
        }
    }

}