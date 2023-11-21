using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;



public class SaturationIncrease : GameBehaviour<SaturationIncrease>
{
    [SerializeField]
    float saturationIncrease;

    [SerializeField]
    VolumeProfile profile;
    Volume volume;

    private void Start()
    {

    }

    public void IncreaseSaturation()
    {
        print("Sat go up");
        profile.TryGet<ColorAdjustments>(out var colourAdjustments);

        colourAdjustments.saturation.value += saturationIncrease;
    }
    
    //reset back to 0
    public void ResetSaturation()
    {
        profile.TryGet<ColorAdjustments>(out var colourAdjustments);

        colourAdjustments.saturation.value = 0;
    }
}
