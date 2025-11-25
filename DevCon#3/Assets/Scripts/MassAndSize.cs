using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassAndSize : MonoBehaviour
{
    public float currentMass;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null )
        {  
            rb.mass = currentMass;
        }

    }

}
