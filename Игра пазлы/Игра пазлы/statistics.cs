using BD;
using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Игра_пазлы
{
    internal class statistics
    {
        private DataGridView _dataGridView;
        public DataGridView dataGridView 
        { 
            get 
            { 
                DataGridView Return = _dataGridView; 
                return Return; 
            } 
            private set { } 
        }
        public statistics(string PuzzleNmae) 
        {
            _dataGridView = new DataGridView();
            _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //создаём столбцы
            _dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Имя" });
            _dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Фамилия" });
            _dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Тип игры" });
            _dataGridView.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Время" });

            bd BD = new bd();
            BD.openconected();
            // Создание команды для выборки данных
            string sql = "SELECT * FROM leaders";
            using (SqlCommand command = new SqlCommand(sql, BD.getbd()))
            {
                // Выполнение команды и получение результата в виде объекта DataReader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Определение количества столбцов в таблице
                    int columnCount = reader.FieldCount;

                    // Чтение данных из DataReader с помощью цикла for
                    while (reader.Read())
                    {
                        // Создание массива для хранения значений столбцов
                        object[] values = new object[columnCount];

                        // Заполнение массива значениями столбцов
                        reader.GetValues(values);
                        
                        if (PuzzleNmae == values[0].ToString())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = values[3] });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = values[4] });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = values[1] });
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = values[5] });
                            _dataGridView.Rows.Add(row);
                        }
                    }
                }
            }
            BD.Closeconected();
            Console.ReadLine();
        }
    }
}
