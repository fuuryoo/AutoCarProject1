
using UnityEngine;
using System.Collections;
using Rewired;
 
public class MouseMove : MonoBehaviour {
 
	//　カーソルに使用するテクスチャ
	[SerializeField]
	private Texture2D cursor;

	private Player player0;
 
	void Start () {
		//　カーソルを自前のカーソルに変更
		Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);

		player0 = ReInput.players.GetPlayer(0);

	}
 
	void Update () {
		//　マウスの左クリックで撃つ
		if(Input.GetButtonDown("Fire1")) {
			
			Debug.Log("a");
		}

		if (player0.GetButtonDown("Shot")){
			Debug.Log("a");
		}

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertival");
		Debug.Log(horizontal+","+vertical);
	}
 
	//　敵を撃つ
	/*void Shot() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
 
		if(Physics.Raycast(ray, out hit, 100f, LayerMask.GetMask("Enemy"))) {
			Destroy(hit.collider.gameObject);
		}
	}*/
}