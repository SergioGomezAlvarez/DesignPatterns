using System;
using System.Collections.Generic;
using CommandPattern.Interfaces;

namespace CommandPattern.Classes
{
    internal class UndoHistory
    {
        private static readonly Lazy<UndoHistory> _instance = new(() => new UndoHistory());
        public static UndoHistory Instance => _instance.Value;

        private readonly Stack<Command> _stack = new();

        private UndoHistory() { }

        public void Push(Command command)
        {
            if (command == null) return;
            _stack.Push(command);
        }

        public void UndoLast()
        {
            if (_stack.Count == 0)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            var cmd = _stack.Pop();
            cmd.Undo();
        }

        public void Clear() => _stack.Clear();

        public int Count => _stack.Count;
    }
}