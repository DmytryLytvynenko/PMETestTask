using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataHolder
{
/*    private static GameObject selectedVehicle = null;*/
    private static int selectedVehicleIndex;
    private static RCC_CarControllerV3 currentRCC;
    public static void SelectVehicle(/*GameObject vehicle*/ int Index)
    {
/*        selectedVehicle = vehicle;*/
        selectedVehicleIndex = Index;
    }    
    public static int GetSelectedVehicleIndex()
    {
        /*        return selectedVehicle;*/
        return selectedVehicleIndex;
    }


    public static RCC_CarControllerV3 GetCurrentVehiclesRCC()
    {
        return currentRCC;
    }
    public static void SetCurrentVehiclesRCC(RCC_CarControllerV3 rcc)
    {
        currentRCC = rcc;
    }
}
