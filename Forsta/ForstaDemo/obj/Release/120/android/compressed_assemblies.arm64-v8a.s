	.file	"obj\Release\120\android\compressed_assemblies.arm64-v8a.s"
	.arch	armv8-a
	.include	"compressed_assemblies.arm64-v8a-data.inc"

	.section	.data, "aw", @progbits

	.type	.L.compressed_assembly_descriptors.0, @object

	.section	.data, "aw", @progbits
	.p2align	3
.L.compressed_assembly_descriptors.0:
	.word	0x38600	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.0	// data

	.word	0x1fe00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.1	// data

	.word	0x23800	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.2	// data

	.word	0x28600	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.3	// data

	.word	0x1ae600	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.4	// data

	.word	0x1ac00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.5	// data

	.word	0x17de00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.6	// data

	.word	0xda00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.7	// data

	.word	0x33e00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.8	// data

	.word	0x6400	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.9	// data

	.word	0x5e400	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.10	// data

	.word	0x1800	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.11	// data

	.word	0x4da00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.12	// data

	.word	0x22c00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.13	// data

	.word	0x2200	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.14	// data

	.word	0xa000	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.15	// data

	.word	0x27600	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.16	// data

	.word	0x3a00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.17	// data

	.word	0x3e00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.18	// data

	.word	0x4000	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.19	// data

	.word	0x8e00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.20	// data

	.word	0x3200	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.21	// data

	.word	0x7000	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.22	// data

	.word	0x6600	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.23	// data

	.word	0x4698	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.24	// data

	.word	0x24dc0	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.25	// data

	.word	0x3b90	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.26	// data

	.word	0x2197a0	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.27	// data

	.word	0x1c9a00	// uncompressed_file_size
	.byte	0x0	// loaded
	.zero	3
	.xword	.L.compressed_assembly_data.28	// data

	.size	.L.compressed_assembly_descriptors.0, 464

	.section	.data, "aw", @progbits

	//
	// Generated from instance of: Xamarin.Android.Tasks.CompressedAssembliesNativeAssemblyGenerator+CompressedAssemblies, Xamarin.Android.Build.Tasks, Version=12.3.0.26, Culture=neutral, PublicKeyToken=84e04ff9cfb79065
	//
	.type	compressed_assemblies, @object
	.global	compressed_assemblies

	.section	.data, "aw", @progbits
	.p2align	3
compressed_assemblies:
	.word	0x1d	// count
	.zero	4
	.xword	.L.compressed_assembly_descriptors.0	// descriptors
	.size	compressed_assemblies, 16

	.ident	"Xamarin.Android remotes/origin/d17-2 @ bbba5a21f3b649a761b22d83959758b4d30df672"
