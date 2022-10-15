using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownText : MonoBehaviour {
    private TextMeshProUGUI myText;
    private void Awake() {
        myText = GetComponent<TMProUGUI>();
        myText.text = "";
    }

    public void StartCountDown(int _time) {
        StartCoroutine(countDownCor(_time));
    }

    private IEnumerator countDownCor(int _startTime) {
        float startTime =
        for (int i = _startTime; i > 0; i--) {
            yield return new WaitForSeconds(1);

        }
    }

}
