using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownText : MonoBehaviour {
    private TextMeshProUGUI myText;

    private void Awake() {
        myText = GetComponent<TextMeshProUGUI>();
        myText.text = "";
    }

    public void StartCountDown(int _time) {
        StartCoroutine(countDownCor(_time));
    }

    private IEnumerator countDownCor(int _startTime) {

        int i = _startTime;
        do {
            myText.text = i.ToString();
            i--;
            yield return new WaitForSeconds(1);
        }while (i > 0);

        gameObject.SetActive(false);
    }

}
