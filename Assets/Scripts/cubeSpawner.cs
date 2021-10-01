using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{



// public GameObject dataSetObj;
 // public int nextNum;
  public GameObject cubePrefab;
   public GameObject textObj;


  
   public int increaseNumber = 1;


    void Start()
    {

     StartCoroutine("cubeSpawn");


    }




IEnumerator cubeSpawn(){



yield return new WaitForSeconds(0.05f);


Instantiate(cubePrefab, transform.position, Quaternion.identity);
textObj.GetComponent<TextMesh>().text = (increaseNumber).ToString();

increaseNumber = increaseNumber +1;
  yield return null;
//nextNum = nextNum +1;
 StartCoroutine("cubeSpawn");


}



}
