using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private List<GameObject> vehicles = new List<GameObject>();
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private RCC_SceneManager sceneManagerRCC;
    private int vehicleIndex;
    

    void Start()
    {
        vehicleIndex = DataHolder.GetSelectedVehicleIndex();
        DataHolder.SetCurrentVehiclesRCC(vehicles[vehicleIndex].GetComponent<RCC_CarControllerV3>());
        vehicles[vehicleIndex].transform.position = spawnPoint.position;
        vehicles[vehicleIndex].SetActive(true);
        sceneManagerRCC.activePlayerVehicle = DataHolder.GetCurrentVehiclesRCC();
    }
}
