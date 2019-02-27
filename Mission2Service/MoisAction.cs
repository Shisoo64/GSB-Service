using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Service
{
	public static class MoisAction
	{
		// Récupère le mois précedent au mois actuel
		public static string getMoisPrecedent()
		{
			int moisPrecedent = DateTime.Now.Month - 1;
			if (moisPrecedent < 0)
			{
				moisPrecedent = 12;
			}
			return moisPrecedent.ToString("00");
		}

		// Récupère le mois précedent au mois passé en paramètre
		public static string getMoisPrecedent(DateTime dateNow)
		{
			int moisPrecedent = DateTime.Now.Month - 1;
			if (moisPrecedent == 0)
			{
				moisPrecedent = 12;
			}
			return moisPrecedent.ToString("00");
		}

		// Récupère le mois suivant au mois actuel
		public static string getMoisSuivant()
		{
			int moisSuivant = DateTime.Now.Month + 1;
			if (moisSuivant > 12)
			{
				moisSuivant = 1;
			}
			return moisSuivant.ToString("00");
		}

		// Récupère le mois suivant au mois passé en paramètre
		public static string getMoisSuivant(DateTime dateNow)
		{
			int moisSuivant = DateTime.Now.Month + 1;
			if (moisSuivant > 12)
			{
				moisSuivant = 1;
			}
			return moisSuivant.ToString("00");
		}

		// Return True si l'on se trouve entre les deux jours passés en paramètres
		public static bool entre(int dayBefore, int dayAfter)
		{
			if (DateTime.Now.Day > dayBefore && DateTime.Now.Day < dayAfter)
			{
				return true;
			}
			return false;
		}

		// Return True si le jour passé en paramètre se trouve entre les deux jours passés en paramètres
		public static bool entre(int dayBefore, int dayAfter, DateTime dateNow)
		{
			if (dateNow.Day > dayBefore && dateNow.Day < dayAfter)
			{
				return true;
			}
			return false;
		}

	}
}
