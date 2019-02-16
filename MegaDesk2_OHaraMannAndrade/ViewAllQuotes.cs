using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2_OHaraMannAndrade
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            listViewAllQuotes.Items.Clear();

            try
            {
                // Read quotes from the quotes json file and fill the ListView control with all quotes
                string quoteFile = @"quotes.json";
                var initialJson = File.ReadAllText(quoteFile);
                var array = JArray.Parse(initialJson);

                //loop through all records
                foreach (JObject quote in array)
                {
                    //create DeskQuote object from this record in the array
                    DeskQuote dq = quote.ToObject<DeskQuote>();
                    string formattedString = "Date: " + dq.QuoteDate;
                    formattedString += " Name: " + dq.SelectedCustomerName;
                    formattedString += " Width: " + dq.QuotedDesk.Width;
                    formattedString += " Depth: " + dq.QuotedDesk.Depth;
                    formattedString += " # of Drawers: " + dq.QuotedDesk.CountDrawer;
                    formattedString += " Material: " + dq.QuotedDesk.SurfaceMaterial;
                    formattedString += " Build Time: " + dq.SelectedBuildOption + " days";
                    formattedString += " Quote: $" + dq.QuotedFinalCost;
                    listViewAllQuotes.Items.Add(formattedString);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Showing Quotes");
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
