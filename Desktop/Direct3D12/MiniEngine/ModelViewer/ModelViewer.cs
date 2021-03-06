﻿//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
// Developed by Minigraph
//
// Author(s):  Alex Nankervis
//             James Stanard
//
// Ported by:  John Judd
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEngine.ModelViewer
{
	using Core;
	using Core.Graphics;

	class ModelViewer : IGameApp
	{
		public void Startup()
		{

		}

		public void Cleanup()
		{

		}

		public bool IsDone()
		{
			return false;
		}

		public void Update(float deltaT)
		{

		}

		public void RenderScene()
		{

		}

		/// <summary>
		/// Optional UI (overlay) rendering pass.  This is LDR.  The buffer is already cleared. 
		/// </summary>
		/// <param name="gc"></param>
		public void RenderUI(ref GraphicsContext gc)
		{
		}
	}
}
