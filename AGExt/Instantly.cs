﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ActionGroupsExtended
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class AGXMainMenu :PartModule
    {

        //abandoned module, no longer needed for key rebinding
        public void Start()
        {
            print("AGExt Ver. 2.1 loaded");

            
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
