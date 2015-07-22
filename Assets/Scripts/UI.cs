using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {

	public GameObject start;
	public GameObject goal;
	public GameObject player;
	public Text percentCompleted;
	public static float distanceStart;
	public static float distancePlayer;

	// Use this for initialization
	void Start () {
		distanceStart = Vector2.Distance (start.transform.position, goal.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		distancePlayer = goal.transform.position.x - player.transform.position.x;
		if (distancePlayer > distanceStart)
			percentCompleted.text = "0% completed";
		else
			percentCompleted.text = Mathf.FloorToInt(((distanceStart - distancePlayer)/distanceStart)*100).ToString() + "% completed";

		if (Mathf.FloorToInt (((distanceStart - distancePlayer) / distanceStart) * 100) == 100) {
			Player.won = true;
			Application.LoadLevel ("Score");
		}
	}
}
