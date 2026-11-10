using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        car = GameObject.Find("car_0");
        flag = GameObject.Find("flag_0");
        distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;

        if (length >= 0) 
        { 
            distance.GetComponent<TextMeshProUGUI>().text = "Distance : " + length.ToString("F2") + "m";
        }
        else
        {
            distance.GetComponent<TextMeshProUGUI>().text = "GameClear";
        }
    }
}
