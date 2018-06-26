using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using Spectrum.API;
using Spectrum.API.Configuration;
using Spectrum.API.Interfaces.Plugins;
using Spectrum.API.Interfaces.Systems;
using Spectrum.API.Logging;
using UnityEngine;
using UnityEngine.UI;

namespace Distance.Translator
{
    public partial class Photon
    {
        [HarmonyPatch(typeof(UIExButton), "Start")]
        internal class UIExButton_Start_Patch : UIExButton
        {
            public static void Postfix(UIExButton __instance)
            {
                foreach (Transform childTransform in __instance.gameObject.transform.GetChildren())
                {
                    GameObject child = childTransform.gameObject;
                    if (child.name == "Unplayed Circle")
                    {
                        child.Destroy();
                    }
                }
            }
        }
    }
}