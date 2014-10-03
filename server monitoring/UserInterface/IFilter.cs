﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryPerformanceMonitoring
{
	public interface IFilter<T>
	{
		IList<T> Filter(IList<T> c);
	}
}