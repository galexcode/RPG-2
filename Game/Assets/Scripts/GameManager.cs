using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	[HideInInspector]
	public TileMap tileMap;
	[HideInInspector]
	public Player player;


	void Awake(){
		tileMap = GameObject.Find("TileMap").GetComponent<TileMap>();
		player = GameObject.Find("Player").GetComponent<Player>();
	}
	#region Player
	public Vector3 PGetCoords(){
		return player.getRCoords();
	}
		#region Movement
		public void pMoveUp(){
			player.moveUp();
		}
		
		public void pMoveDown(){
			player.moveDown();
		}
		
		public void pMoveRight(){
			player.moveRight();
		}
		
		public void pMoveLeft(){
			player.moveLeft();
		}
		#endregion
	#endregion


	#region MapCreation

	/*
	public Vector2 TileMapGetMapSize()
	{
		return new Vector2(tileMap.size_X,tileMap.size_Z);
	}
*/
	/*
	public int getTileIDAt(int x, int y) {
		return map_data[x,y];
	}
	*/
	

/*	public int GetTileID(int x, int y){
		return tileMapData.getTileIDAt(x,y);
	}
*/

	#endregion



}

