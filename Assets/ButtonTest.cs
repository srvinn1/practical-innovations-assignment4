using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Bu : MonoBehaviour
{   
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton()
    {
        text.text = "You clicked me!"; 
    }

}

