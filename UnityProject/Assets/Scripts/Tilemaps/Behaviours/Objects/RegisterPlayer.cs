﻿using UnityEngine;


	[ExecuteInEditMode]
	public class RegisterPlayer : RegisterTile
	{
		public bool IsBlocking { get; set; } = true;

		public override bool IsPassable()
		{
			return !IsBlocking;
		}
	}
