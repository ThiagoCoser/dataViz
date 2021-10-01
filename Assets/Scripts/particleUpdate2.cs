using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleUpdate2 : MonoBehaviour
{
    public GameObject dataSetObj;
  public int nextNum;
  public GameObject particlePrefab;

  // public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
//        gameObject.GetComponent<TextMesh>().text = "oi";
     // dataSetObj = GameObject.Find("dataSet");
     StartCoroutine("updateObj2");


    }




IEnumerator updateObj2(){



//particlePrefab.GetComponent<ParticleSystem>().maxParticles = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths;
yield return new WaitForSeconds(5);


Instantiate(particlePrefab, transform.position, Quaternion.identity);


 //bullet = (GameObject)Instantiate(particlePrefab, transform.position, transform.rotation);
//bullet.GetComponent<ParticleSystem>().maxParticles = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths;


//gameObject.GetComponent<ParticleSystem>().emission.rate = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths;



    yield return null;
nextNum = nextNum +1;
 StartCoroutine("updateObj2");

}



}
