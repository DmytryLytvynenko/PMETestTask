using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VehiclesSelection : MonoBehaviour
{
    [SerializeField] private List<GameObject> vehicles = new List<GameObject>();
    [SerializeField] private Transform spawnPoint;
    private int vehicleIndex = 0;

    private void Start()
    {
        for (int i = 0; i < vehicles.Count; i++)
        {
            vehicles[i].GetComponent<RCC_CarControllerV3>().SetCanControl(false);
        }
        SpawnVehicle();
    }
    public void SelectVehicle(int sceneNumber)
    {
        DataHolder.SelectVehicle(vehicleIndex);
        SceneManager.LoadScene(sceneNumber);
    }
    private void SpawnVehicle()
    {
        vehicles[vehicleIndex].transform.position = spawnPoint.position;
        vehicles[vehicleIndex].SetActive(true);
    }
    public void NextVehicle()
    {
        if (vehicleIndex == vehicles.Count - 1)
        {
            return;
        }
        vehicles[vehicleIndex].SetActive(false);
        vehicleIndex++;
        SpawnVehicle();
    }
    public void PreviousVehicle()
    {
        if (vehicleIndex == 0)
        {
            return;
        }
        vehicles[vehicleIndex].SetActive(false);
        vehicleIndex--;
        SpawnVehicle();
    }
}
