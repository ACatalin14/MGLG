using System;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ListScript : MonoBehaviour {

	public Text numarulCampului;
	public Text numarulJucatoruluiX;
	public Text tipulJucatoruluiX;
	public Text nrJucatori;
	public Text continutLista;
	public RectTransform dimensiuneLista;

	GameObject mainCamera;
	Text numarulJucatoruluiXText;
	ListGenerator listScript;

	int jucatori;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.Find ("Main Camera");
		listScript = mainCamera.GetComponent<ListGenerator> ();

		Int32.TryParse (nrJucatori.text, out jucatori);

		listScript.CreateList ();
		ModificaLista ();
	}
	
	// Update is called once per frame
	void Update () {
		
		numarulJucatoruluiX.text = numarulCampului.text;

		char litera;
		int nr;

		Int32.TryParse (numarulJucatoruluiX.text, out nr);
		Int32.TryParse (nrJucatori.text, out jucatori);

		if (nr >= 1 && nr <= jucatori)
		{
			tipulJucatoruluiX.fontSize = 110;

			litera = listScript.list [nr - 1];

			if (litera == 'm')
				tipulJucatoruluiX.text = "Mafiot";
			else if (litera == 'd')
				tipulJucatoruluiX.text = "Doctor";
			else if (litera == 'p')
				tipulJucatoruluiX.text = "Politist";
			else 
				tipulJucatoruluiX.text = "Orasean";
		}
		else
		{
			tipulJucatoruluiX.fontSize = 90;
			tipulJucatoruluiX.text = "Nu Exista";
		}
	}

	public void ModificaLista()
	{
		continutLista.text = "";
		for (int i = 0; i < jucatori; i++)
		{
			continutLista.text += "     " + (i+1) + "  ";
			if (listScript.list[i] == 'm')
				continutLista.text += "Mafiot\n";
			else if (listScript.list[i] == 'd')
				continutLista.text += "Doctor\n";
			else if (listScript.list[i] == 'p')
				continutLista.text += "Politist\n";
			else continutLista.text += "Orasean\n";
		}
	
		dimensiuneLista.sizeDelta = new Vector2 (381.0f, 55.0f * jucatori);
	}




}
