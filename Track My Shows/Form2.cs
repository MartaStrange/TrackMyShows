using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatTmdb.V3;
using System.Drawing.Text;
using System.IO;

namespace Track_My_Shows
{
    public partial class Form2 : Form
    {
        Tmdb api;
        private Point mouse_offset;
        
        private Movie active = null;
        public User user { get; set; }

        private PrivateFontCollection pfc = new PrivateFontCollection();
        public Form2()
        {
            InitializeComponent();
            api = new Tmdb("b4f9d6a9877dd67328da9e180036834b", "en");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateUserData();
            panelProfile.Visible = true;

        }

        private void updateUserData()
        {

            if (user.gender == 1)
            {
                toolStripMenuItem1.BackgroundImage = global::Track_My_Shows.Properties.Resources.maleAvatar;
                toolStripMenuItem1.Image = global::Track_My_Shows.Properties.Resources.maleAvatar;
                profileMenuItem.Image = global::Track_My_Shows.Properties.Resources.profilemaleIcon;
            }
            else if (user.gender == 0)
            {
                toolStripMenuItem1.BackgroundImage = global::Track_My_Shows.Properties.Resources.femaleAvatar;
                toolStripMenuItem1.Image = global::Track_My_Shows.Properties.Resources.femaleAvatar;
                profileMenuItem.Image = global::Track_My_Shows.Properties.Resources.profilefemaleIcon;
            }

            currentUsername.Text = user.username;
            currentDateRegistered.Text = "Acount has been created on " +user.dateRegistered+".";
            currentTotal.Text = "You are currently tracking "+user.CountTotal().ToString()+" movies.";
            currentToWatch.Text = "You have yet "+user.CountUnwatched().ToString()+" movies to watch.";

            progressBar1.Maximum = user.CountTotal();
            progressBar1.Value = user.CountTotal() - user.CountUnwatched();
            if (user.CountTotal() > 0)
            {
                if ((progressBar1.Value * 100 / user.CountTotal()) > 50)
                label1.Text = "You have watched " + progressBar1.Value * 100 / user.CountTotal() + "% of your movies. Get a life.";
                else
                label1.Text = "You have watched " + progressBar1.Value * 100 / user.CountTotal() + "% of your movies.";
           
            }
            else
            {
                if(user.gender == 1)
                label1.Text = "Watch some movies, dude!";
                else if(user.gender == 0)
                label1.Text = "Watch some movies, dudette!";
            }

            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            if(searchBar.Text == "Search")
            searchBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            panelMovie.Visible = false;
            panelSearch.Visible = true;
            searchResults.Visible = true;
            panelUnwatched.Visible = false;
            panelProfile.Visible = false;
            panelMyshows.Visible = false;

            searchResults.Items.Clear();

            if(searchBar.Text == "")
            {

            }
            string query = searchBar.Text;

            TmdbMovieSearch results = api.SearchMovie(query, 1);

           
            foreach (MovieResult movie in results.results)
            {
                //searchResults.Items.Add(movie.original_title);
                Movie mov = new Movie();
                mov.title = movie.original_title;
                mov.tmdbId = movie.id;

                searchResults.Items.Add(mov);
            }

           if (searchResults.Items.Count == 0) 
            {
                searchResults.Visible = false;
            }
           
        }

        private void showsMenuItem_Click(object sender, EventArgs e)
        {
            panelMyshows.Visible = true;
            panelUnwatched.Visible = false;
            panelProfile.Visible = false;
            panelMovie.Visible = false;
            panelSearch.Visible = false;
        }

        private void unwatchedMenuItem_Click(object sender, EventArgs e)
        {
            panelMyshows.Visible = false;
            panelUnwatched.Visible = true;
            panelProfile.Visible = false;
            panelMovie.Visible = false;
            panelSearch.Visible = false;
        }

        private void profileMenuItem_Click(object sender, EventArgs e)
        {
            panelMyshows.Visible = false;
            panelUnwatched.Visible = false;
            panelProfile.Visible = true;
            panelMovie.Visible = false;
            panelSearch.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Movie mov in searchResults.SelectedItems)
            {
                addMovieToDatabase(mov.tmdbId);
            }
        }

        private void addMovieToDatabase(int tmdbId)
        {
            TmdbMovie movie = api.GetMovieInfo(tmdbId);
            string sql = String.Format("insert into movies (title, length, tagline, overview, tmdbId) values (\"{0}\", {1}, \"{2}\", \"{3}\", {4})",
                                           Escape(movie.title), movie.runtime, Escape(movie.tagline), Escape(movie.overview), movie.id);

            Console.WriteLine(sql);
            //SQLiteCommand 
            SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
            command.ExecuteNonQuery();
        }
        private string Escape(string usString)
        {
            if (usString == null)
            {
                return usString;
            }
            string sample = Convert.ToString(usString);
            return Regex.Replace(sample, @"[\r\n\x00\x1a\\'""]", @"");
        }

        private void searchBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (searchBar.Text == "Search")
            {
                searchBar.Clear();
                searchBar.ForeColor = Color.Black;
            }
            else
            {
                searchBar.SelectAll();
                searchBar.ForeColor = Color.Black;
            }
                
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                panelMovie.Visible = false;
                panelSearch.Visible = true;
                searchResults.Visible = true;
                panelUnwatched.Visible = false;
                panelProfile.Visible = false;
                panelMyshows.Visible = false;

                searchResults.Items.Clear();

                if (searchBar.Text == "")
                {

                }
                string query = searchBar.Text;

