﻿using System;

namespace Beast
{
	/// <summary>
	/// Represents game related time information.
	/// </summary>
	public sealed class GameTime
	{
		private TimeSpan _lastTick = TimeSpan.Zero;

		/// <summary>
		/// Gets the current total game time.
		/// </summary>
		public TimeSpan TotalGameTime { get; private set; }

		/// <summary>
		/// Gets the time that has elapsed since the last game update.
		/// </summary>
		public TimeSpan ElapsedGameTime { get; private set; }

		/// <summary>
		/// Gets the UTC date/time for the current timestamp.
		/// </summary>
		public DateTime CurrentDate { get; private set; }

		public GameTime()
		{
			TotalGameTime = TimeSpan.Zero;
			ElapsedGameTime = TimeSpan.Zero;
			CurrentDate = DateTime.UtcNow;
		}

		public void Update(TimeSpan totalGameTime)
		{
			CurrentDate = DateTime.UtcNow;
			TotalGameTime = totalGameTime;
			ElapsedGameTime = totalGameTime - _lastTick;
			_lastTick = totalGameTime;
		}
	}
}