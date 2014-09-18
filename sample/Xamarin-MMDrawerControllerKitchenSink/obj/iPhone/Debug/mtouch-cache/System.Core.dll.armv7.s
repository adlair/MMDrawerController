.subsections_via_symbols
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,17,1,18,1,64,10,0,0
	.byte 3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0,11,11,62,11,3,8,0
	.byte 0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73,19,56,10,0,0,7,22
	.byte 0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13,0,0,10,57,1,3,8
	.byte 0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13,15,0,73,19,0,0,14
	.byte 16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0,0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 3.8.0 (mono-3.8.0-branch/45d0ba1 Tue Aug 26 07:52:59 EDT 2014)"
	.asciz "System.Core.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14
	.align 2
Lcie0_end:
.text
	.align 3
methods:
	.space 16
.text
	.align 2
	.no_dead_strip _System_Linq_Check_Source_object
_System_Linq_Check_Source_object:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,12,208,77,226,0,0,141,229,0,0,157,229,0,0,80,227,2,0,0,10
	.byte 12,208,141,226,0,1,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long _mono_aot_System_Core_got - . -12
	.byte 0,0,159,231,1,16,160,227
bl _p_1

	.byte 0,16,160,225,43,1,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_2

Lme_0:
.text
	.align 2
	.no_dead_strip _System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource
_System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource:

	.byte 128,64,45,233,13,112,160,225,96,13,45,233,52,208,77,226,13,176,160,225,16,128,139,229,32,0,139,229,0,0,160,227
	.byte 12,0,139,229,32,0,155,229
bl _p_3

	.byte 16,0,155,229
bl _p_4

	.byte 0,32,160,225,4,16,146,229,32,0,155,229
bl _p_5

	.byte 0,0,139,229,0,0,80,227,11,0,0,10,16,0,155,229
bl _p_6

	.byte 0,32,160,225,0,0,155,229,0,16,160,225,0,16,145,229,2,128,160,225,4,224,143,226,76,240,17,229,0,0,0,0
	.byte 0,0,80,227,104,0,0,10,16,0,155,229
bl _p_7

	.byte 0,32,160,225,4,16,146,229,32,0,155,229
bl _p_5

	.byte 0,96,160,225,0,0,80,227,21,0,0,10,16,0,155,229
bl _p_6

	.byte 0,32,160,225,6,0,160,225,0,16,150,229,2,128,160,225,4,224,143,226,76,240,17,229,0,0,0,0,1,0,64,226
	.byte 40,0,139,229,16,0,155,229
bl _p_8

	.byte 0,48,160,225,40,16,155,229,6,0,160,225,0,32,150,229,3,128,160,225,4,224,143,226,12,240,18,229,0,0,0,0
	.byte 70,0,0,234,1,0,160,227,4,0,203,229,0,0,160,227,8,0,139,229,0,80,160,227,16,0,155,229
bl _p_9

	.byte 0,32,160,225,32,0,155,229,0,16,160,225,0,16,145,229,2,128,160,225,4,224,143,226,44,240,17,229,0,0,0,0
	.byte 12,0,139,229,15,0,0,234,12,0,155,229,40,0,139,229,16,0,155,229
bl _p_10

	.byte 0,32,160,225,40,16,155,229,1,0,160,225,0,16,145,229,2,128,160,225,4,224,143,226,28,240,17,229,0,0,0,0
	.byte 0,160,160,225,10,80,160,225,0,0,160,227,4,0,203,229,12,16,155,229,1,0,160,225,0,16,145,229,0,128,159,229
	.byte 0,0,0,234
	.long _mono_aot_System_Core_got - . + 4
	.byte 8,128,159,231,4,224,143,226,60,240,17,229,0,0,0,0,255,0,0,226,0,0,80,227,226,255,255,26,0,0,0,235
	.byte 15,0,0,234,28,224,139,229,12,0,155,229,0,0,80,227,9,0,0,10,12,16,155,229,1,0,160,225,0,16,145,229
	.byte 0,128,159,229,0,0,0,234
	.long _mono_aot_System_Core_got - . + 8
	.byte 8,128,159,231,4,224,143,226,20,240,17,229,0,0,0,0,28,192,155,229,12,240,160,225,4,0,219,229,0,0,80,227
	.byte 1,0,0,26,5,0,160,225,1,0,0,234
