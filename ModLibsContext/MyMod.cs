using System;
using Terraria;
using Terraria.ModLoader;
using ModLibsCore.Libraries.Debug;


namespace ModLibsContext {
	/// @private
	partial class ModLibsContextMod : Mod {
		public static ModLibsContextMod Instance { get; private set; }



		////////////////

		public ModLibsContextMod() {
			ModLibsContextMod.Instance = this;
		}


		public override void Load() {
		}

		////

		public override void Unload() {
			try {
				LogLibraries.Alert( "Unloading mod..." );
			} catch { }

			ModLibsContextMod.Instance = null;
		}
	}
}
