using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffMeshRenderer : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer platMesh;

    private void Start()
    {
        platMesh = GetComponent<MeshRenderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            platMesh.enabled = false ;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            platMesh.enabled = true;
            
        }
    }
}
