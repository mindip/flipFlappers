using UnityEngine;
using System.Collections;

public class ReceivePosition : MonoBehaviour {
	public static float gammaScore;
   	public OSC osc;

	// Use this for initialization
	void Start () {
		osc.SetAddressHandler( "/muse/elements/gamma_session_score" , OnReceiveGamma);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnReceiveGamma(OscMessage message) {
		string stringMessage = message.ToString();
		print (stringMessage);
		float a = message.GetFloat (0);
		float b = message.GetFloat (1);
		float c = message.GetFloat (2);
		float d = message.GetFloat (3);
		gammaScore = a + b + c + d;
    }
}