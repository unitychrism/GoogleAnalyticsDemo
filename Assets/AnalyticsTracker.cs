using UnityEngine;
using System.Collections;

public class AnalyticsTracker : MonoBehaviour {

	public GoogleAnalyticsV4 googleAnalytics;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {

			var touchPos = Input.GetTouch(0).position;

			SendPosition(touchPos);
		}

		if (Input.GetMouseButtonUp(0)) {
			SendPosition(Input.mousePosition);
		}
	}

	void SendPosition(Vector2 pos) {
		Debug.Log(string.Format("Screen was touched at {0}.", pos));

		googleAnalytics.LogEvent(new EventHitBuilder()
			.SetEventCategory("Touch")
			.SetEventAction("ScreenTapped")
			.SetEventLabel("User touched screen")
			.SetEventValue((long)pos.x));
	}
}