bl _p_11
bl _p_2

	.byte 52,208,139,226,96,13,189,232,128,128,189,232
bl _p_11
bl _p_2

Lme_1:
.text
	.align 2
	.no_dead_strip _System_Linq_Enumerable_EmptySequence
_System_Linq_Enumerable_EmptySequence:

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,12,208,77,226,0,0,159,229,0,0,0,234
	.long _mono_aot_System_Core_got - . + 12
	.byte 0,0,159,231,4,0,141,229,0,0,159,229,0,0,0,234
	.long _mono_aot_System_Core_got - . + 16
	.byte 0,0,159,231
bl _p_12

	.byte 4,16,157,229,0,0,141,229
bl _p_13

	.byte 0,0,157,229,12,208,141,226,0,1,189,232,128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip _System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0
_System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0:

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,48,208,77,226,13,176,160,225,16,128,139,229,0,16,139,229,0,96,160,225
	.byte 16,0,155,229
bl _p_14

	.byte 0,80,160,225,0,0,149,229,7,64,128,226,7,64,196,227,4,208,77,224,0,64,141,226,16,0,149,229,0,0,132,224
	.byte 4,16,149,229,8,32,149,229,50,255,47,225,20,16,149,229,4,0,160,225,1,0,128,224,4,16,149,229,8,32,149,229
	.byte 50,255,47,225,24,16,149,229,4,0,160,225,1,0,128,224,4,16,149,229,8,32,149,229,50,255,47,225,0,0,160,227
	.byte 12,0,139,229,6,0,160,225
bl _p_3

	.byte 16,0,155,229
bl _p_15

	.byte 0,32,160,225,4,16,146,229,6,0,160,225
bl _p_5

	.byte 4,0,139,229,0,0,80,227,11,0,0,10,16,0,155,229
bl _p_16

	.byte 32,0,139,229,16,0,155,229
bl _p_17

	.byte 0,16,160,225,32,32,155,229,4,0,155,229,2,128,160,225,49,255,47,225,0,0,80,227,135,0,0,10,16,0,155,229
bl _p_18

	.byte 0,32,160,225,4,16,146,229,6,0,160,225
bl _p_5

	.byte 0,160,160,225,0,0,80,227,31,0,0,10,16,0,155,229
bl _p_16

	.byte 40,0,139,229,16,0,155,229
bl _p_17

	.byte 0,16,160,225,40,32,155,229,10,0,160,225,2,128,160,225,49,255,47,225,1,0,64,226,32,0,139,229,16,0,155,229
bl _p_19

	.byte 36,0,139,229,16,0,155,229
bl _p_20

	.byte 0,48,160,225,32,32,155,229,36,192,155,229,28,0,149,229,0,16,132,224,10,0,160,225,12,128,160,225,51,255,47,225
	.byte 28,0,149,229,0,16,132,224,0,0,155,229,4,32,149,229,12,48,149,229,51,255,47,225,91,0,0,234,1,0,160,227
	.byte 8,0,203,229,20,0,149,229,0,0,132,224,4,16,149,229,8,32,149,229,50,255,47,225,20,0,149,229,0,16,132,224
	.byte 16,0,149,229,0,0,132,224,4,32,149,229,12,48,149,229,51,255,47,225,16,0,155,229
bl _p_21

	.byte 32,0,139,229,16,0,155,229
bl _p_22

	.byte 0,16,160,225,32,32,155,229,6,0,160,225,2,128,160,225,49,255,47,225,12,0,139,229,22,0,0,234,12,0,155,229
	.byte 32,0,139,229,16,0,155,229
bl _p_23

	.byte 36,0,139,229,16,0,155,229
