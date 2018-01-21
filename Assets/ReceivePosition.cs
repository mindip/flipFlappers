using UnityEngine;
using System.Collections;

public class ReceivePosition : MonoBehaviour {
    
   	public OSC osc;


	// Use this for initialization
	void Start () {
		osc.SetAddressHandler( "/muse/elements/gamma_session_score" , OnReceiveGamma);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void OnReceiveGamma(OscMessage message) {
		print (message);
    }
}