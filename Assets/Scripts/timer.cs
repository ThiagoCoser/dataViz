using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{


public static int seconds;

 
    void Start()
    {
   
      StartCoroutine("timerGeneral");


    }



IEnumerator timerGeneral(){


yield return new WaitForSeconds(1);


 seconds =  seconds +1;

 StartCoroutine("timerGeneral");

}
}
