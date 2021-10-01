using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalUpdate: MonoBehaviour
{


  public GameObject dataSetObj;
  public int nextNum;

    // Start is called before the first frame update
    void Start()
    {
      //  gameObject.GetComponent<TextMesh>().text = "oi";
      dataSetObj = GameObject.Find("dataSet");
      StartCoroutine("updateObj3");


    }




IEnumerator updateObj3(){



yield return new WaitForSeconds(1);

gameObject.GetComponent<TextMesh>().text = dataSetObj.GetComponent<CSVReader>().myItemList.items[nextNum].totalDeaths.ToString();

    yield return null;
nextNum = nextNum +1;
 StartCoroutine("updateObj3");

}




}
