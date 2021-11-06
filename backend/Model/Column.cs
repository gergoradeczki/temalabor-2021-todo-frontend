﻿namespace temalabor_2021_todo_backend.Model
{
    public class Column
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public ICollection<Todo>? Todos { get; set; }
    }

    public class ColumnDTO
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }

    public class ColumnDetailsDTO
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public IEnumerable<TodoDTO>? Todos { get; set; }
    }
}
