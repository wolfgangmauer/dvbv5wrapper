using System;
using System.Runtime.InteropServices;

namespace dvbv5
{
	public enum dvb_dev_change_type {
		DVB_DEV_ADD,
		DVB_DEV_CHANGE,
		DVB_DEV_REMOVE,
	}

	public enum dvb_dev_type 
	{
		DVB_DEVICE_FRONTEND,
		DVB_DEVICE_DEMUX,
		DVB_DEVICE_DVR,
		DVB_DEVICE_NET,
		DVB_DEVICE_CA,
		DVB_DEVICE_CA_SEC,
	}

	public enum fe_delivery_system 
	{
		SYS_UNDEFINED,
		SYS_DVBC_ANNEX_A,
		SYS_DVBC_ANNEX_B,
		SYS_DVBT,
		SYS_DSS,
		SYS_DVBS,
		SYS_DVBS2,
		SYS_DVBH,
		SYS_ISDBT,
		SYS_ISDBS,
		SYS_ISDBC,
		SYS_ATSC,
		SYS_ATSCMH,
		SYS_DTMB,
		SYS_CMMB,
		SYS_DAB,
		SYS_DVBT2,
		SYS_TURBO,
		SYS_DVBC_ANNEX_C,
	}

	public enum dmx_pes_type
	{
		DMX_PES_AUDIO0,
		DMX_PES_VIDEO0,
		DMX_PES_TELETEXT0,
		DMX_PES_SUBTITLE0,
		DMX_PES_PCR0,

		DMX_PES_AUDIO1,
		DMX_PES_VIDEO1,
		DMX_PES_TELETEXT1,
		DMX_PES_SUBTITLE1,
		DMX_PES_PCR1,

		DMX_PES_AUDIO2,
		DMX_PES_VIDEO2,
		DMX_PES_TELETEXT2,
		DMX_PES_SUBTITLE2,
		DMX_PES_PCR2,

		DMX_PES_AUDIO3,
		DMX_PES_VIDEO3,
		DMX_PES_TELETEXT3,
		DMX_PES_SUBTITLE3,
		DMX_PES_PCR3,

		DMX_PES_OTHER
	}

	public enum dmx_output
	{
		DMX_OUT_DECODER, /* Streaming directly to decoder. */
		DMX_OUT_TAP,     /* Output going to a memory buffer */
		/* (to be retrieved via the read command).*/
		DMX_OUT_TS_TAP,  /* Output multiplexed into a new TS  */
		/* (to be retrieved by reading from the */
		/* logical DVR device).                 */
		DMX_OUT_TSDEMUX_TAP /* Like TS_TAP but retrieved from the DMX device */
	}

	public enum descriptors {
		/* ISO/IEC 13818-1 */
		video_stream_descriptor				= 0x02,
		audio_stream_descriptor				= 0x03,
		hierarchy_descriptor				= 0x04,
		registration_descriptor				= 0x05,
		ds_alignment_descriptor				= 0x06,
		target_background_grid_descriptor		= 0x07,
		video_window_descriptor				= 0x08,
		conditional_access_descriptor			= 0x09,
		iso639_language_descriptor			= 0x0a,
		system_clock_descriptor				= 0x0b,
		multiplex_buffer_utilization_descriptor		= 0x0c,
		copyright_descriptor				= 0x0d,
		maximum_bitrate_descriptor			= 0x0e,
		private_data_indicator_descriptor		= 0x0f,
		smoothing_buffer_descriptor			= 0x10,
		std_descriptor					= 0x11,
		ibp_descriptor					= 0x12,

		mpeg4_video_descriptor				= 0x1b,
		mpeg4_audio_descriptor				= 0x1c,
		iod_descriptor					= 0x1d,
		sl_descriptor					= 0x1e,
		fmc_descriptor					= 0x1f,
		external_es_id_descriptor			= 0x20,
		muxcode_descriptor				= 0x21,
		fmxbuffersize_descriptor			= 0x22,
		multiplexbuffer_descriptor			= 0x23,
		content_labeling_descriptor			= 0x24,
		metadata_pointer_descriptor			= 0x25,
		metadata_descriptor				= 0x26,
		metadata_std_descriptor				= 0x27,
		AVC_video_descriptor				= 0x28,
		ipmp_descriptor					= 0x29,
		AVC_timing_and_HRD_descriptor			= 0x2a,
		mpeg2_aac_audio_descriptor			= 0x2b,
		flexmux_timing_descriptor			= 0x2c,

		/* ETSI EN 300 468 V1.11.1 (2010-04) */

