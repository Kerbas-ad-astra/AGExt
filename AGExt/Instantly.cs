﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ActionGroupsExtended
{
    [KSPAddon(KSPAddon.Startup.Instantly, false)]
    public class AGXMainMenu :PartModule
    {

        //abandoned module, no longer needed for key rebinding
        public void Start()
        {
            print("AGExt Ver. 1.33a loaded");

            
        }

    }

    //public static class StaticMethods
    //{
    //    public static GUISkin ourSkin;
    //    public static void initSkin()
    //    {
    //        ourSkin = (GUISkin)MonoBehaviour.Instantiate(HighLogic.Skin);
    //    }
    //}
}
