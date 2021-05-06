using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActivator : MonoBehaviour
{
    public GameObject lightToggle;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            lightToggle.SetActive(true);
        }
    }
}
