using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollingTextScript : MonoBehaviour {


	private string completeText = "Hello world.  How are you?  Sometimes I have to consider the fact that my pants will not be the right size.  When I run they sometimes fall to my ankles, but I keep walking in complete... protest." + 
		" Nudge that body back and forth!  Push it with me, baby, like a rainbow of courage!  Piss me off with a racket and shovel me with a rake!  This is a lousy first date!";
	private string animatedText = "";
	public float textScrollSpeed = 3.0f;


	void Start () {
		StartCoroutine(AnimateText(completeText));
	}

	void Update () {
		
	}

	IEnumerator AnimateText(string completeText){
		int i = 0;
		while (i < completeText.Length) {
			animatedText += completeText [i];
			GetComponent <Text>().text = animatedText;
			i++;
			yield return new WaitForSeconds(1/textScrollSpeed);
		}
	}
}
