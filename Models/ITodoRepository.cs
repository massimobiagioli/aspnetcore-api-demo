﻿using System.Collections.Generic;

namespace apidemo.Models
{
	public interface ITodoRepository
	{
		void Add(TodoItem item);
		IEnumerable<TodoItem> GetAll();
		TodoItem Find(long key);
		void Remove(long key);
		void Update(TodoItem item);
	}
}