using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace foxsportsstats
{

    // main form data
    public partial class FoxSports : Form
    {

        private bool isReady = false;
        public string base_url = "http://api.stats.foxsports.com.au/3.0/api";
        public string sports = "league";
        public string userKey = "B0DE796F-905E-4708-837C-5D3F1EF93D4E";

        public int seriesId = 0;
        public int seasonId = 0;
        public int roundNo = 0;

        private dynamic SeriesData;
        private dynamic SeasonsData;
        private dynamic RoundsData;

        public FoxSports()
        {
            InitializeComponent();
        }

        private void FoxSportsForm_Load(object sender, EventArgs e)
        {
            this.isReady = false;
            ComboBoxData.li_series_items = new List<string>() { "(All)" };
            ComboBoxData.li_season_items = new List<string>() { "(All)" };
            ComboBoxData.li_round_items = new List<string>() { "(All)" };

            this.GetInitialAllData();
        }

        private async Task GetInitialAllData()
        {
            await this.GETSeriesData(ComboBoxData.li_series_items);
            if (this.isReady) this.EnableReady();
        }

        private async Task GETSeriesData(List<string> param)
        {
            string series_api = this.base_url + "/sports/" + this.sports + "/serieswithcurrentseason.json" + "?userkey=" + userKey;
            await Task.Run(() => { this.SeriesData = JsonConvert.DeserializeObject<dynamic>(GetAllData(series_api)); });
            if (this.SeriesData != null)
            {
                param = new List<string>() { "(All)" };
                for (int i = 0; i < this.SeriesData.Count; i++)
                {
                    string returndata = this.SeriesData[i].code + " - " + this.SeriesData[i].name;
                    param.Add(returndata);
                }
            }
            else return;
            li_series.DataSource = param;
            if (param.Count == 1 && param[0] == "(All)") { li_series.SelectedIndex = 0; }
        }

        private async Task GETSeasonsData(List<string> param)
        {
            this.seriesId = (li_series.SelectedIndex > 0) ? this.SeriesData[li_series.SelectedIndex - 1].id : 0;
            string seasons_api = this.base_url + "/sports/" + this.sports + "/series/" + this.seriesId + "/seasons.json" + "?userkey=" + userKey;
            await Task.Run(() => { this.SeasonsData = JsonConvert.DeserializeObject<dynamic>(GetAllData(seasons_api)); });
            if (this.SeasonsData != null)
            {
                param = new List<string>() { "(All)" };
                for (int j = 0; j < this.SeasonsData.Count; j++)
                {
                    string returndata = this.SeasonsData[j].name;
                    param.Add(returndata);
                }
            }
            else return;
            li_season.DataSource = param;
            if (li_series.Text == "(All)") { li_season.Text = "(All)"; } else { li_season.Text = this.SeasonsData[this.SeasonsData.Count - 1].name; }
        }

        private async Task GETRoundsData(List<string> param)
        {
            this.seasonId = (li_season.SelectedIndex > 0) ? this.SeasonsData[li_season.SelectedIndex - 1].id : 0;
            string round_api = this.base_url + "/sports/" + this.sports + "/series/" + this.seriesId + "/seasons/" + this.seasonId + "/rounds.json" + "?userkey=" + userKey;
            await Task.Run(() => { this.RoundsData = JsonConvert.DeserializeObject<dynamic>(GetAllData(round_api)); });
            if (this.RoundsData != null)
            {
                param = new List<string>() { "(All)" };
                for (int k = 0; k < this.RoundsData.Count; k++)
                {
                    string returndata = this.RoundsData[k].name;
                    param.Add(returndata);
                }
            }
            else return;
            li_round.DataSource = param;
            if (li_season.Text == "(All)") { li_round.Text = "(All)"; this.roundNo = 0; } else { li_round.Text = this.RoundsData[this.RoundsData.Count - 1].name; }
        }

        private string GetAllData(string Url)
        {
            string result = "";
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(Url);
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;

                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                var data = ((HttpWebResponse)response).GetResponseStream();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                result = sr.ReadToEnd();
                sr.Close();
                this.isReady = true;
            }
            catch (WebException webExcp)
            {
                // If you reach this point, an exception has been caught.  
                Console.WriteLine("A WebException has been caught.");
                // Write out the WebException message.  
                Console.WriteLine(webExcp.ToString());
                this.ErrorMsg("Error: A WebException has been caught.");
                // Get the WebException status code.  
                WebExceptionStatus status = webExcp.Status;
                // If status is WebExceptionStatus.ProtocolError,
                //   there has been a protocol error and a WebResponse
                //   should exist. Display the protocol error.  
                if (status == WebExceptionStatus.ProtocolError)
                {
                    Console.Write("The server returned protocol error ");
                    this.ErrorMsg("Error: The server returned protocol error.");
                    // Get HttpWebResponse so that you can check the HTTP status code.  
                    HttpWebResponse httpResponse = (HttpWebResponse)webExcp.Response;
                    Console.WriteLine((int)httpResponse.StatusCode + " - "
                       + httpResponse.StatusCode);
                }
            }
            catch (Exception e)
            {
                // Code to catch other exceptions goes here.  
            }
            return result;
        }

        private void ErrorMsg(string errorMsg)
        {
            lb_error.Text = errorMsg;
            //li_series.Enabled = false;
            //li_season.Enabled = false;
            //li_round.Enabled = false;
            btnFetchResult.Enabled = false;
            this.isReady = false;
        }

        private void EnableReady()
        {
            lb_error.Text = "";
            //li_series.Enabled = true;
            //li_season.Enabled = true;
            //li_round.Enabled = true;
            btnFetchResult.Enabled = true;
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--- reloading! ---");
            this.GetInitialAllData();
        }

        private void BtnFetchResult_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--- get form selected data ---");
            this.GetAllTeamData();
            Console.WriteLine("--- Generate CSV ---");
        }

        private void GetAllTeamData()
        {
            var matchID = "QLDC20200103";
            string teamInfo_api = "http://reports.foxsportsstats.com.au/lab/"+ "sports" + "/match.html" + "?matchId=" + matchID;
            var SeasonsData = JsonConvert.DeserializeObject<dynamic>(GetAllData(teamInfo_api));
        }

        private void Li_series_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GETSeasonsData(ComboBoxData.li_season_items);
            Console.WriteLine("---change_selections 1-------");
        }

        private void Li_season_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GETRoundsData(ComboBoxData.li_round_items);
            Console.WriteLine("---change_selections 2-------");
        }

        private void Li_round_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.roundNo = (li_round.SelectedIndex > 0) ? this.RoundsData[li_round.SelectedIndex - 1].number : 0;
            string fixturesandresults = this.base_url + "/sports/" + this.sports + "/series/" + this.seriesId + "/seasons/" + this.seasonId + ( (this.roundNo>0)? ("/rounds/" + this.roundNo) : "" ) + "/fixturesandresults.json" + "?userkey=" + userKey;
            Console.WriteLine(fixturesandresults);
        }
    }

    // define global class and functions
    class ComboBoxData
    {
        public static List<string> li_series_items = new List<string>() {"(All)"};
        public static List<string> li_season_items = new List<string>() {"(All)"};
        public static List<string> li_round_items = new List<string>() {"(All)"};
    }
}
