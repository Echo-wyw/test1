using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wqwqww : MonoBehaviour
{
    public GameObject i;

    
    // Start is called before the first frame update
    void Start()
    {
        i = GameObject.Find("Image");
        i.SetActive(false);
        Debug.Log("I am alive! ");
        static void fucntion1()
        {

        };
        void function2()
        {

        };
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) ;
        i.SetActive(true);
    }
}
