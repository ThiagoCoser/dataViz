using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newIntUpdate: MonoBehaviour
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



yield return new WaitForSeconds(1);

gameObject.GetComponent<TextMesh>().text = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].newDeaths.ToString();

    yield return null;
nextNum = nextNum +1;
 StartCoroutine("updateObj");

}




}
