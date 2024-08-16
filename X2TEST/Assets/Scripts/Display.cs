using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : IShow
{
    public void showMessage()
    {
        Debug.Log("Showing message!");
    }
}
