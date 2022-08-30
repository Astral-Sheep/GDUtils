﻿namespace Com.Surbon.GDUtils
{
	public static class Property
	{
		public static class Node
		{
			public const string PAUSE_MODE = "pause_mode";
			public const string PROCESS_PRIORITY = "process_priority";
			public const string SCRIPT = "script";

			public static class CanvasItem
			{
				#region VISIBILITY

				public const string VISIBLE = "visible";
				public const string MODULATE = "modulate";
				public const string SELF_MODULATE = "self_modulate";
				public const string SHOW_BEHIND_PARENT = "show_behind_parent";
				public const string LIGHT_MASK = "light_mask";

				#endregion VISIBILITY

				#region MATERIAL

				public const string MATERIAL = "material";
				public const string USE_PARENT_MATERIAL = "use_parent_material";

				#endregion MATERIAL

				public static class Node2D
				{
					#region TRANSFORM

					public const string POSITION = "position";
					public const string ROTATION_DEGREES = "rotation_degrees";
					public const string SCALE = "scale";

					#endregion TRANSFORM

					#region Z INDEX

					public const string Z_INDEX = "z_index";
					public const string Z_AS_RELATIVE = "z_as_relative";

					#endregion Z INDEX

					public static class LightOccluder2D
					{
						public const string OCCLUDER = "occluder";
						public const string LIGHT_MASK = "light_mask";
					}

					public static class Line2D
					{
						public const string POINTS = "points";
						public const string WIDTH = "width";
						public const string WIDTH_CURVE = "width_curve";
						public const string DEFAULT_COLOR = "default_color";

						#region FILL

						public const string GRADIENT = "gradient";
						public const string TEXTURE = "texture";
						public const string TEXTURE_MODE = "texture_mode";

						#endregion FILL

						#region CAPPING

						public const string JOINT_MODE = "joint_mode";
						public const string BEGIN_CAP_MODE = "begin_cap_mode";
						public const string END_CAP_MODE = "end_cap_mode";

						#endregion CAPPING

						#region BORDER

						public const string SHARP_LIMIT = "sharp_limit";
						public const string ROUND_PRECISION = "round_precision";
						public const string ANTIALIASED = "antialiased";

						#endregion BORDER
					}

					public static class Listener2D
					{
						public const string CURRENT = "current";
					}

					public static class MeshInstance2D
					{
						public const string MESH = "mesh";
						public const string TEXTURE = "texture";
						public const string NORMAL_MAP = "normal_map";
					}

					public static class MultiMeshInstance2D
					{
						public const string MULTIMESH = "multimesh";
						public const string TEXTURE = "texture";
						public const string NORMAL_MAP = "normal_map";
					}

					public static class NavigationPolygonInstance
					{
						public const string NAVPOLY = "navpoly";
						public const string ENABLED = "enabled";
					}

					public static class ParallaxLayer
					{
						#region MOTION

						public const string MOTION_SCALE = "motion_scale";
						public const string MOTION_OFFSET = "motion_offset";
						public const string MOTION_MIRRORING = "motion_mirroring";

						#endregion MOTION
					}

					public static class Particles2D
					{
						public const string EMITTING = "emitting";
						public const string AMOUNT = "amount";

						#region TIME

						public const string LIFETIME = "lifetime";
						public const string ONE_SHOT = "one_shot";
						public const string PREPROCESS = "preprocess";
						public const string SPEED_SCALE = "speed_scale";
						public const string EXPLOSIVENESS = "explosiveness";
						public const string RANDOMNESS = "randomness";
						public const string FIXED_FPS = "fixed_fps";
						public const string FRACT_DELTA = "fract_delta";

						#endregion TIME

						#region DRAWING

						public const string VISIBILITY_RECT = "visibility_rect";
						public const string LOCAL_COORDS = "local_coords";
						public const string DRAW_ORDER = "draw_order";

						#endregion DRAWING

						#region PROCESS MATERIAL

						public const string MATERIAL = "material";

						#endregion PROCESS MATERIAL

						#region TEXTURES

						public const string TEXTURE = "texture";
						public const string NORMAL_MAP = "normal_map";

						#endregion TEXTURES
					}

					public static class Path2D
					{
						public const string CURVE = "curve";
					}

					public static class PathFollow2D
					{
						public const string OFFSET = "offset";
						public const string UNIT_OFFSET = "unit_offset";
						public const string H_OFFSET = "h_offset";
						public const string V_OFFSET = "v_offset";
						public const string ROTATE = "rotate";
						public const string CUBIC_INTERP = "cubic_interp";
						public const string LOOP = "loop";
						public const string LOOKAHEAD = "lookahead";
					}

					public static class Polygon2D
					{
						public const string COLOR = "color";
						public const string OFFSET = "offset";
						public const string ANTIALIASED = "antialiased";

						#region TEXTURE

						public const string TEXTURE = "texture";
						public const string TEXTURE_OFFSET = "texture_offset";
						public const string TEXTURE_SCALE = "texture_scale";
						public const string TEXTURE_ROTATION_DEGREES = "texture_rotation_degrees";

						#endregion TEXTURE

						#region SKELETON

						public const string SKELETON = "skeleton";

						#endregion SKELETON

						#region INVERT

						public const string INVERT_ENABLE = "invert_enable";
						public const string INVERT_BORDER = "invert_border";

						#endregion INVERT

						#region DATA

						public const string POLYGON = "polygon";
						public const string UV = "uv";
						public const string VERTEX_COLORS = "vertex_colors";
						public const string POLYGONS = "polygons";
						public const string INTERNAL_VERTEX_COUNT = "internal_vertex_count";

						#endregion DATA
					}

					public static class Position2D
					{
						public const string GIZMO_EXTENTS = "gizmo_extents";
					}

					public static class RayCast2D
					{
						public const string ENABLED = "enabled";
						public const string EXCLUDE_PARENT = "exclude_parent";
						public const string CAST_TO = "cast_to";
						public const string COLLISION_MASK = "collision_mask";

						#region COLLIDE WITH

						public const string COLLIDE_WITH_AREAS = "collide_with_areas";
						public const string COLLIDE_WITH_BODIES = "collide_with_bodies";

						#endregion COLLIDE WITH
					}

					public static class RemoteTransform2D
					{
						public const string REMOTE_PATH = "remote_path";
						public const string USE_GLOBAL_COORDINATES = "use_global_coordinates";

						#region UPDATE

						public const string UPDATE_POSITION = "update_position";
						public const string UPDATE_ROTATION = "update_rotation";
						public const string UPDATE_SCALE = "update_scale";

						#endregion UPDATE
					}

					public static class Sprite
					{
						public const string TEXTURE = "texture";
						public const string NORMAL_MAP = "normal_map";

						#region OFFSET

						public const string CENTERED = "centered";
						public const string OFFSET = "offset";
						public const string FLIP_H = "flip_h";
						public const string FLIP_V = "flip_v";

						#endregion OFFSET

						#region ANIMATION

						public const string H_FRAMES = "h_frames";
						public const string V_FRAMES = "v_frames";
						public const string FRAME = "frame";
						public const string FRAME_COORDS = "frame_coords";

						#endregion ANIMATION

						#region REGION

						public const string REGION_ENABLED = "region_enabled";
						public const string REGION_RECT = "region_rect";
						public const string FILTER_CLIP = "filter_clip";

						#endregion REGION
					}

					public static class TileMap
					{
						public const string MODE = "mode";
						public const string TILE_SET = "tile_set";
						public const string SHOW_COLLISION = "show_collision";
						public const string COMPATIBILITY_MODE = "compatibility_mode";
						public const string CENTERED_TEXTURES = "centered_textures";
						public const string CELL_CLIP_UV = "cell_clip_uv";

						#region CELL

						public const string CELL_SIZE = "cell_size";
						public const string CELL_QUADRANT_SIZE = "cell_quadrant_size";
						public const string CELL_CUSTOM_TRANSFORM = "cell_custom_transform";
						public const string CELL_HALF_OFFSET = "cell_half_offset";
						public const string CELL_TILE_ORIGIN = "cell_tile_origin";
						public const string CELL_Y_SORT = "cell_y_sort";

						#endregion CELL

						#region COLLISION

						public const string COLLISION_USE_PARENT = "collision_use_parent";
						public const string COLLISION_USE_KINEMATIC = "collision_use_kinematic";
						public const string COLLISION_FRICTION = "collision_friction";
						public const string COLLISION_BOUNCE = "collision_bounce";
						public const string COLLISION_LAYER = "collision_layer";
						public const string COLLISION_MASK = "collision_mask";

						#endregion COLLISION

						#region OCCLUDER

						public const string OCCLUDER_LIGHT_MASK = "occluder_light_mask";

						#endregion OCCLUDER
					}

					public static class TouchScreenButton
					{
						public const string NORMAL = "normal";
						public const string PRESSED = "pressed";
						public const string BITMASK = "bitmask";
						public const string SHAPE = "shape";
						public const string SHAPE_CENTERED = "shape_centered";
						public const string SHAPE_VISIBLE = "shape_visible";
						public const string PASSBY_PRESS = "passby_press";
						public const string ACTION = "action";
						public const string VISIBILITY_MODE = "visibility_mode";
					}

					public static class VisibilityNotifier2D
					{
						public const string RECT = "rect";

						public static class VisibilityEnabler2D
						{
							public const string PAUSE_ANIMATIONS = "pause_animations";
							public const string FREEZE_BODIES = "freeze_bodies";
							public const string PAUSE_PARTICLES = "pause_particles";
							public const string PAUSE_ANIMATED_SPRITES = "pause_animated_sprites";
							public const string PROCESS_PARENT = "process_parent";
							public const string PHYSICS_PROCESS_PARENT = "physics_process_parent";
						}
					}

					public static class YSort
					{
						public const string SORT_ENABLED = "sort_enabled";
					}
				}
			}

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
