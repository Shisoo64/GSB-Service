using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mission2Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Service.Tests
{
	[TestClass()]
	public class MoisActionTests
	{

		[TestMethod()]
		public void entre10et12True()
		{
			int dayBefore = 10;
			int dayAfter = 12;

			// le 11 du mois
			DateTime dateNow = new DateTime(2017, 1, 11);

			// teste si le 11 du mois se trouve entre le 10 et le 12
			bool resultat = MoisAction.entre(dayBefore, dayAfter, dateNow);

			Assert.IsTrue(resultat);
		}

		[TestMethod()]
		public void entre8et10False()
		{
			int dayBefore = 8;
			int dayAfter = 10;

			// le 15 du mois
			DateTime dateNow = new DateTime(2017, 1, 15);

			// teste si le 15 du mois se trouve entre le 8 et le 10
			bool resultat = MoisAction.entre(dayBefore, dayAfter, dateNow);

			Assert.IsFalse(resultat);
		}

		[TestMethod()]
		public void getMoisSuivant8()
		{
			DateTime dateNow = new DateTime(2017, 8, 15);

			// teste si le mois après le 8 est 9
			string resultat = MoisAction.getMoisSuivant(dateNow);

			Assert.AreEqual("09", resultat);
		}

		[TestMethod()]
		public void getMoisSuivant5()
		{
			DateTime dateNow = new DateTime(2017, 5, 15);

			// teste si le mois après le 5 est 8
			string resultat = MoisAction.getMoisSuivant(dateNow);

			Assert.AreNotEqual("08", resultat);
		}

		[TestMethod()]
		public void getMoisSuivant12()
		{
			DateTime dateNow = new DateTime(2017, 12, 15);

			// teste si le mois après le 5 est 8
			string resultat = MoisAction.getMoisSuivant(dateNow);

			Assert.AreEqual("01", resultat);
		}

	}
}