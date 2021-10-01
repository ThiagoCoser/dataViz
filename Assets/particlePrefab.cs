using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class particlePrefab: MonoBehaviour
{
    public GameObject dataSetObj;
  public int nextNum;

    // Start is called before the first frame update

  void Awake() {
      dataSetObj = GameObject.Find("dataSet");
 }
    

    void Start()
    {
        StartCoroutine("updateParticlePrefab");
      //  gameObject.GetComponent<TextMesh>().text = "oi";
     
     

    }




IEnumerator updateParticlePrefab(){


if (nextNum>8){
Destroy(gameObject);

}


gameObject.GetComponent<ParticleSystem>().maxParticles = dataSetObj.GetComponent<CSVReader>().myItemList.items[timer.seconds].newDeaths;
//gameObject.GetComponent<ParticleSystem>().emission.rate = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths;



    yield return new WaitForSeconds(1);

// nextNum = nextNum +1;
//  StartCoroutine("updateParticlePrefab");

}





    
}
