using System;

namespace ShowTableConsole
{
    internal class ConsoleTable
    {
        private string[] columnNames;

        public ConsoleTable(string[] columnNames)
        {
            this.columnNames = columnNames;
        }

        internal void AddRow(object[] itemArray)
        {
            throw new NotImplementedException();
        }

        internal void Write(object alternative)
        {
            throw new NotImplementedException();
        }

        internal void Write(object minimal)
        {
            throw new NotImplementedException();
        }

        internal void Write(object markDown)
        {
            throw new NotImplementedException();
        }
    }
}