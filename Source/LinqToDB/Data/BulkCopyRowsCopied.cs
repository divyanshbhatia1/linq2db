﻿using System;

namespace LinqToDB_2_9_6.Data
{
	public class BulkCopyRowsCopied
	{
		/// <summary>
		/// Gets or sets a value that indicates whether the bulk copy operation should be aborted.
		/// </summary>
		public bool Abort { get; set; }

		/// <summary>
		/// Gets a value that returns the number of rows copied during the current bulk copy operation.
		/// </summary>
		public long RowsCopied { get; set; }

		/// <summary>
		/// Gets operation execution start time.
		/// </summary>
		public DateTime StartTime { get; } = DateTime.Now;
	}
}