bl _p_24

	.byte 0,32,160,225,32,0,155,229,36,48,155,229,24,16,149,229,1,16,132,224,3,128,160,225,50,255,47,225,24,0,149,229
	.byte 0,16,132,224,16,0,149,229,0,0,132,224,4,32,149,229,12,48,149,229,51,255,47,225,0,0,160,227,8,0,203,229
	.byte 12,16,155,229,1,0,160,225,0,16,145,229,0,128,159,229,0,0,0,234
	.long _mono_aot_System_Core_got - . + 4
	.byte 8,128,159,231,4,224,143,226,60,240,17,229,0,0,0,0,255,0,0,226,0,0,80,227,219,255,255,26,0,0,0,235
	.byte 15,0,0,234,28,224,139,229,12,0,155,229,0,0,80,227,9,0,0,10,12,16,155,229,1,0,160,225,0,16,145,229
	.byte 0,128,159,229,0,0,0,234
	.long _mono_aot_System_Core_got - . + 8
	.byte 8,128,159,231,4,224,143,226,20,240,17,229,0,0,0,0,28,192,155,229,12,240,160,225,8,0,219,229,0,0,80,227
	.byte 6,0,0,26,16,0,149,229,0,16,132,224,0,0,155,229,4,32,149,229,12,48,149,229,51,255,47,225,1,0,0,234
bl _p_11
bl _p_2

	.byte 48,208,139,226,112,13,189,232,128,128,189,232
bl _p_11
bl _p_2

Lme_4:
.text
	.align 3
methods_end:

	.long 0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl _System_Linq_Check_Source_object
bl _System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource
bl _System_Linq_Enumerable_EmptySequence
bl method_addresses
bl _System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0
method_addresses_end:
.section __TEXT, __const
	.align 3
code_offsets:

	.long 0

.text
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.section __TEXT, __const
	.align 3
method_info_offsets:

	.long 5,10,1,2
	.short 0
	.byte 1,2,4,255,255,255,255,249,11
.section __TEXT, __const
	.align 3
extra_method_table:

	.long 11,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 20,4,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0
.section __TEXT, __const
	.align 3
extra_method_info_offsets:

	.long 1,4,20
.section __TEXT, __const
	.align 3
class_name_table:

	.short 11, 1, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 2, 0, 0, 0, 3
	.short 0, 0, 0, 0, 0, 0, 0
.section __TEXT, __const
	.align 3
got_info_offsets:

	.long 8,10,1,2
	.short 0
	.byte 36,2,1,1,1,5,5,3
.section __TEXT, __const
	.align 3
ex_info_offsets:

	.long 5,10,1,2
	.short 0
	.byte 130,99,39,128,240,255,255,255,252,134,131,142
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 18,12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,24,29,12,13,0,72,14,8,135,2,68,14,28,133
	.byte 7,134,6,136,5,138,4,139,3,142,1,68,14,80,68,13,11,31,12,13,0,72,14,8,135,2,68,14,32,132,8,133
	.byte 7,134,6,136,5,138,4,139,3,142,1,68,14,80,68,13,11
.section __TEXT, __const
	.align 3
class_info_offsets:

	.long 3,10,1,2
	.short 0
	.byte 132,139,7,23

.text
	.align 4
plt:
_mono_aot_System_Core_plt:
	.no_dead_strip plt__jit_icall_mono_helper_ldstr
plt__jit_icall_mono_helper_ldstr:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 32,59
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 36,79
	.no_dead_strip plt_System_Linq_Check_Source_object
plt_System_Linq_Check_Source_object:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 40,107
	.no_dead_strip plt__rgctx_fetch_0
plt__rgctx_fetch_0:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 44,142
	.no_dead_strip plt_wrapper_castclass_object___isinst_with_cache_object_intptr_intptr
plt_wrapper_castclass_object___isinst_with_cache_object_intptr_intptr:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 48,149
	.no_dead_strip plt__rgctx_fetch_1
plt__rgctx_fetch_1:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 52,157
	.no_dead_strip plt__rgctx_fetch_2
plt__rgctx_fetch_2:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 56,185
	.no_dead_strip plt__rgctx_fetch_3
plt__rgctx_fetch_3:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 60,192
	.no_dead_strip plt__rgctx_fetch_4
plt__rgctx_fetch_4:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 64,220
	.no_dead_strip plt__rgctx_fetch_5
plt__rgctx_fetch_5:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 68,248
	.no_dead_strip plt_System_Linq_Enumerable_EmptySequence
plt_System_Linq_Enumerable_EmptySequence:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 72,269
	.no_dead_strip plt__jit_icall_mono_object_new_fast
plt__jit_icall_mono_object_new_fast:
_p_12:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 76,271
	.no_dead_strip plt_System_InvalidOperationException__ctor_string
