using UnityEngine;
using System.Collections;

public class cloudScript : MonoBehaviour {

    private GameObject cloude;
    private GameObject rain;

    private float TimerS = 10f;
    private float TimerDeltaS = 10f;

    public float TimerRain = 0.5f;
    private float TimerDeltaRain = 0.5f;

    public float TimerStartRain = 0.5f;
    private float TimerDeltaStartRain =0.5f;

    public float TimerWaitCloude = 9.5f;
    private float TimerDeltaWaitCloude = 9.5f;

    public float TimerCloud = 3.5f;
    private float TimerDeltaCloud =3;

    public float TimerSun = 6.5f;
    private float TimerDeltaSun = 6;

    private bool[] numR = new bool[7];

    private int side = 0;
    Vector3 lSide = new Vector3(-4,18,0);
    Vector3 rSide = new Vector3(4,18,0);

    int ready = 0;

    private GameObject[] r = new GameObject[9];

    int numOfRain = 0;

	// Use this for initialization
	void Start () {

        cloude = GameObject.FindGameObjectWithTag("cloud");
 
        for (int i = 0; i < 7; i++)
            numR[i] = false;

        r[0] = GameObject.FindGameObjectWithTag("w1");
        r[1] = GameObject.FindGameObjectWithTag("w2");
        r[2] = GameObject.FindGameObjectWithTag("w3");
        r[3] = GameObject.FindGameObjectWithTag("w4");
        r[4] = GameObject.FindGameObjectWithTag("w5");
        r[5] = GameObject.FindGameObjectWithTag("w6");
        r[6] = GameObject.FindGameObjectWithTag("w7");
        r[7] = GameObject.FindGameObjectWithTag("sun");
	}

    void cl1() {
        int count = 0;
        Vector3 temp;
        if (TimerDeltaCloud > 0) TimerDeltaCloud -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
        if (TimerDeltaCloud < 0) TimerDeltaCloud = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
        if (TimerDeltaCloud == 0)
        {
            if (side == 0)
            {
                temp = cloude.transform.position;
                temp = lSide;
                cloude.transform.position = temp;
            }
            else
            {
                temp = cloude.transform.position;
                temp = rSide;
                cloude.transform.position = temp;
            }

            for (int i = 0; i < 7; i++)
            {
                if (numR[i] != false)
                {
                    temp = r[i].transform.position;
                    temp.y -= 0.1f;
                    r[i].transform.position = temp;
                }
            }


            if (TimerDeltaRain > 0) TimerDeltaRain -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDeltaRain < 0) TimerDeltaRain = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDeltaRain == 0 && numR[6] != true && count !=5)
            {//!
                count++;
                TimerDeltaRain = TimerRain;
                temp = r[numOfRain].transform.position;
                temp = lSide;//!
                temp.x += Random.Range(-1, 1);
                numR[numOfRain] = true;
                r[numOfRain].transform.position = temp;
                numOfRain++;
            }

        }

        if (TimerDeltaWaitCloude > 0) TimerDeltaWaitCloude -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
        if (TimerDeltaWaitCloude < 0) TimerDeltaWaitCloude = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
        if (TimerDeltaWaitCloude == 0)
        {

            temp = cloude.transform.position;
            temp.x = -200;
            temp.y = -200;
            cloude.transform.position = temp;
            ready = 1;
            count = 0;
        }

           
    }

    void Update()
    {
        Vector3 temp;
        temp = r[7].transform.position;
        temp.y -= 0.1f;
        r[7].transform.position = temp;

        if (TimerDeltaSun > 0) TimerDeltaSun -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
        if (TimerDeltaSun < 0) TimerDeltaSun = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
        if (TimerDeltaSun == 0)
        {
            TimerDeltaSun = TimerSun;
            Vector3 vect = new Vector3(0, 18, 0);
            vect.x += Random.Range(-5, 5);
            r[7].transform.position = vect;
        }
       cl1();

         if (TimerDeltaS > 0) TimerDeltaS -= Time.deltaTime; //Если время которое нужно отсчитать еще осталось убавляем от него время обновления экрана (в одну секунду будет убавляться полная единица)
            if (TimerDeltaS < 0) TimerDeltaS = 0; //Если временная переменная ушла в отрицательное число (все возможно) то приравниваем ее к нулю
            if (TimerDeltaS == 0 && ready == 1)
            {
                for (int i = 0; i < 6; i++) numR[i] = false; 
                    ready = 0;
                TimerRain = 0.5f;
                TimerDeltaRain = 0.5f;

                TimerStartRain = 0.5f;
                TimerDeltaStartRain = 0.5f;

                TimerWaitCloude = 9.5f;
                TimerDeltaWaitCloude = 9.5f;

                TimerCloud = 3.5f;
                TimerDeltaCloud = 3;

                TimerSun = 6.5f;
                TimerDeltaSun = 6;

                temp = r[7].transform.position;
                temp.y -= 0.1f;
                r[7].transform.position = temp;

                cl1();

            }
           
        
    }
    
}
