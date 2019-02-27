using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Service
{
	public static class SqlAction
	{

		/// <summary>
		/// Envoie de requête SQL à la base de donnée
		/// </summary>
		/// <param name="sqlComm">Commande SQL</param>
		/// <returns></returns>
		public static DataTable SendSqlCommand(string sqlComm)
		{
			DataTable dt = new DataTable();
			try
			{
				MySqlConnection connection = new MySqlConnection("datasource=localhost;database=gsb_frais;port=3306;username=root;password=");
				MySqlDataAdapter adapter = new MySqlDataAdapter(sqlComm, connection);

				// On ouvre la connection avec la BDD
				connection.Open();

				// On execute la requête et on met son résultat dans une DataTable
				adapter.Fill(dt);

				// On ferme la connection avec la BDD
				connection.Close();
			}
			catch (Exception ex)
			{
			}
			// On retourne la DataTable
			return dt;
		}



		/// <summary>
		/// Cloturation
		/// </summary>
		public static void cl()
		{
			// Si l'on se trouve entre le 1er et le 10 du mois :
			if (MoisAction.entre(1, 10))
			{
				// On récupère le mois précedent
				string mois = DateTime.Now.Year.ToString() + MoisAction.getMoisPrecedent();

				// On envoie une requête qui passe tout les frais du mois précédent avec l'état "CR" à l'état "CL"
				string sqlCmd = "UPDATE ficheFrais"
				+ " SET idetat = 'CL', datemodif = now()"
				+ " WHERE fichefrais.mois = " + mois + ""
				+ " AND idetat = 'CR'";
				SendSqlCommand(sqlCmd);
			}
		}

		/// <summary>
		/// Remboursement
		/// </summary>
		public static void rb()
		{
			// Si l'on se trouve entre le 20 et le 31 du mois :
			if (MoisAction.entre(20, 31))
			{
				// On récupère le mois précedent
				string mois = DateTime.Now.Year.ToString() + MoisAction.getMoisPrecedent();

				// On envoie une requête qui passe tout les frais du mois précédent avec l'état "VA" à l'état "RB"
				string sqlCmd = "UPDATE ficheFrais"
				+ " SET idetat = 'RB', datemodif = now()"
				+ " WHERE fichefrais.mois = " + mois + ""
				+ " AND idetat = 'VA'";
				SendSqlCommand(sqlCmd);
			}
		}

	}
}
