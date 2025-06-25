using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuoption : MonoBehaviour
{
    /*public Sprite activated;
    public Sprite deactivated;*/
    public bool selected;

    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (selected && Input.GetAxis("Vertical") == 1)
        {
            if (up != null)
            {
                selected = false;
                up.GetComponent<menuoption>().selected = true;
            }
        }
        if (selected && Input.GetAxis("Vertical") == -1)
        {
            if (down != null)
            {
                selected = false;
                down.GetComponent<menuoption>().selected = true;
            }
        }
        if (selected && Input.GetAxis("Horizontal") == 1)
        {
            if (right != null)
            {
                selected = false;
                right.GetComponent<menuoption>().selected = true;
            }
        }
        if (selected && Input.GetAxis("Horizontal") == -1)
        {
            if (left != null)
            {
                selected = false;
                left.GetComponent<menuoption>().selected = true;
            }
        }
    }
}
