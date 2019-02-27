using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MySql.Data.MySqlClient;

namespace Mission2Service
{
	public partial class Service1 : ServiceBase
	{
		public Service1()
		{
			InitializeComponent();
		}
		
		protected override void OnStart(string[] args)
		{
			// On lance un timer lorsque le service démarre
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Interval = 60000 * 60; // Intervale = Toute les heures
			timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
			timer.Start();
		}

		public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
		{
			// Remboursement
			SqlAction.rb();

			// Cloturation
			SqlAction.cl();
		}

	}
}