                TmdbMovieSearch results = api.SearchMovie(query, 1);


                foreach (MovieResult movie in results.results)
                {
                    //searchResults.Items.Add(movie.original_title);
                    Movie mov = new Movie();
                    mov.title = movie.original_title;
                    mov.tmdbId = movie.id;

                    searchResults.Items.Add(mov);
                }

                if (searchResults.Items.Count == 0)
                {
                    searchResults.Visible = false;
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }

        private void searchResults_DoubleClick(object sender, EventArgs e)
        {
            getSelectedMovieDetails(searchResults);
        }

        private void unwatchedMovies_DoubleClick(object sender, EventArgs e)
        {
            getSelectedMovieDetails(unwatchedMovies);
        }

        private void allMovies_DoubleClick(object sender, EventArgs e)
        {
            getSelectedMovieDetails(allMovies);
        }

        private void getSelectedMovieDetails(ListBox list)
        {
            if (list.SelectedItem != null)
            {
                Movie mov = (Movie)list.SelectedItem;

                string sql = "select * from movies where tmdbId = '" + mov.tmdbId + "'";
                SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
                SQLiteDataReader reader = command.ExecuteReader();
                TmdbMovie movie = api.GetMovieInfo(mov.tmdbId);

                movieWatched.Visible = false;

                if (!reader.HasRows)
                {
                    mov.overview = movie.overview;
                    mov.tagline = movie.tagline;
                    mov.length = movie.runtime;

                    movieWatched.Checked = false;

                    saveMovie.Show();

                }
                else
                {
                    while (reader.Read())
                    {
                        mov.overview = reader["overview"].ToString();
                        mov.tagline = reader["tagline"].ToString();
                        mov.length = (int)((long)reader["length"]);

                        if (reader["watchedDate"].ToString().Length > 0)
                        {
                            movieWatched.Checked = true;
                        }
                        else
                        {
                            movieWatched.Checked = false;
                        }
                    }

                    saveMovie.Hide();
                    movieWatched.Visible = true;

                }

                active = mov;

                movieTitle.Text = mov.title;
                movieOverview.Text = mov.overview;
                movieTagline.Text = mov.tagline;
                movieLength.Text = mov.length.ToString();
                movieTmdbId.Text = mov.tmdbId.ToString();

                var request = WebRequest.Create("https://image.tmdb.org/t/p/w396" + movie.poster_path);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    moviePoster.Image = Bitmap.FromStream(stream);
                }

                panelMovie.Visible = true;
                panelSearch.Visible = false;
                panelUnwatched.Visible = false;
                panelProfile.Visible = false;
                panelMyshows.Visible = false;

            }
        }

        private void saveMovie_Click(object sender, EventArgs e)
        {
            saveMovie.Hide();
            addMovieToDatabase(active.tmdbId);
            movieWatched.Visible = true;
        }

        private void movieWatched_CheckedChanged(object sender, EventArgs e)
        {

            if (!saveMovie.Visible && movieTmdbId.Text != "")
            {

            }
            
        }

        private void movieWatched_Click(object sender, EventArgs e)
        {

            String dateWatched = null;

            if (movieWatched.Checked)
            {
                dateWatched = DateTime.Now.ToString();
            }

            Console.WriteLine(movieTmdbId.Text);

            int mvdbid = int.Parse(movieTmdbId.Text);

            string sql = String.Format("update movies set watchedDate = '{0}' where tmdbId = {1}",
                                           dateWatched, mvdbid);

            Console.WriteLine(sql);
            //SQLiteCommand 
            SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
            command.ExecuteNonQuery();
        }

        private void panelMyshows_VisibleChanged(object sender, EventArgs e)
        {
            if (panelMyshows.Visible)
            {

                panelMovie.Visible = false;
                panelSearch.Visible = false;
                panelUnwatched.Visible = false;
                panelProfile.Visible = false;

                allMovies.Items.Clear();

                string sql = "select * from movies";
                SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
                SQLiteDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    allMovies.Visible = false;
                    label17.Visible = true;

                }
                else
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        Movie mov = new Movie();
                        mov.title = reader["title"].ToString();
                        mov.overview = reader["overview"].ToString();
                        mov.tagline = reader["tagline"].ToString();
                        mov.length = (int)((long)reader["length"]);
                        mov.tmdbId = (int)((long)reader["tmdbId"]);

                        Console.WriteLine(++i);
                        allMovies.Items.Add(mov);
                    }
                
                }
            }
            
        }

        private void unwatchedMovies_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUnwatched.Visible)
            {
                panelMovie.Visible = false;
                panelSearch.Visible = false;
                panelMyshows.Visible = false;
                panelProfile.Visible = false;

                unwatchedMovies.Items.Clear();

                string sql = "select * from movies where watchedDate is null or watchedDate = ''";
                SQLiteCommand command = new SQLiteCommand(sql, DatabaseConnector.getConnection());
                SQLiteDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    unwatchedMovies.Visible = false;
                    label12.Visible = true;

                }
                else
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        Movie mov = new Movie();
                        mov.title = reader["title"].ToString();
                        mov.overview = reader["overview"].ToString();
                        mov.tagline = reader["tagline"].ToString();
                        mov.length = (int)((long)reader["length"]);
                        mov.tmdbId = (int)((long)reader["tmdbId"]);

                        Console.WriteLine(++i);
                        unwatchedMovies.Items.Add(mov);
                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
            panelMovie.Visible = false;
            
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }

        private void panelProfile_VisibleChanged(object sender, EventArgs e)
        {
            updateUserData();
        }

        
    }

   
   
}
