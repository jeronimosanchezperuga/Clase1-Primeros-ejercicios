using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOnClick : MonoBehaviour
{
    public ObjectSelectionManager selectionManager;
    public Rigidbody2D rb;
    public bool isKinematic = true;

    // Start is called before the first frame update
    void Start()
    {
        selectionManager = GameObject.FindGameObjectWithTag("SelectionManager").GetComponent<ObjectSelectionManager>();;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
        isKinematic = !isKinematic;
        if (!isKinematic)
        {
            selectionManager.selected = gameObject;
            rb.bodyType = RigidbodyType2D.Static;
        }
        else
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            selectionManager.selected = null;
        }
    }

    
}
