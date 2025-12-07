using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassAndSize : MonoBehaviour
{
    public float currentMass;
    public Vector3 currentScale;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 weightscale = transform.localScale;

        if (rb != null )
        {  
            rb.mass = currentMass;
        }

        if (rb != null)
        {
            rb.transform.localScale = currentScale;
        }
    }

}
