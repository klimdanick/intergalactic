using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameScript : MonoBehaviour
{
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // this object was clicked - do something
    void Update() {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast (ray, out hit))
        {
            if(hit.transform.name == gameObject.transform.name)
            {
                if (Input.GetMouseButtonDown(0)) Debug.Log ("New Game!");
            }
        }
    }
}
