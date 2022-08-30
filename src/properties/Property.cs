namespace Com.Surbon.GDUtils
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

				public static class Control
				{
					#region ANCHOR

					public const string ANCHOR_LEFT = "anchor_left";
					public const string ANCHOR_TOP = "anchor_top";
					public const string ANCHOR_RIGHT = "anchor_right";
					public const string ANCHOR_BOTTOM = "anchor_bottom";

					#endregion ANCHOR

					#region MARGIN

					public const string MARGIN_LEFT = "margin_left";
					public const string MARGIN_TOP = "margin_top";
					public const string MARGIN_RIGHT = "margin_right";
					public const string MARGIN_BOTTOM = "margin_bottom";

					#endregion MARGIN

					#region GROW DIRECTION

					public const string GROW_HORIZONTAL = "grow_horizontal";
					public const string GROW_VERTICAL = "grow_vertical";

					#endregion GROW DIRECTION

					#region RECT

					public const string RECT_POSITION = "rect_position";
					public const string RECT_SIZE = "rect_size";
					public const string RECT_MIN_SIZE = "rect_min_size";
					public const string RECT_ROTATION = "rect_rotation";
					public const string RECT_SCALE = "rect_scale";
					public const string RECT_PIVOT_OFFSET = "rect_pivot_offset";
					public const string RECT_CLIP_CONTENT = "rect_clip_content";

					#endregion RECT

					#region HINT

					public const string HINT_TOOLTIP = "hint_tooltip";

					#endregion HINT

					#region FOCUS

					public const string FOCUS_NEIGHBOUR_LEFT = "focus_neighbour_left";
					public const string FOCUS_NEIGHBOUR_TOP = "focus_neighbour_top";
					public const string FOCUS_NEIGHBOUR_RIGHT = "focus_neighbour_right";
					public const string FOCUS_NEIGHBOUR_BOTTOM = "focus_neighbour_bottom";
					public const string FOCUS_NEXT = "focus_next";
					public const string FOCUS_PREVIOUS = "focus_previous";
					public const string FOCUS_MODE = "focus_mode";

					#endregion FOCUS

					#region MOUSE

					public const string MOUSE_FILTER = "mouse_filter";
					public const string MOUSE_DEFAULT_CURSOR_SHAPE = "mouse_default_cursor_shape";

					#endregion MOUSE

					#region INPUT

					public const string INPUT_PASS_ON_MODAL_CLOSE_CLICK = "input_pass_on_modal_close_click";

					#endregion INPUT

					#region SIZE FLAGS

					public const string SIZE_FLAGS_HORIZONTAL = "size_flags_horizontal";
					public const string SIZE_FLAGS_VERTICAL = "size_flags_vertical";
					public const string SIZE_FLAGS_STRETCH_RATIO = "size_flags_stretch_ratio";

					#endregion SIZE FLAGS

					#region THEME

					public const string THEME = "theme";

					#endregion THEME

					public static class BaseButton
					{
						public const string DISABLED = "disabled";
						public const string TOGGLE_MODE = "toggle_mode";
						public const string SHORTCUT_IN_TOOLTIP = "shortcut_in_tooltip";
						public const string PRESSED = "pressed";
						public const string ACTION_MODE = "action_mode";
						public const string BUTTON_MASK = "button_mask";
						public const string ENABLED_FOCUS_MODE = "enabled_focus_mode";
						public const string KEEP_PRESSED_OUTSIDE = "keep_pressed_outside";
						public const string SHORTCUT = "shortcut";
						public const string GROUP = "group";

						public static class Button
						{
							public const string TEXT = "text";
							public const string ICON = "icon";
							public const string FLAT = "flat";
							public const string CLIP_TEXT = "clip_text";
							public const string ALIGN = "align";
							public const string EXPAND_ICON = "expand_icon";

							public static class OptionButton
							{
								public const string SELECTED = "selected";
							}
						}

						public static class LinkButton
						{
							public const string TEXT = "text";
							public const string UNDERLINE = "underline";
						}

						public static class TextureButton
						{
							public const string EXPAND = "expand";
							public const string STRETCH_MODE = "stretch_mode";
							public const string FLIP_H = "flip_h";
							public const string FLIP_V = "flip_v";

							#region TEXTURES

							public const string TEXTURE_NORMAL = "texture_normal";
							public const string TEXTURE_PRESSED = "texture_pressed";
							public const string TEXTURE_HOVER = "texture_hover";
							public const string TEXTURE_DISABLED = "texture_disabled";
							public const string TEXTURE_FOCUSED = "texture_focused";
							public const string TEXTURE_CLICK_MASK = "texture_click_mask";

							#endregion TEXTURES
						}
					}

					public static class ColorRect
					{
						public const string COLOR = "color";
					}

					public static class GraphEdit
					{
						public const string RIGHT_DISCONNECTS = "right_disconnects";
						public const string SCROLL_OFFSET = "scroll_offset";
						public const string SNAP_DISTANCE = "snap_distance";
						public const string USE_SNAP = "use_snap";

						#region ZOOM

						public const string ZOOM = "zoom";
						public const string ZOOM_MIN = "zoom_min";
						public const string ZOOM_MAX = "zoom_max";
						public const string ZOOM_STEP = "zoom_step";
						public const string SHOW_ZOOM_LABEL = "show_zoom_label";

						#endregion ZOOM

						#region MINIMAP

						public const string MINIMAP_ENABLED = "minimap_enabled";
						public const string MINIMAP_SIZE = "minimap_size";
						public const string MINIMAP_OPACITY = "minimap_opacity";

						#endregion MINIMAP
					}

					public static class Range
					{
						public const string MIN_VALUE = "min_value";
						public const string MAX_VALUE = "max_value";
						public const string STEP = "step";
						public const string PAGE = "page";
						public const string VALUE = "value";
						public const string EXP_EDIT = "exp_edit";
						public const string ROUNDED = "rounded";
						public const string ALLOW_GREATER = "allow_greater";
						public const string ALLOW_LESSER = "allow_lesser";

						public static class ScrollBar
						{
							public const string CUSTOM_STEP = "custom_step";
						}

						public static class Slider
						{
							public const string EDITABLE = "editable";
							public const string SCROLLABLE = "scrollable";
							public const string TICK_COUNT = "tick_count";
							public const string TICK_ON_BORDERS = "tick_on_borders";
						}

						public static class ProgressBar
						{
							#region PERCENT

							public const string PERCENT_VISIBLE = "percent_visible";

							#endregion PERCENT
						}

						public static class SpinBox
						{
							public const string ALIGN = "align";
							public const string EDITABLE = "editable";
							public const string PREFIX = "prefix";
							public const string SUFFIX = "suffix";
						}

						public static class TextureProgress
						{
							public const string FILL_MODE = "fill_mode";
							public const string NINE_PATCH_STRETCH = "nine_patch_stretch";
							public const string STRETCH_MARGIN_LEFT = "stretch_margin_left";
							public const string STRETCH_MARGIN_TOP = "stretch_margin_top";
							public const string STRETCH_MARGIN_RIGHT = "stretch_margin_right";
							public const string STRETCH_MARGIN_BOTTOM = "stretch_margin_bottom";

							#region TEXTURES

							public const string TEXTURE_UNDER = "texture_under";
							public const string TEXTURE_OVER = "texture_over";
							public const string TEXTURE_PROGRESS = "texture_progress";
							public const string TEXTURE_PROGRESS_OFFSET = "texture_progress_offset";

							#endregion TEXTURES

							#region TINT

							public const string TINT_UNDER = "tint_under";
							public const string TINT_OVER = "tint_over";
							public const string TINT_PROGRESS = "tint_progress";

							#endregion TINT

							#region RADIAL FILL

							public const string RADIAL_INITIAL_ANGLE = "radial_initial_angle";
							public const string RADIAL_FILL_DEGREES = "radial_fill_degrees";
							public const string RADIAL_CENTER_OFFSET = "radial_center_offset";

							#endregion RADIAL FILL
						}
					}

					public static class ItemList
					{
						public const string SELECT_MODE = "select_mode";
						public const string ALLOW_RESELECT = "allow_reselect";
						public const string ALLOW_RMB_SELECT = "allow_rmb_select";
						public const string MAX_TEXT_LINES = "max_text_lines";
						public const string AUTO_HEIGHT = "auto_height";

						#region COLUMNS

						public const string MAX_COLUMNS = "max_columns";
						public const string SAME_COLUMN_WIDTH = "same_column_width";
						public const string FIXED_COLUMN_WIDTH = "fixed_column_width";

						#endregion COLUMNS

						#region ICON

						public const string ICON_MODE = "icon_mode";
						public const string ICON_SCALE = "icon_scale";
						public const string FIXED_ICON_SIZE = "fixed_icon_size";

						#endregion ICON
					}

					public static class Label
					{
						public const string TEXT = "text";
						public const string ALIGN = "align";
						public const string VALIGN = "valign";
						public const string AUTOWRAP = "autowrap";
						public const string CLIP_TEXT = "clip_text";
						public const string UPPERCASE = "uppercase";
						public const string VISIBLE_CHARACTERS = "visible_characters";
						public const string PERCENT_VISIBLE = "percent_visible";
						public const string LINES_SKIPPED = "lines_skipped";
						public const string MAX_LINES_VISIBLE = "max_lines_visible";
					}

					public static class LineEdit
					{
						public const string TEXT = "text";
						public const string ALIGN = "align";
						public const string MAX_LENGTH = "max_length";
						public const string EDITABLE = "editable";
						public const string SECRET = "secret";
						public const string SECRET_CHARACTER = "secret_character";
						public const string EXPAND_TO_TEXT_LENGTH = "expand_to_text_length";
						public const string CONTEXT_MENU_ENABLED = "context_menu_enabled";
						public const string VIRTUAL_KEYBOARD_ENABLED = "virtual_keyboard_enabled";
						public const string CLEAR_BUTTON_ENABLED = "clear_button_enabled";
						public const string SHORTCUT_KEYS_ENABLED = "shortcut_keys_enabled";
						public const string SELECTING_ENABLED = "selecting_enabled";
						public const string RIGHT_ICON = "right_icon";

						#region PLACEHOLDER

						public const string PLACEHOLDER_TEXT = "placeholder_text";
						public const string PLACEHOLDER_ALPHA = "placeholder_alpha";

						#endregion PLACEHOLDER

						#region CARET

						public const string CARET_BLINK = "caret_blink";
						public const string CARET_BLINK_SPEED = "caret_blink_speed";
						public const string CARET_POSITION = "caret_position";

						#endregion CARET
					}

					public static class NinePatchRect
					{
						public const string TEXTURE = "texture";
						public const string DRAW_CENTER = "draw_center";
						public const string REGION_RECT = "region_rect";

						#region PATCH MARGIN

						public const string PATCH_MARGIN_LEFT = "patch_margin_left";
						public const string PATCH_MARGIN_TOP = "patch_margin_top";
						public const string PATCH_MARGIN_RIGHT = "patch_margin_right";
						public const string PATCH_MARGIN_BOTTOM = "patch_margin_bottom";

						#endregion PATCH MARGIN

						#region AXIS STRETCH

						public const string AXIS_STRETCH_HORIZONTAL = "axis_stretch_horizontal";
						public const string AXIS_STRETCH_VERTICAL = "axis_stretch_vertical";

						#endregion AXIS STRETCH
					}

					public static class ReferenceRect
					{
						public const string BORDER_COLOR = "border_color";
						public const string BORDER_WIDTH = "border_width";
						public const string EDITOR_ONLY = "editor_only";
					}

					public static class RichTextLabel
					{
						public const string VISIBLE_CHARACTERS = "visible_characters";
						public const string PERCENT_VISIBLE = "percent_visible";
						public const string META_UNDERLINED = "meta_underlined";
						public const string TAB_SIZE = "tab_size";
						public const string TEXT = "text";
						public const string FIT_CONTENT_HEIGHT = "fit_content_height";
						public const string SCROLL_ACTIVE = "scroll_active";
						public const string SCROLL_FOLLOWING = "scroll_following";
						public const string SELECTION_ENABLED = "selection_enabled";
						public const string OVERRIDE_SELECTED_FONT_COLOR = "override_selected_font_color";
						public const string CUSTOM_EFFECTS = "custom_effects";

						#region BB CODE

						public const string BB_CODE_ENABLED = "bbcode_enabled";
						public const string BB_CODE_TEXT = "bbcode_text";

						#endregion BB CODE
					}

					public static class Tabs
					{
						public const string CURRENT_TAB = "current_tab";
						public const string TAB_ALIGN = "tab_align";
						public const string TAB_CLOSE_DISPLAY_POLICY = "tab_close_display_policy";
						public const string SCROLLING_ENABLED = "scrolling_enabled";
						public const string DRAG_TO_REARRANGE_ENABLED = "drag_to_rearrange_enabled";
					}

					public static class TextEdit
					{
						public const string TEXT = "text";
						public const string READONLY = "readonly";
						public const string HIGHLIGHT_CURRENT_LINE = "highlight_current_line";
						public const string SYNTAX_HIGHLIGHTING = "syntax_highlighting";
						public const string SHOW_LINE_NUMBERS = "show_line_numbers";
						public const string DRAW_TABS = "draw_tabs";
						public const string DRAW_SPACES = "draw_spaces";
						public const string BOOKMARK_GUTTER = "bookmark_gutter";
						public const string BREAKPOINT_GUTTER = "breakpoint_gutter";
						public const string FOLD_GUTTER = "fold_gutter";
						public const string HIGHLIGHT_ALL_OCCURENCES = "highlight_all_occurences";
						public const string OVERRIDE_SELECTED_FONT_COLOR = "override_selected_font_color";
						public const string CONTEXT_MENU_ENABLED = "context_menu_enabled";
						public const string SHORTCUT_KEYS_ENABLED = "shortcut_keys_enabled";
						public const string VIRTUAL_KEYBOARD_ENABLED = "virtual_keyboard_enabled";
						public const string SELECTING_ENABLED = "selecting_enabled";
						public const string SMOOTH_SCROLLING = "smooth_scrolling";
						public const string V_SCROLL_SPEED = "v_scroll_speed";
						public const string HIDING_ENABLED = "hiding_enabled";
						public const string WRAP_ENABLED = "wrap_enabled";
						public const string SCROLL_VERTICAL = "scroll_vertical";
						public const string SCROLL_HORIZONTAL = "scroll_horizontal";

						#region MINIMAP

						public const string MINIMAP_DRAW = "minimap_draw";
						public const string MINIMAP_WIDTH = "minimap_width";

						#endregion MINIMAP

						#region CARET

						public const string CARET_BLOCK_MODE = "caret_block_mode";
						public const string CARET_BLINK = "caret_blink";
						public const string CARET_BLINK_SPEED = "caret_blink_speed";
						public const string CARET_MOVING_BY_RIGHT_CLICK = "caret_moving_by_right_click";

						#endregion CARET
					}

					public static class TextureRect
					{
						public const string TEXTURE = "texture";
						public const string EXPAND = "expand";
						public const string STRETCH_MODE = "stretch_mode";
						public const string FLIP_H = "flip_h";
						public const string FLIP_V = "flip_v";
					}

					public static class Tree
					{
						public const string COLUMNS = "columns";
						public const string ALLOW_RESELECT = "allow_reselect";
						public const string ALLOW_RMB_SELECT = "allow_rmb_select";
						public const string HIDE_FOLDING = "hide_folding";
						public const string HIDE_ROOT = "hide_root";
						public const string DROP_MODE_FLAGS = "drop_mode_flags";
					}

					public static class VideoPlayer
					{
						public const string AUDIO_TRACK = "audio_track";
						public const string STREAM = "stream";
						public const string VOLUME_DB = "volume_db";
						public const string AUTOPLAY = "autoplay";
						public const string PAUSED = "paused";
						public const string EXPAND = "expand";
						public const string BUFFERING_MSEC = "buffering_msec";
						public const string BUS = "bus";
					}
				}

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

					public static class AnimatedSprite
					{
						public const string FRAMES = "frames";
						public const string ANIMATION = "animation";
						public const string FRAME = "frame";
						public const string SPEED_SCALE = "speed_scale";
						public const string PLAYING = "playing";
						public const string CENTERED = "centered";
						public const string OFFSET = "offset";
						public const string FLIP_H = "flip_h";
						public const string FLIP_V = "flip_v";
					}

					public static class CollisionObject2D
					{
						#region COLLISION

						public const string COLLISION_LAYER = "collision_layer";
						public const string COLLISION_MASK = "collision_mask";

						#endregion COLLISION

						#region INPUT

						public const string INPUT_PICKABLE = "input_pickable";

						#endregion INPUT

						public static class Area2D
						{
							public const string MONITORING = "monitoring";
							public const string MONITORABLE = "monitorable";
							public const string PRIORITY = "priority";

							#region PHYSICS OVERRIDES

							public const string SPACE_OVERRIDE = "space_override";
							public const string GRAVITY_POINT = "gravity_point";
							public const string GRAVITY_DISTANCE_SCALE = "gravity_distance_scale";
							public const string GRAVITY_VEC = "gravity_vec";
							public const string GRAVITY = "gravity";
							public const string LINEAR_DAMP = "linear_damp";
							public const string ANGULAR_DAMP = "angular_damp";

							#endregion PHYSICS OVERRIDES

							#region AUDIO BUS

							public const string AUDIO_BUS_OVERRIDE = "audio_bus_override";
							public const string AUDIO_BUS_NAME = "audio_bus_name";

							#endregion AUDIO BUS
						}

						public static class KinematicBody2D
						{
							#region COLLISION

							public const string COLLISION_SAFE_MARGIN = "collision/safe_margin";

							#endregion COLLISION

							#region MOTION

							public const string MOTION_SYNC_TO_PHYSICS = "motion/sync_to_physics";

							#endregion MOTION
						}

						public static class RigidBody2D
						{
							public const string MODE = "mode";
							public const string MASS = "mass";
							public const string WEIGHT = "weight";
							public const string PHYSICS_MATERIAL_OVERRIDE = "physics_material_override";
							public const string GRAVITY_SCALE = "gravity_scale";
							public const string CUSTOM_INTEGRATOR = "custom_integrator";
							public const string CONTINUOUS_CD = "continuous_cd";
							public const string CONTACTS_REPORTED = "contacts_reported";
							public const string CONTACT_MONITOR = "contact_monitor";
							public const string SLEEPING = "sleeping";
							public const string CAN_SLEEP = "can_sleep";

							#region LINEAR

							public const string LINEAR_VELOCITY = "linear_velocity";
							public const string LINEAR_DAMP = "linear_damp";

							#endregion LINEAR

							#region ANGULAR

							public const string ANGULAR_VELOCITY = "angular_velocity";
							public const string ANGULAR_DAMP = "angular_damp";

							#endregion ANGULAR

							#region APPLIED FORCES

							public const string APPLIED_FORCE = "applied_force";
							public const string APPLIED_TORQUE = "applied_torque";

							#endregion APPLIED FORCES
						}

						public static class StaticBody2D
						{
							public const string CONSTANT_LINEAR_VELOCITY = "constant_linear_velocity";
							public const string CONSTANT_ANGULAR_VELOCITY = "constant_angular_velocity";
							public const string PHYSICS_MATERIAL_OVERRIDE = "physics_material_override";
						}
					}

					public static class AudioStreamPlayer2D
					{
						public const string STREAM = "stream";
						public const string VOLUME_DB = "volume_db";
						public const string PITCH_SCALE = "pitch_scale";
						public const string PLAYING = "playing";
						public const string AUTOPLAY = "autoplay";
						public const string STREAM_PAUSED = "stream_paused";
						public const string MAX_DISTANCE = "max_distance";
						public const string ATTENUATION = "attenuation";
						public const string BUS = "bus";
						public const string AREA_MASK = "area_mask";
					}

					public static class BackBufferCopy
					{
						public const string COPY_MODE = "copy_mode";
						public const string RECT = "rect";
					}

					public static class Bone2D
					{
						public const string REST = "rest";
						public const string DEFAULT_LENGTH = "default_length";
					}

					public static class CPUParticles2D
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
						public const string LIFETIME_RANDOMNESS = "lifetime_randomness";
						public const string FIXED_FPS = "fixed_fps";
						public const string FRACT_DELTA = "fract_delta";

						#endregion TIME

						#region DRAWING

						public const string LOCAL_COORDS = "local_coords";
						public const string DRAW_ORDER = "draw_order";
						public const string TEXTURE = "texture";
						public const string NORMALMAP = "normalmap";

						#endregion DRAWING

						#region EMISSION SHAPE

						public const string EMISSION_SHAPE = "emission_shape";

						#endregion EMISSION SHAPE

						#region FLAGS

						public const string FLAG_ALIGN_Y = "flag_align_y";

						#endregion FLAGS

						#region DIRECTION

						public const string DIRECTION = "direction";
						public const string SPREAD = "spread";

						#endregion DIRECTION

						#region GRAVITY

						public const string GRAVITY = "gravity";

						#endregion GRAVITY

						#region INITIAL VELOCITY

						public const string INITIAL_VELOCITY = "initial_velocity";
						public const string INITIAL_VELOCITY_RANDOM = "initial_velocity_random";

						#endregion INITIAL VELOCITY

						#region ANGULAR VELOCITY

						public const string ANGULAR_VELOCITY = "angular_velocity";
						public const string ANGULAR_VELOCITY_RANDOM = "angular_velocity_random";
						public const string ANGULAR_VELOCITY_CURVE = "angular_velocity_curve";

						#endregion ANGULAR VELOCITY

						#region ORBIT VELOCITY

						public const string ORBIT_VELOCITY = "orbit_velocity";
						public const string ORBIT_VELOCITY_RANDOM = "orbit_velocity_random";
						public const string ORBIT_VELOCITY_CURVE = "orbit_velocity_curve";

						#endregion ORBIT VELOCITY

						#region LINEAR ACCEL

						public const string LINEAR_ACCEL = "linear_accel";
						public const string LINEAR_ACCEL_RANDOM = "linear_accel_random";
						public const string LINEAR_ACCEL_CURVE = "linear_accel_curve";

						#endregion LINEAR ACCEL

						#region RADIAL ACCEL

						public const string RADIAL_ACCEL = "radial_accel";
						public const string RADIAL_ACCEL_RANDOM = "radial_accel_random";
						public const string RADIAL_ACCEL_CURVE = "radial_accel_curve";

						#endregion RADIAL ACCEL

						#region TANGENTIAL ACCEL

						public const string TANGENTIAL_ACCEL = "tangential_accel";
						public const string TANGENTIAL_ACCEL_RANDOM = "tangential_accel_random";
						public const string TANGENTIAL_ACCEL_CURVE = "tangential_accel_curve";

						#endregion TANGENTIAL ACCEL

						#region DAMPING

						public const string DAMPING = "damping";
						public const string DAMPING_RANDOM = "damping_random";
						public const string DAMPING_CURVE = "damping_curve";

						#endregion DAMPING

						#region ANGLE

						public const string ANGLE = "angle";
						public const string ANGLE_RANDOM = "angle_random";
						public const string ANGLE_CURVE = "angle_curve";

						#endregion ANGLE

						#region SCALE

						public const string SCALE_AMOUNT = "scale_amount";
						public const string SCALE_AMOUNT_RANDOM = "scale_amount_random";
						public const string SCALE_AMOUNT_CURVE = "scale_amount_curve";

						#endregion SCALE

						#region COLOR

						public const string COLOR = "color";
						public const string COLOR_RAMP = "color_ramp";

						#endregion COLOR

						#region HUE VARIATION

						public const string HUE_VARIATION = "hue_variation";
						public const string HUE_VARIATION_RANDOM = "hue_variation_random";
						public const string HUE_VARIATION_CURVE = "hue_variation_curve";

						#endregion HUE VARIATION

						#region ANIMATION

						public const string ANIM_SPEED = "anim_speed";
						public const string ANIM_SPEED_RANDOM = "anim_speed_random";
						public const string ANIM_SPEED_CURVE = "anim_speed_curve";
						public const string ANIM_OFFSET = "anim_offset";
						public const string ANIM_OFFSET_RANDOM = "anim_offset_random";
						public const string ANIM_OFFSET_CURVE = "anim_offset_curve";

						#endregion ANIMATION
					}

					public static class Camera2D
					{
						public const string OFFSET = "offset";
						public const string ANCHOR_MODE = "anchor_mode";
						public const string ROTATING = "rotating";
						public const string CURRENT = "current";
						public const string ZOOM = "zoom";
						public const string PROCESS_MODE = "process_mode";
						public const string DRAG_MARGIN_H_ENABLED = "drag_margin_h_enabled";
						public const string DRAG_MARGIN_V_ENABLED = "drag_margin_v_enabled";

						#region LIMIT

						public const string LIMIT_LEFT = "limit_left";
						public const string LIMIT_TOP = "limit_top";
						public const string LIMIT_RIGHT = "limit_right";
						public const string LIMIT_BOTTOM = "limit_bottom";
						public const string LIMIT_SMOOTHED = "limit_smoothed";

						#endregion LIMIT

						#region SMOOTHING

						public const string SMOOTHING_ENABLED = "smoothing_enabled";
						public const string SMOOTHING_SPEED = "smoothing_speed";

						#endregion SMOOTHING

						#region OFFSET

						public const string OFFSET_H = "offset_h";
						public const string OFFSET_V = "offset_v";

						#endregion OFFSET

						#region DRAG_MARGIN

						public const string DRAG_MARGIN_LEFT = "drag_margin_left";
						public const string DRAG_MARGIN_TOP = "drag_margin_top";
						public const string DRAG_MARGIN_RIGHT = "drag_margin_right";
						public const string DRAG_MARGIN_BOTTOM = "drag_margin_bottom";

						#endregion DRAG_MARGIN

						#region EDITOR

						public const string EDITOR_DRAW_SCREEN = "editor_draw_screen";
						public const string EDITOR_DRAW_LIMITS = "editor_draw_limits";
						public const string EDITOR_DRAW_DRAG_MARGIN = "editor_draw_drag_margin";

						#endregion EDITOR
					}

					public static class CanvasModulate
					{
						public const string COLOR = "color";
					}

					public static class CollisionPolygon2D
					{
						public const string BUILD_MODE = "build_mode";
						public const string POLYGON = "polygon";
						public const string DISABLED = "disabled";
						public const string ONE_WAY_COLLISION = "one_way_collision";
						public const string ONE_WAY_COLLISION_MARGIN = "one_way_collision_margin";
					}

					public static class CollisionShape2D
					{
						public const string SHAPE = "shape";
						public const string DISABLED = "disabled";
						public const string ONE_WAY_COLLISION = "one_way_collision";
						public const string ONE_WAY_COLLISION_MARGIN = "one_way_collision_margin";
					}

					public static class Joint2D
					{
						public const string NODE_A = "node_a";
						public const string NODE_B = "node_b";
						public const string BIAS = "bias";
						public const string DISABLE_COLLISION = "disable_collision";

						public static class DampedSpringJoint2D
						{
							public const string LENGTH = "length";
							public const string REST_LENGTH = "rest_length";
							public const string STIFFNESS = "stiffness";
							public const string DAMPING = "damping";
						}

						public static class GrooveJoint2D
						{
							public const string LENGTH = "length";
							public const string INITIAL_OFFSET = "initial_offset";
						}

						public static class PinJoint2D
						{
							public const string SOFTNESS = "softness";
						}
					}

					public static class Light2D
					{
						public const string ENABLED = "enabled";
						public const string EDITOR_ONLY = "editor_only";
						public const string TEXTURE = "texture";
						public const string OFFSET = "offset";
						public const string TEXTURE_SCALE = "texture_scale";
						public const string COLOR = "color";
						public const string ENERGY = "energy";
						public const string MODE = "mode";

						#region RANGE

						public const string RANGE_HEIGHT = "range_height";
						public const string RANGE_Z_MIN = "range_z_min";
						public const string RANGE_Z_MAX = "range_z_max";
						public const string RANGE_LAYER_MIN = "range_layer_min";
						public const string RANGE_LAYER_MAX = "range_layer_max";
						public const string RANGE_ITEM_CULL_MASK = "range_item_cull_mask";

						#endregion RANGE

						#region SHADOW

						public const string SHADOW_ENABLED = "shadow_enabled";
						public const string SHADOW_COLOR = "shadow_color";
						public const string SHADOW_BUFFER_SIZE = "shadow_buffer_size";
						public const string SHADOW_GRADIENT_LENGTH = "shadow_gradient_length";
						public const string SHADOW_FILTER = "shadow_filter";
						public const string SHADOW_FILTER_SMOOTH = "shadow_filter_smooth";
						public const string SHADOW_ITEM_CULL_MASK = "shadow_item_cull_mask";

						#endregion SHADOW
					}

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
