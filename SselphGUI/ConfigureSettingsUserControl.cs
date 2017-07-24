using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SselphGUI
{
    public partial class ConfigureSettingsUserControl : UserControl
    {
        public ConfigureSettingsUserControl()
        {
            InitializeComponent();
            // hide the tab control tabs
            AppTabControl.Appearance = TabAppearance.FlatButtons;
            AppTabControl.ItemSize = new Size(0, 1);
            AppTabControl.SizeMode = TabSizeMode.Fixed;
            // remove the default border from the console control
            AppConsoleControl.InternalRichTextBox.BorderStyle = BorderStyle.None;
            // change the default font of the console control
            AppConsoleControl.InternalRichTextBox.Font = new Font(FontFamily.GenericMonospace, 8);
            // update ui to reflect saved settings
            UpdateUI();
        }

        #region SaveSettings
        private void SaveSettings()
        {
            // download_images
            if (DownloadImagesCheckBox.Checked == true)
            {
                Properties.Settings.Default.download_images = "-download_images=true";
            }
            else
            {
                Properties.Settings.Default.download_images = "-download_images=false";
            }
            // console_img
            string console_img = ConsoleImgComboBox.SelectedItem.ToString();
            Properties.Settings.Default.console_img = "-console_img=" + console_img;
            // img_format
            string img_format = ImgFormatComboBox.SelectedItem.ToString();
            Properties.Settings.Default.img_format = "-img_format=" + img_format;
            // image_suffix
            if (ImageSuffixTextBox.Text != "")
            {
                string image_suffix = ImageSuffixTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                image_suffix = rgx.Replace(image_suffix, "");
                Properties.Settings.Default.image_suffix = "-image_suffix=-" + image_suffix;
            }
            else
            {
                Properties.Settings.Default.image_suffix = "-image_suffix=";
            }
            // image_path
            if (ImagePathTextBox.Text != "")
            {
                string image_path = ImagePathTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                image_path = rgx.Replace(image_path, "");
                Properties.Settings.Default.image_path = "-image_path=" + image_path;
                Properties.Settings.Default.image_path_string = image_path;
            }
            else
            {
                Properties.Settings.Default.image_path = "";
                Properties.Settings.Default.image_path_string = "";
            }
            // max_height
            string max_height = MaxHeightNumericUpDown.Value.ToString();
            if (max_height != "0")
            {
                Properties.Settings.Default.max_height = "-max_height=" + max_height;
            }
            else
            {
                Properties.Settings.Default.max_height = "";
            }
            // max_width
            string max_width = MaxWidthNumericUpDown.Value.ToString();
            if (max_width != "0")
            {
                Properties.Settings.Default.max_width = "-max_width=" + max_width;
            }
            else
            {
                Properties.Settings.Default.max_width = "";
            }
            // download_marquees
            if (DownloadMarqueesCheckBox.Checked == true)
            {
                Properties.Settings.Default.download_marquees = "-download_marquees=true";
            }
            else
            {
                Properties.Settings.Default.download_marquees = "-download_marquees=false";
            }
            // marquee_format
            string marquee_format = MarqueeFormatComboBox.SelectedItem.ToString();
            Properties.Settings.Default.marquee_format = "-marquee_format=" + marquee_format;
            // marquee_suffix
            if (MarqueeSuffixTextBox.Text != "")
            {
                string marquee_suffix = MarqueeSuffixTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                marquee_suffix = rgx.Replace(marquee_suffix, "");
                Properties.Settings.Default.marquee_suffix = "-marquee_suffix=-" + marquee_suffix;
            }
            else
            {
                Properties.Settings.Default.marquee_suffix = "-marquee_suffix=";
            }
            // marquee_path
            if (MarqueePathTextBox.Text != "")
            {
                string marquee_path = MarqueePathTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                marquee_path = rgx.Replace(marquee_path, "");
                Properties.Settings.Default.marquee_path = "-marquee_path=" + marquee_path;
                Properties.Settings.Default.marquee_path_string = marquee_path;
            }
            else
            {
                Properties.Settings.Default.marquee_path = "";
                Properties.Settings.Default.marquee_path_string = "";
            }
            // download_videos
            if (DownloadVideosCheckBox.Checked == true)
            {
                Properties.Settings.Default.download_videos = "-download_videos=true";
            }
            else
            {
                Properties.Settings.Default.download_videos = "-download_videos=false";
            }
            // convert_videos
            if (ConvertVideosCheckBox.Checked == true)
            {
                Properties.Settings.Default.convert_videos = "-convert_videos=true";
            }
            else
            {
                Properties.Settings.Default.convert_videos = "-convert_videos=false";
            }
            // video_suffix
            if (VideoSuffixTextBox.Text != "")
            {
                string video_suffix = VideoSuffixTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                video_suffix = rgx.Replace(video_suffix, "");
                Properties.Settings.Default.video_suffix = "-video_suffix=-" + video_suffix;
            }
            else
            {
                Properties.Settings.Default.video_suffix = "-video_suffix=";
            }
            // video_path
            if (VideoPathTextBox.Text != "")
            {
                string video_path = VideoPathTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                video_path = rgx.Replace(video_path, "");
                Properties.Settings.Default.video_path = "-video_path=" + video_path;
                Properties.Settings.Default.video_path_string = video_path;
            }
            else
            {
                Properties.Settings.Default.video_path = "";
                Properties.Settings.Default.video_path_string = "";
            }
            // add_not_found
            if (AddNotFoundCheckBox.Checked == true)
            {
                Properties.Settings.Default.add_not_found = "-add_not_found=true";
            }
            else
            {
                Properties.Settings.Default.add_not_found = "-add_not_found=false";
            }
            // append
            if (AppendCheckBox.Checked == true)
            {
                Properties.Settings.Default.append = "-append=true";
            }
            else
            {
                Properties.Settings.Default.append = "-append=false";
            }
            // nested_img_dir
            if (NestedImgDirCheckBox.Checked == true)
            {
                Properties.Settings.Default.nested_img_dir = "-nested_img_dir=true";
            }
            else
            {
                Properties.Settings.Default.nested_img_dir = "-nested_img_dir=false";
            }
            // strip_unicode
            if (StripUnicodeCheckBox.Checked == true)
            {
                Properties.Settings.Default.strip_unicode = "-strip_unicode=true";
            }
            else
            {
                Properties.Settings.Default.strip_unicode = "-strip_unicode=false";
            }
            // use_filename
            if (UseFilenameCheckBox.Checked == true)
            {
                Properties.Settings.Default.use_filename = "-use_filename=true";
            }
            else
            {
                Properties.Settings.Default.use_filename = "-use_filename=false";
            }
            // use_nointro_name
            if (UseNointroNameCheckBox.Checked == true)
            {
                Properties.Settings.Default.use_nointro_name = "-use_nointro_name=true";
            }
            else
            {
                Properties.Settings.Default.use_nointro_name = "-use_nointro_name=false";
            }
            // overview_len
            string overview_len = OverviewLenNumericUpDown.Value.ToString();
            if (overview_len != "0")
            {
                Properties.Settings.Default.overview_len = "-overview_len=" + overview_len;
            }
            else
            {
                Properties.Settings.Default.overview_len = "";
            }
            // console_src
            string console_src = ConsoleSrcComboBox.SelectedItem.ToString();
            Properties.Settings.Default.console_src = "-console_src=" + console_src;
            // ss_user
            if (SSUserTextBox.Text != "")
            {
                string ss_user = SSUserTextBox.Text;
                Properties.Settings.Default.ss_user = "-ss_user=" + ss_user;
            }
            else
            {
                Properties.Settings.Default.ss_user = "-ss_user=";
            }
            // ss_password
            if (SSPasswordTextBox.Text != "")
            {
                string ss_password = SSPasswordTextBox.Text;
                Properties.Settings.Default.ss_password = "-ss_password=" + ss_password;
            }
            else
            {
                Properties.Settings.Default.ss_password = "-ss_password=";
            }
            // skip_check
            if (SkipCheckCheckBox.Checked == true)
            {
                Properties.Settings.Default.skip_check = "-skip_check=true";
            }
            else
            {
                Properties.Settings.Default.skip_check = "-skip_check=false";
            }
            // extra_ext
            if (ExtraExtTextBox.Text != "")
            {
                string extra_ext = ExtraExtTextBox.Text;
                Regex rgx = new Regex("[^a-zA-Z0-9]");
                extra_ext = rgx.Replace(extra_ext, "");
                Properties.Settings.Default.extra_ext = "-extra_ext=" + extra_ext;
            }
            else
            {
                Properties.Settings.Default.extra_ext = "-extra_ext=";
            }
            // retries
            string retries = RetriesNumericUpDown.Value.ToString();
            Properties.Settings.Default.retries = "-retries=" + retries;
            // workers
            string workers = WorkersNumericUpDown.Value.ToString();
            Properties.Settings.Default.workers = "-workers=" + workers;

            // save the settings
            Properties.Settings.Default.Save();
            // update the ui to reflect changes
            UpdateUI();
        }
        #endregion

        #region UpdateUI
        private void UpdateUI()
        {
            // download_images
            if (Properties.Settings.Default.download_images == "-download_images=true")
            {
                DownloadImagesCheckBox.Checked = true;
            }
            else
            {
                DownloadImagesCheckBox.Checked = false;
            }
            // console_img
            string console_img = Properties.Settings.Default.console_img;
            console_img = console_img.Remove(0, 13);
            ConsoleImgComboBox.SelectedItem = console_img;
            // img_format
            string img_format = Properties.Settings.Default.img_format;
            img_format = img_format.Remove(0, 12);
            ImgFormatComboBox.SelectedItem = img_format;
            // image_suffix
            string image_suffix = Properties.Settings.Default.image_suffix;
            image_suffix = image_suffix.Remove(0, 14);
            ImageSuffixTextBox.Text = image_suffix;
            // image_path
            string image_path = Properties.Settings.Default.image_path;
            image_path = image_path.Remove(0, 12);
            ImagePathTextBox.Text = image_path;
            // max_height
            string max_height = Properties.Settings.Default.max_height;
            if (max_height != "")
            {
                max_height = max_height.Remove(0, 12);
                decimal max_height_decimal = 0;
                if (decimal.TryParse(max_height, out max_height_decimal))
                {
                    MaxHeightNumericUpDown.Value = max_height_decimal;
                }
            }
            else
            {
                MaxHeightNumericUpDown.Value = 0;
            }
            // max_width
            string max_width = Properties.Settings.Default.max_width;
            if (max_width != "")
            {
                max_width = max_width.Remove(0, 11);
                decimal max_width_decimal = 0;
                if (decimal.TryParse(max_width, out max_width_decimal))
                {
                    MaxWidthNumericUpDown.Value = max_width_decimal;
                }
            }
            else
            {
                MaxWidthNumericUpDown.Value = 0;
            }
            // download_marquees
            if (Properties.Settings.Default.download_marquees == "-download_marquees=true")
            {
                DownloadMarqueesCheckBox.Checked = true;
            }
            else
            {
                DownloadMarqueesCheckBox.Checked = false;
            }
            // marquee_format
            string marquee_format = Properties.Settings.Default.marquee_format;
            marquee_format = marquee_format.Remove(0, 16);
            MarqueeFormatComboBox.SelectedItem = marquee_format;
            // marquee_suffix
            string marquee_suffix = Properties.Settings.Default.marquee_suffix;
            marquee_suffix = marquee_suffix.Remove(0, 16);
            MarqueeSuffixTextBox.Text = marquee_suffix;
            // marquee_path
            string marquee_path = Properties.Settings.Default.marquee_path;
            marquee_path = marquee_path.Remove(0, 14);
            MarqueePathTextBox.Text = marquee_path;
            // download_videos
            if (Properties.Settings.Default.download_videos == "-download_videos=true")
            {
                DownloadVideosCheckBox.Checked = true;
            }
            else
            {
                DownloadVideosCheckBox.Checked = false;
            }
            // convert_videos
            if (Properties.Settings.Default.convert_videos == "-convert_videos=true")
            {
                ConvertVideosCheckBox.Checked = true;
            }
            else
            {
                ConvertVideosCheckBox.Checked = false;
            }
            // video_suffix
            string video_suffix = Properties.Settings.Default.video_suffix;
            video_suffix = video_suffix.Remove(0, 14);
            VideoSuffixTextBox.Text = video_suffix;
            // video_path
            string video_path = Properties.Settings.Default.video_path;
            video_path = video_path.Remove(0, 12);
            VideoPathTextBox.Text = video_path;
            // add_not_found
            if (Properties.Settings.Default.add_not_found == "-add_not_found=true")
            {
                AddNotFoundCheckBox.Checked = true;
            }
            else
            {
                AddNotFoundCheckBox.Checked = false;
            }
            // append
            if (Properties.Settings.Default.append == "-append=true")
            {
                AppendCheckBox.Checked = true;
            }
            else
            {
                AppendCheckBox.Checked = false;
            }
            // nested_img_dir
            if (Properties.Settings.Default.nested_img_dir == "-nested_img_dir=true")
            {
                NestedImgDirCheckBox.Checked = true;
            }
            else
            {
                NestedImgDirCheckBox.Checked = false;
            }
            // strip_unicode
            if (Properties.Settings.Default.strip_unicode == "-strip_unicode=true")
            {
                StripUnicodeCheckBox.Checked = true;
            }
            else
            {
                StripUnicodeCheckBox.Checked = false;
            }
            // use_filename
            if (Properties.Settings.Default.use_filename == "-use_filename=true")
            {
                UseFilenameCheckBox.Checked = true;
            }
            else
            {
                UseFilenameCheckBox.Checked = false;
            }
            // use_nointro_name
            if (Properties.Settings.Default.use_nointro_name == "-use_nointro_name=true")
            {
                UseNointroNameCheckBox.Checked = true;
            }
            else
            {
                UseNointroNameCheckBox.Checked = false;
            }
            // overview_len
            string overview_len = Properties.Settings.Default.overview_len;
            if (overview_len != "")
            {
                overview_len = overview_len.Remove(0, 14);
                decimal overview_len_decimal = 0;
                if (decimal.TryParse(overview_len, out overview_len_decimal))
                {
                    OverviewLenNumericUpDown.Value = overview_len_decimal;
                }
            }
            else
            {
                OverviewLenNumericUpDown.Value = 0;
            }
            // console_src
            string console_src = Properties.Settings.Default.console_src;
            console_src = console_src.Remove(0, 13);
            ConsoleSrcComboBox.SelectedItem = console_src;
            // ss_user
            string ss_user = Properties.Settings.Default.ss_user;
            if (ss_user != "-ss_user=")
            {
                ss_user = ss_user.Remove(0, 9);
                SSUserTextBox.Text = ss_user;
            }
            else
            {
                SSUserTextBox.Text = "";
            }
            // ss_password
            string ss_password = Properties.Settings.Default.ss_password;
            if (ss_password != "-ss_password=")
            {
                ss_password = ss_password.Remove(0, 13);
                SSPasswordTextBox.Text = ss_password;
            }
            else
            {
                SSPasswordTextBox.Text = "";
            }
            // skip_check
            if (Properties.Settings.Default.skip_check == "-skip_check=true")
            {
                SkipCheckCheckBox.Checked = true;
            }
            else
            {
                SkipCheckCheckBox.Checked = false;
            }
            // extra_ext
            string extra_ext = Properties.Settings.Default.extra_ext;
            extra_ext = extra_ext.Remove(0, 11);
            ExtraExtTextBox.Text = extra_ext;
            // retries
            string retries = Properties.Settings.Default.retries;
            retries = retries.Remove(0, 9);
            decimal retries_decimal = 0;
            if (decimal.TryParse(retries, out retries_decimal))
            {
                RetriesNumericUpDown.Value = retries_decimal;
            }
            // workers
            string workers = Properties.Settings.Default.workers;
            workers = workers.Remove(0, 9);
            decimal workers_decimal = 0;
            if (decimal.TryParse(workers, out workers_decimal))
            {
                WorkersNumericUpDown.Value = workers_decimal;
            }
        }
        #endregion

        #region ResetDefaults
        private void ResetDefaults()
        {
            // revert all settings to sselph's default values
            Properties.Settings.Default.add_not_found = "-add_not_found=false";
            Properties.Settings.Default.append = "-append=false";
            Properties.Settings.Default.console_img = "-console_img=b";
            Properties.Settings.Default.console_src = "-console_src=gdb";
            Properties.Settings.Default.convert_videos = "-convert_videos=false";
            Properties.Settings.Default.download_images = "-download_images=true";
            Properties.Settings.Default.download_marquees = "-download_marquees=false";
            Properties.Settings.Default.download_videos = "-download_videos=false";
            Properties.Settings.Default.extra_ext = "-extra_ext=";
            Properties.Settings.Default.image_dir = "";
            Properties.Settings.Default.image_path = "-image_path=images";
            Properties.Settings.Default.image_path_string = "images";
            Properties.Settings.Default.image_suffix = "-image_suffix=-image";
            Properties.Settings.Default.img_format = "-img_format=jpg";
            Properties.Settings.Default.img_workers = "-img_workers=0";
            Properties.Settings.Default.lang = "-lang=en";
            Properties.Settings.Default.mame = "-mame=false";
            Properties.Settings.Default.mame_img = "-mame_img=t,m,s,c";
            Properties.Settings.Default.mame_src = "-mame_src=adb,gdb";
            Properties.Settings.Default.marquee_dir = "";
            Properties.Settings.Default.marquee_format = "-marquee_format=png";
            Properties.Settings.Default.marquee_path = "-marquee_path=images";
            Properties.Settings.Default.marquee_path_string = "images";
            Properties.Settings.Default.marquee_suffix = "-marquee_suffix=-marquee";
            Properties.Settings.Default.max_height = "";
            Properties.Settings.Default.max_width = "-max_width=400";
            Properties.Settings.Default.missing = "";
            Properties.Settings.Default.nested_img_dir = "-nested_img_dir=false";
            Properties.Settings.Default.no_thumb = "-no_thumb";
            Properties.Settings.Default.output_file = "";
            Properties.Settings.Default.overview_len = "";
            Properties.Settings.Default.region = "-region=us,wor,eu,jp,fr,xx";
            Properties.Settings.Default.retries = "-retries=2";
            Properties.Settings.Default.rom_dir = "";
            Properties.Settings.Default.rom_path = "-rom_path=.";
            Properties.Settings.Default.skip_check = "-skip_check=true";
            Properties.Settings.Default.ss_password = "-ss_password=";
            Properties.Settings.Default.ss_user = "-ss_user=";
            Properties.Settings.Default.strip_unicode = "-strip_unicode=false";
            Properties.Settings.Default.update_cache = "-update_cache=true";
            Properties.Settings.Default.use_filename = "-use_filename=false";
            Properties.Settings.Default.use_nointro_name = "-use_nointro_name=true";
            Properties.Settings.Default.video_dir = "";
            Properties.Settings.Default.video_path = "-video_path=images";
            Properties.Settings.Default.video_path_string = "images";
            Properties.Settings.Default.video_suffix = "-video_suffix=-video";
            Properties.Settings.Default.workers = "-workers=1";
        }
        #endregion

        #region BuildOutput
        private string BuildOutput()
        {
            // build the scraper options string with the users customized settings
            StringBuilder sbo = new StringBuilder();
            sbo.Append(Properties.Settings.Default.add_not_found + " ");
            sbo.Append(Properties.Settings.Default.append + " ");
            sbo.Append(Properties.Settings.Default.console_img + " ");
            sbo.Append(Properties.Settings.Default.console_src + " ");
            sbo.Append(Properties.Settings.Default.convert_videos + " ");
            sbo.Append(Properties.Settings.Default.download_images + " ");
            sbo.Append(Properties.Settings.Default.download_marquees + " ");
            sbo.Append(Properties.Settings.Default.download_videos + " ");
            sbo.Append(Properties.Settings.Default.extra_ext + " ");
            sbo.Append(Properties.Settings.Default.image_dir + " ");
            sbo.Append(Properties.Settings.Default.image_path + " ");
            sbo.Append(Properties.Settings.Default.image_suffix + " ");
            sbo.Append(Properties.Settings.Default.img_format + " ");
            sbo.Append(Properties.Settings.Default.img_workers + " ");
            sbo.Append(Properties.Settings.Default.lang + " ");
            sbo.Append(Properties.Settings.Default.mame + " ");
            sbo.Append(Properties.Settings.Default.mame_img + " ");
            sbo.Append(Properties.Settings.Default.mame_src + " ");
            sbo.Append(Properties.Settings.Default.marquee_dir + " ");
            sbo.Append(Properties.Settings.Default.marquee_format + " ");
            sbo.Append(Properties.Settings.Default.marquee_path + " ");
            sbo.Append(Properties.Settings.Default.marquee_suffix + " ");
            sbo.Append(Properties.Settings.Default.max_height + " ");
            sbo.Append(Properties.Settings.Default.max_width + " ");
            sbo.Append(Properties.Settings.Default.missing + " ");
            sbo.Append(Properties.Settings.Default.nested_img_dir + " ");
            sbo.Append(Properties.Settings.Default.no_thumb + " ");
            sbo.Append(Properties.Settings.Default.output_file + " ");
            sbo.Append(Properties.Settings.Default.overview_len + " ");
            sbo.Append(Properties.Settings.Default.region + " ");
            sbo.Append(Properties.Settings.Default.retries + " ");
            sbo.Append(Properties.Settings.Default.rom_dir + " ");
            sbo.Append(Properties.Settings.Default.rom_path + " ");
            sbo.Append(Properties.Settings.Default.skip_check + " ");
            sbo.Append(Properties.Settings.Default.ss_password + " ");
            sbo.Append(Properties.Settings.Default.ss_user + " ");
            sbo.Append(Properties.Settings.Default.strip_unicode + " ");
            sbo.Append(Properties.Settings.Default.update_cache + " ");
            sbo.Append(Properties.Settings.Default.use_filename + " ");
            sbo.Append(Properties.Settings.Default.use_nointro_name + " ");
            sbo.Append(Properties.Settings.Default.video_dir + " ");
            sbo.Append(Properties.Settings.Default.video_path + " ");
            sbo.Append(Properties.Settings.Default.video_suffix + " ");
            sbo.Append(Properties.Settings.Default.workers);
            // convert the string builder output to a string
            return sbo.ToString();
        }
        #endregion

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit the program
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display the about form
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }

        private void ConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // navigate to the settings tab page
            AppTabControl.SelectedTab = SettingsTabPage;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            // save the customized settings
            SaveSettings();
            MessageBox.Show("Your settings have been saved.", "Sselph Scraper GUI - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseSettingsButton_Click(object sender, EventArgs e)
        {
            // close the settings tab page and navigate to the main tab page
            AppTabControl.SelectedTab = MainTabPage;
        }

        private void RomDirButton_Click(object sender, EventArgs e)
        {
            // select the rom directory to scrape
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    RomDirTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void CancelScrapeButton_Click(object sender, EventArgs e)
        {
            // cancel the scraping process
            if (AppConsoleControl.IsProcessRunning == true)
            {
                AppConsoleControl.StopProcess();
            }
        }

        private void ScrapeButton_Click(object sender, EventArgs e)
        {
            // check if a rom directory has been selected
            if (RomDirTextBox.Text == "")
            {
                MessageBox.Show("Oops! It looks like you forgot to select a directory containing the ROMs you want to scrape.", "Sselph Scraper GUI - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // set the dir arguments that are dependent on the selected rom directory
                Properties.Settings.Default.rom_dir = "-rom_dir=" + "\"" + RomDirTextBox.Text + "\"";
                Properties.Settings.Default.image_dir = "-image_dir=" + "\"" + RomDirTextBox.Text + "\\" + Properties.Settings.Default.image_path_string + "\"";
                Properties.Settings.Default.marquee_dir = "-marquee_dir=" + "\"" + RomDirTextBox.Text + "\\" + Properties.Settings.Default.marquee_path_string + "\"";
                Properties.Settings.Default.video_dir = "-video_dir=" + "\"" + RomDirTextBox.Text + "\\" + Properties.Settings.Default.video_path_string + "\"";
                Properties.Settings.Default.output_file = "-output_file=" + "\"" + RomDirTextBox.Text + "\\" + "gamelist.xml" + "\"";
                Properties.Settings.Default.missing = "-missing=" + "\"" + RomDirTextBox.Text + "\\" + "miss.txt" + "\"";
                // build the string
                string scrape_options = BuildOutput();
                // clear the rom dir text box
                RomDirTextBox.Text = "";
                // clear the console control
                AppConsoleControl.ClearOutput();
                // start the scraping process
                AppConsoleControl.StartProcess("scraper.exe", scrape_options);
            }
        }

        private void ResetToDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to revert the scraper settings to their default values?", "Sselph Scraper GUI - Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetDefaults();
                // save the settings after reverting them all back to sselph's default values
                Properties.Settings.Default.Save();
                // update the UI
                UpdateUI();
                // inform the user of a successful save
                MessageBox.Show("The scraper settings have been reverted to their original values (as defined by Sselph) and saved.", "Sselph Scraper GUI - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
