namespace Com.Surbon.GDUtils
{
	public static class Property
	{
		public static class Node
		{
			public const string PAUSE_MODE = "pause_mode";
			public const string PROCESS_PRIORITY = "process_priority";
			public const string SCRIPT = "script";

			public static class AnimationPlayer
			{
				public const string ROOT_NODE = "root_node";
				public const string CURRENT_ANIMATION = "current_animation";
				public const string RESET_ON_SAVE = "reset_on_save";
				public const string METHOD_CALL_MODE = "method_call_mode";

				#region PLAYBACK OPTIONS

				public const string PLAYBACK_PROCESS_MODE = "playback_process_mode";
				public const string PLAYBACK_DEFAULT_BLEND_TIME = "playback_default_blend_time";
				public const string PLAYBACK_SPEED = "playback_speed";

				#endregion PLAYBACK OPTIONS
			}

			public static class AnimationTree
			{
				public const string TREE_ROOT = "tree_root";
				public const string ANIM_PLAYER = "anim_player";
				public const string ACTIVE = "active";
				public const string PROCESS_MODE = "process_mode";
				public const string ROOT_MOTION_TRACK = "root_motion_track";
			}

			public static class AnimationTreePlayer
			{
				public const string MASTER_PLAYER = "master_player";
				public const string BASE_PATH = "base_path";
				public const string ACTIVE = "active";
				public const string PLAYBACK_PROCESS_MODE = "playback_process_mode";
			}

			public static class AudioStreamPlayer
			{
				public const string STREAM = "stream";
				public const string VOLUME_DB = "volume_db";
				public const string PITCH_SCALE = "pitch_scale";
				public const string PLAYING = "playing";
				public const string AUTOPLAY = "autoplay";
				public const string STREAM_PAUSED = "stream_paused";
				public const string MIX_TARGET = "mix_target";
				public const string BUS = "bus";
			}

			public static class CanvasLayer
			{
				#region LAYER

				public const string LAYER = "layer";

				#endregion LAYER

				#region TRANSFORM

				public const string OFFSET = "offset";
				public const string ROTATION_DEGREES = "rotation_degrees";
				public const string SCALE = "scale";
				public const string TRANSFORM = "transform";

				#endregion TRANSFORM

				#region FOLLOW_VIEWPORT

				public const string FOLLOW_VIEWPORT_ENABLE = "follow_viewport_enable";
				public const string FOLLOW_VIEWPORT_SCALE = "follow_viewport_scale";

				#endregion FOLLOW_VIEWPORT

				public static class ParallaxBackground
				{
					public const string SCROLL_OFFSET = "scroll_offset";
					public const string SCROLL_BASE_OFFSET = "scroll_base_offset";
					public const string SCROLL_BASE_SCALE = "scroll_base_scale";
					public const string SCROLL_LIMIT_BEGIN = "scroll_limit_begin";
					public const string SCROLL_LIMIT_END = "scroll_limit_end";
					public const string SCROLL_IGNORE_CAMERA_ZOOM = "scroll_ignore_camera_zoom";
				}
			}

			public static class HTTPRequest
			{
				public const string DOWNLOAD_FILE = "download_file";
				public const string DOWNLOAD_CHUNK_SIZE = "download_chunk_size";
				public const string USE_THREADS = "use_threads";
				public const string BODY_SIZE_LIMIT = "body_size_limit";
				public const string MAX_REDIRECTS = "max_redirects";
				public const string TIMEOUT = "timeout";
			}

			public static class SkeletonIK
			{
				public const string ROOT_BONE = "root_bone";
				public const string TIP_BONE = "tip_bone";
				public const string INTERPOLATION = "interpolation";
				public const string TARGET = "target";
				public const string OVERRIDE_TIP_BASIS = "override_tip_basis";
				public const string USE_MAGNET = "use_magnet";
				public const string MAGNET = "magnet";
				public const string TARGET_NODE = "target_node";
				public const string MIN_DISTANCE = "min_distance";
				public const string MAX_ITERATIONS = "max_iterations";
			}

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
