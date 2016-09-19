using System;

namespace CodeLou.CSharp.Week3.Challenge
{
	public abstract class CalendarItemBase
	{
		public int Id { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
	}
}
