using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEX : MonoBehaviour
{
    public GameObject EXprefab;
	// クリックした位置座標
	private Vector3 clickPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// マウス入力で左クリックをした瞬間
		if (Input.GetMouseButtonDown(0)) {
			clickPosition = Input.mousePosition;
			// Z軸修正
			clickPosition.z = 10f;
			// オブジェクト生成 : オブジェクト(GameObject), 位置(Vector3), 角度(Quaternion)
			// ScreenToWorldPoint(位置(Vector3))：スクリーン座標をワールド座標に変換する
			Instantiate(EXprefab, Camera.main.ScreenToWorldPoint(clickPosition), EXprefab.transform.rotation);
		}
	}
}