		network_name_descriptor				= 0x40,
		service_list_descriptor				= 0x41,
		stuffing_descriptor				= 0x42,
		satellite_delivery_system_descriptor		= 0x43,
		cable_delivery_system_descriptor		= 0x44,
		VBI_data_descriptor				= 0x45,
		VBI_teletext_descriptor				= 0x46,
		bouquet_name_descriptor				= 0x47,
		service_descriptor				= 0x48,
		country_availability_descriptor			= 0x49,
		linkage_descriptor				= 0x4a,
		NVOD_reference_descriptor			= 0x4b,
		time_shifted_service_descriptor			= 0x4c,
		short_event_descriptor				= 0x4d,
		extended_event_descriptor			= 0x4e,
		time_shifted_event_descriptor			= 0x4f,
		component_descriptor				= 0x50,
		mosaic_descriptor				= 0x51,
		stream_identifier_descriptor			= 0x52,
		CA_identifier_descriptor			= 0x53,
		content_descriptor				= 0x54,
		parental_rating_descriptor			= 0x55,
		teletext_descriptor				= 0x56,
		telephone_descriptor				= 0x57,
		local_time_offset_descriptor			= 0x58,
		subtitling_descriptor				= 0x59,
		terrestrial_delivery_system_descriptor		= 0x5a,
		multilingual_network_name_descriptor		= 0x5b,
		multilingual_bouquet_name_descriptor		= 0x5c,
		multilingual_service_name_descriptor		= 0x5d,
		multilingual_component_descriptor		= 0x5e,
		private_data_specifier_descriptor		= 0x5f,
		service_move_descriptor				= 0x60,
		short_smoothing_buffer_descriptor		= 0x61,
		frequency_list_descriptor			= 0x62,
		partial_transport_stream_descriptor		= 0x63,
		data_broadcast_descriptor			= 0x64,
		scrambling_descriptor				= 0x65,
		data_broadcast_id_descriptor			= 0x66,
		transport_stream_descriptor			= 0x67,
		DSNG_descriptor					= 0x68,
		PDC_descriptor					= 0x69,
		AC_3_descriptor					= 0x6a,
		ancillary_data_descriptor			= 0x6b,
		cell_list_descriptor				= 0x6c,
		cell_frequency_link_descriptor			= 0x6d,
		announcement_support_descriptor			= 0x6e,
		application_signalling_descriptor		= 0x6f,
		adaptation_field_data_descriptor		= 0x70,
		service_identifier_descriptor			= 0x71,
		service_availability_descriptor			= 0x72,
		default_authority_descriptor			= 0x73,
		related_content_descriptor			= 0x74,
		TVA_id_descriptor				= 0x75,
		content_identifier_descriptor			= 0x76,
		time_slice_fec_identifier_descriptor		= 0x77,
		ECM_repetition_rate_descriptor			= 0x78,
		S2_satellite_delivery_system_descriptor		= 0x79,
		enhanced_AC_3_descriptor			= 0x7a,
		DTS_descriptor					= 0x7b,
		AAC_descriptor					= 0x7c,
		XAIT_location_descriptor			= 0x7d,
		FTA_content_management_descriptor		= 0x7e,
		extension_descriptor				= 0x7f,

		/* SCTE 35 2004 */
		CUE_identifier_descriptor			= 0x8a,

		extended_channel_name				= 0xa0,
		service_location				= 0xa1,
		/* From http://www.etherguidesystems.com/Help/SDOs/ATSC/Semantics/Descriptors/Default.aspx */
		component_name_descriptor			= 0xa3,

		/* From http://www.coolstf.com/tsreader/descriptors.html */
		logical_channel_number_descriptor		= 0x83,

		/* ISDB Descriptors, as defined on ABNT NBR 15603-1 2007 */

		carousel_id_descriptor				= 0x13,
		association_tag_descriptor			= 0x14,
		deferred_association_tags_descriptor		= 0x15,

		hierarchical_transmission_descriptor		= 0xc0,
		digital_copy_control_descriptor			= 0xc1,
		network_identifier_descriptor			= 0xc2,
		partial_transport_stream_time_descriptor	= 0xc3,
		audio_component_descriptor			= 0xc4,
		hyperlink_descriptor				= 0xc5,
		target_area_descriptor				= 0xc6,
		data_contents_descriptor			= 0xc7,
		video_decode_control_descriptor			= 0xc8,
		download_content_descriptor			= 0xc9,
		CA_EMM_TS_descriptor				= 0xca,
		CA_contract_information_descriptor		= 0xcb,
		CA_service_descriptor				= 0xcc,
		TS_Information_descriptior			= 0xcd,
		extended_broadcaster_descriptor			= 0xce,
		logo_transmission_descriptor			= 0xcf,
		basic_local_event_descriptor			= 0xd0,
		reference_descriptor				= 0xd1,
		node_relation_descriptor			= 0xd2,
		short_node_information_descriptor		= 0xd3,
		STC_reference_descriptor			= 0xd4,
		series_descriptor				= 0xd5,
		event_group_descriptor				= 0xd6,
		SI_parameter_descriptor				= 0xd7,
		broadcaster_Name_Descriptor			= 0xd8,
		component_group_descriptor			= 0xd9,
		SI_prime_TS_descriptor				= 0xda,
		board_information_descriptor			= 0xdb,
		LDT_linkage_descriptor				= 0xdc,
		connected_transmission_descriptor		= 0xdd,
		content_availability_descriptor			= 0xde,
		service_group_descriptor			= 0xe0,
		carousel_compatible_composite_descriptor	= 0xf7,
		conditional_playback_descriptor			= 0xf8,
		ISDBT_delivery_system_descriptor		= 0xfa,
		partial_reception_descriptor			= 0xfb,
		emergency_information_descriptor		= 0xfc,
		data_component_descriptor			= 0xfd,
		system_management_descriptor			= 0xfe,

