using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnMesh : MonoBehaviour
{
    public GameObject objectToToggle;
    new Light light;

    private void Start()
    {
        light = GetComponentInChildren<Light>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToToggle.SetActive(true);
            light.enabled = true;
        }
    }
}
