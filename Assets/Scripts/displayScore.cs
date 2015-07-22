using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class displayScore : MonoBehaviour {

	public Text congratsKek;
	public Text youCompleted;
	public Text percentageKek;

	// Use this for initialization
	void Start () {
		if (Player.won == true) {
			congratsKek.text = "Congratulaions";
		}
		else
			congratsKek.text = "Better luck next time";

		youCompleted.text = "You completed";
		percentageKek.text = Mathf.FloorToInt(((UI.distanceStart - UI.distancePlayer)/UI.distanceStart)*100).ToString() + "%";
	}
}
