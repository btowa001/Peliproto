using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNight : MonoBehaviour
{
    Light day;
    // Start is called before the first frame update
    void Start()
    {
        day = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        day.color -= (Color.white / 2.0f) * Time.deltaTime * 0.01f;
    }
}
