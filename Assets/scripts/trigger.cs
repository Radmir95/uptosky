using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class trigger : MonoBehaviour {
    private GameObject[] r = new GameObject[7];
    private GameObject sun;
    private GameObject water;
    int countSun;
    int countWater;
	
	void Start () {
        sun = GameObject.FindGameObjectWithTag("sunCount");
        water = GameObject.FindGameObjectWithTag("waterCount");
        r[0] = GameObject.FindGameObjectWithTag("w1");
        r[1] = GameObject.FindGameObjectWithTag("w2");
        r[2] = GameObject.FindGameObjectWithTag("w3");
        r[3] = GameObject.FindGameObjectWithTag("w4");
        r[4] = GameObject.FindGameObjectWithTag("w5");
        r[5] = GameObject.FindGameObjectWithTag("w6");
        r[6] = GameObject.FindGameObjectWithTag("w7");
	    
	}
	
	
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Vector3 temp;
        if (other.gameObject.tag == "w1") {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }

        if (other.gameObject.tag == "w2")
        {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }

        if (other.gameObject.tag == "w3")
        {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }

        if (other.gameObject.tag == "w4")
        {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }

        if (other.gameObject.tag == "w5")
        {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }

        if (other.gameObject.tag == "w6")
        {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }
        if (other.gameObject.tag == "w7")
        {
            countWater++;
            water.GetComponent<Text>().text = countWater.ToString();
        }

        if (other.gameObject.tag == "sun")
        {
            countSun++;
            sun.GetComponent<Text>().text = countSun.ToString();
        }

        temp = other.transform.position;
        temp.x = -200;
        temp.y = -200;
        other.transform.position = temp;
        
    }


}
