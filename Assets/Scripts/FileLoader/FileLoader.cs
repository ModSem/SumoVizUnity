﻿using UnityEngine;
using System.Collections.Generic;

public abstract class FileLoader {

	public abstract void loadFileByPath (string filename);
	public abstract void buildGeometry();
	public abstract void loadTrajectories (List<string> trajectoryLines);
	public abstract List<string> loadTrajectoryLines (string filename);
	public abstract string getInputfileExtension();

	protected void createWall(string name, List<Vector2> verticesList, float height){
		ObstacleExtrudeGeometry.create(name, verticesList, height);
	}

	protected void createTable(string name, List<Vector2> verticesList, float height){
		ModelGeometry.create(name, verticesList, height); 
	}

	protected void createDoor(string name, List<Vector2> verticesList, float height){

		Material doorMat = Resources.Load("Door")as Material;
		ExtrudeGeometry.create(name,verticesList, height,doorMat,doorMat);
	}

	protected void createFence(string name, List<Vector2> verticesList, float height){
		Material wall = Resources.Load("FenceWall")as Material;
		Material top = Resources.Load("FenceTop")as Material;
		ExtrudeGeometry.create(name,verticesList, height,top,wall);

	}

	protected void createTwoSideWall(string name, List<Vector2> verticesList, float height){
		TwoSideWallGeometry.create(name, verticesList, height);
	}
	protected void createBench(string name, List<Vector2> verticesList, float height){
		ModelGeometry.create (name, verticesList, height); 
	}

	protected void createAreaGeometry(string name, List<Vector2> verticesList){
		AreaGeometry.create(name, verticesList);
	}

	protected void createRoof(string name, List<Vector2> roofpoints, float heightAboveGround){
		ModelGeometry.create (name, roofpoints, heightAboveGround); 
	}

}
