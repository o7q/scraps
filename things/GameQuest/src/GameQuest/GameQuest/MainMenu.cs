using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace GameQuest
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (File.Exists("data"))
            {
                string data = File.ReadAllText("data");

                if (data != "")
                {
                    string[] dataList = data.Split('\n');

                    HoursPerDayTextBox.Text = dataList[0];

                    if (dataList.Length > 1)
                    {
                        for (int i = 1; i < dataList.Length; i++)
                        {
                            string[] dataPiece = dataList[i].Split('ʃ');
                            double.TryParse(dataPiece[1], out double hours);
                            string[] itemTexts = new string[] { dataPiece[0], FormatHoursToDate(hours), dataPiece[1] };
                            ListViewItem newItem = new ListViewItem(itemTexts);
                            GameListView.Items.Add(newItem);
                        }
                    }
                }
            }

            RefreshUI(false);
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            if (GameTitleTextBox.Text == "" || TimeToBeatTextBox.Text == "")
                return;

            foreach (ListViewItem item in GameListView.Items)
                if (item.Text == GameTitleTextBox.Text)
                    return;

            double hours;
            double.TryParse(TimeToBeatTextBox.Text, out hours);

            string formattedTime = FormatHoursToDate(hours);

            string[] itemTexts = new string[] { GameTitleTextBox.Text, formattedTime, hours.ToString() };
            ListViewItem newItem = new ListViewItem(itemTexts);
            GameListView.Items.Add(newItem);

            GameTitleTextBox.Text = "";
            TimeToBeatTextBox.Text = "";

            RefreshUI(false);
        }

        private void RemoveGameButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in GameListView.SelectedItems)
            {
                GameListView.Items.Remove(selectedItem);
            }

            RefreshUI(false);
        }

        private string FormatHoursToDate(double hours)
        {
            TimeSpan timeSpan = TimeSpan.FromHours(hours);
            return $"{(int)timeSpan.TotalDays}d {timeSpan.Hours}h {timeSpan.Minutes}m";
        }

        private void RefreshUI(bool useSelected)
        {
            double totalHours = 0;
            // Sorting by Items
            if (useSelected)
            {
                double.TryParse(HoursPerDayTextBox.Text, out double hoursPerDay);
                foreach (ListViewItem item in GameListView.SelectedItems)
                {
                    double.TryParse(item.SubItems[2].Text, out double hours);

                    if (hoursPerDay > 24)
                        hoursPerDay = 24;

                    totalHours += hours;
                }

                if (hoursPerDay > 0)
                {
                    totalHours = (int)(totalHours / hoursPerDay) * 24 + totalHours % hoursPerDay;
                    TotalTimeLabel.Text = FormatHoursToDate(totalHours);
                }
                else
                {
                    TotalTimeLabel.Text = "infinity days";
                }
                CompleteText4Label.Text = "to beat " + (GameListView.SelectedItems.Count == 1 ? "this game." : "these " + GameListView.SelectedItems.Count + " games.");
            }
            // Sorting by SelectedItems
            else
            {
                double.TryParse(HoursPerDayTextBox.Text, out double hoursPerDay);
                foreach (ListViewItem item in GameListView.Items)
                {
                    double.TryParse(item.SubItems[2].Text, out double hours);

                    if (hoursPerDay > 24)
                        hoursPerDay = 24;

                    totalHours += hours;
                }

                if (hoursPerDay > 0)
                {
                    totalHours = (int)(totalHours / hoursPerDay) * 24 + totalHours % hoursPerDay;
                    TotalTimeLabel.Text = FormatHoursToDate(totalHours);
                }
                else
                {
                    TotalTimeLabel.Text = "infinity days";
                }
                CompleteText4Label.Text = "to beat " + (GameListView.Items.Count == 1 ? "this game." : "all " + GameListView.Items.Count + " games.");
            }

            CompleteText4Label.Location = new Point(266 + TotalTimeLabel.Width - 59, CompleteText4Label.Location.Y);
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(HoursPerDayTextBox.Text);
            sb.Append('\n');
            foreach (ListViewItem item in GameListView.Items)
            {
                sb.Append(item.SubItems[0].Text);
                sb.Append('ʃ');
                sb.Append(item.SubItems[2].Text);
                sb.Append('\n');
            }
            sb.Length--;

            File.WriteAllText("data", sb.ToString());
        }

        private void HoursPerDayTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshUI(false);
        }

        bool ascendingOrder = true;
        private void GameListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int columnToSortBY = e.Column;
            if (e.Column == 1)
            {
                columnToSortBY = 2;
            }
            ascendingOrder = !ascendingOrder;
            GameListView.ListViewItemSorter = new ListViewItemComparer(columnToSortBY, columnToSortBY == 2, ascendingOrder);
            GameListView.Sort();
        }

        private void GameListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameListView.SelectedItems.Count > 0)
            {
                RefreshUI(true);
            }
            else
                RefreshUI(false);
        }
    }

    public class ListViewItemComparer : IComparer
    {
        private int columnIndex;
        private bool sortNumeric;
        private bool ascendingOrder;

        public ListViewItemComparer(int columnIndex, bool sortNumeric, bool ascendingOrder)
        {
            this.columnIndex = columnIndex;
            this.sortNumeric = sortNumeric;
            this.ascendingOrder = ascendingOrder;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            // Numeric comparison
            if (sortNumeric)
            {
                double doubleX, doubleY;
                if (double.TryParse(itemX.SubItems[columnIndex].Text, out doubleX) && double.TryParse(itemY.SubItems[columnIndex].Text, out doubleY))
                {
                    if (ascendingOrder)
                        return doubleX.CompareTo(doubleY);
                    else
                        return doubleY.CompareTo(doubleX);
                }
            }
            // Alphanumeric comparison
            if (ascendingOrder)
                return string.Compare(itemX.SubItems[columnIndex].Text, itemY.SubItems[columnIndex].Text);
            else
                return string.Compare(itemY.SubItems[columnIndex].Text, itemX.SubItems[columnIndex].Text);
        }
    }
}