		/* ATSC descriptors - ATSC A/65:2009 spec */
		atsc_stuffing_descriptor			= 0x80,
		atsc_ac3_audio_descriptor			= 0x81,
		atsc_caption_service_descriptor			= 0x86,
		atsc_content_advisory_descriptor		= 0x87,
		atsc_extended_channel_descriptor		= 0xa0,
		atsc_service_location_descriptor		= 0xa1,
		atsc_time_shifted_service_descriptor		= 0xa2,
		atsc_component_name_descriptor			= 0xa3,
		atsc_DCC_departing_request_descriptor		= 0xa8,
		atsc_DCC_arriving_request_descriptor		= 0xa9,
		atsc_redistribution_control_descriptor		= 0xaa,
		atsc_ATSC_private_information_descriptor	= 0xad,
		atsc_genre_descriptor				= 0xab,
	}

	public delegate int dvb_dev_change(string sysname, dvb_dev_change_type type);

	public static class NativeMethods
	{
		[DllImport("dvbv5")]
		public static extern IntPtr dvb_dev_alloc();

		[DllImport("dvbv5")]
		public static extern IntPtr dvb_dev_seek_by_sysname (IntPtr dvb, UInt32 adapter, UInt32 num, dvb_dev_type type);

		[DllImport("dvbv5")]
		public static extern int dvb_dev_find (IntPtr dvb, dvb_dev_change handler = null);

		[DllImport("dvbv5")]
		public static extern IntPtr dvb_dev_open(IntPtr dvb, string sysname, int flags);

		[DllImport("dvbv5")]
		public static extern void dvb_dev_close(IntPtr open_dev);

		[DllImport("dvbv5")]
		public static extern int dvb_dev_set_bufsize(IntPtr open_dev, int buffersize);

		[DllImport("dvbv5")]
		public static extern int dvb_set_sys(IntPtr param, fe_delivery_system sys);

		[DllImport("dvbv5")]
		public static extern IntPtr dvb_fe_open (int adapter, int frontend, uint verbose, uint use_legacy_call);

		[DllImport("dvbv5")]
		public static extern int dvb_fe_get_event (IntPtr param);

		[DllImport("dvbv5")]
		public static extern int dvb_fe_set_default_country (IntPtr param, string country);

		[DllImport("dvbv5")]
		public static extern int dvb_fe_set_parms (IntPtr param);

		[DllImport("dvbv5")]
		public static extern int dvb_fe_get_parms (IntPtr param);

		[DllImport("dvbv5")]
		public static extern int dvb_dev_dmx_set_pesfilter(IntPtr open_dev,	int pid, dmx_pes_type type, dmx_output output, int buffersize);

		[DllImport("dvbv5")]
		public static extern int dvb_dev_dmx_set_section_filter(IntPtr open_dev, int pid, uint filtsize, IntPtr filter, IntPtr mask, IntPtr mode, uint flags);

		[DllImport("dvbv5")]
		public static extern int dvb_dev_dmx_get_pmt_pid(IntPtr open_dev, int sid);

		[DllImport("dvbv5")]
		public static extern void dvb_dev_dmx_stop (IntPtr open_dev);

		[DllImport("dvbv5")]
		public static extern UIntPtr dvb_dev_read (IntPtr open_dev, IntPtr buf, UIntPtr count);

		[DllImport("dvbv5")]
		public static extern int dvb_poll (IntPtr param, IntPtr dvb_desc, uint seconds);

		[DllImport("dvbv5")]
		public static extern IntPtr dvb_dev_get_parms(IntPtr open_dev);

		[DllImport("dvbv5")]
		public static extern UIntPtr dvb_table_pmt_init(IntPtr param, IntPtr buf, UIntPtr buflen, ref IntPtr table);

		[DllImport("dvbv5")]
		public static extern IntPtr dvb_pmt_get_stream(IntPtr table);

		[DllImport("dvbv5")]
		public static extern int dvb_pmt_get_elementary_pid (IntPtr stream);

		[DllImport("dvbv5")]
		public static extern IntPtr dvb_pmt_get_desc(IntPtr stream);

		[DllImport("dvbv5")]
		public static extern descriptors dvb_desc_get_type(IntPtr descriptor);

		[DllImport("dvbv5")]
		public static extern void dvb_table_pmt_free(IntPtr table);

		[DllImport("dvbv5")]
		public static extern UIntPtr dvb_table_sdt_init (IntPtr param, IntPtr buf, UIntPtr buflen, ref IntPtr table);

		[DllImport("dvbv5")]
		public static extern void dvb_table_sdt_free(IntPtr table);
	}
}

