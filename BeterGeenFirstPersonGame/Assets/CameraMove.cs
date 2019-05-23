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

    IEnumerator MoveOverField()
    {
        float timer = .0f;

        while(timer < .5f)
        {
            timer += Time.deltaTime;

            transform.position -= new Vector3(5f * Time.deltaTime, .0f, .0f);

            yield return 0;
        }

        yield return new WaitForSeconds(.5f);

        while(timer < 1.5f)
        {
            timer += Time.deltaTime;

            transform.position += new Vector3(5f * Time.deltaTime, .0f, .0f);

            yield return 0;
        }
    }
}
