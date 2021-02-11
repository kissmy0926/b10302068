using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B10302002project
{
    public partial class Form1 : Form
    {
        Random random;
        int step;
        int now_player;
        Player[] players;
        Block[] map;
        Bitmap map1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            now_player = 0;
            pictureBox1.Load("01.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            map1 = new Bitmap("01.jpg");

            random = new Random();
            map = new Block[40];
            map[0] = new Block();
            map[0].Location = new Point(108, 290);
            map[1] = new Block();
            map[1].Location = new Point(208, 290);
            map[2] = new Block();
            map[2].Location = new Point(308, 290);
            map[3] = new Block();
            map[3].Location = new Point(308, 220);
            map[4] = new Block();
            map[4].Location = new Point(308, 140);
            map[5] = new Block();
            map[5].Location = new Point(400, 140);
            map[6] = new Block();
            map[6].Location = new Point(500, 140);
            map[7] = new Block();
            map[7].Location = new Point(595, 140);
            map[8] = new Block();
            map[8].Location = new Point(685, 140);
            map[9] = new Block();
            map[9].Location = new Point(780, 140);
            map[10] = new Block();
            map[10].Location = new Point(780, 220);
            map[11] = new Block();
            map[11].Location = new Point(395, 290);
            map[12] = new Block();
            map[12].Location = new Point(490, 290);
            map[13] = new Block();
            map[13].Location = new Point(580, 290);
            map[14] = new Block();
            map[14].Location = new Point(680, 290);
            map[15] = new Block();
            map[15].Location = new Point(770, 290);
            map[16] = new Block();
            map[16].Location = new Point(870, 290);
            map[17] = new Block();
            map[17].Location = new Point(965, 290);
            map[18] = new Block();
            map[18].Location = new Point(965, 370);
            map[19] = new Block();
            map[19].Location = new Point(965, 445);
            map[20] = new Block();
            map[20].Location = new Point(965, 520);
            map[21] = new Block();
            map[21].Location = new Point(870, 520);
            map[22] = new Block();
            map[22].Location = new Point(770, 520);
            map[23] = new Block();
            map[23].Location = new Point(770, 595);
            map[24] = new Block();
            map[24].Location = new Point(770, 665);
            map[25] = new Block();
            map[25].Location = new Point(685, 665);
            map[26] = new Block();
            map[26].Location = new Point(595, 665);
            map[27] = new Block();
            map[27].Location = new Point(500, 665);
            map[28] = new Block();
            map[28].Location = new Point(400, 665);
            map[29] = new Block();
            map[29].Location = new Point(300, 665);
            map[30] = new Block();
            map[30].Location = new Point(308, 595);
            map[31] = new Block();
            map[31].Location = new Point(680, 520);
            map[32] = new Block();
            map[32].Location = new Point(580, 520);
            map[33] = new Block();
            map[33].Location = new Point(490, 520);
            map[34] = new Block();
            map[34].Location = new Point(395, 520);
            map[35] = new Block();
            map[35].Location = new Point(308, 520);
            map[36] = new Block();
            map[36].Location = new Point(208, 520);
            map[37] = new Block();
            map[37].Location = new Point(108, 520);
            map[38] = new Block();
            map[38].Location = new Point(108, 445);
            map[39] = new Block();
            map[39].Location = new Point(108, 370);

            players = new Player[4];

            players[0] = new Player("M1.png");
            players[0].Location = pictureBox1.Location;
            Controls.Add(players[0].Image);
            players[0].Image.BringToFront();

            players[1] = new Player("M2.png");
            players[1].Location = pictureBox1.Location;
            Controls.Add(players[1].Image);
            players[1].Image.BringToFront();

            players[2] = new Player("M3.png");
            players[2].Location = pictureBox1.Location;
            Controls.Add(players[2].Image);
            players[2].Image.BringToFront();

            players[3] = new Player("M4.png");
            players[3].Location = pictureBox1.Location;
            Controls.Add(players[3].Image);
            players[3].Image.BringToFront();

            pictureBox1.Refresh();
            pictureBox2.Refresh();
            pictureBox3.Refresh();

            SetUI(TurnPhase.Initial);
        }
        private void SetUI(TurnPhase phase)
        {
            switch (phase)
            {
                case TurnPhase.Initial:
                    label2.Text = (now_player + 1).ToString();
                    label4.Text = players[now_player].Money.ToString();
                    label6.Text = players[now_player].State.ToString();

                    players[now_player].Image.BringToFront();
                    button1.Enabled = true;
                    button2.Enabled = false;
                    break;

                case TurnPhase.Walk:
                    label6.Text = step.ToString();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    break;

                case TurnPhase.Dice:
                    button1.Enabled = true;
                    button2.Enabled = false;
                    break;

                case TurnPhase.End:
                    button1.Enabled = false;
                    button2.Enabled = true;
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            now_player = (now_player + 1) % 4;
            SetUI(TurnPhase.Initial);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (step != 0)
            {
                PlayerMove(players[now_player]);
                pictureBox1.Refresh();
                pictureBox2.Refresh();
            }
        }
        private void PlayerMove(Player player)
        {
            int now_index = player.BlockIndex;
            int next_index = (player.BlockIndex + 1) % 40;
            Point dis = new Point((map[next_index].Location.X - map[now_index].Location.X), (map[next_index].Location.Y - map[now_index].Location.Y));
            player.Location = new Point(player.Location.X + dis.X, player.Location.Y + dis.Y);

            if (player.Location.X+108 - pictureBox1.Location.X == map[next_index].Location.X && player.Location.Y+290 - pictureBox1.Location.Y == map[next_index].Location.Y)
            {
                --step;
                label6.Text = step.ToString();
                player.BlockIndex = next_index;

                if (step == 0)
                {
                    //         map[player.BlockIndex].PassAction(ref player);
                    map[player.BlockIndex].StopAction(ref player);
                    label4.Text = player.Money.ToString();
                    SetUI(TurnPhase.End);
                }
           /*     else
                {
                    map[player.BlockIndex].PassAction(ref player);
                    label4.Text = player.Money.ToString();
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = random.Next(6) + 1;
            label6.Text = r.ToString();
            step = r;
            SetUI(TurnPhase.Walk);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle player_region;
            for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
            {
                player_region = new Rectangle(players[i].Location.X + 25, players[i].Location.Y + 25, 50, 50);
               // g.DrawImage(players[i].Image, new Rectangle((int)((players[i].Location.X + 25) * 0.5), (int)((players[i].Location.Y + 25) * 0.5), 25, 25), new Rectangle(0, 0, players[i].Image.Width, players[i].Image.Height), TurnPhase.Pixel);
            }

            player_region = new Rectangle(players[now_player].Location.X + 25, players[now_player].Location.Y + 25, 50, 50);
         //   g.DrawImage(players[now_player].Image, new Rectangle((int)((players[now_player].Location.X + 25) * 0.5), (int)((players[now_player].Location.Y + 25) * 0.5), 25, 25), new Rectangle(0, 0, players[now_player].Image.Width, players[now_player].Image.Height), TurnPhase.Pixel);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Point now_loc = players[now_player].Location;
            int left = Math.Max(0, Math.Min(400, now_loc.X - 50));
            int top = Math.Max(0, Math.Min(400, now_loc.Y - 50));
            if (left + 200 > 400)
                left = 200;
            if (top + 200 > 400)
                top = 200;
            Rectangle map_region = new Rectangle(left, top, 200, 200);

            Graphics g = e.Graphics;

            // Draw background map
            g.DrawImage(map1, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height), map_region, GraphicsUnit.Pixel);

            // Draw player
            Rectangle player_region;
            for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
            {
                player_region = new Rectangle(players[i].Location.X + 25, players[i].Location.Y + 25, 50, 50);
            //    if (i != now_player && map_region.IntersectsWith(player_region))
                 //   g.DrawImage(players[i].Image, new Rectangle((players[i].Location.X + 25 - left) * (pictureBox2.Width / 200), (players[i].Location.Y + 25 - top) * 2, 100, 100), new Rectangle(0, 0, players[i].Image.Width, players[i].Image.Height), GraphicsUnit.Pixel);
            }

            player_region = new Rectangle(players[now_player].Location.X + 25, players[now_player].Location.Y + 25, 50, 50);
          //  g.DrawImage(players[now_player].Image, new Rectangle((players[now_player].Location.X + 25 - left) * 2, (players[now_player].Location.Y + 25 - top) * 2, 100, 100), new Rectangle(0, 0, players[now_player].Image.Width, players[now_player].Image.Height), TurnPhase.Pixel);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen mouse_on = new Pen(Brushes.Yellow, 3);
            Pen mouse_down = new Pen(Brushes.Gold, 3);
            List<Item> item_list = players[now_player].ItemList;

            bool is_down = false;

            for (int z = 0; z < item_list.Count; ++z)
            {
                Item item = item_list[z];
                if (item.Number > 0)
                {
                    if (item.IsMouseDown)
                        is_down = true;
                }
            }

            for (int z = 0; z < item_list.Count; ++z)
            {
                Item item = item_list[z];
                if (item.Number > 0)
                {
                    if (!is_down && item.IsMouseOn)
                        g.DrawRectangle(mouse_on, new Rectangle(50 * z + 3, 3, 44, 44));

                    if (item.IsMouseDown)
                        g.DrawRectangle(mouse_down, new Rectangle(50 * z + 3, 3, 44, 44));

                    g.DrawImage(item.Image, new Rectangle(50 * z + 5, 5, 40, 40), new Rectangle(0, 0, item.Image.Width, item.Image.Height), GraphicsUnit.Pixel);
                    g.DrawString(item.Number.ToString(), new Font("Calibri", 30), Brushes.Black, new PointF(50 * z + 5, 50));
                }
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            List<Item> item_list = players[now_player].ItemList;

            for (int z = 0; z < item_list.Count; ++z)
            {
                Item item = item_list[z];
                if (item.Number > 0 && 50 * z + 5 <= p.X && p.X <= 50 * z + 45 && 5 <= p.Y && p.Y <= 45)
                    item.IsMouseDown = true;
                else
                    item.IsMouseDown = false;
            }

            //pictureBox1.Capture = true;
            pictureBox3.Refresh();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            List<Item> item_list = players[now_player].ItemList;

            for (int z = 0; z < item_list.Count; ++z)
            {
                Item item = item_list[z];
                if (item.Number > 0 && 50 * z + 5 <= p.X && p.X <= 50 * z + 45 && 5 <= p.Y && p.Y <= 45)
                    item.IsMouseOn = true;
                else
                    item.IsMouseOn = false;
            }

            pictureBox3.Refresh();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            List<Item> item_list = players[now_player].ItemList;

            for (int z = 0; z < item_list.Count; ++z)
            {
                Item item = item_list[z];
                if (item.Number > 0 && item.IsMouseDown && 50 * z + 5 <= p.X && p.X <= 50 * z + 45 && 5 <= p.Y && p.Y <= 45)
                {
                    Player[] target = new Player[1];
                    target[0] = players[now_player];
                    item.Use(players[now_player], target);
                   // UpdateHP();
                }

                item.IsMouseDown = false;
            }

            //pictureBox1.Capture = false;
            pictureBox3.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
