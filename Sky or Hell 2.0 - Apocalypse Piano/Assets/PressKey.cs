using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressKey : MonoBehaviour
{

    public Image myImage;
    public Color myColor;
    public Color myColor2;
    
    // Start is called before the first frame update
    private void Start()
    {
        myColor.a=1;
        myColor2.a=1;  
    }


    public void OnClick()
    {

     myImage.color = myColor;
    }


    void Update ()
    {
        myImage.color = myColor2; 
    }
}
