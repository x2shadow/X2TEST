using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Display display;

    // Start is called before the first frame update
    void Start()
    {
       display = new Display();

       InvokeRepeating("Hello", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Hello()
    {
        display.showMessage();
    }
}
