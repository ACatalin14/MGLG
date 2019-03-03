using System;
using System.Linq;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ListGenerator : MonoBehaviour {

	public char[] list;
	char[] posibilitati;

	public Text juc, maf, doc, pol;

	int nrJucatori;
	int nrMafioti;
	int nrDoctori;
	int nrPolitisti;

	private int nrPosibilitati;

	// Use this for initialization
	void Start () {
		nrJucatori = 10;
		nrMafioti = 2;
		nrDoctori = 1;
		nrPolitisti = 1;

		//CreateList ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CreateList ()
	{
		Int32.TryParse (juc.text, out nrJucatori);
		Int32.TryParse (maf.text, out nrMafioti);
		Int32.TryParse (doc.text, out nrDoctori);
		Int32.TryParse (pol.text, out nrPolitisti);

		nrPosibilitati = nrJucatori;

		list = new char[nrJucatori];
		posibilitati = new char[nrPosibilitati];

		for (int i = 0; i < nrMafioti; i++)
			posibilitati[i] = 'm';
		for (int i = nrMafioti; i < nrMafioti + nrDoctori; i++)
			posibilitati[i] = 'd';
		for (int i = nrMafioti + nrDoctori; i < nrMafioti + nrDoctori + nrPolitisti; i++)
			posibilitati[i] = 'p';
		for (int i = nrMafioti + nrDoctori + nrPolitisti; i < nrPosibilitati; i++)
			posibilitati[i] = 'o';

		for (int i = 0; i < nrJucatori; i++)
		{
			int index = UnityEngine.Random.Range (0, nrPosibilitati);
			list [i] = posibilitati [index];

			for (int j = index; j < nrPosibilitati - 1; j++)
				posibilitati [j] = posibilitati [j + 1];

			nrPosibilitati--;
		}
	}

	public char[] GetList ()
	{
		return list;
	}
}
