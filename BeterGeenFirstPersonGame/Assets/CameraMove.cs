using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveOverField());
    }

    //Coroutine, speciale functie die gepauzeerd kan worden, begint altijd met IEnumerator
    IEnumerator MoveOverField()
    {
        float timer = .0f;

        while(timer < .5f)
        {
            timer += Time.deltaTime;//deltaTime is de tijd tussen het vorige frame en het huidige frame

            transform.position -= new Vector3(5f * Time.deltaTime, .0f, .0f);

            yield return 0; //Pauzeer de coroutine en ga het volgende frame weer verder
        }

        yield return new WaitForSeconds(.5f); //Pauzeer de coroutine en ga over een halve seconde weer verder

        while(timer < 1.5f)
        {
            timer += Time.deltaTime;

            transform.position += new Vector3(5f * Time.deltaTime, .0f, .0f);

            yield return 0;
        }
    }
}
