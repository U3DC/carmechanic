﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PartStatusPanel : MonoBehaviour
{
	public Text status;
	public new Text name;


	public void show (CarEngine.Part part, int nStatus)
	{
		status.text = nStatus + "%";
		name.text = Service.partsList[part].name;

		gameObject.SetActive(true);
	}

	public void hide () {
		gameObject.SetActive(false);
	}
}
