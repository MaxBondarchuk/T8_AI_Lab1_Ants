﻿using System;
using System.Collections.Generic;
using System.Windows;

namespace AntGraphColouringAlgorithm
{
	public class Vertex
	{
		/// <summary>
		/// Coordinates on Canvas
		/// </summary>
		public Point Location;

		/// <summary>
		/// Size in pixels
		/// </summary>
		public const int VertexSize = 50;

		/// <summary>
		/// Font size in pixels
		/// </summary>
		public const int VertexFontSize = 15;

		/// <summary>
		/// Vertex index in Canvas.Children
		/// </summary>
		public int CanvasIdx;

		/// <summary>
		/// Contains indexes of nodes
		/// </summary>
		public readonly List<int> ConnectedWith = new List<int>();

		/// <summary>
		/// Contains indexes of lines
		/// </summary>
		public readonly List<int> ConnectedBy = new List<int>();

		/// <summary>
		/// Number of color node is colored in
		/// </summary>
		public int ColorNumber;

		/// <summary>
		/// Number of conflicts for node
		/// </summary>
		public int ConflictsNumber;

		/// <summary>
		/// Checks if p is point of node
		/// </summary>
		/// <param name="p">Explored point</param>
		/// <returns></returns>
		public bool IsMyPoint(Point p)
		{
			return Math.Pow(p.X - Location.X, 2) + Math.Pow(p.Y - Location.Y, 2) <= VertexSize * VertexSize * .25;
		}

		/// <summary>
		/// Checks if p is point near node (2 radii distance)
		/// </summary>
		/// <param name="p">Explored point</param>
		/// <returns></returns>
		public bool IsNearPoint(Point p)
		{
			return Math.Pow(p.X - Location.X, 2) + Math.Pow(p.Y - Location.Y, 2) <= VertexSize * VertexSize;
		}
	}
}