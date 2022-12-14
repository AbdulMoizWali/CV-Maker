using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
{
	public static class SQLConnect
	{
		
		public static SqlConnection sqlConnection
		{
			get;
			private set;
		}

		#region SQL

		#region SQL Connection
		public static async void SqlConnect(Action onConnectionEstablished, Action onConnectionNotEstablished = null)
		{
			if (onConnectionNotEstablished is null)
			{
				onConnectionNotEstablished = DefaultErrorOnConnection;
			}

			sqlConnection = new SqlConnection();
			sqlConnection.ConnectionString = SQLConnectionString.SQL_CONNECTION_STRING;
			sqlConnection.Open();

			while (sqlConnection.State == ConnectionState.Connecting || sqlConnection.State == ConnectionState.Executing)
			{
				await Task.Yield();
			}

			if (sqlConnection.State == ConnectionState.Open)
			{
				onConnectionEstablished.Invoke();
			}
			else if (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken)
			{
				onConnectionNotEstablished.Invoke();
			}

			sqlConnection.Close();

		}


		public static void DefaultErrorOnConnection()
		{
			MessageBox.Show("Database not Connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		#endregion

		#region SQL Command
		public static void InsertSQLCommand(string query, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			SQLCommand(query, "Inserted the record", "Enter correct data and ID cannot be duplicate", onSuccess, ParameterName, ParameterData);
		}

		public static void InsertSQLCommand(string query, bool ShowMessageBox, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			SQLCommand(query, ShowMessageBox, null, null, onSuccess, ParameterName, ParameterData);
		}


		public static void UpdateSQLCommand(string query, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			SQLCommand(query, "Updated the record", "Cannot Update the record", onSuccess, ParameterName, ParameterData);
		}

		public static void UpdateSQLCommand(string query, bool ShowMessageBox, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			SQLCommand(query, ShowMessageBox, null, null, onSuccess, ParameterName, ParameterData);
		}

		public static void RemoveSQLCommand(string query, Action onSuccess = null)
		{
			SQLCommand(query, "Removed the record", "Cannot remove the record (User Id not found)", onSuccess);
		}

		public static void RemoveSQLCommand(string query, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			SQLCommand(query, "Removed the record", "Cannot remove the record (User Id not found)", onSuccess, ParameterName, ParameterData);
		}

		public static void SQLCommand(string query, string onSuccessMessage, string onFailedMessage, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			SQLCommand(query, true, onSuccessMessage, onFailedMessage, onSuccess, ParameterName, ParameterData);
		}

		private static void SQLCommand(string query, bool showMessageBox, string onSuccessMessage = null, string onFailedMessage = null, Action onSuccess = null, string ParameterName = null, byte[] ParameterData = null)
		{
			if (query == "VALUEISEMPTY")
			{
				return;
			}
			//MessageBox.Show(query);
			SqlConnect(() =>
			{
				try
				{
					SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
					if (ParameterName != null && ParameterData != null)
					{
						sqlCommand.Parameters.Add( new SqlParameter(ParameterName, ParameterData));
					}
					if (sqlCommand.ExecuteNonQuery() != 0)
					{
						if (showMessageBox)
						{
							MessageBox.Show(onSuccessMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						onSuccess?.Invoke();
					}
					else
					{
						throw new NotImplementedException();
					}
				}
				catch// (Exception ex)
				{
					if (showMessageBox)
					{
						MessageBox.Show(onFailedMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			});
		}
		#endregion

		#endregion


		#region Queries Function

		public static string ProcedureQuery(string procedureName, bool showErrorMessage = true, params string[] Values)
		{
			string result = "";
			result = "exec " + procedureName + " ";
			if (Values.Length > 0)
			{
				if (isValuesEmpty(showErrorMessage, Values))
				{
					result = "VALUEISEMPTY";
					return result;
				}
				for (int i = 0; i < Values.Length - 1; i++)
				{
					result += "'" + Values[i] + "', ";
				}
				if (Values.Length > 0)
				{
					result += "'" + Values[Values.Length - 1] + "'";
				}
			}
			return result;
		}

		public static string ProcedureQuery(string procedureName, params string[] Values)
		{
			return ProcedureQuery(procedureName, true, Values);
		}


		public static bool isValuesEmpty(bool showErrorMessage = true, params string[] Values)
		{
			for (int i = 0; i < Values.Length; i++)
			{
				if (string.IsNullOrEmpty(Values[i]))
				{
					if (showErrorMessage)
					{
						MessageBox.Show("All fields are required", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					return true;
				}
			}
			return false;
		}


		public static bool isValuesEmpty(params string[] Values)
		{
			for (int i = 0; i < Values.Length; i++)
			{
				if (string.IsNullOrEmpty(Values[i]))
				{
					MessageBox.Show("All fields are required", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return true;
				}
			}
			return false;
		}
		#endregion

		#region Output

		public static bool SearchinTable(string query, string column_name, TextBox textBoxes_Input)
		{
			List<string> fetched_data = new List<string>(); 
			SqlConnect(() =>
			{
				try
				{
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
					DataTable dataTable = new DataTable();
					sqlDataAdapter.Fill(dataTable);
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						fetched_data.Add(dataTable.Rows[i][column_name].ToString());
					}
				}
				catch
				{
					MessageBox.Show("Nothing There!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});

			if(fetched_data.Count > 0)
			{
				return fetched_data.Contains(textBoxes_Input.Text);
			}
			else
			{
				return false;
			}
		}

		public static void GetDataTableFromTable(string query, Action<DataTable> onSuccess, Action onFailed = null)
		{
			DataTable dataTable = new DataTable();
			SqlConnect(() =>
			{
				try
				{
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
					sqlDataAdapter.Fill(dataTable);
					onSuccess?.Invoke(dataTable);
				}
				catch
				{
					onFailed?.Invoke();
				}
			});
		}


		public static string GetValueFromTable(string query, string column_name)
		{
			string result = "";
			SqlConnect(() =>
			{
				try
				{
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
					DataTable dataTable = new DataTable();
					sqlDataAdapter.Fill(dataTable);
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						result = dataTable.Rows[i][column_name].ToString();
					}
				}
				catch
				{
					MessageBox.Show("Nothing There! \n" + query, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});
			return result;
		}


		public static void ShowSQLDataOutputInGridView(string Query, DataGridView dataGridView)
		{
			SqlConnect(() => {
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(Query, sqlConnection);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				dataGridView.Columns.Clear();
				dataGridView.DataSource = dataTable;
			});

		}


		public static void ClearValues(params TextBox[] textBoxes)
		{
			for (int i = 0; i < textBoxes.Length; i++)
			{
				textBoxes[i].Clear();
			}
		}

		#endregion



	}
}
