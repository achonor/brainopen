-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf.protobuf"
module('xls2proto/play_data_v2_pb')


local PLAY_DATA = protobuf.Descriptor();
local PLAY_DATA_ID_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_NAME_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_PREFAB_PATH_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_ICON_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_INTRO_ICON_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_INTRO_TIME_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_TIME_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_EXPECT_GRADE_SCALE_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_ATTRIBUTE_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_PARAM1_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_PARAM2_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_PARAM3_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_PARAM4_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_PARAM5_FIELD = protobuf.FieldDescriptor();
local PLAY_DATA_ARRAY = protobuf.Descriptor();
local PLAY_DATA_ARRAY_ITEMS_FIELD = protobuf.FieldDescriptor();

PLAY_DATA_ID_FIELD.name = "id"
PLAY_DATA_ID_FIELD.full_name = ".play_data.id"
PLAY_DATA_ID_FIELD.number = 1
PLAY_DATA_ID_FIELD.index = 0
PLAY_DATA_ID_FIELD.label = 1
PLAY_DATA_ID_FIELD.has_default_value = false
PLAY_DATA_ID_FIELD.default_value = 0
PLAY_DATA_ID_FIELD.type = 5
PLAY_DATA_ID_FIELD.cpp_type = 1

PLAY_DATA_NAME_FIELD.name = "name"
PLAY_DATA_NAME_FIELD.full_name = ".play_data.name"
PLAY_DATA_NAME_FIELD.number = 2
PLAY_DATA_NAME_FIELD.index = 1
PLAY_DATA_NAME_FIELD.label = 1
PLAY_DATA_NAME_FIELD.has_default_value = false
PLAY_DATA_NAME_FIELD.default_value = ""
PLAY_DATA_NAME_FIELD.type = 9
PLAY_DATA_NAME_FIELD.cpp_type = 9

PLAY_DATA_PREFAB_PATH_FIELD.name = "prefab_path"
PLAY_DATA_PREFAB_PATH_FIELD.full_name = ".play_data.prefab_path"
PLAY_DATA_PREFAB_PATH_FIELD.number = 3
PLAY_DATA_PREFAB_PATH_FIELD.index = 2
PLAY_DATA_PREFAB_PATH_FIELD.label = 1
PLAY_DATA_PREFAB_PATH_FIELD.has_default_value = false
PLAY_DATA_PREFAB_PATH_FIELD.default_value = ""
PLAY_DATA_PREFAB_PATH_FIELD.type = 9
PLAY_DATA_PREFAB_PATH_FIELD.cpp_type = 9

PLAY_DATA_ICON_FIELD.name = "icon"
PLAY_DATA_ICON_FIELD.full_name = ".play_data.icon"
PLAY_DATA_ICON_FIELD.number = 4
PLAY_DATA_ICON_FIELD.index = 3
PLAY_DATA_ICON_FIELD.label = 1
PLAY_DATA_ICON_FIELD.has_default_value = false
PLAY_DATA_ICON_FIELD.default_value = ""
PLAY_DATA_ICON_FIELD.type = 9
PLAY_DATA_ICON_FIELD.cpp_type = 9

PLAY_DATA_INTRO_ICON_FIELD.name = "intro_icon"
PLAY_DATA_INTRO_ICON_FIELD.full_name = ".play_data.intro_icon"
PLAY_DATA_INTRO_ICON_FIELD.number = 5
PLAY_DATA_INTRO_ICON_FIELD.index = 4
PLAY_DATA_INTRO_ICON_FIELD.label = 1
PLAY_DATA_INTRO_ICON_FIELD.has_default_value = false
PLAY_DATA_INTRO_ICON_FIELD.default_value = ""
PLAY_DATA_INTRO_ICON_FIELD.type = 9
PLAY_DATA_INTRO_ICON_FIELD.cpp_type = 9

PLAY_DATA_INTRO_TIME_FIELD.name = "intro_time"
PLAY_DATA_INTRO_TIME_FIELD.full_name = ".play_data.intro_time"
PLAY_DATA_INTRO_TIME_FIELD.number = 6
PLAY_DATA_INTRO_TIME_FIELD.index = 5
PLAY_DATA_INTRO_TIME_FIELD.label = 1
PLAY_DATA_INTRO_TIME_FIELD.has_default_value = false
PLAY_DATA_INTRO_TIME_FIELD.default_value = 0.0
PLAY_DATA_INTRO_TIME_FIELD.type = 2
PLAY_DATA_INTRO_TIME_FIELD.cpp_type = 6

PLAY_DATA_TIME_FIELD.name = "time"
PLAY_DATA_TIME_FIELD.full_name = ".play_data.time"
PLAY_DATA_TIME_FIELD.number = 7
PLAY_DATA_TIME_FIELD.index = 6
PLAY_DATA_TIME_FIELD.label = 1
PLAY_DATA_TIME_FIELD.has_default_value = false
PLAY_DATA_TIME_FIELD.default_value = 0.0
PLAY_DATA_TIME_FIELD.type = 2
PLAY_DATA_TIME_FIELD.cpp_type = 6

PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.name = "expect_grade_scale"
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.full_name = ".play_data.expect_grade_scale"
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.number = 8
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.index = 7
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.label = 3
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.has_default_value = false
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.default_value = {}
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.type = 5
PLAY_DATA_EXPECT_GRADE_SCALE_FIELD.cpp_type = 1

PLAY_DATA_ATTRIBUTE_FIELD.name = "attribute"
PLAY_DATA_ATTRIBUTE_FIELD.full_name = ".play_data.attribute"
PLAY_DATA_ATTRIBUTE_FIELD.number = 9
PLAY_DATA_ATTRIBUTE_FIELD.index = 8
PLAY_DATA_ATTRIBUTE_FIELD.label = 3
PLAY_DATA_ATTRIBUTE_FIELD.has_default_value = false
PLAY_DATA_ATTRIBUTE_FIELD.default_value = {}
PLAY_DATA_ATTRIBUTE_FIELD.type = 5
PLAY_DATA_ATTRIBUTE_FIELD.cpp_type = 1

PLAY_DATA_PARAM1_FIELD.name = "param1"
PLAY_DATA_PARAM1_FIELD.full_name = ".play_data.param1"
PLAY_DATA_PARAM1_FIELD.number = 10
PLAY_DATA_PARAM1_FIELD.index = 9
PLAY_DATA_PARAM1_FIELD.label = 3
PLAY_DATA_PARAM1_FIELD.has_default_value = false
PLAY_DATA_PARAM1_FIELD.default_value = {}
PLAY_DATA_PARAM1_FIELD.type = 5
PLAY_DATA_PARAM1_FIELD.cpp_type = 1

PLAY_DATA_PARAM2_FIELD.name = "param2"
PLAY_DATA_PARAM2_FIELD.full_name = ".play_data.param2"
PLAY_DATA_PARAM2_FIELD.number = 11
PLAY_DATA_PARAM2_FIELD.index = 10
PLAY_DATA_PARAM2_FIELD.label = 3
PLAY_DATA_PARAM2_FIELD.has_default_value = false
PLAY_DATA_PARAM2_FIELD.default_value = {}
PLAY_DATA_PARAM2_FIELD.type = 5
PLAY_DATA_PARAM2_FIELD.cpp_type = 1

PLAY_DATA_PARAM3_FIELD.name = "param3"
PLAY_DATA_PARAM3_FIELD.full_name = ".play_data.param3"
PLAY_DATA_PARAM3_FIELD.number = 12
PLAY_DATA_PARAM3_FIELD.index = 11
PLAY_DATA_PARAM3_FIELD.label = 3
PLAY_DATA_PARAM3_FIELD.has_default_value = false
PLAY_DATA_PARAM3_FIELD.default_value = {}
PLAY_DATA_PARAM3_FIELD.type = 5
PLAY_DATA_PARAM3_FIELD.cpp_type = 1

PLAY_DATA_PARAM4_FIELD.name = "param4"
PLAY_DATA_PARAM4_FIELD.full_name = ".play_data.param4"
PLAY_DATA_PARAM4_FIELD.number = 13
PLAY_DATA_PARAM4_FIELD.index = 12
PLAY_DATA_PARAM4_FIELD.label = 3
PLAY_DATA_PARAM4_FIELD.has_default_value = false
PLAY_DATA_PARAM4_FIELD.default_value = {}
PLAY_DATA_PARAM4_FIELD.type = 9
PLAY_DATA_PARAM4_FIELD.cpp_type = 9

PLAY_DATA_PARAM5_FIELD.name = "param5"
PLAY_DATA_PARAM5_FIELD.full_name = ".play_data.param5"
PLAY_DATA_PARAM5_FIELD.number = 14
PLAY_DATA_PARAM5_FIELD.index = 13
PLAY_DATA_PARAM5_FIELD.label = 3
PLAY_DATA_PARAM5_FIELD.has_default_value = false
PLAY_DATA_PARAM5_FIELD.default_value = {}
PLAY_DATA_PARAM5_FIELD.type = 5
PLAY_DATA_PARAM5_FIELD.cpp_type = 1

PLAY_DATA.name = "play_data"
PLAY_DATA.full_name = ".play_data"
PLAY_DATA.nested_types = {}
PLAY_DATA.enum_types = {}
PLAY_DATA.fields = {PLAY_DATA_ID_FIELD, PLAY_DATA_NAME_FIELD, PLAY_DATA_PREFAB_PATH_FIELD, PLAY_DATA_ICON_FIELD, PLAY_DATA_INTRO_ICON_FIELD, PLAY_DATA_INTRO_TIME_FIELD, PLAY_DATA_TIME_FIELD, PLAY_DATA_EXPECT_GRADE_SCALE_FIELD, PLAY_DATA_ATTRIBUTE_FIELD, PLAY_DATA_PARAM1_FIELD, PLAY_DATA_PARAM2_FIELD, PLAY_DATA_PARAM3_FIELD, PLAY_DATA_PARAM4_FIELD, PLAY_DATA_PARAM5_FIELD}
PLAY_DATA.is_extendable = false
PLAY_DATA.extensions = {}
PLAY_DATA_ARRAY_ITEMS_FIELD.name = "items"
PLAY_DATA_ARRAY_ITEMS_FIELD.full_name = ".play_data_ARRAY.items"
PLAY_DATA_ARRAY_ITEMS_FIELD.number = 1
PLAY_DATA_ARRAY_ITEMS_FIELD.index = 0
PLAY_DATA_ARRAY_ITEMS_FIELD.label = 3
PLAY_DATA_ARRAY_ITEMS_FIELD.has_default_value = false
PLAY_DATA_ARRAY_ITEMS_FIELD.default_value = {}
PLAY_DATA_ARRAY_ITEMS_FIELD.message_type = PLAY_DATA
PLAY_DATA_ARRAY_ITEMS_FIELD.type = 11
PLAY_DATA_ARRAY_ITEMS_FIELD.cpp_type = 10

PLAY_DATA_ARRAY.name = "play_data_ARRAY"
PLAY_DATA_ARRAY.full_name = ".play_data_ARRAY"
PLAY_DATA_ARRAY.nested_types = {}
PLAY_DATA_ARRAY.enum_types = {}
PLAY_DATA_ARRAY.fields = {PLAY_DATA_ARRAY_ITEMS_FIELD}
PLAY_DATA_ARRAY.is_extendable = false
PLAY_DATA_ARRAY.extensions = {}

play_data = protobuf.Message(PLAY_DATA)
play_data_ARRAY = protobuf.Message(PLAY_DATA_ARRAY)

