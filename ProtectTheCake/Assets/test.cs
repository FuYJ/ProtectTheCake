using UnityEngine;
using System;
using System.Collections;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum; 

public class Test : MonoBehaviour {

	Image<Bgr, byte> img;

	// Use this for initialization
	void Start () {
		img = new Image<Bgr, byte> ("/Users/fuyiru/Pictures/downloaded/green1.jpg");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
