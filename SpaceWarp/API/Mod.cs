﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceWarp.API.Logging;
using UnityEngine;

namespace SpaceWarp.API
{
	public class MainModAttribute : Attribute
	{
	}

	public abstract class Mod : MonoBehaviour
	{
		public BaseModLogger Logger;
		public SpaceWarpManager Manager;
		public virtual void Start()
		{
			// Default mod startup code
		}

		public abstract void Initialize();
	}
}
