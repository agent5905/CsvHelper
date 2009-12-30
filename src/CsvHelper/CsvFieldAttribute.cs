﻿using System;
using System.Diagnostics;

namespace CsvHelper
{
	[DebuggerDisplay( "FieldIndex = {FieldIndex}, FieldName = {FieldName}, Ignore = {Ignore}" )]
	[AttributeUsage( AttributeTargets.Property )]
	public class CsvFieldAttribute : Attribute
	{
		/// <summary>
		/// When reading, is used to get the field
		/// at the index of the name if there was a
		/// header specified. When writing, sets
		/// the name of the field in the header record.
		/// </summary>
		public string FieldName { get; set; }

		/// <summary>
		/// When reading, is used to get the field at
		/// the given index. When writing, the fields
		/// will be written in the order of the field
		/// indexes.
		/// </summary>
		public int FieldIndex { get; set; }

		/// <summary>
		/// When reading, not used. When writing,
		/// ignores the property and doesn't
		/// write it to the CSV file.
		/// </summary>
		public bool Ignore { get; set; }
	}
}