using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTest : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log("Hit Sth");
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
