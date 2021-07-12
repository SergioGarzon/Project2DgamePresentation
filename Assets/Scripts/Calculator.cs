using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;


    public void PressButton()
    {
        panel1.gameObject.SetActive(false);
        panel2.gameObject.SetActive(true);
    }
    




}
