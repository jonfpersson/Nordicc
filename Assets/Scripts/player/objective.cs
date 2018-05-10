using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objective : MonoBehaviour {
    
    void Start() {
        StartCoroutine(StartFadeText());
    }

    IEnumerator StartFadeText() {
        print(Time.time);
        yield return new WaitForSeconds(7);
        StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<Text>()));

        //print(Time.time);
    }

    public IEnumerator FadeTextToZeroAlpha(float t, Text i) {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
