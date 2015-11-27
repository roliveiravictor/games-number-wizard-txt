/**********************************************************************/
/*                                                                    */
/*                          NUMBER WIZARD							  */
/*		                                                              */
/*																	  */
/*		This is the code from a game created to practice my           */
/*      Unity and Game Development skills. All of this was            */
/*      made watching Ben Tristem's tutorial at Udemy.                */
/*                                                                    */
/*      For more information please visit:                            */
/*      https://www.udemy.com/unitycourse/                            */
/*                                                                    */
/*                                                                    */
/**********************************************************************/

using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		max = 1000;
		min = 1;
		guess = 500;
			
		Debug.Log ("### ======================== ###\n");
		Debug.Log ("### Welcome to Number Wizard ###\n");
		Debug.Log ("### ======================== ###\n");
		Debug.Log ("Pick a number in your head and don't tell me!\n");
		
		Debug.Log ("The highest number you can pick is " + max + " and the lowest is " + min + "!\n");
		
		Debug.Log ("Is the number higher or lower than " + guess + " ?\n");
		Debug.Log ("Up Arrow = Higher \"Down Arrow = Lower \"Enter = Equal\n".Replace("\"", System.Environment.NewLine));
		
		//Bug fix case player thinks 1000.
		max++;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
		   	min = guess;
		  	NextGuess();
		} else if(Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if(Input.GetKeyDown(KeyCode.Return)) {
			Debug.Log ("I Won!\n");
            Start();
		}
	}
	
	void NextGuess() {
		guess = (max + min) / 2;
		Debug.Log ("Higher or lower than " + guess + "?\n");
	}
}
