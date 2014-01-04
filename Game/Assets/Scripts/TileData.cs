using UnityEngine;
using System.Collections.Generic;
using System;

public class TileData {

	private enum TileType : int {
		unknown,
		floor,
		wall,
		stone,
	};

	//Build World
	//How Big
	//Make tile map data
	//Convert tile map data to tile data
	//Build Map



	public Tile CreateNewTile(bool walkable, int height){
		Tile tmpTile = new Tile();
		tmpTile.Walkable = walkable;
		tmpTile.Height = height;
		return tmpTile;
	}


//	public Array TileMapDataToTileData(int[,] tileData){
//
//
//	}

}