plt_System_InvalidOperationException__ctor_string:
_p_13:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 80,294
	.no_dead_strip plt__rgctx_fetch_6
plt__rgctx_fetch_6:
_p_14:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 84,315
	.no_dead_strip plt__rgctx_fetch_7
plt__rgctx_fetch_7:
_p_15:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 88,367
	.no_dead_strip plt__rgctx_fetch_8
plt__rgctx_fetch_8:
_p_16:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 92,375
	.no_dead_strip plt__rgctx_fetch_9
plt__rgctx_fetch_9:
_p_17:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 96,397
	.no_dead_strip plt__rgctx_fetch_10
plt__rgctx_fetch_10:
_p_18:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 100,431
	.no_dead_strip plt__rgctx_fetch_11
plt__rgctx_fetch_11:
_p_19:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 104,439
	.no_dead_strip plt__rgctx_fetch_12
plt__rgctx_fetch_12:
_p_20:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 108,461
	.no_dead_strip plt__rgctx_fetch_13
plt__rgctx_fetch_13:
_p_21:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 112,498
	.no_dead_strip plt__rgctx_fetch_14
plt__rgctx_fetch_14:
_p_22:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 116,520
	.no_dead_strip plt__rgctx_fetch_15
plt__rgctx_fetch_15:
_p_23:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 120,560
	.no_dead_strip plt__rgctx_fetch_16
plt__rgctx_fetch_16:
_p_24:

	.byte 0,192,159,229,12,240,159,231
	.long _mono_aot_System_Core_got - . + 124,582
plt_end:
.section __TEXT, __const
	.align 3
image_table:

	.long 2
	.asciz "System.Core"
	.asciz "8A0E153A-00B0-4F8A-8E69-25BEE76C4B3F"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
	.asciz "mscorlib"
	.asciz "6B3E8066-599B-4D3F-90DF-C69F0383CE36"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
.data
	.align 3
_mono_aot_System_Core_got:
	.space 132
got_end:
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "8A0E153A-00B0-4F8A-8E69-25BEE76C4B3F"
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "System.Core"
.data
	.align 3
_mono_aot_file_info:

	.long 100,0
	.align 2
	.long _mono_aot_System_Core_got
	.align 2
	.long methods
	.align 2
	.long 0
	.align 2
	.long blob
	.align 2
	.long class_name_table
	.align 2
	.long class_info_offsets
	.align 2
	.long method_info_offsets
	.align 2
	.long ex_info_offsets
	.align 2
	.long code_offsets
	.align 2
	.long method_addresses
	.align 2
	.long extra_method_info_offsets
	.align 2
	.long extra_method_table
	.align 2
	.long got_info_offsets
	.align 2
	.long methods_end
	.align 2
	.long unwind_info
	.align 2
	.long mem_end
	.align 2
	.long image_table
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end

	.long 8,132,25,5,10,387000831,0,1216
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,128,4,4,14
	.long 0,0,0,0,0
	.globl _mono_aot_module_System_Core_info
	.align 2
_mono_aot_module_System_Core_info:
	.align 2
	.long _mono_aot_file_info
.section __TEXT, __const
	.align 3
