﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace ConnectedWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial catalog=SampleDatabase;Integrated Security=True;Connect Timeout=30";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFilename=C:\Users\zaaza\source\repos\CS2_20220222\ConnectedWPF\bin\Debug\SampleDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            connection =new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT ID,FIO, Birthday, Email, Phone From People", connection);
            adapter.SelectCommand = command;
            //Insert
            command = new SqlCommand(@"INSERT INTO People (FIO, Birthday, Email, Phone) Values (@FIO, @Birthday, @Email, @Phone); SET @ID=@@IDENTITY;", connection);
            command.Parameters.Add("@FIO", SqlDbType.NVarChar, -1, "FIO");
            command.Parameters.Add("@Birthday", SqlDbType.NVarChar, -1, "Birthday");
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
            command.Parameters.Add("@Phone", SqlDbType.NVarChar, -1, "Phone");
            SqlParameter param = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            param.Direction = ParameterDirection.Output;
            adapter.InsertCommand = command;
            // update
            command = new SqlCommand(@"UPDATE People SET FIO = @FIO, Birthday = @Birthday, Email = @Email, Phone = @Phone WHERE ID = @ID", connection);
            command.Parameters.Add("@FIO", SqlDbType.NVarChar, -1, "FIO");
            command.Parameters.Add("@Birthday", SqlDbType.NVarChar, -1, "Birthday");
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100, "Email");
            command.Parameters.Add("@Phone", SqlDbType.NVarChar, -1, "Phone");
            param = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            param.SourceVersion = DataRowVersion.Original;
            adapter.UpdateCommand = command;
            //delete
            command = new SqlCommand("DELETE FROM People WHERE ID = @ID", connection);
            param = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            param.SourceVersion = DataRowVersion.Original;
            adapter.DeleteCommand = command;
            dt = new DataTable();
            adapter.Fill(dt);
            peopleDataGrid.DataContext = dt.DefaultView;

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // добавим новую строку
            DataRow newRow = dt.NewRow();
            EditWindow editWindow = new EditWindow(newRow);
            editWindow.ShowDialog();
            if (editWindow.DialogResult.HasValue && editWindow.DialogResult.Value)
            {
                dt.Rows.Add(editWindow.resultRow);
                adapter.Update(dt);
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView newRow = (DataRowView)peopleDataGrid.SelectedItem;
            newRow.BeginEdit();
            EditWindow editWindow = new EditWindow(newRow.Row);
            editWindow.ShowDialog();
            if (editWindow.DialogResult.HasValue && editWindow.DialogResult.Value)
            {
                newRow.EndEdit();
                adapter.Update(dt);
            }
            else
            {
                newRow.CancelEdit();
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView newRow = (DataRowView)peopleDataGrid.SelectedItem;

            newRow.Row.Delete();
            adapter.Update(dt);
        }
    }
}
