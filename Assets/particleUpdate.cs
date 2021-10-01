using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleUpdate : MonoBehaviour
{
    public GameObject dataSetObj;
  public int nextNum;

    // Start is called before the first frame update
    void Start()
    {
      //  gameObject.GetComponent<TextMesh>().text = "oi";
      dataSetObj = GameObject.Find("dataSet");
      StartCoroutine("updateObj");


    }




IEnumerator updateObj(){


if (nextNum>8){
Destroy(gameObject);

}



yield return new WaitForSeconds(1);


gameObject.GetComponent<ParticleSystem>().maxParticles = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths;
//gameObject.GetComponent<ParticleSystem>().emission.rate = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths;



    yield return null;
nextNum = nextNum +1;
 StartCoroutine("updateObj");

}



}