blob:

	.byte 0,0,0,0,2,4,5,0,2,6,7,0,2,4,5,5,30,0,0,1,255,253,0,0,0,1,3,0,198,0,0,2
	.byte 0,1,7,15,12,0,39,42,47,6,193,0,0,222,6,193,0,6,28,17,0,15,14,2,129,115,1,7,17,109,111,110
	.byte 111,95,104,101,108,112,101,114,95,108,100,115,116,114,0,7,25,109,111,110,111,95,97,114,99,104,95,116,104,114,111,119
	.byte 95,101,120,99,101,112,116,105,111,110,0,3,1,5,30,0,1,255,255,255,255,255,2,255,253,0,0,0,1,3,0,198
	.byte 0,0,2,0,1,7,109,4,2,36,1,1,7,109,35,119,150,25,7,128,135,3,255,252,0,0,0,19,10,35,119,140
	.byte 11,255,253,0,0,0,7,128,135,1,198,0,0,148,1,7,109,0,4,2,42,1,1,7,109,35,119,150,25,7,128,178
	.byte 35,119,140,11,255,253,0,0,0,7,128,178,1,198,0,0,164,1,7,109,0,4,2,39,1,1,7,109,35,119,140,11
	.byte 255,253,0,0,0,7,128,213,1,198,0,0,157,1,7,109,0,4,2,40,1,1,7,109,35,119,140,11,255,253,0,0
	.byte 0,7,128,241,1,198,0,0,158,1,7,109,0,3,3,7,20,109,111,110,111,95,111,98,106,101,99,116,95,110,101,119
	.byte 95,102,97,115,116,0,3,193,0,6,89,255,253,0,0,0,1,3,0,198,0,0,2,0,1,7,15,35,129,43,192,0
	.byte 92,41,255,253,0,0,0,1,3,0,198,0,0,2,0,1,7,15,7,14,7,15,23,7,15,22,7,15,21,7,15,21
	.byte 7,15,21,7,15,21,7,15,4,2,36,1,1,7,15,35,129,43,150,25,7,129,104,35,129,43,140,11,255,253,0,0
	.byte 0,7,129,104,1,198,0,0,148,1,7,15,0,35,129,43,192,0,90,35,32,0,8,255,253,0,0,0,7,129,104,1
	.byte 198,0,0,148,1,7,15,0,4,2,42,1,1,7,15,35,129,43,150,25,7,129,168,35,129,43,140,11,255,253,0,0
	.byte 0,7,129,168,1,198,0,0,164,1,7,15,0,35,129,43,192,0,90,35,32,1,30,7,15,8,255,253,0,0,0,7
	.byte 129,168,1,198,0,0,164,1,7,15,0,4,2,39,1,1,7,15,35,129,43,140,11,255,253,0,0,0,7,129,235,1
	.byte 198,0,0,157,1,7,15,0,35,129,43,192,0,90,35,32,0,21,2,40,1,1,7,15,255,253,0,0,0,7,129,235
	.byte 1,198,0,0,157,1,7,15,0,4,2,40,1,1,7,15,35,129,43,140,11,255,253,0,0,0,7,130,41,1,198,0
	.byte 0,158,1,7,15,0,35,129,43,192,0,90,35,32,0,30,7,15,255,253,0,0,0,7,130,41,1,198,0,0,158,1
	.byte 7,15,0,2,0,36,32,24,88,208,0,0,13,0,0,11,1,24,0,4,5,16,0,16,0,4,0,4,5,4,0,8
	.byte 5,4,0,4,2,255,255,255,255,200,7,19,1,2,28,129,252,129,60,129,184,129,188,0,1,11,16,16,255,253,0,0
	.byte 0,1,3,0,198,0,0,2,0,1,7,109,0,128,203,130,24,40,130,44,208,0,0,11,32,208,0,0,11,0,6,208
	.byte 0,0,11,4,5,208,0,0,11,8,10,208,0,0,11,12,0,80,1,40,6,8,0,4,0,4,0,8,7,8,0,4
	.byte 6,8,0,4,0,12,0,4,0,4,5,12,0,4,12,8,0,4,0,4,0,8,0,4,7,4,0,4,7,8,0,4
	.byte 0,4,0,4,0,4,0,4,6,12,1,12,0,4,0,8,0,4,0,4,0,4,5,12,1,8,2,8,10,4,2,8
	.byte 0,4,0,12,0,4,0,4,7,16,7,16,0,4,0,8,0,4,0,4,0,4,0,12,7,4,3,8,4,8,0,4
	.byte 0,4,0,16,0,12,5,4,0,4,5,4,0,4,7,12,0,4,7,8,0,4,0,4,0,16,5,12,2,12,0,4
	.byte 6,4,0,4,1,4,5,4,0,4,255,255,255,255,137,12,5,4,0,4,115,255,255,255,255,236,2,0,17,72,16,84
	.byte 0,6,0,16,10,20,0,16,0,8,0,4,6,8,7,49,1,2,28,130,204,129,240,130,136,130,140,0,1,11,16,16
	.byte 255,253,0,0,0,1,3,0,198,0,0,2,0,1,7,15,1,0,1,1,128,213,130,252,36,131,16,6,208,0,0,11
	.byte 4,10,208,0,0,11,8,255,80,0,0,3,255,80,0,0,4,255,80,0,0,5,208,0,0,11,12,1,5,4,82,0
	.byte 36,0,4,0,4,0,4,1,92,0,4,6,8,0,4,0,4,0,4,0,4,7,8,0,4,6,8,0,12,0,4,0
	.byte 12,0,4,5,4,0,4,12,8,0,4,0,4,0,4,0,4,0,4,7,4,0,4,7,8,0,12,0,4,0,8,0
	.byte 4,0,4,6,4,1,12,0,12,0,4,0,20,0,4,0,4,5,28,1,8,14,56,0,12,0,4,0,8,0,4,0
	.byte 4,7,8,7,16,0,12,0,4,0,20,0,4,10,36,4,8,0,4,0,4,0,16,0,12,5,4,0,4,5,4,0
	.byte 4,7,12,0,4,7,8,0,4,0,4,0,16,5,12,2,12,0,4,6,28,1,4,5,4,0,4,255,255,255,255,137
	.byte 12,5,4,0,4,115,255,255,255,255,236,0,128,144,8,0,0,1,4,128,144,8,0,0,1,193,0,7,49,193,0,7
	.byte 46,193,0,7,45,193,0,7,43,4,128,144,8,0,0,1,193,0,7,49,193,0,7,46,193,0,7,45,193,0,7,43
	.byte 98,111,101,104,109,0
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash

	.long 0,0
