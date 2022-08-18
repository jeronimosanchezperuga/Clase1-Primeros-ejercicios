using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelectionManager : MonoBehaviour
{
    public GameObject selected;
    public float movSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * movSpeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movSpeed * Time.deltaTime;

        if (selected)
        {
        selected.transform.Translate(new Vector3(x,y,0),Space.World);
        }
    }
}
