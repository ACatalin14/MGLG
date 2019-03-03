using System;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour {

	Text numar;

	// Use this for initialization
	void Start () {
		numar = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void AddDigit(int d)
	{
		if (numar.text.Length < 3)
		{
			if (d != 0)
				numar.text = numar.text + d;
			else if (numar.text.Length != 0)
				numar.text = numar.text + d;
		}
	}

	public void DeleteNumber()
	{
		numar.text = "";
	}

	public void Increment(int limit)
	{
		int nr;
		bool parsed = Int32.TryParse (numar.text, out nr);
		if (parsed) 
		{
			if (nr < limit)
			{
				nr++;
				numar.text = nr.ToString ();
			}
		}
	}

	public void Decrement(int limit)
	{
		int nr;
		bool parsed = Int32.TryParse (numar.text, out nr);
		if (parsed) 
		{
			if (nr > limit)
			{
				nr--;
				numar.text = nr.ToString ();
			}
		}
	}
}
