using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{
    [SerializeField] Material omoColor1 = null;
    [SerializeField] Material omoColor2 = null;
    [SerializeField] Material omoSelected = null;
   
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material = omoColor1;
    }

    void selectOmo()
    {
        this.GetComponent<Renderer>().material = omoSelected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