.section __DWARF, __debug_info,regular,debug
LTDIE_0:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM5
	.byte 2
	.asciz "System.Linq.Check:Source"
	.long _System_Linq_Check_Source_object
	.long Lme_0

	.byte 2,118,16,3
	.asciz "source"

LDIFF_SYM6=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM7=Lfde0_end - Lfde0_start
	.long LDIFF_SYM7
Lfde0_start:

	.long 0
	.align 2
	.long _System_Linq_Check_Source_object

LDIFF_SYM8=Lme_0 - _System_Linq_Check_Source_object
	.long LDIFF_SYM8
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,24
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_1:

	.byte 17
	.asciz "System_Collections_Generic_IEnumerable`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEnumerable`1"

LDIFF_SYM9=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM10=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM10
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM11=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM11
LTDIE_2:

	.byte 17
	.asciz "System_Collections_Generic_ICollection`1"

	.byte 8,7
	.asciz "System_Collections_Generic_ICollection`1"

LDIFF_SYM12=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM12
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM13=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM13
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM14=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_3:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM15=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM15
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM16=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM16
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM17=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM17
LTDIE_5:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM18=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM18
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM19=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM20=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM20
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM21=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM21
LTDIE_4:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM22=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM23=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM24=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM24
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM25=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM25
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM26=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM26
LTDIE_6:

	.byte 17
	.asciz "System_Collections_Generic_IEnumerator`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEnumerator`1"

LDIFF_SYM27=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM27
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM28=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM29=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM29
	.byte 2
	.asciz "System.Linq.Enumerable:Last<TSource>"
	.long _System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource
	.long Lme_1

	.byte 2,118,16,3
	.asciz "source"

LDIFF_SYM30=LTDIE_1_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 2,123,32,11
	.asciz "collection"

LDIFF_SYM31=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 2,123,0,11
	.asciz "list"

LDIFF_SYM32=LTDIE_3_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM32
	.byte 1,86,11
	.asciz "empty"

LDIFF_SYM33=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM33
	.byte 2,123,4,11
	.asciz "item"

LDIFF_SYM34=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM34
	.byte 1,85,11
	.asciz ""

LDIFF_SYM35=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM35
	.byte 2,123,8,11
	.asciz "element"

LDIFF_SYM36=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM36
	.byte 1,90,11
	.asciz ""

LDIFF_SYM37=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2,123,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM38=Lfde1_end - Lfde1_start
	.long LDIFF_SYM38
Lfde1_start:

	.long 0
	.align 2
	.long _System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource

LDIFF_SYM39=Lme_1 - _System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource
	.long LDIFF_SYM39
	.byte 12,13,0,72,14,8,135,2,68,14,28,133,7,134,6,136,5,138,4,139,3,142,1,68,14,80,68,13,11
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "System.Linq.Enumerable:EmptySequence"
	.long _System_Linq_Enumerable_EmptySequence
	.long Lme_2

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM40=Lfde2_end - Lfde2_start
	.long LDIFF_SYM40
