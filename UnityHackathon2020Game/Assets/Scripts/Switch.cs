using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private bool switched = false;

    private void OnMouseOver()
    { 
        //if object is clicked, change rotation and value of switched
        if (Input.GetMouseButtonDown(0))
        {
            if (switched)
            {
                switched = false;
                gameObject.transform.eulerAngles = new Vector3(0,0,0);
            }
            else
            {
                switched = true;
                gameObject.transform.eulerAngles = new Vector3(0, 0, -65);

            }
        }
    }

    //public reference to switched
    public bool isSwitched()
    {
        return switched;
    }
}
