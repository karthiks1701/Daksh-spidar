using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchinput : MonoBehaviour
{   string btn;

    // Start is called before the first frame update
    public GameObject fun;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            
        
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
          RaycastHit Hit;
          if(Physics.Raycast(ray, out Hit)){
                
                btn = Hit.transform.name;
                if(btn == "button")
                 fun.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