Lfde2_start:

	.long 0
	.align 2
	.long _System_Linq_Enumerable_EmptySequence

LDIFF_SYM41=Lme_2 - _System_Linq_Enumerable_EmptySequence
	.long LDIFF_SYM41
	.byte 12,13,0,72,14,8,135,2,68,14,12,136,3,142,1,68,14,24
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_7:

	.byte 17
	.asciz "System_Collections_Generic_IEnumerable`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEnumerable`1"

LDIFF_SYM42=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM42
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM43=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM43
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM44=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM44
LTDIE_8:

	.byte 17
	.asciz "System_Collections_Generic_ICollection`1"

	.byte 8,7
	.asciz "System_Collections_Generic_ICollection`1"

LDIFF_SYM45=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM45
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM46=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM46
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM47=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM47
LTDIE_9:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM48=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM48
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM49=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM49
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM50=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM50
LTDIE_10:

	.byte 17
	.asciz "System_Collections_Generic_IEnumerator`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEnumerator`1"

LDIFF_SYM51=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM51
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM52=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM52
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM53=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 2
	.asciz "System.Linq.Enumerable:Last<!!0>"
	.long _System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0
	.long Lme_4

	.byte 2,118,16,3
	.asciz "source"

LDIFF_SYM54=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM54
	.byte 1,86,11
	.asciz "collection"

LDIFF_SYM55=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM55
	.byte 2,123,4,11
	.asciz "list"

LDIFF_SYM56=LTDIE_9_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 1,90,11
	.asciz "empty"

LDIFF_SYM57=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM57
	.byte 2,123,8,11
	.asciz "item"

LDIFF_SYM58=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM58
	.byte 1,80,11
	.asciz ""

LDIFF_SYM59=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 1,80,11
	.asciz "element"

LDIFF_SYM60=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM60
	.byte 1,80,11
	.asciz ""

LDIFF_SYM61=LTDIE_10_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM61
	.byte 2,123,12,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM62=Lfde3_end - Lfde3_start
	.long LDIFF_SYM62
Lfde3_start:

	.long 0
	.align 2
	.long _System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0

LDIFF_SYM63=Lme_4 - _System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0
	.long LDIFF_SYM63
	.byte 12,13,0,72,14,8,135,2,68,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,80,68,13,11
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:

	.long Ldebug_line_end - . -4
	.short 2
	.long Ldebug_line_header_end - . -4
	.byte 1,1,251,14,13,0,1,1,1,1,0,0,0,1,0,0,1
.section __DWARF, __debug_line,regular,debug
	.asciz "///Library/Frameworks/Xamarin.iOS.framework/Versions/7.4.0.108/src/mono/mcs/class/System.Core/System.Linq"

	.byte 0
	.asciz "<unknown>"

	.byte 0,0,0
	.asciz "Check.cs"

	.byte 1,0,0
	.asciz "Enumerable.cs"

	.byte 1,0,0,0
Ldebug_line_header_end:
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _System_Linq_Check_Source_object

	.byte 3,36,4,2,1,3,36,2,24,1,131,2,56,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _System_Linq_Enumerable_Last_TSource_System_Collections_Generic_IEnumerable_1_TSource

	.byte 3,187,9,4,3,1,3,187,9,2,40,1,132,8,117,3,3,2,60,1,8,117,187,3,5,2,216,0,1,131,188,3
	.byte 1,2,224,0,1,131,3,3,2,132,1,1,131,132,3,108,2,20,1,2,8,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _System_Linq_Enumerable_EmptySequence

	.byte 3,236,24,4,3,1,3,236,24,2,16,1,2,196,0,1,0,1,1
.section __DWARF, __debug_line,regular,debug

	.byte 0,5,2
	.long _System_Linq_Enumerable_Last___0_System_Collections_Generic_IEnumerable_1___0

	.byte 3,187,9,4,3,1,3,187,9,2,36,1,3,2,2,244,0,1,8,117,3,3,2,60,1,8,117,187,3,5,2,128
	.byte 1,1,3,3,2,56,1,3,2,2,132,1,1,3,3,2,132,1,1,8,229,76,3,108,2,20,1,2,8,1,0,1
	.byte 1,0,1,1
Ldebug_line_end:
.text
	.align 3
mem_end:
