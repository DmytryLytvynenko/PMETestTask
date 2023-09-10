using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    private RCC_CarControllerV3 playersController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playersController = DataHolder.GetCurrentVehiclesRCC();
            playersController.SetCanControl(false);
            winScreen.SetActive(true);
        }
    }
}
