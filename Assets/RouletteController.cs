using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;

public class RouletteController : MonoBehaviour
{
	// 回転速度
	float rotSpeed = 0;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		// マウス左クリックにより回転速度を設定する
		if (Input.GetMouseButtonDown (0)) {
			this.rotSpeed = 10;
		}

		// ルーレットを回転させる
		transform.Rotate (0, 0, this.rotSpeed);

		// ルーレット減速
		this.rotSpeed *= 0.96f;

		if (0.01f > this.rotSpeed) {
			this.rotSpeed = 0;
		}

	}
}
