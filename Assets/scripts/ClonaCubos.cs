using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonaCubos : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cuboPrefab;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clonar()
    {
        Instantiate(cuboPrefab);
    }
}
