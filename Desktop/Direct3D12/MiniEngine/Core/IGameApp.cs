//
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

namespace MiniEngine.Core
{
	using Graphics;

	public interface IGameApp
	{
		/// <summary>
		/// 
		/// </summary>
		void Startup();

		/// <summary>
		/// 
		/// </summary>
		void Cleanup();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		bool IsDone();

		/// <summary>
		/// The update method will be invoked once per frame.  Both state updating and scene
		/// rendering should be handled by this method.
		/// </summary>
		/// <param name="deltaT"></param>
		void Update(float deltaT);

		/// <summary>
		/// Official rendering pass 
		/// </summary>
        void RenderScene();

		/// <summary>
		/// Optional UI (overlay) rendering pass.  This is LDR.  The buffer is already cleared. 
		/// </summary>
		/// <param name="gc"></param>
		void RenderUI(ref GraphicsContext gc);

	}
}
