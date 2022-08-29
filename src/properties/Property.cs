namespace Com.Surbon.GDUtils
{
	public static class Property
	{
		public static class Node
		{
			public const string PAUSE_MODE = "pause_mode";
			public const string PROCESS_PRIORITY = "process_priority";
			public const string SCRIPT = "script";

			public static class Timer
			{
				public const string PROCESS_MODE = "process_mode";
				public const string WAIT_TIME = "wait_time";
				public const string ONE_SHOT = "one_shot";
				public const string AUTOSTART = "autostart";
			}

			public static class Tween
			{
				public const string REPEAT = "repeat";
				public const string PLAYBACK_PROCESS_MODE = "playback_process_mode";
				public const string PLAYBACK_SPEED = "playback_speed";
			}

			public static class Viewport
			{
				public const string ARVR = "arvr";
				public const string SIZE = "size";
				public const string SIZE_OVERRIDE_STRETCH = "size_override_stretch";
				public const string OWN_WORLD = "own_world";
				public const string WORLD = "world";
				public const string TRANSPARENT_BG = "transparent_bg";
				public const string HANDLE_INPUT_LOCALLY = "handle_input_locally";

				#region RENDERING

				public const string MSAA = "msaa";
				public const string FXAA = "fxaa";
				public const string DEBANDING = "debanding";
				public const string SHARPEN_INTENSITY = "sharpen_intensity";
				public const string HDR = "hdr";
				public const string DISABLE_3D = "disable_3d";
				public const string KEEP_3D_LINEAR = "keep_3d_linear";
				public const string USAGE = "usage";
				public const string RENDER_DIRECT_TO_SCREEN = "render_direct_to_screen";
				public const string DEBUG_DRAW = "debug_draw";

				#endregion RENDERING

				#region RENDER TARGET

				public const string V_FLIP = "render_target_v_flip";
				public const string CLEAR_MODE = "render_target_clear_mode";
				public const string UPDATE_MODE = "render_target_update_mode";

				#endregion RENDER TARGET

				#region AUDIO LISTENER

				public const string AUDIO_LISTENER_ENABLE_2D = "audio_listener_enable_2d";
				public const string AUDIO_LISTENER_ENABLE_3D = "audio_listener_enable_3d";

				#endregion AUDIO LISTENER

				#region PHYSICS

				public const string PHYSICS_OBJECT_PICKING = "physics_object_picking";

				#endregion PHYSICS

				#region GUI

				public const string GUI_DISABLE_INPUT = "gui_disable_input";
				public const string GUI_SNAP_CONTROLS_TO_PIXELS = "gui_snap_controls_to_pixels";

				#endregion GUI

				#region SHADOW ATLAS

				public const string SHADOW_ATLAS_SIZE = "shadow_atlas_size";
				public const string SHADOW_ATLAS_QUAD_0 = "shadow_atlas_quad_0";
				public const string SHADOW_ATLAS_QUAD_1 = "shadow_atlas_quad_1";
				public const string SHADOW_ATLAS_QUAD_2 = "shadow_atlas_quad_2";
				public const string SHADOW_ATLAS_QUAD_3 = "shadow_atlas_quad_3";

				#endregion SHADOW ATLAS
			}

			public static class WorldEnvironment
			{
				public const string ENVIRONMENT = "environment";
			}
		}
	}
}
