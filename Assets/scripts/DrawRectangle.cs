using UnityEngine;
using System.Collections;

public class DrawRectangle : MonoBehaviour {

    public GameObject character;
    public Vector3 P0 = new Vector3(0, -17, 0);
    public Vector3 P1 = new Vector3(0, 0, 0);
    public Vector3 P2 = new Vector3(100, 100, 0);
    public Vector3 P3 = new Vector3(100, 0, 0);

    public Color c1 = Color.green;
    public Color c2 = Color.green;

    LineRenderer line;
    void Start()
    {
        Vector3 temp = character.transform.position;
        temp.y -= 2f;
        P3 = temp;
 
    }

    public Vector3 Evaluate(float t)
    {
        float t1 = 1 - t;
        return t1 * t1 * t1 * P0 + 3 * t * t1 * t1 * P1 +
               3 * t * t * t1 * P2 + t * t * t * P3;
    }
	
	// Update is called once per frame
	void Update () {
        P3 = character.transform.position;  
        line = transform.GetComponent<LineRenderer>();
        line.SetVertexCount(10);
        line.SetPosition(0, Evaluate(0.1f));
        line.SetPosition(1, Evaluate(0.2f));
        line.SetPosition(2, Evaluate(0.3f));
        line.SetPosition(3, Evaluate(0.4f));
        line.SetPosition(4, Evaluate(0.5f));
        line.SetPosition(5, Evaluate(0.6f));
        line.SetPosition(6, Evaluate(0.7f));
        line.SetPosition(7, Evaluate(0.8f));
        line.SetPosition(8, Evaluate(0.9f));
        line.SetPosition(9, Evaluate(1f));
	}
}
