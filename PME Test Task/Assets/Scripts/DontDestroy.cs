using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static GameObject[] instances = new GameObject[2];
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instances[0] == null)
        {
            instances[0] = gameObject;
            return;
        }
        if (gameObject != instances[0] && instances[1] == null)
        {
            instances[1] = gameObject;
            return;
        }


        for (int i = 0; i < instances.Length; i++)
        {
            if (instances[i].name == gameObject.name)
            {
                Destroy(instances[i]);
                instances[i] = gameObject;
            }
        }
    }
}
