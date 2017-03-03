using System;
using Xamarin.Forms;

namespace SmallishGenerator
{
	public partial class SmallishGeneratorPage : ContentPage
	{
		public SmallishGeneratorPage()
		{
			InitializeComponent();
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			result.Text = Translate(entry.Text);
		}

		private static String Translate(String swedishText)
		{
			//Add to this list!
			string[][] stringsToReplace = new[]
			{
				new[] { "s", "ss" },
				new[] { "r", "" },
				new[] { "å", "åå" },
				new[] { "dagen", "dan" }
			};

			String smallishText = swedishText;
			foreach (string[] item in stringsToReplace)
				smallishText = smallishText.Replace(item[0], item[1]);

			return smallishText;
		}
	}
}